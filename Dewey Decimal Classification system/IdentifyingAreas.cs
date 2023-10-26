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
    public partial class IdentifyingAreas : Form
    {
        //Dictionary
        public IDictionary<int, string> decimalNum = new Dictionary<int, string>();
        public int points = TasksForm.points;

        public IdentifyingAreas()
        {
            InitializeComponent();

            //Storing to Dictionary
            decimalNum.Add(000, "General Knowledge");
            decimalNum.Add(100, "Philosophy and Psychology");
            decimalNum.Add(200, "Religion");
            decimalNum.Add(300, "Social Science");
            decimalNum.Add(400, "Language");
            decimalNum.Add(500, "Science");
            decimalNum.Add(600, "Technology");
            decimalNum.Add(700, "Arts and Recreation");
            decimalNum.Add(800, "Litruture");
            decimalNum.Add(900, "History and Geography");


            //randomizer & loading our table with call numbers and descriptions
            //tags will be used to validate if user is correct
            Random rand = new Random();

            var randomNumbersCall = Enumerable.Range(0, 10).OrderBy(x => rand.Next()).Take(7).ToList();

            //populating call numbers
            callNum1Txt.Text = "A) " + decimalNum.ElementAt(randomNumbersCall[0]).Key.ToString();
            btnA.Tag = decimalNum.ElementAt(randomNumbersCall[0]).Value;

            callNum2Txt.Text = "B) " + decimalNum.ElementAt(randomNumbersCall[1]).Key.ToString();
            btnB.Tag = decimalNum.ElementAt(randomNumbersCall[1]).Value;

            callNum3Txt.Text = "C) " + decimalNum.ElementAt(randomNumbersCall[2]).Key.ToString();
            btnC.Tag = decimalNum.ElementAt(randomNumbersCall[2]).Value;

            callNum4Txt.Text = "D) " + decimalNum.ElementAt(randomNumbersCall[3]).Key.ToString();
            btnD.Tag = decimalNum.ElementAt(randomNumbersCall[3]).Value;

            //populating descriptions
            description1Txt.Text = "1) " + decimalNum.ElementAt(randomNumbersCall[5]).Value;
            panel1.Tag = decimalNum.ElementAt(randomNumbersCall[5]).Value;

            description2Txt.Text = "2) " + decimalNum.ElementAt(randomNumbersCall[2]).Value;
            panel2.Tag = decimalNum.ElementAt(randomNumbersCall[2]).Value;

            description3Txt.Text = "3) " + decimalNum.ElementAt(randomNumbersCall[1]).Value;
            panel3.Tag = decimalNum.ElementAt(randomNumbersCall[1]).Value;

            description4Txt.Text = "4) " + decimalNum.ElementAt(randomNumbersCall[4]).Value;
            panel4.Tag = decimalNum.ElementAt(randomNumbersCall[4]).Value;

            description5Txt.Text = "5) " + decimalNum.ElementAt(randomNumbersCall[0]).Value;
            panel5.Tag = decimalNum.ElementAt(randomNumbersCall[0]).Value;

            description6Txt.Text = "6) " + decimalNum.ElementAt(randomNumbersCall[3]).Value;
            panel6.Tag = decimalNum.ElementAt(randomNumbersCall[3]).Value;

            description7Txt.Text = "7) " + decimalNum.ElementAt(randomNumbersCall[6]).Value;
            panel7.Tag = decimalNum.ElementAt(randomNumbersCall[6]).Value;

            //displaying points
            pointsLbl.Text = points.ToString();
        }

        //drag drop function
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //drag drop function
        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Button bt = ((Button)e.Data.GetData(typeof(Button)));
            bt.Parent = (Panel)sender;
            bt.Dock = DockStyle.Fill;
            bt.BringToFront();
        }

        //drag drop function
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (sender as Button);
            bt.DoDragDrop(sender, DragDropEffects.Move);

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            string message = "Thank you for playing! You have accumilated: " + TasksForm.points + " points during your session";
            string title = "Congradulations";
            MessageBox.Show(message, title);
            this.Hide();
            TasksForm tasksForm = new TasksForm();
            tasksForm.Show();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            //loops over all controls
            foreach (var ctl in Controls)
            {
                var pnl = ctl as Panel;
                if (pnl != null)
                {
                    // loop over the Controls in a Panel
                    foreach (var pnlctl in pnl.Controls)
                    {
                        // finds buttons
                        var bt = pnlctl as Button;

                        bt.Enabled = false;
                        pnl.Enabled = false;
                        if (bt != null)
                        {
                            // check if the Tag property of the Panel matches that of the Button
                            if (pnl.Tag == bt.Tag)
                            {
                                bt.BackColor = Color.Green;
                            }
                            else
                            {
                                bt.BackColor = Color.Red;
                            }

                        }
                    }
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //loops over all controls
            foreach (var ctl in Controls)
            {
                var pnl = ctl as Panel;
                if (pnl != null)
                {
                    // loop over the Controls in a Panel
                    foreach (var pnlctl in pnl.Controls)
                    {
                        
                        // finds buttons
                        var bt = pnlctl as Button;
                        bt.Enabled = true;
                        pnl.Enabled = true;
                        if (bt != null)
                        {
                            // check if the Tag property of the Panel matches that of the Button
                            if (pnl.Tag == bt.Tag)
                            {
                                //gammification feature adding points 
                                points = points + 25;
                                pointsLbl.Text = points.ToString();
                            }
                            else
                            {
                                pointsLbl.Text = points.ToString();
                            }

                        }
                    }
                }
            }
            TasksForm.points = points;
            this.Close();
            IdentifyingAreas identifyingAreas = new IdentifyingAreas();
            identifyingAreas.Show();
        }
    } 
}
