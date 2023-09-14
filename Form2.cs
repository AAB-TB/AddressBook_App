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
            // Get the values entered in the textboxes for new admin registration.
            string UserName = NewAdminName.Text;
            string UserPassword = NewAdminPass.Text;
            string confirmPass = NewAdminPassConfirm.Text;
            // Check if any of the required fields are empty.
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(UserPassword) || string.IsNullOrEmpty(confirmPass))
            {
                // Display an error message if any of the required fields are empty.
                Reg.Text = "Please fill in all required fields.";
            }
            // Check if the entered password matches the confirmation password.
             else if (UserPassword == confirmPass)
            {
                try
                {
                    // Specify the file path where admin credentials will be stored.
                    string filePath = @"D:\Visual Studio c#\AddressBook_App\Admin.txt";

                    // Use a StreamWriter to append the new admin's credentials to the file.
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"{UserName},{UserPassword}");
                    }

                    // Clear the input fields and display a success message in the "Reg" label.
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
