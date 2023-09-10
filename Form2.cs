using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            string UserName = NewAdminName.Text;
            string UserPassword = NewAdminPass.Text;
            string confirmPass = NewAdminPassConfirm.Text;

            if (UserPassword == confirmPass)
            {
                try
                {
                    string filePath = @"D:\Visual Studio c#\AddressBook_App\Admin.txt";

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"{UserName},{UserPassword}");
                    }
                    NewAdminName.Clear();
                    NewAdminPass.Clear();
                    NewAdminPassConfirm.Clear();
                    Reg.Text = "Registration is successful.";
                }
                catch (Exception ex)
                {
                    Reg.Text = $"An error occurred: {ex.Message}";
                }
            }
            else
            {
                Reg.Text = "Passwords do not match. Please try again.";
            }
        }

        private void GoToSignInBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
