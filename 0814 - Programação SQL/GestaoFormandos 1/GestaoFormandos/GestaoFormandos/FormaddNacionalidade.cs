using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFormandos
{
    public partial class FormaddNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormaddNacionalidade()
        {
            InitializeComponent();
        }
 

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {

                if (ligacao.InsertNacionalidade(txtALF2.Text, txtNacionalidade.Text))
                {
                    MessageBox.Show("Gravou com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro na gravação do registo!");
                    Limpar();
                    
                }
            }
        }

        private bool VerificarCampos()
        {
           
            //verificar o campo Nome
            txtALF2.Text = Geral.TirarEspacos(txtALF2.Text);
            if (txtALF2.Text.Length != 2)
            {
                MessageBox.Show("Erro no ALF2 (ISO2)!");
                txtALF2.Focus();
                return false;
            }
            //verificar o campo Morada
            txtNacionalidade.Text = Geral.TirarEspacos(txtNacionalidade.Text);
            if (txtNacionalidade.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nacionalidade!");
                txtNacionalidade.Focus();
                return false;
            }

            return true;
        }
        private void Limpar()
        {
            
            txtALF2.Text = "";
            txtNacionalidade.Text = "";
            txtALF2.Focus();

        }

        private void btnCancelar_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Limpar();
                    break;
                case MouseButtons.Right:
                    Close();
                    break;
            }
        }

        private void FormaddNacionalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
