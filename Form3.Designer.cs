﻿namespace AddressBook_App
{
    partial class Form3
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
            SearchBox = new TextBox();
            SearchBtn = new Button();
            listBox1 = new ListBox();
            ViewDetailsBtn = new Button();
            NewContactBtn = new Button();
            SignOutBtn = new Button();
            RemoveBtn = new Button();
            Reg = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ShowAllUsersBtn = new Button();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBox.Location = new Point(67, 46);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Enter Name or Postal Area";
            SearchBox.Size = new Size(611, 34);
            SearchBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.Location = new Point(699, 46);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(149, 34);
            SearchBtn.TabIndex = 8;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(75, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(603, 254);
            listBox1.TabIndex = 9;
            // 
            // ViewDetailsBtn
            // 
            ViewDetailsBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ViewDetailsBtn.Location = new Point(696, 178);
            ViewDetailsBtn.Name = "ViewDetailsBtn";
            ViewDetailsBtn.Size = new Size(152, 29);
            ViewDetailsBtn.TabIndex = 10;
            ViewDetailsBtn.Text = "View ";
            ViewDetailsBtn.UseVisualStyleBackColor = true;
            ViewDetailsBtn.Click += ViewDetailsBtn_Click;
            // 
            // NewContactBtn
            // 
            NewContactBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewContactBtn.Location = new Point(77, 491);
            NewContactBtn.Name = "NewContactBtn";
            NewContactBtn.Size = new Size(197, 29);
            NewContactBtn.TabIndex = 11;
            NewContactBtn.Text = "new Contact";
            NewContactBtn.UseVisualStyleBackColor = true;
            NewContactBtn.Click += NewContactBtn_Click;
            // 
            // SignOutBtn
            // 
            SignOutBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignOutBtn.Location = new Point(531, 491);
            SignOutBtn.Name = "SignOutBtn";
            SignOutBtn.Size = new Size(149, 29);
            SignOutBtn.TabIndex = 12;
            SignOutBtn.Text = "Sign Out";
            SignOutBtn.UseVisualStyleBackColor = true;
            SignOutBtn.Click += SignOutBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveBtn.Location = new Point(313, 491);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(149, 29);
            RemoveBtn.TabIndex = 13;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(101, 439);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 14;
            // 
            // ShowAllUsersBtn
            // 
            ShowAllUsersBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShowAllUsersBtn.Location = new Point(696, 302);
            ShowAllUsersBtn.Name = "ShowAllUsersBtn";
            ShowAllUsersBtn.Size = new Size(152, 29);
            ShowAllUsersBtn.TabIndex = 15;
            ShowAllUsersBtn.Text = "View All";
            ShowAllUsersBtn.UseVisualStyleBackColor = true;
            ShowAllUsersBtn.Click += ShowAllUsersBtn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 553);
            Controls.Add(ShowAllUsersBtn);
            Controls.Add(Reg);
            Controls.Add(RemoveBtn);
            Controls.Add(SignOutBtn);
            Controls.Add(NewContactBtn);
            Controls.Add(ViewDetailsBtn);
            Controls.Add(listBox1);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private Button SearchBtn;
        private ListBox listBox1;
        private Button ViewDetailsBtn;
        private Button NewContactBtn;
        private Button SignOutBtn;
        private Button RemoveBtn;
        private Label Reg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ShowAllUsersBtn;
    }
}