using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wylosuj();
        }

        private void wylosuj()
        {
            Random rnd = new Random();
            liczba.Text = ""+rnd.Next(1, 6);
        }

        private void r(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                wylosuj();
            }
        }

        private void LPM(object sender, EventArgs e)
        {
            Clipboard.SetText(liczba.Text);
        }
    }
}
