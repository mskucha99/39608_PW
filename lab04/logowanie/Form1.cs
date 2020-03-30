using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{
    public partial class Form1 : Form
    {
        List<User> uzytkownicy =new List<User>();

        public Form1()
        {
            InitializeComponent();
            uzytkownicy.Add(new User("skucha@wp.pl", "1234"));
            uzytkownicy.Add(new User("kowalski@wp.pl", "1234"));
        }

        private Boolean wypelnione()
        {
            if(textBox1.Text != "" && textBox2.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (wypelnione())
            {
                foreach(User user in uzytkownicy)
                {
                    if (user.logowanie(textBox1.Text, textBox2.Text))
                    {
                        Form2 form2 = new Form2();
                        form2.ustawEmail(textBox1.Text);
                        form2.Show();
                    }
                }
            }
        }
    }
}
