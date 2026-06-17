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
            textBox_password = new System.Windows.Forms.TextBox();
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
            label1.Location = new System.Drawing.Point(316, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 46);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(227, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(228, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // textBox_username
            // 
            textBox_username.Location = new System.Drawing.Point(316, 129);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new System.Drawing.Size(178, 27);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new System.Drawing.Point(316, 181);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new System.Drawing.Size(178, 27);
            textBox_password.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(228, 243);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Role";
            // 
            // comboBox_role
            // 
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new System.Drawing.Point(316, 235);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new System.Drawing.Size(151, 28);
            comboBox_role.TabIndex = 6;
            // 
            // button_register
            // 
            button_register.Location = new System.Drawing.Point(573, 163);
            button_register.Name = "button_register";
            button_register.Size = new System.Drawing.Size(126, 45);
            button_register.TabIndex = 7;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // button_backToLogin
            // 
            button_backToLogin.Location = new System.Drawing.Point(76, 39);
            button_backToLogin.Name = "button_backToLogin";
            button_backToLogin.Size = new System.Drawing.Size(177, 40);
            button_backToLogin.TabIndex = 8;
            button_backToLogin.Text = "Back to Login";
            button_backToLogin.UseVisualStyleBackColor = true;
            button_backToLogin.Click += button_backToLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button_backToLogin);
            Controls.Add(button_register);
            Controls.Add(comboBox_role);
            Controls.Add(label4);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_backToLogin;
    }
}