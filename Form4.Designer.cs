namespace AddressBook_App
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            NewUserName = new TextBox();
            NewAddress = new TextBox();
            NewPostalCode = new TextBox();
            NewPostalArea = new TextBox();
            NewTelephone = new TextBox();
            NewEmail = new TextBox();
            SaveBtn = new Button();
            MainMenuBtn = new Button();
            Reg = new Label();
            SuspendLayout();
            // 
            // NewUserName
            // 
            NewUserName.BackColor = Color.CornflowerBlue;
            NewUserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewUserName.ForeColor = Color.DarkBlue;
            NewUserName.Location = new Point(209, 51);
            NewUserName.Name = "NewUserName";
            NewUserName.PlaceholderText = "Enter Your Name";
            NewUserName.Size = new Size(475, 34);
            NewUserName.TabIndex = 6;
            // 
            // NewAddress
            // 
            NewAddress.BackColor = Color.CornflowerBlue;
            NewAddress.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAddress.ForeColor = Color.DarkBlue;
            NewAddress.Location = new Point(209, 127);
            NewAddress.Name = "NewAddress";
            NewAddress.PlaceholderText = "Enter Street Adress";
            NewAddress.Size = new Size(475, 34);
            NewAddress.TabIndex = 8;
            // 
            // NewPostalCode
            // 
            NewPostalCode.BackColor = Color.CornflowerBlue;
            NewPostalCode.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewPostalCode.ForeColor = Color.DarkBlue;
            NewPostalCode.Location = new Point(213, 198);
            NewPostalCode.Name = "NewPostalCode";
            NewPostalCode.PlaceholderText = "Enter Postal Code";
            NewPostalCode.Size = new Size(475, 34);
            NewPostalCode.TabIndex = 10;
            // 
            // NewPostalArea
            // 
            NewPostalArea.BackColor = Color.CornflowerBlue;
            NewPostalArea.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewPostalArea.ForeColor = Color.DarkBlue;
            NewPostalArea.Location = new Point(213, 272);
            NewPostalArea.Name = "NewPostalArea";
            NewPostalArea.PlaceholderText = "Enter Postal Area";
            NewPostalArea.Size = new Size(475, 34);
            NewPostalArea.TabIndex = 12;
            // 
            // NewTelephone
            // 
            NewTelephone.BackColor = Color.CornflowerBlue;
            NewTelephone.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewTelephone.ForeColor = Color.DarkBlue;
            NewTelephone.Location = new Point(209, 342);
            NewTelephone.Name = "NewTelephone";
            NewTelephone.PlaceholderText = "Telephone Nummber";
            NewTelephone.Size = new Size(475, 34);
            NewTelephone.TabIndex = 14;
            // 
            // NewEmail
            // 
            NewEmail.BackColor = Color.CornflowerBlue;
            NewEmail.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewEmail.ForeColor = Color.DarkBlue;
            NewEmail.Location = new Point(209, 412);
            NewEmail.Name = "NewEmail";
            NewEmail.PlaceholderText = "exampel@example.com";
            NewEmail.Size = new Size(475, 34);
            NewEmail.TabIndex = 16;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.CornflowerBlue;
            SaveBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.DarkBlue;
            SaveBtn.Location = new Point(209, 482);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(475, 29);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.BackColor = Color.CornflowerBlue;
            MainMenuBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuBtn.ForeColor = Color.DarkBlue;
            MainMenuBtn.Location = new Point(213, 592);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(479, 29);
            MainMenuBtn.TabIndex = 19;
            MainMenuBtn.Text = "Go To Main Menu";
            MainMenuBtn.UseVisualStyleBackColor = false;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(185, 542);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 20;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 700);
            Controls.Add(Reg);
            Controls.Add(MainMenuBtn);
            Controls.Add(SaveBtn);
            Controls.Add(NewEmail);
            Controls.Add(NewTelephone);
            Controls.Add(NewPostalArea);
            Controls.Add(NewPostalCode);
            Controls.Add(NewAddress);
            Controls.Add(NewUserName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewUserName;
        private TextBox NewAddress;
        private TextBox NewPostalCode;
        private TextBox NewPostalArea;
        private TextBox NewTelephone;
        private TextBox NewEmail;
        private Button SaveBtn;
        private Button MainMenuBtn;
        private Label Reg;
    }
}