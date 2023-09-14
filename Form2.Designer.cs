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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            NewAdminName = new TextBox();
            NewAdminPass = new TextBox();
            NewAdminPassConfirm = new TextBox();
            AdminBtn = new Button();
            GoToSignInBtn = new Button();
            Reg = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // NewAdminName
            // 
            NewAdminName.BackColor = Color.CornflowerBlue;
            NewAdminName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminName.ForeColor = Color.DarkBlue;
            NewAdminName.Location = new Point(219, 142);
            NewAdminName.Name = "NewAdminName";
            NewAdminName.PlaceholderText = "Enter Your Name";
            NewAdminName.Size = new Size(449, 34);
            NewAdminName.TabIndex = 4;
            // 
            // NewAdminPass
            // 
            NewAdminPass.BackColor = Color.CornflowerBlue;
            NewAdminPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPass.ForeColor = Color.DarkBlue;
            NewAdminPass.Location = new Point(219, 218);
            NewAdminPass.Name = "NewAdminPass";
            NewAdminPass.PlaceholderText = "Password";
            NewAdminPass.Size = new Size(449, 34);
            NewAdminPass.TabIndex = 5;
            // 
            // NewAdminPassConfirm
            // 
            NewAdminPassConfirm.BackColor = Color.CornflowerBlue;
            NewAdminPassConfirm.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAdminPassConfirm.ForeColor = Color.DarkBlue;
            NewAdminPassConfirm.Location = new Point(219, 293);
            NewAdminPassConfirm.Name = "NewAdminPassConfirm";
            NewAdminPassConfirm.PlaceholderText = "Confirm Password";
            NewAdminPassConfirm.Size = new Size(449, 34);
            NewAdminPassConfirm.TabIndex = 6;
            // 
            // AdminBtn
            // 
            AdminBtn.BackColor = Color.CornflowerBlue;
            AdminBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            AdminBtn.ForeColor = Color.DarkBlue;
            AdminBtn.Location = new Point(219, 373);
            AdminBtn.Name = "AdminBtn";
            AdminBtn.Size = new Size(449, 29);
            AdminBtn.TabIndex = 7;
            AdminBtn.Text = "Register";
            AdminBtn.UseVisualStyleBackColor = false;
            AdminBtn.Click += AdminBtn_Click;
            // 
            // GoToSignInBtn
            // 
            GoToSignInBtn.BackColor = Color.CornflowerBlue;
            GoToSignInBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            GoToSignInBtn.ForeColor = Color.DarkBlue;
            GoToSignInBtn.Location = new Point(219, 541);
            GoToSignInBtn.Name = "GoToSignInBtn";
            GoToSignInBtn.Size = new Size(449, 29);
            GoToSignInBtn.TabIndex = 8;
            GoToSignInBtn.Text = "Please Sign In";
            GoToSignInBtn.UseVisualStyleBackColor = false;
            GoToSignInBtn.Click += GoToSignInBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(219, 468);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.CornflowerBlue;
            label4.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(258, 496);
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 700);
            Controls.Add(label4);
            Controls.Add(Reg);
            Controls.Add(GoToSignInBtn);
            Controls.Add(AdminBtn);
            Controls.Add(NewAdminPassConfirm);
            Controls.Add(NewAdminPass);
            Controls.Add(NewAdminName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NewAdminName;
        private TextBox NewAdminPass;
        private TextBox NewAdminPassConfirm;
        private Button AdminBtn;
        private Button GoToSignInBtn;
        private Label Reg;
        private Label label4;
    }
}