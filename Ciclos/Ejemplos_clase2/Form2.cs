using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos_clase2
{
    public partial class Form2 : Form
    {
        Random aleatorio = new Random();
        int f = 3; int c = 3;
        int[,] matriz1 ;
        int[,] matriz2;
        int[,] matriz3;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matriz1 = new int[f, c];
            for(int i=0; i < f; i++) {
                for(int j = 0; j < c; j++)
                {
                    matriz1[i, j] = aleatorio.Next(0, 10);
                }
            }

            for(int k = 0; k < f; k++)
            {
                dataGridView1.Rows.Add(matriz1[k, 0], matriz1[k, 1], matriz1[k, 2]);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            matriz2 = new int[f, c];
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz2[i, j] = matriz1[j,i];
                }
            }

            for (int k = 0; k < f; k++)
            {
                dataGridView2.Rows.Add(matriz2[k, 0], matriz2[k, 1], matriz2[k, 2]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matriz3 = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz3[i, j] = matriz1[i, j]+ matriz2[i, j];
                }
            }

            for (int k = 0; k < f; k++)
            {
                dataGridView3.Rows.Add(matriz3[k, 0], matriz3[k, 1], matriz3[k, 2]);
            }
        }
    }
}
