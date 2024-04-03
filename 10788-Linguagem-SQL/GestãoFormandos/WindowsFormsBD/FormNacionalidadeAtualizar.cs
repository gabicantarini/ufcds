using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsBD.DBConnect;

namespace WindowsFormsBD
{
    public partial class FormNacionalidadeAtualizar : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormNacionalidadeAtualizar()
        {
            InitializeComponent();
        }

        private void FormApagarNacionalidade_Load(object sender, EventArgs e)
        {
            carrega_combobox();

        }

        private void FormAtualizarNacionalidade_Load(object sender, EventArgs e)
        {
            carrega_combobox();
        }

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ALF2 = "", Nacionalidade = "", ID_nacionalidade = Ultimapalavra();

            ligacao.PesquisaNacionalidade(ID_nacionalidade, ref ALF2, ref Nacionalidade);

            txtALF2.Text = ALF2;
            txtNacionalidade.Text = Nacionalidade;
            btnAtualizar.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (ligacao.UpdateNacionalidade(Ultimapalavra(), txtALF2.Text, txtNacionalidade.Text))
                {
                    MessageBox.Show("Atualizado com sucesso!");

                    cmbNacionalidade.Items.Clear();
                    carrega_combobox();
                    txtALF2.Text = "";
                    txtNacionalidade.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro na actualização da Nacionaliade!");
                }


            }
        }

        private string Ultimapalavra()
        {
            // Recebe o item selecionado no ComboBox
            NacionalidadeItem itemSelecionado = (NacionalidadeItem)cmbNacionalidade.SelectedItem;
            // Dividindo a representação do item em uma matriz de palavras
            string[] palavras = itemSelecionado.ToString().Split('-');
            // Selecionando a última palavra
            string ultimaPalavra = palavras[palavras.Length - 1].Trim();
            return ultimaPalavra;
        }

        private bool VerificarCampos()
        {

            if (txtNacionalidade.Text.Length > 100)
            {
                MessageBox.Show("Erro: A nacionalidade deve conter até 100 carateres!");
                txtNacionalidade.Focus();
                return false;
            }

            if (txtALF2.Text.Length != 2)
            {
                MessageBox.Show("Erro no campo ALF2 tem de colcar 2 caracteres pelo menos!");
                txtALF2.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carrega_combobox()
        {
            ligacao.PreenchercomboNacionalidade(ref cmbNacionalidade);
            groupBox3.Enabled = false;
            btnAtualizar.Enabled = false;
        }
    }
}
