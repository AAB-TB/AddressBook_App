using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AddressBook_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // It initializes the form's components, such as buttons, labels, etc.
            InitializeComponent();
        }


        // This event handler is triggered when the "SignInBtn" button is clicked.
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            // Get the text entered in the "UserName" and "UserPassword" textboxes.
            string enteredUserName = UserName.Text;
            string enteredPassword = UserPassword.Text;

            // Check if either of the textboxes is empty.
            if (string.IsNullOrEmpty(enteredUserName) || string.IsNullOrEmpty(enteredPassword))
            {
                // Display an error message if either field is empty.
                Reg.Text = "Please enter both username and password.";
            }
            else
            {

                // Call the CheckCredentials method to verify the entered username and password.
                if (CheckCredentials(enteredUserName, enteredPassword))
                {
                    // If the credentials are correct, create a new instance of Form3 and show it.
                    Form3 form3 = new Form3();
                    form3.Show();
                    // Hide the current form (Form1).
                    this.Hide();
                }
                else
                {
                    // If the credentials are incorrect, display an error message in the "Reg" label.
                    Reg.Text = "Incorrect username or password. Please try again.";
                }
            }
        }

        // This method checks the entered user credentials against a file.
        // It returns true if the credentials are valid, otherwise, it returns false.
        private bool CheckCredentials(string enteredUserName, string enteredPassword)
        {
            // Specify the path to the file that stores the admin credentials.
            string filePath = @"D:\Visual Studio c#\AddressBook_App\Admin.txt";

            try
            {
                // Use a StreamReader to read the file line by line.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    // Iterate through each line in the file.
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into parts based on the ',' delimiter.
                        string[] parts = line.Split(',');

                        // Check if the line has exactly 2 parts (username and password) and they match the entered credentials.
                        if (parts.Length == 2 && parts[0] == enteredUserName && parts[1] == enteredPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If an error occurs while reading the file, display an error message in the "Reg" label.
                Reg.Text = ($"An error occurred: {ex.Message}");
            }
            // If no valid credentials are found or an error occurred, return false.
            return false;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SignInBtn.Select();
        }
    }
}