using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddressBook_App
{
    public partial class Form3 : Form
    {
        private List<string[]> userDataList;
        private List<string[]> displayedUserData;
        private List<int> searchResultsIndices;
        public Form3()
        {
            InitializeComponent();
            userDataList = LoadUserData();
            searchResultsIndices = new List<int>();
        }

        private List<string[]> LoadUserData()
        {
            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";
            List<string[]> data = new List<string[]>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            data.Add(parts);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Reg.Text = ($"An error occurred while loading data: {ex.Message}");
            }

            return data;
        }



        private void DisplaySearchResults()
        {
            listBox1.Items.Clear();
            foreach (int index in searchResultsIndices)
            {
                string[] userData = userDataList[index];
                listBox1.Items.Add(userData[0]);
            }
        }



        private void NewContactBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = searchResultsIndices[listBox1.SelectedIndex];
                string[] selectedUserData = userDataList[selectedIndex];
                Form5 detailsForm = new Form5(selectedUserData, userDataList, selectedIndex);
                detailsForm.Show();
                this.Hide();
            }
            else
            {
                Reg.Text = "Please select a user and click view details.";
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchBox.Text.Trim().ToLower();
            Console.WriteLine($"Search Term: {searchTerm}");

            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchResultsIndices.Clear();

                for (int i = 0; i < userDataList.Count; i++)
                {
                    string[] userData = userDataList[i];
                    string name = userData[0].ToLower();
                    string postalArea = userData[3].ToLower();

                    if (name == searchTerm || postalArea == searchTerm)
                    {
                        searchResultsIndices.Add(i);
                    }
                }
                DisplaySearchResults();
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                string selectedUserName = listBox1.SelectedItem.ToString();
                int indexToRemove = -1;

                for (int i = 0; i < userDataList.Count; i++)
                {
                    string[] userData = userDataList[i];
                    if (userData[0] == selectedUserName)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                if (indexToRemove >= 0)
                {
                    RemoveUserData(userDataList[indexToRemove]);
                    userDataList.RemoveAt(indexToRemove);
                    searchResultsIndices.Remove(indexToRemove);
                    listBox1.Items.Clear();
                    DisplaySearchResults();
                    Reg.Text = "User removed successfully!";

                }
                else
                {
                    Reg.Text = ("User not found in the data.");
                }
            }
            else
            {
                Reg.Text = ("Please select a user to remove.");
            }

        }


        private void RemoveUserData(string[] userDataToRemove)
        {
            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";
            try
            {
                var lines = File.ReadAllLines(filePath);
                var updatedLines = lines.Where(line => !string.Join(",", userDataToRemove).Equals(line));
                File.WriteAllLines(filePath, updatedLines);
            }
            catch (Exception ex)
            {
                Reg.Text = ($"An error occurred while removing data: {ex.Message}");
            }
        }

    }
}
