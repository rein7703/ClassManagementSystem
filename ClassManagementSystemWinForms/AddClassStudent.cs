using ClassManagementSystemMAUIVersion;
using Npgsql;
using System.Data;

namespace ClassManagementSystemWinForms
{
    public partial class AddClassStudent : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection(ConnString.connString);
        string id = "-1";
        public DataTable LoadData()
        {
            try
            {
                connection.Open();
                //MessageBox.Show(LoginID.ID.ToString());
                NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM \"Course\"",connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);
                dgvCourse.DataSource = dt;
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new DataTable();
            }
        }
        public AddClassStudent()
        {
            InitializeComponent();
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var filtered_dt = LoadData().AsEnumerable().Where(r => (r.Field<string>("Name")??"").ToLower().Contains(txtSearch.Text.ToLower())).CopyToDataTable();
                dgvCourse.DataSource = filtered_dt;
            }
            catch
            {
                dgvCourse.DataSource = new DataTable();
            }
            
        }

        private void AddClassStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Selecting the cell
               
                id = dgvCourse.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                lblSelectedTitle.Text = dgvCourse.Rows[e.RowIndex].Cells["Name"].Value.ToString();
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 
            connection.Open();
            if(id=="-1")
            {
                MessageBox.Show("Pilih matkul terlebih dahulu");
                return;
            }
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"StudentCourse\" (\"StudentID\",\"CourseID\") VALUES (@StudentId,@CourseId)", connection);
            command.Parameters.AddWithValue("StudentID", LoginID.ID);
            command.Parameters.AddWithValue("CourseID", int.Parse(id));
            command.ExecuteNonQuery();
            MessageBox.Show($"Berhasil menambahkan matkul!");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                
                connection.Close();
                LoadData();
            }
        }
    }
}