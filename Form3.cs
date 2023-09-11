using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AddressBook_App
{
    public partial class Form3 : Form
    {
        // Lists to store user data and search results indices
        private List<string[]> userDataList;
        private List<string[]> displayedUserData;
        private List<int> searchResultsIndices;
        public Form3()
        {
            InitializeComponent();

            // Load user data from a file when the form is created
            userDataList = LoadUserData(); /* userDataList = [
                ["Torsten Berglund", " Upplandsgatan 67", " 113 28", " stockholm", " +46785214", " hfgt@ghm.com"],
                ["Bostonn lund", " Upplan 67", " 113 28", " Dhakackholm", " +46785214", " hfgt@ghm.com"]
                                                             ]*/

            searchResultsIndices = new List<int>();
        }

        // Method to load user data from a file
        private List<string[]> LoadUserData()
        {
            string filePath = @"D:\Visual Studio c#\AddressBook_App\UsersInformation.txt";
            List<string[]> data = new List<string[]>();

            try
            {
                // Use a StreamReader to read data from the specified file.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Read each line of the file.
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts using a comma as the delimiter.
                        string[] parts = line.Split(',');// creating an array name parts which will have six elements

                        // Check if the line has exactly 6 parts, which indicates a valid user record.
                        if (parts.Length == 6)
                        {
                            // Add the valid user data to the 'data' list.
                            data.Add(parts); // Adding arrays to the data list. 
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


        // Method to display search results in the 'listBox1' control
        private void DisplaySearchResults()
        {
            // Clear the items in the 'listBox1' to prepare for displaying new search results.
            listBox1.Items.Clear();

            // Iterate through the search result indices stored in 'searchResultsIndices'.
            foreach (int index in searchResultsIndices) //foreach loop iterate every elements not from 0
            {
                // Check if the index is within the valid range of 'userDataList'.
               if (index >= 0 && index < userDataList.Count)
                {
                    // Retrieve the user data for the current index.
                    string[] userData = userDataList[index];
                    // Add the user's name (located at index 0) to the 'listBox1'.
                    listBox1.Items.Add(userData[0]);
               }
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
            // Check if an item is selected in the 'listBox1'
            if (listBox1.SelectedItem != null)
            {
                // Get the index of the selected item in 'listBox1'
                int selectedIndex = searchResultsIndices[listBox1.SelectedIndex];

                // Retrieve the user data for the selected index from 'userDataList'
                string[] selectedUserData = userDataList[selectedIndex];

                // Create a new instance of Form5 (presumably used for displaying user details)
                Form5 detailsForm = new Form5(selectedUserData, userDataList, selectedIndex);

                // Show the Form5 details form
                detailsForm.Show();

                // Hide the current form (Form3)
                this.Hide();
            }
            else
            {
                Reg.Text = "Please select a user and click view details.";
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // Get the search term entered by the user, trim whitespace, and convert to lowercase for case-insensitive search.
            string searchTerm = SearchBox.Text.Trim().ToLower();

            // Check if the search term is not empty
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Clear the list of search results indices to prepare for new search results.
                searchResultsIndices.Clear();

                // Create a regular expression pattern using the search term.
                // The pattern matches words that start with the search term in a case-insensitive manner.
                Regex regex = new Regex($@"\b{Regex.Escape(searchTerm)}\w*", RegexOptions.IgnoreCase);
                // Iterate through the user data list to find matching results.
                for (int i = 0; i < userDataList.Count; i++)
                {
                    // Retrieve the user data at index 'i' from the userDataList
                    string[] userData = userDataList[i];

                    // Convert the user's name and postal area to lowercase for case-insensitive comparison.
                    string name = userData[0].ToLower();
                    string postalArea = userData[3].ToLower();

                    // Check if the regular expression matches the name or postal area.
                    if ((regex.IsMatch(name) || regex.IsMatch(postalArea)))
                    {
                        // If a match is found, add the index to the list of search results indices.
                        searchResultsIndices.Add(i);
                    }
                }
                // Display the search results in the UI.
                DisplaySearchResults();
            }

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the 'listBox1' control
            if (listBox1.SelectedItem != null)
            {
                // Get the index of the selected item in 'listBox1'
                int selectedIndex = listBox1.SelectedIndex;

                // Get the selected user's name as a string
                string selectedUserName = listBox1.SelectedItem.ToString();

                // Initialize a variable to track the index of the user to remove
                int indexToRemove = -1;

                // Iterate through 'userDataList' to find the index of the selected user by matching their name
                for (int i = 0; i < userDataList.Count; i++)
                {
                    string[] userData = userDataList[i];

                    // Check if the user's name matches the selected user's name
                    if (userData[0] == selectedUserName)
                    {
                        // Store the index of the user to remove and exit the loop
                        indexToRemove = i;
                        break;
                    }
                }

                // Check if a valid index to remove was found
                if (indexToRemove >= 0)
                {
                    // Call the 'RemoveUserData' method to remove the user's data from the file
                    RemoveUserData(userDataList[indexToRemove]);


                    // Remove the user's data from 'userDataList'
                    userDataList.RemoveAt(indexToRemove);

                    // Create a new list for updated search results indices
                    List<int> updatedSearchResultsIndices = new List<int>();

                    // Populate the updated list with valid indices
                    for (int i = 0; i < userDataList.Count; i++)
                    {
                        updatedSearchResultsIndices.Add(i);
                    }

                    listBox1.Items.Clear();

                    // Update the displayed search results
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
                // Read all lines from the file into an array.
                var lines = File.ReadAllLines(filePath);

                // Use LINQ to create updated lines without the data to be removed.
                var updatedLines = lines.Where(line => !string.Join(",", userDataToRemove).Equals(line));

                // Overwrite the file with the updated lines, effectively removing the user's data.
                File.WriteAllLines(filePath, updatedLines);
            }
            catch (Exception ex)
            {
                // If an error occurs while removing data, display an error message in the "Reg" label.
                Reg.Text = ($"An error occurred while removing data: {ex.Message}");
            }
        }

        private void ShowAllUsersBtn_Click(object sender, EventArgs e)
        {
            DisplayAllUsers();
        }

        // Method to display all users in the 'listBox1' control
        private void DisplayAllUsers()
        {
            // Clear the search results indices to show all users
            searchResultsIndices.Clear();

            // Add all user indices to the search results
            for (int i = 0; i < userDataList.Count; i++)
            {
                searchResultsIndices.Add(i);
            }


            // Display the updated search results in the 'listBox1' control
            DisplaySearchResults();
        }



    }
}
