using System;
using System.Windows.Forms;

namespace Final_ms539_2023
{
    public partial class Form1 : Form
    {
        public Form1(string Name = "", string Phone = "")
        {
            InitializeComponent();
            textBox1.Text = Name;
            maskedTextBox1.Text = Phone;
            maskedTextBox1.Mask = "(000) 000-0000";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(textBox1.Text);
            //f2.Show();
            // this.Hide();
            //put in if statement for each box to have messagebox pop up saying it can't be left blank/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form3 F3 = new Form3();
            // F3.Show();
            //this.Hide();
            //see if buttons can be merged depending on what radiobutton is used
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked && maskedTextBox1.Text.Length <= 9)
                {
                    maskedTextBox1.Clear();
                    radioButton1.Checked = false;
                    MessageBox.Show("A-Enter a valid phone number!");
                }
                else if (radioButton1.Checked)
                {
                    Form2 f2 = new Form2(textBox1.Text, maskedTextBox1.Text);
                    f2.Show();
                    this.Hide();
                }
            }
            catch { }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked && maskedTextBox1.Text.Length <= 9)
                {
                    maskedTextBox1.Clear();
                    radioButton2.Checked = false;
                    MessageBox.Show("B-Enter a valid phone number!");
                }
                else if (radioButton2.Checked)
                {
                    Form3 f3 = new Form3(textBox1.Text, maskedTextBox1.Text);
                    f3.Show();
                    this.Hide();
                }
            }
            catch { }
            
            //see if buttons can be merged depending on what radiobutton is used
            //add a jump from client to form 3 when next button is hit
        }

        private void employeeNamePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip employee = new MenuStrip();
            this.MainMenuStrip = employee;
            Controls.Add(employee);
            //Form2.Show();
            //put link to other forms
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip calendar = new MenuStrip();
            this.MainMenuStrip = calendar;
            Controls.Add(calendar);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip Home = new MenuStrip();
            this.MainMenuStrip = Home;
            Controls.Add(Home);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeHRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}

