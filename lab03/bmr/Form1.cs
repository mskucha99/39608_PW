using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmr
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            double wynik= 9.99 * Convert.ToDouble(textBox1.Text) + 6.25 * Convert.ToDouble(textBox2.Text) + 4.92 * Convert.ToDouble(textBox3.Text);

            if (mezczyzna.Checked && wypelnione())
            {
                WynikTekst.Text = "Twoja przemiana materi : " + (wynik + 5);
            }
            else if (kobieta.Checked && wypelnione())
            {
                WynikTekst.Text = "Twoja przemiana materi : " + (wynik - 161);
            }
        }

        private Boolean wypelnione()
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            WynikTekst.Text = "";
        }
    }
}
