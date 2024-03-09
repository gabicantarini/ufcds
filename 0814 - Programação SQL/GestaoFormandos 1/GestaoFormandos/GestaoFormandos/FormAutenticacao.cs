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
    public partial class FormAutenticacao : Form
    {
        DBConnect ligacao = new DBConnect();
      
        public FormAutenticacao()
        {
            InitializeComponent();
        }

        private void FormAutenticacao_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPW.Text = "";
            ControlBox = false;
            AcceptButton = btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha tudo
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int nfalhas = 0;    
            if (ligacao.ValidateUserStatus(txtUser.Text, ref nfalhas))
            {
                MessageBox.Show("Utilizador bloqueado! Nº Falhas de autenticação: " + nfalhas + "\nContacte o Administrador do Sistema.");
                return;
            }
            if (ligacao.ValidateUser2(txtUser.Text, txtPW.Text, ref Geral.id_user))
            {
                DialogResult = DialogResult.OK;
            }
            else  
            {
                MessageBox.Show("Erro na autenticação.");
            }
        }
    }
}
