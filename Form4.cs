using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook_App
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string userName = NewUserName.Text;
            string address = NewAddress.Text;
            string postalCode = NewPostalCode.Text;
            string postalArea = NewPostalArea.Text;
            string telephone = NewTelephone.Text;
            string email = NewEmail.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(postalCode) || string.IsNullOrWhiteSpace(postalArea) ||
                string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
            {
                Reg.Text = "Please fill in all mandatory fields.";
                return;
            }

            if (!IsValidPhoneNumber(telephone))
            {
                Reg.Text = "Please enter a valid telephone number.";
                return;
            }

            if (!IsValidEmail(email))
            {
                Reg.Text = "Please enter a valid email address.";
                return;
            }
            string userData = $"{userName},{address},{postalCode},{postalArea},{telephone},{email}";

            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(userData);
                }

                ClearInputFields();

                Reg.Text = "User information saved successfully.";
            }
            catch (Exception ex)
            {
                Reg.Text = $"An error occurred while saving: {ex.Message}";
            }
        }

        private void ClearInputFields()
        {
            NewUserName.Clear();
            NewAddress.Clear();
            NewPostalCode.Clear();
            NewPostalArea.Clear();
            NewTelephone.Clear();
            NewEmail.Clear();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"\+[\d]{1,4}[-\s]?[\d]+");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }













}
