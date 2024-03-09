using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace GestaoFormandos
{
    public partial class FormAtualizarNacionalidade : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_nacionalidade = "";
        public FormAtualizarNacionalidade()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ALF2 = "", nacionalidade = "";

            if (cmbNacionalidade.SelectedIndex != -1)
            {
                id_nacionalidade = cmbNacionalidade.Text.Substring(cmbNacionalidade.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
                //MessageBox.Show(id_nacionalidade);
                if (ligacao.PesquisaNacionalidade(id_nacionalidade, ref ALF2, ref nacionalidade))
                {
                    txtALF2.Text = ALF2;
                    txtNacionalidade.Text = nacionalidade;

                    cmbNacionalidade.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nacionalidade não encontrada");
                }
            }
        }
        private void Limpar()
        {
            cmbNacionalidade.Text = "";
            txtNacionalidade.Text = "";
            txtALF2.Text = "";
        }

        private void FormAtualizarNacionalidade_Load(object sender, EventArgs e)
        {
            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);

            btnAtualizar.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnAtualizar.Enabled = false;
            cmbNacionalidade.Focus();

            Limpar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (ligacao.UpdateNacionalidade(id_nacionalidade, txtALF2.Text, txtNacionalidade.Text))
                {
                    MessageBox.Show("Atualizou com sucesso.");
                    //btnAtualizar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo.");
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
    }

}
