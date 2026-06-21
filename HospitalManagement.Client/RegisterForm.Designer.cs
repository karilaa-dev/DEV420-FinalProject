namespace HospitalManagement.Client
{
    partial class RegisterForm
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
            textBox_displayName = new System.Windows.Forms.TextBox();
            textBox_password = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBox_role = new System.Windows.Forms.ComboBox();
            button_register = new System.Windows.Forms.Button();
            button_backToLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            label1.Location = new System.Drawing.Point(182, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 37);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(106, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(106, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox_username
            // 
            textBox_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox_username.Location = new System.Drawing.Point(211, 119);
            textBox_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new System.Drawing.Size(156, 29);
            textBox_username.TabIndex = 3;
            // 
            // textBox_displayName
            // 
            textBox_displayName.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox_displayName.Location = new System.Drawing.Point(211, 152);
            textBox_displayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox_displayName.Name = "textBox_displayName";
            textBox_displayName.Size = new System.Drawing.Size(156, 29);
            textBox_displayName.TabIndex = 4;
            // 
            // textBox_password
            // 
            textBox_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox_password.Location = new System.Drawing.Point(211, 185);
            textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new System.Drawing.Size(156, 29);
            textBox_password.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            label5.Location = new System.Drawing.Point(106, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 21);
            label5.TabIndex = 9;
            label5.Text = "Display name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(106, 221);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 21);
            label4.TabIndex = 5;
            label4.Text = "Role";
            // 
            // comboBox_role
            // 
            comboBox_role.Font = new System.Drawing.Font("Segoe UI", 12F);
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new System.Drawing.Point(211, 218);
            comboBox_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new System.Drawing.Size(133, 29);
            comboBox_role.TabIndex = 6;
            // 
            // button_register
            // 
            button_register.Font = new System.Drawing.Font("Segoe UI", 12F);
            button_register.Location = new System.Drawing.Point(182, 251);
            button_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_register.Name = "button_register";
            button_register.Size = new System.Drawing.Size(110, 35);
            button_register.TabIndex = 7;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_backToLogin
            // 
            button_backToLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            button_backToLogin.Location = new System.Drawing.Point(159, 11);
            button_backToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_backToLogin.Name = "button_backToLogin";
            button_backToLogin.Size = new System.Drawing.Size(155, 30);
            button_backToLogin.TabIndex = 8;
            button_backToLogin.Text = "Back to Login";
            button_backToLogin.UseVisualStyleBackColor = true;
            button_backToLogin.Click += button_backToLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(472, 338);
            Controls.Add(button_backToLogin);
            Controls.Add(button_register);
            Controls.Add(comboBox_role);
            Controls.Add(label4);
            Controls.Add(textBox_password);
            Controls.Add(label5);
            Controls.Add(textBox_displayName);
            Controls.Add(textBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_displayName;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_backToLogin;
    }
}
