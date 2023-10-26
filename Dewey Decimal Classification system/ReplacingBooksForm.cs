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
    public partial class ReplacingBooksForm : Form
    {
        //used to check if sorted list is correct
        public List<double> sortedList = new List<double>();
        public List<double> unSortedList = new List<double>();

        public ReplacingBooksForm()
        {
            InitializeComponent();
            listView3.Visible = false;

            randomNumbers();
        }

        //Method to generate our random call numbers and display them on the system
        private void randomNumbers()
        {
            var num = new List<double>();
            Random rnd = new Random();

            double temp;

            //generates random numbers
            for (int j = 0; j < 10; j++)
            {

                num.Add(rnd.NextDouble() * ((999 - 10) + 10));
            }

            //column headers for ui
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Generated Call Numbers";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 146;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Sorted Call Numbers";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 146;

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Correct Call Numbers order";
            columnHeader3.TextAlign = HorizontalAlignment.Left;
            columnHeader3.Width = 146;

            listView1.Columns.Add(columnHeader1);
            listView2.Columns.Add(columnHeader2);
            listView3.Columns.Add(columnHeader3);

            //adds numbers to ui
            for (int count = 0; count < num.Count; count++)
            {
                listView1.Items.Add(num[count].ToString("00.000"));

                temp = Double.Parse(num[count].ToString("000.000"));
                sortedList.Add(temp);
            }
            //sortedList = num;
        }

        //allows user to select items form the first list to sort them
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = listView1.SelectedItems;

            var selectedNum = new List<double>();

            double num;

            //adds items to users sorted list
            //removes items from original list to avoid them being selected multiple times
            foreach (ListViewItem item in selected)
            {
                num = Double.Parse(item.SubItems[0].Text);
                
                unSortedList.Add(num);

                listView2.Items.Add(num.ToString("00.000"));

                item.Remove();
            }
        }


        //submits the users sorted list to check if its correct.
        private void button1_Click(object sender, EventArgs e)
        { 
            // This sorts the randomly generated call numbers and will be used to compare to 
            // check the users call numbers if they have been sorted correctly in acending order.
            sortedList.Sort();

            for (int count = 0; count < sortedList.Count; count++)
            {
                //adds numbers to ui
                listView1.Visible = false;
                listView3.Visible = true;
                this.listView3.Items.Add(sortedList[count].ToString("00.000"));
            }

            // The sorting algorithem intersects the first list with the correct sorted values 
            // and the second list with the users sorted values, it then checks if the squence of the
            // first list matches that of the second list.
            // This algorithem is used in conjunction with the systems gamification feature 
            // awarding the user 'library points' if the sort the list correctly.
            if (sortedList.Intersect(unSortedList).SequenceEqual(unSortedList))
            {
                string message = "Nice! You have succsefuly sorted the numbers! You have been awarded 50 library points.";
                string title = "Congradulations";
                MessageBox.Show(message, title);
                lpLbl.Text = "50";
            }
            else
            {
                string message = "Oops you were not able to correctly sort the numbers. Try again!";
                string title = "Oops";
                MessageBox.Show(message, title);
            }

            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TryAgainBtn_Click(object sender, EventArgs e)
        {
            //restarts the application
            TasksForm tf = new TasksForm();
            tf.Show();
            this.Close();
        }
    }
}
