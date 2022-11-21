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
    public partial class ClassManagerAdmin : Form
    {
        NpgsqlConnection connection = new NpgsqlConnection(ConnString.connString);
        string id = "-1";
        public DataTable LoadData()
        {
            try
            {
                connection.Open();
                //MessageBox.Show(LoginID.ID.ToString());
                NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM \"Course\"", connection);
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
        public ClassManagerAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Selecting the cell

                id = dgvCourse.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                lblSelectedTitle.Text = dgvCourse.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtClassCode.Text = dgvCourse.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                txtClassName.Text = dgvCourse.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtDay.Text = dgvCourse.Rows[e.RowIndex].Cells["Day"].Value.ToString();
                startTimePicker.Text = dgvCourse.Rows[e.RowIndex].Cells["StartTime"].Value.ToString();
                txtLecturerName.Text = dgvCourse.Rows[e.RowIndex].Cells["Lecturer"].Value.ToString();
                txtRoom.Text = dgvCourse.Rows[e.RowIndex].Cells["Room"].Value.ToString();

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
            try
            {
                connection.Open();
                //MessageBox.Show(startTimePicker.Text);
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO \"Course\" (\"Code\", \"Name\", \"Day\", \"StartTime\", \"Lecturer\", \"Room\") VALUES (@code, @name, @day, @startTime, @lecturer, @room)", connection);
                command.Parameters.AddWithValue("code", txtClassCode.Text);
                command.Parameters.AddWithValue("name", txtClassName.Text);
                command.Parameters.AddWithValue("day", txtDay.Text);
                command.Parameters.AddWithValue("startTime", startTimePicker.Value);
                command.Parameters.AddWithValue("lecturer", txtLecturerName.Text);
                command.Parameters.AddWithValue("room", txtRoom.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Berhasil menambah kelas!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == "-1")
                {
                    MessageBox.Show("Pilih matkul terlebih dahulu");
                    return;
                }
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"UPDATE \"Course\" SET \"Code\" = @code, \"Name\" = @name, \"Day\" = @day, \"StartTime\" = @startTime, \"Lecturer\" = @lecturer, \"Room\" = @room WHERE \"Id\" = @id", connection);
                command.Parameters.AddWithValue("code", txtClassCode.Text);
                command.Parameters.AddWithValue("name", txtClassName.Text);
                command.Parameters.AddWithValue("day", txtDay.Text);
                command.Parameters.AddWithValue("startTime", startTimePicker.Value);
                command.Parameters.AddWithValue("lecturer", txtLecturerName.Text);
                command.Parameters.AddWithValue("room", txtRoom.Text);
                command.Parameters.AddWithValue("id", int.Parse(id));
                command.ExecuteNonQuery();
                MessageBox.Show("Berhasil mengubah kelas!");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == "-1")
                {
                    MessageBox.Show("Pilih matkul terlebih dahulu");
                    return;
                }
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand($"DELETE FROM \"Course\" WHERE \"Id\" = @id", connection);
                command.Parameters.AddWithValue("id", int.Parse(id));
                command.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus kelas!");
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
