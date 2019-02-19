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
    public partial class Form1 : Form
    {
        //numeros aleatorios
        Random aleatorio = new Random();
        //int[] vector= new int[20];
        List<int> vector = new List<int>();
        List<int> Otralista = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetodoBurbuja();
            listBox2.DataSource = vector;

        }

        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Count; a++)
                for (int b = vector.Count - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                int numero = aleatorio.Next(0, 100);
                vector.Add(numero);                  
            }

            listBox1.DataSource = vector;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otralista.Add(int.Parse(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.DataSource = Otralista;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int t;
            for (int a = 1; a < Otralista.Count; a++)
                for (int b = Otralista.Count - 1; b >= a; b--)
                {
                    if (Otralista[b - 1] > Otralista[b])
                    {
                        t = Otralista[b - 1];
                        Otralista[b - 1] = Otralista[b];
                        Otralista[b] = t;
                    }
                }

          //  listBox3.Items.Clear();
            listBox2.DataSource = Otralista;
        }
    }
}
