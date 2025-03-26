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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nume1;
            nume1 = Convert.ToInt32(textBox1.Text);
            int nume2;
            nume2= Convert.ToInt32(textBox2.Text);

            for (int cont = 1; cont < 2; cont++)
            {
                int multi;
                multi = nume1 + nume2;

                dataGridView1.Rows.Add(nume1, nume2, multi);
            }
        }
    }
}
