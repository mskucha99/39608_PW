using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesel
{
    public partial class Form1 : Form
    {
        private static readonly int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidatePesel(textBox1.Text))
            {
                label2.Text = "Pesel Poprawny";
            }
            else
            {
                label2.Text = "Pesel niepoprawny";
            }
        }

        public static bool ValidatePesel(string pesel)
        {
            bool toRet = false;
            try
            {
                if (pesel.Length == 11)
                {
                    toRet = CountSum(pesel).Equals(pesel[10].ToString());
                }
            }
            catch (Exception)
            {
                toRet = false;
            }
            return toRet;
        }

        private static string CountSum(string pesel)
        {
            int sum = 0;
            for (int i = 0; i < mnozniki.Length; i++)
            {
                sum += mnozniki[i] * int.Parse(pesel[i].ToString());
            }

            int reszta = sum % 10;
            return reszta == 0 ? reszta.ToString() : (10 - reszta).ToString();
        }
    }
}
