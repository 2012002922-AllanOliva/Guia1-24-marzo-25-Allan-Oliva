using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guia1_24_marzo_25_AllanOliva
{
    public partial class Form5 : Form
    {
        private int[,] matriz;
        private int[,] matriz2;
        int mul;
        public Form5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            matriz = new int[2, 3];
            matriz2 = new int[2, 3];

            for (int co = 0; co < 2; co++)
            {
                for (int f1 = 0; f1 < 3; f1++)
                {
                    matriz[co, f1] = Convert.ToInt32(Interaction.InputBox("Ingrese un numero"));
                }
            }

            for(int co = 0; co < 2; co++)
            {
                for (int f1 = 0; f1 < 3; f1++)
                {
                    matriz2[co, f1] = Convert.ToInt32(Interaction.InputBox("Ingrese un numero"));
                }
            }

            for (int co = 0; co < 2; co++)
            {
                for (int f1 = 0; f1 < 3; f1++)
                {
                    mul = matriz[co, f1] * matriz2[co, f1];
                    dataGridView1.Rows.Add(matriz[co, f1], matriz2[co,f1],mul);
                }
            }
        }

    }
}
