using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace GestaoFormandos
{
    public partial class FormAtualizarFormador : Form
    {
        DBConnect ligacao = new DBConnect();
        String idArea = "";
        String idUtilizador = "";

        public FormAtualizarFormador()
        {
            InitializeComponent();
        }

        private void FormAtualizarFormador_Load(object sender, EventArgs e)
        {

            DesativarControlos();
            ligacao.PreencherComboIDArea(ref cmbIDArea);
            ligacao.PreencherComboIDUtilizador(ref cmbIDUtilizador);
        }

        private void DesativarControlos()
        {
            txtNome.ReadOnly = true;
            mtxtNIF.ReadOnly = true;
            mtxtDataNascimento.ReadOnly = true;
            dateTimePicker1.Visible = false;
            btnAtualizar.Enabled = false;
            this.AcceptButton = this.btnPesquisa;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string nome = "", nif = "", dataNascimento = "", idArea = "", idUtilizador = "";    
            
            if(ligacao.PesquisaFormador(nudID.Value.ToString(), ref nome, ref nif, ref dataNascimento, ref idArea, ref idUtilizador))
            {
                txtNome.Text = nome;
                mtxtNIF.Text = nif;
                mtxtDataNascimento.Text = dataNascimento;
                cmbIDArea.Text = ligacao.DevolverIDArea(idArea);
                cmbIDUtilizador.Text = ligacao.DevolverIDUtilizador(idUtilizador);
                btnAtualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Formador não encontrado.");
                Limpar();
            }
        
        }
        private void Limpar()
        {
            nudID.Value = 0;
            txtNome.Text = string.Empty;
            mtxtNIF.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            mtxtDataNascimento.Clear();
            cmbIDArea.SelectedIndex = -1;
            cmbIDUtilizador.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAtualizar.Enabled = false;
            nudID.Focus();

            Limpar();
            DesativarControlos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                idArea = cmbIDArea.Text.Substring(cmbIDArea.Text.LastIndexOf(' ') + 1);
                idUtilizador = cmbIDUtilizador.Text.Substring(cmbIDUtilizador.Text.LastIndexOf(' ') + 1);

                if (ligacao.UpdateFormador(nudID.Value.ToString(), txtNome.Text, mtxtNIF.Text, DateTime.Parse(mtxtDataNascimento.Text).ToString("yyyy-MM-dd"), idArea, idUtilizador))
                {
                    MessageBox.Show("Gravou com sucesso.");
                    btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erro na atualização do registo!");
                }
            }

        }

        private bool VerificarCampos()
        {
            if (nudID.Value == 0)
            {
                MessageBox.Show("Erro no campo ID.");
                nudID.Focus();
                return false;   
            }
            txtNome.Text = Geral.TirarEspacos(txtNome.Text);
            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Erro no campo Nome.");
                txtNome.Focus();
                return false;
            }
            if(mtxtDataNascimento.Text.Length != 10 || Geral.CheckDate(mtxtDataNascimento.Text) == false)
            {
                MessageBox.Show("Erro no campo Data de Nascimento.");
                mtxtDataNascimento.Focus();
                return false;   
            }
            if(cmbIDArea.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo ID Area.");
                cmbIDArea.Focus();
                return false;
            }
            if (cmbIDUtilizador.SelectedIndex == -1)
            {
                MessageBox.Show("Erro no campo ID Utilizador.");
                cmbIDUtilizador.Focus();
                return false;
            }
            return true;
        }

        private void cmbIDArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDArea.SelectedIndex != -1)
            {
                idArea = cmbIDArea.Text.Substring(cmbIDArea.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
                
            }

            else
            {
                MessageBox.Show("Área não encontrada");
            }
        }

        private void cmbIDUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDUtilizador.SelectedIndex != -1)
            {
                idUtilizador = cmbIDUtilizador.Text.Substring(cmbIDUtilizador.Text.LastIndexOf(' ') + 1);//+1 para contar a partir do espaço
              
            }

            else
            {
                MessageBox.Show("Utilizador não encontrado.");
            }

        }
    }
}
