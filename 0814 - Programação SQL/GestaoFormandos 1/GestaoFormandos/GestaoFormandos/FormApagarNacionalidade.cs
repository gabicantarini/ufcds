using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoFormandos
{
    public partial class FormApagarNacionalidade : Form
    {   
        DBConnect ligacao = new DBConnect();
        string id_nacionalidade = "";
        public FormApagarNacionalidade()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            cmbNacionalidade.SelectedIndex = -1;
            cmbNacionalidade.Enabled = true;
            txtALF2.Text = "";
            txtNacionalidade.Text = "";
            btnEliminar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            cmbNacionalidade.Focus();
        }

        
        private void FormApagarNacionalidade_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
            txtALF2.ReadOnly = true;
            txtNacionalidade.ReadOnly = true;

            btnEliminar.Enabled = false;
        }

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ALF2 = "", nacionalidade = "";

            if(cmbNacionalidade.SelectedIndex != -1)
            {
                id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
                //MessageBox.Show(id_nacionalidade);
                if(ligacao.PesquisaNacionalidade(id_nacionalidade, ref ALF2, ref nacionalidade))
                {
                    txtALF2.Text = ALF2;
                    txtNacionalidade.Text = nacionalidade;

                    cmbNacionalidade.Enabled = false;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nacionalidade não encontrada");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja eliminar o registo " + txtNacionalidade.Text, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ligacao.DeleteNacionalidade(id_nacionalidade))
                {
                    MessageBox.Show("Eliminou o registo com sucesso.");
                    cmbNacionalidade.Text = "";
                    cmbNacionalidade.Items.Clear();
                    ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro na eliminação do registo.");
                }
            }
        }
    }
    
}
