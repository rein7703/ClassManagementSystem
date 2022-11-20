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
        public ClassManager()
        {
            InitializeComponent();
            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT \"Code\",\"Name\",\"Lecturer\",\"Day\",\"StartTime\",\"Room\"  FROM \"Course\"", connection);
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
    }
}
