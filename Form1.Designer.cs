namespace AddressBook_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            UserName = new TextBox();
            UserPassword = new TextBox();
            SignInBtn = new Button();
            SignUpBtn = new Button();
            Reg = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(207, 484);
            label3.Name = "label3";
            label3.Size = new Size(273, 25);
            label3.TabIndex = 2;
            label3.Text = "Are You A New User?";
            // 
            // UserName
            // 
            UserName.BackColor = Color.CornflowerBlue;
            UserName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserName.ForeColor = Color.DarkBlue;
            UserName.Location = new Point(207, 184);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter User Name";
            UserName.Size = new Size(436, 34);
            UserName.TabIndex = 3;
            // 
            // UserPassword
            // 
            UserPassword.BackColor = Color.CornflowerBlue;
            UserPassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserPassword.ForeColor = Color.DarkBlue;
            UserPassword.Location = new Point(207, 263);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.PlaceholderText = "Enter Password";
            UserPassword.Size = new Size(436, 34);
            UserPassword.TabIndex = 4;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = Color.CornflowerBlue;
            SignInBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignInBtn.ForeColor = Color.DarkBlue;
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
            SignUpBtn.BackColor = Color.CornflowerBlue;
            SignUpBtn.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpBtn.ForeColor = Color.DarkBlue;
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
            Reg.Location = new Point(122, 427);
            Reg.Name = "Reg";
            Reg.Size = new Size(0, 25);
            Reg.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 700);
            Controls.Add(Reg);
            Controls.Add(SignUpBtn);
            Controls.Add(SignInBtn);
            Controls.Add(UserPassword);
            Controls.Add(UserName);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox UserName;
        private TextBox UserPassword;
        private Button SignInBtn;
        private Button SignUpBtn;
        private Label Reg;
    }
}