﻿namespace AddressBook_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserName = new TextBox();
            UserPassword = new TextBox();
            SignInBtn = new Button();
            SignUpBtn = new Button();
            Reg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(207, 134);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(207, 239);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(207, 484);
            label3.Name = "label3";
            label3.Size = new Size(273, 25);
            label3.TabIndex = 2;
            label3.Text = "Are You A New User?";
            // 
            // UserName
            // 
            UserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.ForeColor = SystemColors.MenuHighlight;
            UserName.Location = new Point(207, 162);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter User Name";
            UserName.Size = new Size(436, 34);
            UserName.TabIndex = 3;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserPassword.ForeColor = SystemColors.MenuHighlight;
            UserPassword.Location = new Point(207, 267);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.PlaceholderText = "Enter Password";
            UserPassword.Size = new Size(436, 34);
            UserPassword.TabIndex = 4;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = SystemColors.Info;
            SignInBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignInBtn.ForeColor = SystemColors.MenuHighlight;
            SignInBtn.Location = new Point(207, 353);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(436, 29);
            SignInBtn.TabIndex = 5;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = SystemColors.Info;
            SignUpBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpBtn.ForeColor = SystemColors.MenuHighlight;
            SignUpBtn.Location = new Point(527, 480);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(116, 29);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(122, 417);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 700);
            Controls.Add(Reg);
            Controls.Add(SignUpBtn);
            Controls.Add(SignInBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserName;
        private TextBox UserPassword;
        private Button SignInBtn;
        private Button SignUpBtn;
        private Label Reg;
    }
}