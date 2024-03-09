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
    public partial class FormApagarFormandos : Form
    {
        DBConnect ligacao = new DBConnect();
        public FormApagarFormandos()
        {
            InitializeComponent();
        }


        private void FormApagarFormandos_Load(object sender, EventArgs e)
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

            btnEliminar.Enabled = false;

            this.AcceptButton = this.btnPesquisa;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "", nacionalidade = "";
            char genero = ' ';

            if(ligacao.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero, ref data_nascimento, ref nacionalidade))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                mtxtIBAN.Text = iban;
                txtNacionalidade.Text = ligacao.DevolverNacionalidade(nacionalidade);

                if(genero == 'F')
                {
                    rbFeminino.Checked = true;  
                }
                else if(genero == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else if(genero == 'O')
                {
                    rbOutro.Checked = true; 
                }
                mtxtDataNascimento.Text = data_nascimento;  

                groupBox3.Enabled = false;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formando não encontrado.");
                Limpar();
            }
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
            dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();
            txtNacionalidade.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled=true;
            btnEliminar.Enabled = false;
            nudID.Focus();
            Limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Tem que confirmar com o utilizador primeiro se quer apagar o registo
            //é emitido a mensagem se foi eliminado com sucesso ou não
            //limpas os campos caso for eliminado com sucesso

            if(MessageBox.Show("Deseja eliminar o registo ID " + nudID.Value.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult)
            {
                if (ligacao.Delete(nudID.Value.ToString()))
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
