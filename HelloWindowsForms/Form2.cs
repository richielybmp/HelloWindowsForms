using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowsForms
{
    public partial class Form2 : Form
    {
        int quantidade = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantidade++;
            label_qtd_clicks.Text = quantidade.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quantidade > 0)
            {
                quantidade = 0;
                MessageBox.Show("Contador zerado!", "Alerta");
            }
            else
            {
                MessageBox.Show("O contador já está zerado!", "Alerta");
            }
        }
    }
}
