using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserisci_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Conv();
        }

        void Conv()
        {
            if (checkBox1.Checked)
            {
                string text = Inserisci.Text;
                string risultato = "";
                for (int i = 0; i < text.Length / 4; i++)
                {
                    risultato += Program.valori.GetBySecondValue(text.Substring(i * 4, 4)).ToString();
                }
                textBox1.Text = risultato;

            }
            else
            {
                string text = Inserisci.Text.ToLower();
                string risultato = "";
                foreach (char ch in text)
                {
                    risultato += Program.valori.GetByFirstValue(ch.ToString()).ToString();
                }
                textBox1.Text = risultato;
            }
        }
    }
}
