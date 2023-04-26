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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2(textBox1.Text, textBox2.Text);
            //f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              // Streamwriter employeeInfo = new Streamwriter("C:/Users/trici/OneDrive/Documents/GitHub/Employee info VS.docx");
        }
    }
}
