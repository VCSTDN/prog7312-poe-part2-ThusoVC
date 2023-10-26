using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_Classification_system
{
    public partial class TasksForm : Form
    {

        public static int points = 0;
        public TasksForm()
        {
            InitializeComponent();
            points = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplacingBooksForm frm = new ReplacingBooksForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdentifyingAreas identifyingAreas = new IdentifyingAreas();
            identifyingAreas.Show();
            this.Hide();
           
        }
    }
}
