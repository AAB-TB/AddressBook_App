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
        private List<string[]> userDataList;
        private int selectedIndex;
        public Form5(string[] userData, List<string[]> userDataList, int selectedIndex)
        {
            InitializeComponent();
            this.userDataList = userDataList;
            this.selectedIndex = selectedIndex;

            UserName.Text = userData[0];
            StreetAddress.Text = userData[1];
            PostalCode.Text = userData[2];
            PostalArea.Text = userData[3];
            Telephone.Text = userData[4];
            Email.Text = userData[5];
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string updatedName = UserName.Text;
            string updatedStreetAddress = StreetAddress.Text;
            string updatedPostalCode = PostalCode.Text;
            string updatedPostalArea = PostalArea.Text;
            string updatedTelephone = Telephone.Text;
            string updatedEmail = Email.Text;

            string[] updatedUserData = { updatedName, updatedStreetAddress, updatedPostalCode, updatedPostalArea, updatedTelephone, updatedEmail };
            userDataList[selectedIndex] = updatedUserData;
            UpdateUserDataInFile(updatedUserData, selectedIndex);
            Reg.Text = "User information updated successfully!";
        }

        private void UpdateUserDataInFile(string[] updatedUserData, int selectedIndex)
        {
            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";

            try
            {
                var lines = File.ReadAllLines(filePath);
                lines[selectedIndex] = string.Join(",", updatedUserData);
                File.WriteAllLines(filePath, lines);

            }
            catch (Exception ex)
            {
                Reg.Text = $"An error occurred while updating data: {ex.Message}";
            }
        }



    }
}
