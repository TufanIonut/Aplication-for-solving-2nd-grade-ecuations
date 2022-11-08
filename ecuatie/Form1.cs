using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecuatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ecuatie ecuatie = new Ecuatie(textBox1.Text);

                textBox2.Text = ecuatie.Delta().ToString();

                string radacini = ecuatie.Radacini();
                textBox3.Text = radacini.Split(' ')[0];
                textBox4.Text = radacini.Split(' ')[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
