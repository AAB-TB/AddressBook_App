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
    public partial class Form5 : Form
    {
        private List<string[]> userDataList; // List to store user data
        private int selectedIndex;// Index of the selected user
        public Form5(string[] userData, List<string[]> userDataList, int selectedIndex)
        {
            InitializeComponent();

            // Initialize the class-level fields with provided data
            this.userDataList = userDataList;// Store the list of user data
            this.selectedIndex = selectedIndex;// Store the index of the selected user

            // Populate text boxes with user data for display/editing

            UserName.Text = userData[0];// Set the user's name
            StreetAddress.Text = userData[1];// Set the street address
            PostalCode.Text = userData[2];// Set the postal code
            PostalArea.Text = userData[3];// Set the postal area
            Telephone.Text = userData[4];// Set the telephone number
            Email.Text = userData[5];// Set the email address
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // Retrieve updated user information from text boxes
            string updatedName = UserName.Text;
            string updatedStreetAddress = StreetAddress.Text;
            string updatedPostalCode = PostalCode.Text;
            string updatedPostalArea = PostalArea.Text;
            string updatedTelephone = Telephone.Text;
            string updatedEmail = Email.Text;


            // Create an array to hold the updated user data
            string[] updatedUserData = { updatedName, updatedStreetAddress, updatedPostalCode, updatedPostalArea, updatedTelephone, updatedEmail };

            // Update the user data at the selected index in the userDataList
            userDataList[selectedIndex] = updatedUserData;

            // Update the user data in the file
            UpdateUserDataInFile(updatedUserData, selectedIndex);

            Reg.Text = "User information updated successfully!";
        }

        // Method to update user data in the file
        private void UpdateUserDataInFile(string[] updatedUserData, int selectedIndex)
        {
            // Specify the file path where user data is stored
            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";

            try
            {
                // Read all lines from the file into an array
                var lines = File.ReadAllLines(filePath);

                // Update the line at the selected index with the updated user data
                lines[selectedIndex] = string.Join(",", updatedUserData);


                // Write the updated lines back to the file
                File.WriteAllLines(filePath, lines);

            }
            catch (Exception ex)
            {
                Reg.Text = $"An error occurred while updating data: {ex.Message}";
            }
        }



    }
}
