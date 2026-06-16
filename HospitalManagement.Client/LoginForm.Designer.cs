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
            label1.Location = new System.Drawing.Point(327, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 46);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(188, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(188, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // textBox_username
            // 
            textBox_username.Location = new System.Drawing.Point(283, 126);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new System.Drawing.Size(186, 27);
            textBox_username.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new System.Drawing.Point(283, 173);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new System.Drawing.Size(186, 27);
            textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new System.Drawing.Point(327, 235);
            button_login.Name = "button_login";
            button_login.Size = new System.Drawing.Size(122, 36);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_register
            // 
            button_register.Location = new System.Drawing.Point(329, 311);
            button_register.Name = "button_register";
            button_register.Size = new System.Drawing.Size(120, 40);
            button_register.TabIndex = 6;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button_register);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
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