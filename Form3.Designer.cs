namespace AddressBook_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            SearchBox = new TextBox();
            SearchBtn = new Button();
            listBox1 = new ListBox();
            ViewDetailsBtn = new Button();
            NewContactBtn = new Button();
            SignOutBtn = new Button();
            RemoveBtn = new Button();
            Reg = new Label();
            ShowAllUsersBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.CornflowerBlue;
            SearchBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBox.ForeColor = Color.DarkBlue;
            SearchBox.Location = new Point(258, 58);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Enter Name or Postal Area";
            SearchBox.Size = new Size(612, 34);
            SearchBox.TabIndex = 5;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.CornflowerBlue;
            SearchBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.DarkBlue;
            SearchBtn.Location = new Point(460, 121);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(149, 34);
            SearchBtn.TabIndex = 8;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.CornflowerBlue;
            listBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = Color.DarkBlue;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(258, 198);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(594, 404);
            listBox1.TabIndex = 9;
            // 
            // ViewDetailsBtn
            // 
            ViewDetailsBtn.BackColor = Color.CornflowerBlue;
            ViewDetailsBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ViewDetailsBtn.ForeColor = Color.DarkBlue;
            ViewDetailsBtn.Location = new Point(29, 277);
            ViewDetailsBtn.Name = "ViewDetailsBtn";
            ViewDetailsBtn.Size = new Size(180, 29);
            ViewDetailsBtn.TabIndex = 10;
            ViewDetailsBtn.Text = "View ";
            ViewDetailsBtn.UseVisualStyleBackColor = false;
            ViewDetailsBtn.Click += ViewDetailsBtn_Click;
            // 
            // NewContactBtn
            // 
            NewContactBtn.BackColor = Color.CornflowerBlue;
            NewContactBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NewContactBtn.ForeColor = Color.DarkBlue;
            NewContactBtn.Location = new Point(29, 198);
            NewContactBtn.Name = "NewContactBtn";
            NewContactBtn.Size = new Size(180, 29);
            NewContactBtn.TabIndex = 11;
            NewContactBtn.Text = "new Contact";
            NewContactBtn.UseVisualStyleBackColor = false;
            NewContactBtn.Click += NewContactBtn_Click;
            // 
            // SignOutBtn
            // 
            SignOutBtn.BackColor = Color.CornflowerBlue;
            SignOutBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignOutBtn.ForeColor = Color.DarkBlue;
            SignOutBtn.Location = new Point(29, 561);
            SignOutBtn.Name = "SignOutBtn";
            SignOutBtn.Size = new Size(180, 29);
            SignOutBtn.TabIndex = 12;
            SignOutBtn.Text = "Sign Out";
            SignOutBtn.UseVisualStyleBackColor = false;
            SignOutBtn.Click += SignOutBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.CornflowerBlue;
            RemoveBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveBtn.ForeColor = Color.DarkBlue;
            RemoveBtn.Location = new Point(29, 467);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(180, 29);
            RemoveBtn.TabIndex = 13;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // Reg
            // 
            Reg.AutoSize = true;
            Reg.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Reg.Location = new Point(258, 639);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 14;
            // 
            // ShowAllUsersBtn
            // 
            ShowAllUsersBtn.BackColor = Color.CornflowerBlue;
            ShowAllUsersBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ShowAllUsersBtn.ForeColor = Color.DarkBlue;
            ShowAllUsersBtn.Location = new Point(29, 366);
            ShowAllUsersBtn.Name = "ShowAllUsersBtn";
            ShowAllUsersBtn.Size = new Size(180, 29);
            ShowAllUsersBtn.TabIndex = 15;
            ShowAllUsersBtn.Text = "View All";
            ShowAllUsersBtn.UseVisualStyleBackColor = false;
            ShowAllUsersBtn.Click += ShowAllUsersBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(73, 121);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 16;
            label3.Text = "Menu";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 700);
            Controls.Add(label3);
            Controls.Add(ShowAllUsersBtn);
            Controls.Add(Reg);
            Controls.Add(RemoveBtn);
            Controls.Add(SignOutBtn);
            Controls.Add(NewContactBtn);
            Controls.Add(ViewDetailsBtn);
            Controls.Add(listBox1);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form3";
            Load += Form3_Load;
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
        private Button ShowAllUsersBtn;
        private Label label3;
    }
}