using iTextSharp.text.pdf.fonts.cmaps;
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
    public partial class FormAtualizarFormandos : Form
    {
        DBConnect ligacao = new DBConnect();
        string contactoAux = "";
        string id_nacionalidade = "";
        public FormAtualizarFormandos()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormandos_Load(object sender, EventArgs e)
        {

            DesativarControlos();

            btnAtualizar.Enabled = false;

            this.AcceptButton = this.btnPesquisa;

            ligacao.PreencherComboNacionalidade(ref cmbNacionalidade);
        }

        private void DesativarControlos()
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

            btnAtualizar.Enabled = false;

            this.AcceptButton = this.btnPesquisa;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", morada = "", contacto = "", iban = "", data_nascimento = "", nacionalidade = "";
            char genero = ' ';

            if (ligacao.PesquisaFormando(nudID.Value.ToString(), ref nome, ref morada, ref contacto, ref iban, ref genero, ref data_nascimento, ref nacionalidade))
            {
                txtNome.Text = nome;
                txtMorada.Text = morada;
                mtxtContacto.Text = contacto;
                mtxtIBAN.Text = iban;
                if (genero == 'F')
                {
                    rbFeminino.Checked = true;
                }
                else if (genero == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else if (genero == 'O')
                {
                    rbOutro.Checked = true;
                }
                mtxtDataNascimento.Text = data_nascimento;
                cmbNacionalidade.Text = ligacao.DevolverNacionalidade(nacionalidade);
               

                groupBox3.Enabled = false;
                btnAtualizar.Enabled = true;

                txtNome.ReadOnly = false;
                txtMorada.ReadOnly = false;
                mtxtContacto.ReadOnly = false;
                mtxtIBAN.ReadOnly = false;
                rbFeminino.Enabled = true;
                rbMasculino.Enabled = true;
                rbOutro.Enabled = true;
                mtxtDataNascimento.ReadOnly = false;
                cmbNacionalidade.Enabled = true;
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
            cmbNacionalidade .SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            btnAtualizar.Enabled = false;
            nudID.Focus();

            Limpar() ;
            DesativarControlos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(VerificarCampos())
            {
                //Atualizar o registo do formando
                //Criar o método de Update e devolve bool
                //Caso consegue atualizar emite a mensagem de "Atualizado com sucesso" e 
                //ative o botão de cancelar
                //Caso não consegue, dá erro na atualização emite só a mensagem "Erro na atualização do registo."

                id_nacionalidade = cmbNacionalidade.Text.Substring(
                    cmbNacionalidade.Text.LastIndexOf(' ') + 1);

                if (ligacao.Update(nudID.Value.ToString(), txtNome.Text, txtMorada.Text, contactoAux, mtxtIBAN.Text, Genero(), DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), id_nacionalidade))
                {
                    MessageBox.Show("Gravou com sucesso.");
                    btnCancelar_Click(sender,e);
                
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo!");
                }
            }
        
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
            //verificar o campo Nome
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nome.");
                txtMorada.Focus();
                return false;
            }
            //verificar o campo Morada
            txtMorada.Text = Geral.TirarEspacos(txtMorada.Text);
            if (txtMorada.Text.Length < 3)
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

            //verificar o campo Nacionalidade
            if (cmbNacionalidade.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo da Nacionalidade!");
                cmbNacionalidade.Focus();
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

        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNacionalidade.SelectedIndex != -1)
            {
                id_nacionalidade = cmbNacionalidade.Text.Substring(cmbNacionalidade.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
                MessageBox.Show(id_nacionalidade);                  
            }

            else
            {
                MessageBox.Show("Nacionalidade não encontrada");
            }
        }
    }
}
