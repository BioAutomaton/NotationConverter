using System;
using System.Windows.Forms;

namespace NotationConverter
{
    public partial class Form1 : Form
    {
        private readonly string[] options = { "Notation 2", "Notation 8", "Notation 10", "Notation 16" };

        public Form1()
        {
            InitializeComponent();
            FromComBox.Items.AddRange(options);
            FromComBox.SelectedIndex = 3;

            ToComBox.Items.AddRange(options);
            ToComBox.SelectedIndex = 2;
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                dynamic number;
                string output = "";
                switch (FromComBox.SelectedItem)
                {
                    case "Notation 2":
                        number = new N2(InputTextBox.Text);
                        break;
                    case "Notation 8":
                        number = new N8(InputTextBox.Text);
                        break;
                    case "Notation 10":
                        number = new N10(InputTextBox.Text);
                        break;
                    case "Notation 16":
                        number = new N16(InputTextBox.Text);
                        break;
                    default:
                        number = new N16(InputTextBox.Text);
                        break;
                }

                switch (ToComBox.SelectedItem)
                {
                    case "Notation 2":
                        output = number.ToN2().ToString();
                        break;
                    case "Notation 8":
                        output = number.ToN8().ToString();
                        break;
                    case "Notation 10":
                        output = number.ToN10().ToString();
                        break;
                    case "Notation 16":
                        output = number.ToN16().ToString();
                        break;
                    default:
                        output = "N/A";
                        break;
                }

                OutputTextBox.Text = output;
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate(null, null);
        }

        private void swapNotationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = FromComBox.SelectedIndex;

            FromComBox.SelectedIndex = ToComBox.SelectedIndex;
            ToComBox.SelectedIndex = selectedIndex;

            InputTextBox.Text = OutputTextBox.Text;
            Calculate(null, null);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                Calculate(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}