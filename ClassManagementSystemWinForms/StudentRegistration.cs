using Tiny.RestClient;

namespace ClassManagementSystemWinForms
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
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
            string prodi = "";
            if (rbTE.Checked) prodi = "S1 TEKNIK ELEKTRO";
            else if (rbTIF.Checked) prodi = "S1 TEKNOLOGI INFORMASI";
            else if (rbTB.Checked) prodi = "S1 TEKNIK BIOMEDIS";
            else prodi = txtOtherProdi.Text;
            Student student = new Student(txtName.Text, txtUsername.Text, txtPassword.Text, txtNIU.Text, prodi);
            Console.WriteLine(student.createAtDatabase());

        }
        
        private async void btnCariNIU_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new TinyRestClient(new HttpClient(), "https://niu-ugm-id.azurewebsites.net");
                var response = (await client.GetRequest("/" + txtNIU.Text).ExecuteAsync<List<dynamic>>())[0];
                txtName.Text = response["Nama"];
                String prodi = response["Prodi"];
                if (prodi == "S1 TEKNIK ELEKTRO") { 
                    rbTE.Checked = true;
                    txtOtherProdi.Text = "";
                }
                else if (prodi == "S1 TEKNOLOGI INFORMASI")
                {
                    rbTIF.Checked = true;
                    txtOtherProdi.Text = "";
                }
                else if (prodi == "S1 TEKNIK BIOMEDIS")
                {
                    rbTB.Checked = true;
                    txtOtherProdi.Text = "";
                }
                else
                {
                    rbOther.Checked = true;
                    txtOtherProdi.Text = prodi;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}