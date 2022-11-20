namespace ClassManagementSystemWinForms
{
    public partial class AllLogin : Form
    {
        bool isStudent = true;
        public AllLogin()
        {
            InitializeComponent();
        }

        private void btnSwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isStudent = !isStudent;
            lblHeadline.Text = isStudent ? "Student Login" : "Admin Login";
            btnSwitch.Text = isStudent ? "Login as Admin?" : "Login as Student?";
        }

        private void btnLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isStudent)
            {
                StudentRegistration studentRegister = new StudentRegistration();
                studentRegister.Show();
            }
            else
            {
                AdminRegistration adminRegister = new AdminRegistration();
                adminRegister.Show();
            }
        }
    }
}