namespace HospitalManagement.Client
{
    partial class PatientFor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbGender = new System.Windows.Forms.ComboBox();
            txtName = new System.Windows.Forms.TextBox();
            txtAge = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtphone = new System.Windows.Forms.TextBox();
            txtMedicalHistory = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "famale", "male", "Unknow" });
            cmbGender.Location = new System.Drawing.Point(108, 78);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new System.Drawing.Size(151, 28);
            cmbGender.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(98, 12);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(108, 45);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(125, 27);
            txtAge.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(120, 112);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(125, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtphone
            // 
            txtphone.Location = new System.Drawing.Point(120, 175);
            txtphone.Name = "txtphone";
            txtphone.Size = new System.Drawing.Size(125, 27);
            txtphone.TabIndex = 4;
            // 
            // txtMedicalHistory
            // 
            txtMedicalHistory.Location = new System.Drawing.Point(124, 208);
            txtMedicalHistory.Name = "txtMedicalHistory";
            txtMedicalHistory.Size = new System.Drawing.Size(125, 27);
            txtMedicalHistory.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 215);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "call History";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 8;
            label3.Text = "phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Adress";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 86);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 20);
            label5.TabIndex = 10;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 20);
            label6.TabIndex = 11;
            label6.Text = "Age";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(129, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(21, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(12, 302);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(139, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(129, 311);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column6, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new System.Drawing.Point(265, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(533, 318);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Gender";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "name";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Age";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adress";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "phone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "callhistory";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // PatientFor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMedicalHistory);
            Controls.Add(txtphone);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(cmbGender);
            Name = "PatientFor";
            Text = "PatientFor";
            Load += PatientFor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtMedicalHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}