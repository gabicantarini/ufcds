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
    public partial class FormInserirFormandos : Form
    {
        DBConnect ligacao = new DBConnect();
        private string contactoAux = "";
        string id_nacionalidade = "";
        public FormInserirFormandos()
        {
            InitializeComponent();
        }

        private void FormInserirFormandos_Load(object sender, EventArgs e)
        {
            nudID.Value = ligacao.DevolveUltimoID();

            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {


            if (ligacao.Insert(nudID.Value.ToString(), txtNome.Text, txtMorada.Text, contactoAux, mtxtIBAN.Text, Genero(), DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), id_nacionalidade))
            {
                MessageBox.Show("Gravou com sucesso.");
                Limpar();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Erro na gravação do registo!");

            }

        }

        private bool VerificarCampos()
        {
            //verificar o campo ID
            if(nudID.Value == 0) 
            {
                MessageBox.Show("Erro no campo ID.");
                nudID.Focus();
                return false;
            }
            //verificar o campo Nome
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if(txtNome.Text.Length <3)
            {
                MessageBox.Show("Erro no campo Nome.");
                txtMorada.Focus();
                return false;
            }
            //verificar o campo Morada
            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if(txtMorada.Text.Length <3)
            {
                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }
            //verificar o campo Contato
            contactoAux = mtxtContacto.Text.Replace(" ", "");
            if (contactoAux.Length != 0 && contactoAux.Length != 9)
            {
                MessageBox.Show("Erro no campo Contacto.");
                mtxtContacto.Focus();
                return false;
            }
            //verificar o campo IBAN
            if (mtxtIBAN.Text.Length > 25) 
            {
                MessageBox.Show("Erro no campo IBAN.");
                mtxtIBAN.Focus();
                return false;
            }
            //verificar o campo Género
            if (Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Género.");
                rbFeminino.Focus();
                return false;
            }
            //verificar o campo Data de Nascimento
            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data de Nascimento.");
                mtxtDataNascimento.Focus();
                return false;
            }

            return true;
        }
        private char Genero()
        {
            char genero = 'T';

            if (rbFeminino.Checked)
            {
                genero = 'F';
            }
            else if (rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if (rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mtxtDataNascimento.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void mtxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            int dia, mes, ano;
            string textoData;
            DateTime data;

            if(mtxtDataNascimento.MaskCompleted == true)
            {
                textoData = mtxtDataNascimento.Text;
                dia = int.Parse(textoData.Substring(0,2));
                mes = int.Parse(textoData.Substring (3,2));
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
        private void Limpar()
        {
            nudID.Value = ligacao.DevolveUltimoID();
            txtNome.Text = string.Empty;
            txtMorada.Text = "";
            mtxtContacto.Clear();
            mtxtIBAN.Text = string.Empty;
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();


        }

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNacionalidade.SelectedIndex != -1)
            {
                id_nacionalidade = cmbNacionalidade.Text.Substring(cmbNacionalidade.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
            }

            else
            {
                MessageBox.Show("Nacionalidade não encontrada");
            }
            
        }

    }
}
