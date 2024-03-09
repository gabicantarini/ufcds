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
    public partial class FormAtualizarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormAtualizarArea()
        {
            InitializeComponent();
        }

        private void FormAtualizarArea_Load(object sender, EventArgs e)
        {
            txtArea.ReadOnly = true;
            groupBox3.Enabled = false;

            this.AcceptButton = this.btnPesquisa; //O AcceptButton é uma propriedade do formulário que especifica o botão que será clicado automaticamente quando o usuário pressionar "Enter", simulando um clique manual.
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string area = "";

            if(ligacao.PesquisaArea(nudID.Value.ToString(), ref area))
                { 
                    txtArea.Text = area;

                    
                    groupBox3.Enabled = true;
                    txtArea.ReadOnly = false;

            }
            else 
            {
                MessageBox.Show("Area não encontrado.");
                Limpar();
            }
        }
        private void Limpar()
        {
            nudID.Value = 0;
            txtArea.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nudID.Focus();
            groupBox3.Enabled = false;  

            Limpar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(ligacao.UpdateArea(nudID.Value.ToString(), txtArea.Text))
            {
                MessageBox.Show("Gravou com sucesso.");
                btnCancelar_Click(sender, e);   
            }
            else
            {
                MessageBox.Show("Erro na atualização do registo.");
            }
        }

    }
}
