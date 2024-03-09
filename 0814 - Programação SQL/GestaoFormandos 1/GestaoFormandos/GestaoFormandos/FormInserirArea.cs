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
    
    public partial class FormInserirArea : Form
    {
        DBConnect ligacao = new DBConnect();

        public FormInserirArea()
        {
            InitializeComponent();
        }

        private void FormInserirArea_Load(object sender, EventArgs e)
        {
            nudID.Value = ligacao.DevolveUltimoIDArea();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ligacao.InsertArea(Convert.ToInt32(nudID.Value), txtArea.Text))
            {
                MessageBox.Show("Gravou com sucesso.");
                Limpar();
                txtArea.Focus();
            }
            else
            {
                MessageBox.Show("Erro na gravação do registo!");

            }
        }
        private void Limpar()
        {
            nudID.Value = ligacao.DevolveUltimoIDArea();
            txtArea.Text = string.Empty;
            
        }
        private bool VerificarCampos()
        {
            //verificar o campo ID
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID.");
                nudID.Focus();
                return false;
            }
            //verificar o campo Area
            txtArea.Text = Geral.TirarEspacos(txtArea.Text);
            if (txtArea.Text.Length == 0)
            {
                MessageBox.Show("Erro no campo Nome.");
                txtArea.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
