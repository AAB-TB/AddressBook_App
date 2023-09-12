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
            // Retrieve user input values from text boxes
            string userName = NewUserName.Text;
            string address = NewAddress.Text;
            string postalCode = NewPostalCode.Text;
            string postalArea = NewPostalArea.Text;
            string telephone = NewTelephone.Text;
            string email = NewEmail.Text;

            // Check if any mandatory fields are empty or contain only whitespace
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(postalCode) || string.IsNullOrWhiteSpace(postalArea) ||
                string.IsNullOrWhiteSpace(telephone) || string.IsNullOrWhiteSpace(email))
            {
                Reg.Text = "Please fill in all mandatory fields.";
                return;// Exit the method early if any mandatory field is empty.
            }

            // Validate the format of the postal code (numbers only)
            if (!IsValidPostalCode(postalCode))
            {
                Reg.Text = "Please enter a valid postal code (numbers only).";
                return;// Exit the method early if the postal code is invalid.
            }

            // Validate the format of the telephone number
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

            // Combine user information into a single string
            string userData = $"{userName},{address},{postalCode},{postalArea},{telephone},{email}";

            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(userData);
                }

                // Clear input fields after successful save
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
            // Define a regular expression pattern for a valid phone number
            // The pattern matches a plus sign (+) followed by 1 to 4 digits,
            // an optional hyphen (-) or space (\s), and then one or more digits.
            return Regex.IsMatch(phoneNumber, @"\+[\d]{1,4}[-\s]?[\d]+");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // Attempt to create a MailAddress object with the provided email string
                var addr = new System.Net.Mail.MailAddress(email);

                // If the creation is successful and the Address property of the MailAddress
                // object matches the input email string, it's considered a valid email.
                return addr.Address == email;
            }
            catch
            {
                // If creating the MailAddress object fails or the Address doesn't match,
                // it's not a valid email.
                return false;
            }
        }

        private bool IsValidPostalCode(string postalCode)
        {

            // Check if the postal code contains only numeric characters
            // The regular expression pattern ^[0-9]+$ checks that the entire string
            // consists of one or more digits (0-9) from start (^) to finish ($).
            return Regex.IsMatch(postalCode, @"^[0-9]+$");
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }













}
