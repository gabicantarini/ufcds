using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class FormNacionalidadeInserir : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormNacionalidadeInserir()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {

                if (ligacao.InsertNacionalidade(iso2.Text, nacionalidade.Text))
                {
                    MessageBox.Show("Nacionalidade gravada com sucesso!");
                    Limpar();
                    iso2.Focus();
                }
                else
                {
                    MessageBox.Show("Erro na gravação da nacionalidade!");
                }
            }
        }

        private bool VerificarCampos()
        {

            if (nacionalidade.Text.Length > 100)
            {
                MessageBox.Show("Erro: A nacionalidade deve conter até 100 carateres!");
                nacionalidade.Focus();
                return false;
            }

            if (iso2.Text.Length != 2)
            {
                MessageBox.Show("Erro no campo ALF2 tem de colcar 2 caracteres pelo menos!");
                iso2.Focus();
                return false;
            }
            return true;
        }
        private void FormAdicionarNacionalidade_Load(object sender, EventArgs e)
        {

        }
        private void Limpar()
        {
            nacionalidade.Text = string.Empty;
            iso2.Text = string.Empty;

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
