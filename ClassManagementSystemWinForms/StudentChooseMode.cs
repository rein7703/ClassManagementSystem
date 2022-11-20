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
    public partial class StudentChooseMode : Form
    {
        public StudentChooseMode()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClassManager classManager = new ClassManager();
            classManager.FormClosing += delegate { this.Show(); };
            classManager.Show();
            this.Hide();
        }

        private void btnToTask_Click(object sender, EventArgs e)
        {
            TaskManager taskManager = new TaskManager();
            taskManager.FormClosing += delegate { this.Show(); };
            taskManager.Show();
            this.Hide();
        }
    }
}
