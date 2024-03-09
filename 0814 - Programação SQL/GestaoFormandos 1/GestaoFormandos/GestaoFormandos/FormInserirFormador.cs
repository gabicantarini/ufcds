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
    public partial class FormInserirFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        string id_area = "";
        string id_utilizador = "";

        public FormInserirFormador()
        {
            InitializeComponent();
        }

        private void FormInserirFormador_Load(object sender, EventArgs e)
        {
            nudID.Value = ligacao.DevolveUltimoIDFormador();

            ligacao.PreencherComboIDArea(ref cmbArea);
            ligacao.PreencherComboIDUtilizador(ref cmbUtilizador);

            // Associando o evento SelectedIndexChanged ao ComboBox cmbArea
            cmbArea.SelectedIndexChanged += cmbArea_SelectedIndexChanged;
            cmbUtilizador.SelectedIndexChanged += cmbUtilizador_SelectedIndexChanged;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e) 
        {
            if(ligacao.InsertFormador(nudID.Value.ToString(), txtNome.Text, mtxtNIF.Text, DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), id_area, id_utilizador))
            {
                MessageBox.Show("Gravou com sucesso.");
                Limpar();
                txtNome.Focus();
            }
        }
        private void Limpar()
        {
            nudID.Value = ligacao.DevolveUltimoID();
            txtNome.Text = string.Empty;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mtxtDataNascimento.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void mtxtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int dia, mes, ano;
            string textoData;
            DateTime data;

            if(mtxtDataNascimento.MaskCompleted == true)
            {
                textoData = mtxtDataNascimento.Text;
                dia = int.Parse(textoData.Substring(0,2));
                mes = int.Parse(textoData.Substring(3, 2));
                ano = int.Parse(textoData.Substring(6));

                try
                {
                    data = DateTime.Parse(dia + "-" + mes + "-" + ano);
                    dateTimePicker1.Value = data;
                }
                catch 
                {
                    MessageBox.Show("Data incorreta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtxtDataNascimento.Focus();
                }
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex != -1)
            {
                id_area = cmbArea.Text.Substring(cmbArea.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
            }

            else
            {
                MessageBox.Show("Area não encontrada");
            }

        }

        private void cmbUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUtilizador.SelectedIndex != -1)
            {
                id_utilizador = cmbUtilizador.Text.Substring(cmbUtilizador.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
            }

            else
            {
                MessageBox.Show("Utilizador não encontrada");
            }

        }
    }
}
