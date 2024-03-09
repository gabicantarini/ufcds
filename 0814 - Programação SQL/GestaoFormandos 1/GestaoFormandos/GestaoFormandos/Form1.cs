using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos
{
    public partial class Form1 : Form
    {
        DBConnect ligacao = new DBConnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ligação: " + ligacao.StatusConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DBConnection ligacao = new DBConnect();
            MessageBox.Show("Nº total de formandos: " + ligacao.Count().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ligacao.Insert();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (ligacao.Delete())
            {
                MessageBox.Show("Apagou com sucesso!");
            }
           else
            {
                MessageBox.Show("Erro na eliminação!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ligacao.Delete(textBox1.Text))
            {
                MessageBox.Show("Apagou com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na eliminação!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(ligacao.Update(txtID.Text, txtNome.Text))
            {
                MessageBox.Show("Atualizou o nome com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na atualização!");
            }
        }
    }
}
