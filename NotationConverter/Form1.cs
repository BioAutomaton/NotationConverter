using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotationConverter
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
                N10 number = new N10(EnteringTextBox.Text);
                N8 output = number.ToN8();
                OutputTextBox.Text = output.ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
