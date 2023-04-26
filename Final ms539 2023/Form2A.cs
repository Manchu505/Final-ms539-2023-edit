using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ms539_2023
{
    public partial class Form2 : Form
    {
        public Form2(string fromF1, string phone)
        {
            InitializeComponent();
            textBox1.Text = fromF1;
            textBox2.Text = phone;
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //figure how to put in new pages for this on the same form?     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(textBox1.Text, textBox2.Text);
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.Clear();
            MessageBox.Show("Not a Valid Phone Number");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //put in transferr from phone number on form 1
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please Enter Valid Date ");
            MessageBox.Show("Date Format is MM/DD/YYYY");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3 = new TextBox();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4 = new TextBox();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving Employee file");
            //add save to file here 
            //SaveFileDialog https:\\d.docs.live.net\8c6e90fe5fe39e7c\Documents\GitHub\Employee%20info%20from%20visual%20studio.docx
        }

        private void hRPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Protected");
            //put in password information 
            //"if" incorrect password then (loop)stay on form and message saying incorrect password56
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}