using System;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class FormFormandosAtualizar : Form
    {
        DBConnect ligacao = new DBConnect();
        string contactoAux = "";
        public FormFormandosAtualizar()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormandos_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            mtxtIBAN.ReadOnly = true;
            rbFeminino.Enabled = false;
            rbMasculino.Enabled = false;
            rbOutro.Enabled = false;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;

            DesativarControlos();

            btnAtualizar.Enabled = false;

            this.AcceptButton = this.btnPesquisa;
        }

        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            txtMorada.ReadOnly = true;
            //txtNacionalidade.ReadOnly = true;
            mtxtContacto.ReadOnly = true;
            mtxtIBAN.ReadOnly = true;
            rbFeminino.Enabled = false;
            rbMasculino.Enabled = false;
            rbOutro.Enabled = false;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void Limpar()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            txtMorada.Text = "";
            mtxtContacto.Clear();
            mtxtIBAN.Text = string.Empty;
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbOutro.Checked = false;
            //dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

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

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID!");
                nudID.Focus();
                return false;
            }

            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nome!");
                txtNome.Focus();
                return false;
            }

            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Morada!");
                txtMorada.Focus();
                return false;
            }

            //Falta verificar o campo contacto
            contactoAux = mtxtContacto.Text.Replace(" ", "");
            if (contactoAux.Length != 0 && contactoAux.Length != 9)
            {
                MessageBox.Show("Erro no campo Contacto!");
                mtxtContacto.Focus();
                return false;
            }

            if (mtxtIBAN.Text.Length < 25)
            {
                MessageBox.Show("Erro no campo IBAN!");
                mtxtIBAN.Focus();
                return false;
            }

            if (Genero() == 'T')
            {
                MessageBox.Show("Erro no campo Gémero!");
                rbFeminino.Focus();
                return false;
            }

            if (mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data Nascimento!");
                mtxtDataNascimento.Focus();
                return false;
            }


            return true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnAtualizar.Enabled = false;
            nudID.Focus();

            Limpar();
            DesativarControlos();

        }

    }
}
