using System.DirectoryServices.ActiveDirectory;

namespace Guia1_24_marzo_25_AllanOliva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;

                dataGridView1.Rows.Add(num1, cont, multi);
            }

            //int cont2 = 1;
            //while (cont2 < 11) 
            //{
            //    int multi;
            //    multi = num1 * cont2;
            //    dataGridView1.Rows.Add(num1, cont2, multi);
            //    cont2++;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 forme = new Form2();
            forme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 forme1 = new Form3();
            forme1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 forme4 = new Form4();
            forme4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 forme5 = new Form5();
            forme5.ShowDialog();
        }
    }
}
