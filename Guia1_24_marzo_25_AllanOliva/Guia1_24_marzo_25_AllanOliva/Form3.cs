using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_25_AllanOliva
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 1;
            int nume;
            nume=Convert.ToInt32(textBox1.Text);
            do
            {
                int multi;
                multi = nume * cont;
                dataGridView1.Rows.Add(nume, cont, multi);
                cont++;
            }
            while (cont < 11);
           
        }
    }
}
