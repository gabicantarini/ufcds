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
    public partial class FormApagarArea : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormApagarArea()
        {
            InitializeComponent();
        }

        private void FormApagarArea_Load(object sender, EventArgs e)
        {
            txtArea.ReadOnly = true;
            btnEliminar.Enabled = false;

            this.AcceptButton = this.btnEliminar;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string area = "";

            if(ligacao.PesquisaArea(nudID.Value.ToString(), ref area)) 
            {
                txtArea.Text = area;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Area encontrada.");
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
            btnCancelar.Enabled = false;
            nudID.Focus();
            Limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja eliminar o registo ID " + nudID.Value.ToString(),"Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult)
            {
                Limpar();

                if (ligacao.DeleteArea(nudID.Value.ToString()))
                {
                    
                    MessageBox.Show("Registo Eliminado!");
                    btnCancelar_Click(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("Não foi possível eliminar o registo!");
                }
            }    
        }
    }
}
