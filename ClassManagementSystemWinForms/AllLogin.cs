using ClassManagementSystemMAUIVersion;
using Npgsql;
using System.Data;
using System.Windows.Forms;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(ConnString.connString);
            if (isStudent)
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT \"Id\" FROM \"Student\" WHERE \"Username\" = @username AND \"Password\" = @password", connection);
                    command.Parameters.AddWithValue("username", txtUsername.Text);
                    command.Parameters.AddWithValue("password", txtPassword.Text);
                    var result = command.ExecuteScalar();
                    if (result == null) { throw new DataException("Periksa kembali Username dan Password Anda"); }
                    
                    MessageBox.Show("Berhasil login dengan username "+txtUsername.Text);
                    LoginID.ID = (int) result;
                    StudentChooseMode studentChooseMode = new StudentChooseMode();
                    studentChooseMode.Show();
                    studentChooseMode.FormClosing += delegate { this.Show(); };
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
 
            }
            else
            {
                

                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT \"Id\" FROM \"Admin\" WHERE \"Username\" = @username AND \"Password\" = @password", connection);
                    command.Parameters.AddWithValue("username", txtUsername.Text);
                    command.Parameters.AddWithValue("password", txtPassword.Text);
                    var result = command.ExecuteScalar();
                    if (result == null) { throw new DataException("Periksa kembali Username dan Password Anda"); }

                    MessageBox.Show("Berhasil login dengan username " + txtUsername.Text);
                    LoginID.ID = (int)result;
                    ClassManagerAdmin classManagerAdmin = new ClassManagerAdmin();
                    classManagerAdmin.Show();
                    classManagerAdmin.FormClosing += delegate { this.Show(); };
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}