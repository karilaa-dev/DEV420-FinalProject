namespace HospitalManagement.Client
{
    partial class LoginForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox_username = new System.Windows.Forms.TextBox();
            textBox_password = new System.Windows.Forms.TextBox();
            button_login = new System.Windows.Forms.Button();
            button_register = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            label1.Location = new System.Drawing.Point(189, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(113, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(113, 164);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox_username
            // 
            textBox_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox_username.Location = new System.Drawing.Point(197, 123);
            textBox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new System.Drawing.Size(163, 29);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox_password.Location = new System.Drawing.Point(197, 159);
            textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new System.Drawing.Size(163, 29);
            textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Font = new System.Drawing.Font("Segoe UI", 12F);
            button_login.Location = new System.Drawing.Point(181, 211);
            button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new System.Drawing.Size(110, 35);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_register
            // 
            button_register.Font = new System.Drawing.Font("Segoe UI", 12F);
            button_register.Location = new System.Drawing.Point(181, 250);
            button_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_register.Name = "button_register";
            button_register.Size = new System.Drawing.Size(110, 35);
            button_register.TabIndex = 6;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(472, 338);
            Controls.Add(button_register);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
    }
}
