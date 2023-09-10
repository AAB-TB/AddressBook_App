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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(207, 116);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(147, 174);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 230);
            label3.Name = "label3";
            label3.Size = new Size(252, 25);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password:";
            // 
            // NewAdminName
            // 
            NewAdminName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminName.Location = new Point(305, 117);
            NewAdminName.Name = "NewAdminName";
            NewAdminName.PlaceholderText = "Enter Your Name";
            NewAdminName.Size = new Size(363, 34);
            NewAdminName.TabIndex = 4;
            // 
            // NewAdminPass
            // 
            NewAdminPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPass.Location = new Point(305, 172);
            NewAdminPass.Name = "NewAdminPass";
            NewAdminPass.PlaceholderText = "Password";
            NewAdminPass.Size = new Size(363, 34);
            NewAdminPass.TabIndex = 5;
            // 
            // NewAdminPassConfirm
            // 
            NewAdminPassConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPassConfirm.Location = new Point(305, 231);
            NewAdminPassConfirm.Name = "NewAdminPassConfirm";
            NewAdminPassConfirm.PlaceholderText = "Confirm Password";
            NewAdminPassConfirm.Size = new Size(363, 34);
            NewAdminPassConfirm.TabIndex = 6;
            // 
            // AdminBtn
            // 
            AdminBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AdminBtn.Location = new Point(342, 291);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(149, 29);
            AdminBtn.TabIndex = 7;
            AdminBtn.Text = "Register";
            AdminBtn.UseVisualStyleBackColor = true;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // GoToSignInBtn
            // 
            GoToSignInBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GoToSignInBtn.Location = new Point(552, 291);
            GoToSignInBtn.Name = "GoToSignInBtn";
            GoToSignInBtn.Size = new Size(116, 29);
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 453);
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
    }
}