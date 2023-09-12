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
            NewUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NewAddress = new TextBox();
            label3 = new Label();
            NewPostalCode = new TextBox();
            label4 = new Label();
            NewPostalArea = new TextBox();
            label5 = new Label();
            NewTelephone = new TextBox();
            label6 = new Label();
            NewEmail = new TextBox();
            SaveBtn = new Button();
            MainMenuBtn = new Button();
            Reg = new Label();
            SuspendLayout();
            // 
            // NewUserName
            // 
            NewUserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewUserName.ForeColor = SystemColors.HotTrack;
            NewUserName.Location = new Point(209, 51);
            NewUserName.Name = "NewUserName";
            NewUserName.PlaceholderText = "Enter Your Name";
            NewUserName.Size = new Size(475, 34);
            NewUserName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(209, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(209, 99);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 9;
            label2.Text = "Street Address:";
            // 
            // NewAddress
            // 
            NewAddress.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewAddress.ForeColor = SystemColors.HotTrack;
            NewAddress.Location = new Point(209, 127);
            NewAddress.Name = "NewAddress";
            NewAddress.PlaceholderText = "Enter Street Adress";
            NewAddress.Size = new Size(475, 34);
            NewAddress.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(209, 187);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 11;
            label3.Text = "Postal Code:";
            // 
            // NewPostalCode
            // 
            NewPostalCode.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewPostalCode.ForeColor = SystemColors.HotTrack;
            NewPostalCode.Location = new Point(209, 215);
            NewPostalCode.Name = "NewPostalCode";
            NewPostalCode.PlaceholderText = "Enter Postal Code";
            NewPostalCode.Size = new Size(475, 34);
            NewPostalCode.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(209, 364);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 13;
            label4.Text = "Telephone:";
            // 
            // NewPostalArea
            // 
            NewPostalArea.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewPostalArea.ForeColor = SystemColors.HotTrack;
            NewPostalArea.Location = new Point(209, 304);
            NewPostalArea.Name = "NewPostalArea";
            NewPostalArea.PlaceholderText = "Enter Postal Area";
            NewPostalArea.Size = new Size(475, 34);
            NewPostalArea.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(209, 276);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 15;
            label5.Text = "Postal Area:";
            // 
            // NewTelephone
            // 
            NewTelephone.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewTelephone.ForeColor = SystemColors.HotTrack;
            NewTelephone.Location = new Point(209, 392);
            NewTelephone.Name = "NewTelephone";
            NewTelephone.PlaceholderText = "Telephone Nummber";
            NewTelephone.Size = new Size(475, 34);
            NewTelephone.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(209, 455);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // NewEmail
            // 
            NewEmail.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewEmail.ForeColor = SystemColors.HotTrack;
            NewEmail.Location = new Point(209, 483);
            NewEmail.Name = "NewEmail";
            NewEmail.PlaceholderText = "exampel@example.com";
            NewEmail.Size = new Size(475, 34);
            NewEmail.TabIndex = 16;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = SystemColors.Highlight;
            SaveBtn.Location = new Point(209, 547);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(475, 29);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuBtn.ForeColor = SystemColors.Highlight;
            MainMenuBtn.Location = new Point(209, 604);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(479, 29);
            MainMenuBtn.TabIndex = 19;
            MainMenuBtn.Text = "Main Menu";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(246, 577);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 20;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 661);
            Controls.Add(Reg);
            Controls.Add(MainMenuBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label6);
            Controls.Add(NewEmail);
            Controls.Add(label5);
            Controls.Add(NewTelephone);
            Controls.Add(label4);
            Controls.Add(NewPostalArea);
            Controls.Add(label3);
            Controls.Add(NewPostalCode);
            Controls.Add(label2);
            Controls.Add(NewAddress);
            Controls.Add(label1);
            Controls.Add(NewUserName);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewUserName;
        private Label label1;
        private Label label2;
        private TextBox NewAddress;
        private Label label3;
        private TextBox NewPostalCode;
        private Label label4;
        private TextBox NewPostalArea;
        private Label label5;
        private TextBox NewTelephone;
        private Label label6;
        private TextBox NewEmail;
        private Button SaveBtn;
        private Button MainMenuBtn;
        private Label Reg;
    }
}