using ClassManagementSystemMAUIVersion;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagementSystemWinForms
{
    public partial class ClassManager : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection(ConnString.connString);

        public void LoadData()
        {
        try
            {
                connection.Open();
                //MessageBox.Show(LoginID.ID.ToString());
                NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM \"StudentCourse\" sc INNER JOIN \"Course\" c ON sc.\"CourseID\"=c.\"Id\" WHERE sc.\"StudentID\"={LoginID.ID}", connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);
                dgvCourse.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ClassManager()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var addClassStudent = new AddClassStudent();
            addClassStudent.FormClosing += delegate { this.LoadData(); };
            addClassStudent.Show();
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {


                    var r = dgvCourse.Rows[e.RowIndex];
                    int id = int.Parse(r.Cells["CourseId"].Value.ToString());
                    //Delete
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand($"DELETE FROM \"StudentCourse\" WHERE \"StudentCourse\".\"CourseID\"={id} AND \"StudentCourse\".\"StudentID\"={LoginID.ID}", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Menghapus Jadwal");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                LoadData();
                
            }
        }

        private void ClassManager_Load(object sender, EventArgs e)
        {

        }
    }
}
