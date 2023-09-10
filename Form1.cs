using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AddressBook_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string enteredUserName = UserName.Text;
            string enteredPassword = UserPassword.Text;


            if (CheckCredentials(enteredUserName, enteredPassword))
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                Reg.Text = "Incorrect username or password. Please try again.";
            }
        }


        private bool CheckCredentials(string enteredUserName, string enteredPassword)
        {
            string filePath = @"D:\Visual Studio c#\AddressBook_App\Admin.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 2 && parts[0] == enteredUserName && parts[1] == enteredPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Reg.Text = ($"An error occurred: {ex.Message}");
            }

            return false;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}