using System.Xml.Linq;

namespace ClassManagementSystemWinForms
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                MessageBox.Show("Harap isi semua kolom yang diwajibkan");
                return;
            }
            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Mohon cek kembali kolom Password dan Ulangi Password");
                return;
            }

            Admin admin = new Admin(txtNama.Text, txtUsername.Text, txtPassword.Text, txtNIP.Text, txtJabatan.Text);
            if(admin.createAtDatabase())this.Close();;
            
        }
    }
}