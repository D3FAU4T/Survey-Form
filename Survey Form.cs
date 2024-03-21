using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Survey_Form
{
    public partial class SurveyForm : Form
    {
        private static string NotGiven = "Not Given";
        private static string NotSelected = "Not Selected";
        private static string SelectAnOption = "Select an option";
        private static string SubmitAlert = "Submit Alert";
        private static string SubmitError = "Submit Error";

        public SurveyForm()
        {
            InitializeComponent();
            InitializeConfig();
            RegisterEvents();
        }

        private Dictionary<string, string> GetConfig()
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            if (NameBox.Text != "Enter your name") config.Add("Name", NameBox.Text);
            else config.Add("Name", NotGiven);

            if (EmailBox.Text != "Enter your email") config.Add("Email", EmailBox.Text);
            else config.Add("Email", NotGiven);

            if (AgeBox.Text != "0") config.Add("Age", AgeBox.Text);
            else config.Add("Age", NotGiven);

            if (RoleSelection.Text != SelectAnOption) config.Add("Role", RoleSelection.Text);
            else config.Add("Current Role", NotSelected);

            config.Add("Recommendation", GetRecommended());

            if (FCCselection.Text != SelectAnOption) config.Add("FCC", FCCselection.Text);
            else config.Add("FCC", NotSelected);

            config.Add("Improvements", GetImprovements());

            return config;
        }

        private string GetImprovements()
        {
            if (FrontEndRadio.Checked) return "Front-end projects";
            else if (BackEndRadio.Checked) return "Back-end projects";
            else if (DataVisualizationRadio.Checked) return "Data Visualization";
            else return "Not Selected";
        }

        private string GetRecommended()
        {
            if (DefinitelyRadio.Checked) return "Definitely";
            else if (MostLikelyRadio.Checked) return "Most Likely";
            else if (NotSureRadio.Checked) return "Not Sure";
            else return "Not Selected";
        }

        private void InitializeConfig()
        {
            RecommendLine.Text = "* How likely is that you would\nrecommend freeCodeCamp to a friend?";
            ImprovementLabel.Text = "Things that should be improved in future\n(Check all that apply):";
            RoleSelection.Text = "Select an option";
            RoleSelection.Items.Add("Student");
            RoleSelection.Items.Add("Professor");
            RoleSelection.Items.Add("Invigilator");
            RoleSelection.Items.Add("Developer");

            FCCselection.Text = "Select an option";
            FCCselection.Items.Add("Developping projects");
            FCCselection.Items.Add("Collaborating with others");
            FCCselection.Items.Add("Organizing events");
        }

        private bool executionCheck(Dictionary<string, string>config)
        {
            if (config["Name"] == NotGiven)
            {
                MessageBox.Show("Name cannot be empty", SubmitError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (config["Email"] == NotGiven)
            {
                MessageBox.Show("Email cannot be empty", SubmitError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(config["Email"]))
            {
                MessageBox.Show("Please enter a valid email", SubmitError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (config["Age"] == NotGiven)
            {
                MessageBox.Show("Please select a valid age", SubmitError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (config["Recommendation"] == NotSelected)
            {
                MessageBox.Show("Recommendation is a required parameter", SubmitError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.\w{2,3})+)$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> config = GetConfig();
            bool check = executionCheck(config);
            if (!check) return;

            string filePath = Path.Combine(Environment.CurrentDirectory, "Survey.txt");

            string[] Lines = {
                "Name: " + config["Name"],
                "Email: " + config["Email"],
                "Age: " + config["Age"],
                "Current Role: " + config["Current Role"],
                "Recommendation: " + config["Recommendation"],
                "FCC: " + config["FCC"],
                "Improvements: " + config["Improvements"],
            };

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in Lines) writer.WriteLine(line);
            }

            MessageBox.Show("Information saved to Survey.txt in the current directory", "Submit alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterEvents()
        {
            NameBox.GotFocus += RemoveNamePlaceHolder;
            NameBox.LostFocus += AddNamePlaceHolder;
            EmailBox.GotFocus += RemoveEmailPlaceHolder;
            EmailBox.LostFocus += AddEmailPlaceHolder;
        }
        
        static void AddNamePlaceHolder(object sender, EventArgs e)
        {
            TextBox namebox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(namebox.Text))
            {
                namebox.Text = "Enter your name";
                namebox.ForeColor = Color.Gray;
            }
        }

        static void AddEmailPlaceHolder(object sender, EventArgs e)
        {
            TextBox emailbox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(emailbox.Text))
            {
                emailbox.Text = "Enter your email";
                emailbox.ForeColor = Color.Gray;
            }
        }

        static void RemoveNamePlaceHolder(object sender, EventArgs e)
        {
            TextBox namebox = (TextBox)sender;
            if (namebox.Text == "Enter your name")
            {
                namebox.Text = "";
                namebox.ForeColor = Color.Black;
            }
        }

        static void RemoveEmailPlaceHolder(object sender, EventArgs e)
        {
            TextBox emailbox = (TextBox)sender;
            if (emailbox.Text == "Enter your email")
            {
                emailbox.Text = "";
                emailbox.ForeColor = Color.Black;
            }
        }
    }
}