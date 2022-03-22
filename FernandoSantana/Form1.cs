using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FernandoSantana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ARRAY = new int[100];
            int ValorRecebido = Convert.ToInt32(textBox1.Text);
            ARRAY[0] = ValorRecebido * 2; //valor inicial 
            for (int i = 0; i < ARRAY.Length; i++)
            {
                ARRAY[i] = (ValorRecebido + ValorRecebido) * i;
                richTextBox1.AppendText(Convert.ToString(ARRAY[i]) + Environment.NewLine);
            }
            
        }


    }
}
