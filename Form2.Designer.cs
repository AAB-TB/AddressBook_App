namespace AddressBook_App
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NewAdminName = new TextBox();
            NewAdminPass = new TextBox();
            NewAdminPassConfirm = new TextBox();
            AdminBtn = new Button();
            GoToSignInBtn = new Button();
            Reg = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(219, 99);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(219, 187);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(219, 284);
            label3.Name = "label3";
            label3.Size = new Size(252, 25);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password:";
            // 
            // NewAdminName
            // 
            NewAdminName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminName.ForeColor = SystemColors.MenuHighlight;
            NewAdminName.Location = new Point(219, 127);
            NewAdminName.Name = "NewAdminName";
            NewAdminName.PlaceholderText = "Enter Your Name";
            NewAdminName.Size = new Size(449, 34);
            NewAdminName.TabIndex = 4;
            // 
            // NewAdminPass
            // 
            NewAdminPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPass.ForeColor = SystemColors.MenuHighlight;
            NewAdminPass.Location = new Point(219, 215);
            NewAdminPass.Name = "NewAdminPass";
            NewAdminPass.PlaceholderText = "Password";
            NewAdminPass.Size = new Size(449, 34);
            NewAdminPass.TabIndex = 5;
            // 
            // NewAdminPassConfirm
            // 
            NewAdminPassConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPassConfirm.ForeColor = SystemColors.MenuHighlight;
            NewAdminPassConfirm.Location = new Point(219, 312);
            NewAdminPassConfirm.Name = "NewAdminPassConfirm";
            NewAdminPassConfirm.PlaceholderText = "Confirm Password";
            NewAdminPassConfirm.Size = new Size(449, 34);
            NewAdminPassConfirm.TabIndex = 6;
            // 
            // AdminBtn
            // 
            AdminBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AdminBtn.ForeColor = SystemColors.Highlight;
            AdminBtn.Location = new Point(219, 394);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(449, 29);
            AdminBtn.TabIndex = 7;
            AdminBtn.Text = "Register";
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // GoToSignInBtn
            // 
            GoToSignInBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GoToSignInBtn.ForeColor = SystemColors.Highlight;
            GoToSignInBtn.Location = new Point(219, 541);
            GoToSignInBtn.Name = "GoToSignInBtn";
            GoToSignInBtn.Size = new Size(449, 29);
            GoToSignInBtn.TabIndex = 8;
            GoToSignInBtn.Text = "Sign In";
            GoToSignInBtn.UseVisualStyleBackColor = true;
            GoToSignInBtn.Click += GoToSignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(147, 364);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuHighlight;
            label4.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(219, 513);
            label4.Name = "label4";
            label4.Size = new Size(357, 25);
            label4.TabIndex = 10;
            label4.Text = "Already have an account?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 661);
            Controls.Add(label4);
            Controls.Add(Reg);
            Controls.Add(GoToSignInBtn);
            Controls.Add(AdminBtn);
            Controls.Add(NewAdminPassConfirm);
            Controls.Add(NewAdminPass);
            Controls.Add(NewAdminName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NewAdminName;
        private TextBox NewAdminPass;
        private TextBox NewAdminPassConfirm;
        private Button AdminBtn;
        private Button GoToSignInBtn;
        private Label Reg;
        private Label label4;
    }
}