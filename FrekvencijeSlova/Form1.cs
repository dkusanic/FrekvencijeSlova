using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrekvencijeSlova
{
    public partial class FrmFrekvencije : Form
    {
        public FrmFrekvencije()
        {
            InitializeComponent();
            
        }
        private List<Letter> lista = new List<Letter>();

        private void txtBoxUnos_TextChanged(object sender, EventArgs e)
        {
            CheckFrequencies();
            Print();
        }
        private void CheckFrequencies()
        {
            lista.Clear();
            foreach (char c in txtBoxUnos.Text)
            {
                Letter l = lista.FirstOrDefault(y => y.LetterName == c);
                if (l != null)
                    l.Frequency++;
                else
                {
                    Letter novo = new Letter();
                    novo.LetterName = c;
                    lista.Add(novo);
                }
            }
        }
        private void Print()
        {
            txtBoxIspis.Clear();
            foreach (Letter l in lista.OrderByDescending(y => y.Frequency))
                txtBoxIspis.Text += l.ToString();
        }
    }
}
