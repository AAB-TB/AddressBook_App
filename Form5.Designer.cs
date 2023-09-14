namespace AddressBook_App
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PostalArea = new TextBox();
            PostalCode = new TextBox();
            StreetAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            Email = new TextBox();
            Telephone = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            UpdateBtn = new Button();
            MainMenuBtn = new Button();
            Reg = new Label();
            UserName = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(367, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(69, 138);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 365);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.CornflowerBlue;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(PostalArea);
            tabPage1.Controls.Add(PostalCode);
            tabPage1.Controls.Add(StreetAddress);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(716, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Address";
            // 
            // PostalArea
            // 
            PostalArea.BackColor = Color.CornflowerBlue;
            PostalArea.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PostalArea.ForeColor = Color.DarkBlue;
            PostalArea.Location = new Point(280, 169);
            PostalArea.Name = "PostalArea";
            PostalArea.Size = new Size(337, 34);
            PostalArea.TabIndex = 15;
            // 
            // PostalCode
            // 
            PostalCode.BackColor = Color.CornflowerBlue;
            PostalCode.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PostalCode.ForeColor = Color.DarkBlue;
            PostalCode.Location = new Point(280, 114);
            PostalCode.Name = "PostalCode";
            PostalCode.Size = new Size(337, 34);
            PostalCode.TabIndex = 14;
            // 
            // StreetAddress
            // 
            StreetAddress.BackColor = Color.CornflowerBlue;
            StreetAddress.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StreetAddress.ForeColor = Color.DarkBlue;
            StreetAddress.Location = new Point(280, 66);
            StreetAddress.Name = "StreetAddress";
            StreetAddress.Size = new Size(337, 34);
            StreetAddress.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(53, 66);
            label4.Name = "label4";
            label4.Size = new Size(221, 25);
            label4.TabIndex = 12;
            label4.Text = "Street Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(99, 123);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 11;
            label3.Text = "Postal Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(91, 172);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 10;
            label2.Text = "Postal Area:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.CornflowerBlue;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(Email);
            tabPage2.Controls.Add(Telephone);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(716, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact";
            // 
            // Email
            // 
            Email.BackColor = Color.CornflowerBlue;
            Email.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Email.ForeColor = Color.DarkBlue;
            Email.Location = new Point(229, 112);
            Email.Name = "Email";
            Email.Size = new Size(337, 34);
            Email.TabIndex = 20;
            // 
            // Telephone
            // 
            Telephone.BackColor = Color.CornflowerBlue;
            Telephone.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Telephone.ForeColor = Color.DarkBlue;
            Telephone.Location = new Point(229, 64);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(337, 34);
            Telephone.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(71, 67);
            label8.Name = "label8";
            label8.Size = new Size(152, 25);
            label8.TabIndex = 18;
            label8.Text = "Telephone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(131, 115);
            label9.Name = "label9";
            label9.Size = new Size(92, 25);
            label9.TabIndex = 17;
            label9.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(59, 66);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(59, 117);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 10;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.CornflowerBlue;
            UpdateBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.DarkBlue;
            UpdateBtn.Location = new Point(69, 562);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(727, 29);
            UpdateBtn.TabIndex = 19;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.BackColor = Color.CornflowerBlue;
            MainMenuBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuBtn.ForeColor = Color.DarkBlue;
            MainMenuBtn.Location = new Point(69, 620);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(724, 29);
            MainMenuBtn.TabIndex = 20;
            MainMenuBtn.Text = "Main Menu";
            MainMenuBtn.UseVisualStyleBackColor = false;
            MainMenuBtn.Click += MainMenuBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(73, 519);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 21;
            // 
            // UserName
            // 
            UserName.BackColor = Color.CornflowerBlue;
            UserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.ForeColor = Color.DarkBlue;
            UserName.Location = new Point(69, 86);
            UserName.Name = "UserName";
            UserName.Size = new Size(720, 34);
            UserName.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 700);
            Controls.Add(Reg);
            Controls.Add(MainMenuBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(UserName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form5";
            Load += Form5_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button UpdateBtn;
        private Button MainMenuBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label Reg;
        private TextBox PostalArea;
        private TextBox Email;
        private TextBox Telephone;
        private Label label8;
        private Label label9;
        private TextBox PostalCode;
        private TextBox StreetAddress;
        private TextBox UserName;
    }
}