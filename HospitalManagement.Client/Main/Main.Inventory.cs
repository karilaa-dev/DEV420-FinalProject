using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    public partial class Main
    {
        private void SetupInventoryTab()
        {
            if (currentUser != null && !IsAdminUser())
            {
                return;
            }

            // Set grid selection behavior
            inventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventoryGrid.MultiSelect = false;

            if (cmbInventoryCategory.Items.Count > 0 && cmbInventoryCategory.SelectedIndex == -1)
            {
                cmbInventoryCategory.SelectedIndex = 0;
            }

            LoadInventoryItems();
        }

        private void LoadInventoryItems()
        {
            inventoryGrid.Rows.Clear();
            lstLowStock.Items.Clear();
            selectedInventoryItemId = 0;

            if (currentUser != null && !IsAdminUser())
            {
                lstLowStock.Items.Add("Inventory is available to administrative staff only.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    List<InventoryItem> inventoryItems = db.InventoryItems
                        .OrderBy(item => item.ItemName)
                        .ToList();

                    foreach (InventoryItem inventoryItem in inventoryItems)
                    {
                        int rowIndex = inventoryGrid.Rows.Add(
                            inventoryItem.ItemName,
                            inventoryItem.Category,
                            inventoryItem.Quantity.ToString(),
                            inventoryItem.ReorderLevel.ToString(),
                            inventoryItem.StorageLocation ?? ""
                        );

                        inventoryGrid.Rows[rowIndex].Tag = inventoryItem.InventoryItemId;

                        if (inventoryItem.Quantity <= inventoryItem.ReorderLevel)
                        {
                            inventoryGrid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                            lstLowStock.Items.Add(
                                inventoryItem.ItemName +
                                " is low: " +
                                inventoryItem.Quantity.ToString() +
                                " remaining, reorder at " +
                                inventoryItem.ReorderLevel.ToString()
                            );
                        }
                    }
                }

                if (lstLowStock.Items.Count == 0)
                {
                    lstLowStock.Items.Add("No items are currently below reorder level.");
                }

                statusText.Text = "Inventory records loaded.";
            }
            catch (Exception ex)
            {
                statusText.Text = "Error loading inventory: " + ex.Message;
            }
        }

        private void LoadInventoryDetails(int inventoryItemId)
        {
            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem item = db.InventoryItems
                        .FirstOrDefault(record => record.InventoryItemId == inventoryItemId);

                    if (item != null)
                    {
                        selectedInventoryItemId = inventoryItemId;
                        txtInventoryItem.Text = item.ItemName;
                        cmbInventoryCategory.Text = item.Category;
                        numInventoryQuantity.Value = Convert.ToDecimal(item.Quantity);
                        numInventoryReorder.Value = Convert.ToDecimal(item.ReorderLevel);
                        txtInventoryLocation.Text = item.StorageLocation ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory item details: " + ex.Message);
            }
        }

        private void ClearInventoryForm()
        {
            selectedInventoryItemId = 0;
            txtInventoryItem.Clear();
            txtInventoryLocation.Clear();
            numInventoryQuantity.Value = 0;
            numInventoryReorder.Value = 0;

            if (cmbInventoryCategory.Items.Count > 0)
            {
                cmbInventoryCategory.SelectedIndex = 0;
            }
        }

        private void LogInventoryTransaction(
            HospitalDbContext db,
            int? inventoryItemId,
            string itemName,
            string category,
            int quantityChange,
            string reason)
        {
            db.InventoryTransactions.Add(new InventoryTransaction
            {
                InventoryItemId = inventoryItemId,
                ItemName = itemName,
                Category = category,
                QuantityChange = quantityChange,
                TransactionReason = reason,
                CreatedAt = DateTime.Now
            });
        }

        private int GetInventoryQuantity(HospitalDbContext db, int inventoryItemId)
        {
            return db.InventoryItems
                .Where(item => item.InventoryItemId == inventoryItemId)
                .Select(item => item.Quantity)
                .FirstOrDefault();
        }

        private async void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();
            string storageLocation = txtInventoryLocation.Text.Trim();
            int quantity = Convert.ToInt32(numInventoryQuantity.Value);
            int reorderLevel = Convert.ToInt32(numInventoryReorder.Value);

            if (itemName == "" || category == "")
            {
                MessageBox.Show("Item Name and Category are required.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = new InventoryItem
                    {
                        ItemName = itemName,
                        Category = category,
                        Quantity = quantity,
                        ReorderLevel = reorderLevel,
                        StorageLocation = storageLocation,
                        UpdatedAt = DateTime.Now
                    };

                    db.InventoryItems.Add(inventoryItem);
                    db.SaveChanges();

                    if (quantity != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            inventoryItem.InventoryItemId,
                            itemName,
                            category,
                            quantity,
                            "Initial stock"
                        );
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Inventory item added successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory item added: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory item added: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding inventory item: " + ex.Message);
            }
        }

        private async void btnInventoryUpdate_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            if (selectedInventoryItemId == 0)
            {
                MessageBox.Show("Double-click an inventory item before updating it.");
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();
            string storageLocation = txtInventoryLocation.Text.Trim();
            int quantity = Convert.ToInt32(numInventoryQuantity.Value);
            int reorderLevel = Convert.ToInt32(numInventoryReorder.Value);

            if (itemName == "" || category == "")
            {
                MessageBox.Show("Item Name and Category are required.");
                return;
            }

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = db.InventoryItems
                        .FirstOrDefault(item => item.InventoryItemId == selectedInventoryItemId);

                    if (inventoryItem == null)
                    {
                        MessageBox.Show("No inventory item found for the selected row.");
                        return;
                    }

                    int previousQuantity = inventoryItem.Quantity;
                    inventoryItem.ItemName = itemName;
                    inventoryItem.Category = category;
                    inventoryItem.Quantity = quantity;
                    inventoryItem.ReorderLevel = reorderLevel;
                    inventoryItem.StorageLocation = storageLocation;
                    inventoryItem.UpdatedAt = DateTime.Now;

                    int quantityChange = quantity - previousQuantity;

                    if (quantityChange != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            selectedInventoryItemId,
                            itemName,
                            category,
                            quantityChange,
                            "Stock update"
                        );
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Inventory item updated successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory stock updated: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory stock updated: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory item: " + ex.Message);
            }
        }

        private async void btnInventoryRemove_Click(object sender, EventArgs e)
        {
            if (!IsAdminUser())
            {
                MessageBox.Show("Inventory is available to administrative staff only.");
                return;
            }

            if (selectedInventoryItemId == 0)
            {
                MessageBox.Show("Double-click an inventory item before removing it.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this inventory item?",
                "Confirm Remove",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            string itemName = txtInventoryItem.Text.Trim();
            string category = cmbInventoryCategory.Text.Trim();

            try
            {
                using (HospitalDbContext db = CreateHospitalDbContext())
                {
                    InventoryItem inventoryItem = db.InventoryItems
                        .FirstOrDefault(item => item.InventoryItemId == selectedInventoryItemId);

                    if (inventoryItem == null)
                    {
                        MessageBox.Show("No inventory item found for the selected row.");
                        return;
                    }

                    int previousQuantity = GetInventoryQuantity(db, selectedInventoryItemId);
                    db.InventoryItems.Remove(inventoryItem);

                    if (previousQuantity != 0)
                    {
                        LogInventoryTransaction(
                            db,
                            null,
                            itemName,
                            category,
                            -previousQuantity,
                            "Item removed"
                        );
                    }

                    db.SaveChanges();
                }

                MessageBox.Show("Inventory item removed successfully.");
                ClearInventoryForm();
                LoadInventoryItems();
                RefreshDashboardCounts();
                SaveNotification("Inventory", "Inventory item removed: " + itemName + ".");
                await SendInventoryChangeAsync("Inventory item removed: " + itemName + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing inventory item: " + ex.Message);
            }
        }

        private void btnInventoryRefresh_Click(object sender, EventArgs e)
        {
            LoadInventoryItems();
            RefreshDashboardCounts();
        }

        private void inventoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || inventoryGrid.Rows[e.RowIndex].Tag == null)
            {
                return;
            }

            int inventoryItemId = Convert.ToInt32(inventoryGrid.Rows[e.RowIndex].Tag);
            LoadInventoryDetails(inventoryItemId);
        }
    }
}
