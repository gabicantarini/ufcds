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
    public partial class FormPrincipal : Form
    {
        FormInserirFormandos formInserirFormandos = new FormInserirFormandos();
        FormApagarFormandos formApagarFormandos = new FormApagarFormandos();
        FormAtualizarFormandos formAtualizarFormandos = new FormAtualizarFormandos();
        FormListarFormandos formListarFormandos = new FormListarFormandos();
        FormaddNacionalidade formaddNacionalidade = new FormaddNacionalidade();
        FormAtualizarNacionalidade formAtualizarNacionalidade = new FormAtualizarNacionalidade();
        FormApagarNacionalidade formApagarNacionalidade = new FormApagarNacionalidade();
        FormListarNacionalidade formListarNacionalidade = new FormListarNacionalidade();
        FormAutenticacao formAutenticacao = new FormAutenticacao();
        FormInserirArea formInserirArea = new FormInserirArea();
        FormAtualizarArea formAtualizarArea = new FormAtualizarArea();
        FormApagarArea formApagarArea = new FormApagarArea();
        FormListarArea formListarArea = new FormListarArea();
        FormInserirFormador formInserirFormador = new FormInserirFormador();
        FormAtualizarFormador formAtualizarFormador = new FormAtualizarFormador();
        FormApagarFormador formApagarFormador = new FormApagarFormador();
        FormListarFormador formListarFormador = new FormListarFormador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormandos.IsDisposed)
            {
                formInserirFormandos = new FormInserirFormandos();
            }
            formInserirFormandos.MdiParent = this;
            formInserirFormandos.StartPosition = FormStartPosition.Manual;
            formInserirFormandos.Location = new Point((this.ClientSize.Width-formInserirFormandos.Width) /2,
                    (this.ClientSize.Height-formInserirFormandos.Height)/3);
            formInserirFormandos.Show();
            formInserirFormandos.Activate();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormandos.IsDisposed)
            {
                formApagarFormandos = new FormApagarFormandos();
            }
            formApagarFormandos.MdiParent = this;
            formApagarFormandos.StartPosition = FormStartPosition.Manual;
            formApagarFormandos.Location = new Point((this.ClientSize.Width - formApagarFormandos.Width) / 2,
                    (this.ClientSize.Height - formApagarFormandos.Height) / 3);
            formApagarFormandos.Show();
            formApagarFormandos.Activate();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormandos.IsDisposed)
            {
                formAtualizarFormandos = new FormAtualizarFormandos();
            }
            formAtualizarFormandos.MdiParent = this;
            formAtualizarFormandos.StartPosition = FormStartPosition.Manual;
            formAtualizarFormandos.Location = new Point((this.ClientSize.Width - formAtualizarFormandos.Width) / 2,
                    (this.ClientSize.Height - formAtualizarFormandos.Height) / 3);
            formAtualizarFormandos.Show();
            formAtualizarFormandos.Activate();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formListarFormandos.IsDisposed)
            {
                formListarFormandos = new FormListarFormandos();
            }
            formListarFormandos.MdiParent = this;
            formListarFormandos.StartPosition = FormStartPosition.Manual;
            formListarFormandos.Location = new Point((this.ClientSize.Width - formListarFormandos.Width) / 2,
                    (this.ClientSize.Height - formListarFormandos.Height) / 3);
            formListarFormandos.Show();
            formListarFormandos.Activate();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formaddNacionalidade.IsDisposed)
            {
                formaddNacionalidade = new FormaddNacionalidade();
            }
            formaddNacionalidade.MdiParent = this;
            formaddNacionalidade.StartPosition = FormStartPosition.Manual;
            formaddNacionalidade.Location = new Point((this.ClientSize.Width - formaddNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formaddNacionalidade.Height) / 3);
            formaddNacionalidade.Show();
            formaddNacionalidade.Activate();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formAtualizarNacionalidade.IsDisposed)
            {
                formAtualizarNacionalidade = new FormAtualizarNacionalidade();
            }
            formAtualizarNacionalidade.MdiParent = this;
            formAtualizarNacionalidade.StartPosition = FormStartPosition.Manual;
            formAtualizarNacionalidade.Location = new Point((this.ClientSize.Width - formAtualizarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formAtualizarNacionalidade.Height) / 3);
            formAtualizarNacionalidade.Show();
            formAtualizarNacionalidade.Activate();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formApagarNacionalidade.IsDisposed)
            {
                formApagarNacionalidade = new FormApagarNacionalidade();
            }
            formApagarNacionalidade.MdiParent = this;
            formApagarNacionalidade.StartPosition = FormStartPosition.Manual;
            formApagarNacionalidade.Location = new Point((this.ClientSize.Width - formApagarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formApagarNacionalidade.Height) / 3);
            formApagarNacionalidade.Show();
            formApagarNacionalidade.Activate();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarNacionalidade.IsDisposed)
            {
                formListarNacionalidade = new FormListarNacionalidade();
            }
            formListarNacionalidade.MdiParent = this;
            formListarNacionalidade.StartPosition = FormStartPosition.Manual;
            formListarNacionalidade.Location = new Point((this.ClientSize.Width - formListarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formListarNacionalidade.Height) / 3);
            formListarNacionalidade.Show();
            formListarNacionalidade.Activate();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            toolStripLabelUser.Text = "";
            toolStripButtonLogOut.Enabled = false;
            formAutenticacao.ShowDialog();
            toolStripLabelUser.Text = "ID User: " + Geral.id_user;
            toolStripButtonLogOut.Enabled = true;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja efetuar logout?\n Todas as janelas serão fechadas.", "LogOut",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                foreach(Form frm in this.MdiChildren)
                {
                    frm.Dispose();
                    frm.Close();
                }

                toolStripLabelUser.Text = "";
                toolStripButtonLogOut.Enabled = false;
                formAutenticacao.ShowDialog();
                toolStripLabelUser.Text = "Perfil: " + Geral.id_user;
                toolStripButtonLogOut.Enabled = true;
            }
        }
        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formInserirArea.IsDisposed)
            {
                formInserirArea = new FormInserirArea();
            }
            formInserirArea.MdiParent = this;
            formInserirArea.StartPosition = FormStartPosition.Manual;
            formInserirArea.Location = new Point((this.ClientSize.Width - formInserirArea.Width) / 2,
                    (this.ClientSize.Height - formInserirArea.Height) / 3);
            formInserirArea.Show();
            formInserirArea.Activate();
        }

        private void atualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formAtualizarArea.IsDisposed)
            {
                formAtualizarArea = new FormAtualizarArea();
            }
            formAtualizarArea.MdiParent = this;
            formAtualizarArea.StartPosition = FormStartPosition.Manual;
            formAtualizarArea.Location = new Point((this.ClientSize.Width - formAtualizarArea.Width) / 2,
                    (this.ClientSize.Height - formAtualizarArea.Height) / 3);
            formAtualizarArea.Show();
            formAtualizarArea.Activate();
        }

        private void apagarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formApagarArea.IsDisposed)
            {
                formApagarArea = new FormApagarArea();
            }
            formApagarArea.MdiParent = this;
            formApagarArea.StartPosition = FormStartPosition.Manual;
            formApagarArea.Location = new Point((this.ClientSize.Width - formApagarArea.Width) / 2,
                    (this.ClientSize.Height - formApagarArea.Height) / 3);
            formApagarArea.Show();
            formApagarArea.Activate();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formListarArea.IsDisposed)
            {
                formListarArea = new FormListarArea();
            }
            formListarArea.MdiParent = this;
            formListarArea.StartPosition = FormStartPosition.Manual;
            formListarArea.Location = new Point((this.ClientSize.Width - formListarArea.Width) / 2,
                    (this.ClientSize.Height - formListarArea.Height) / 3);
            formListarArea.Show();
            formListarArea.Activate();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formInserirFormador.IsDisposed)
            {
                formInserirFormador = new FormInserirFormador();
            }
            formInserirFormador.MdiParent = this;
            formInserirFormador.StartPosition = FormStartPosition.Manual;
            formInserirFormador.Location = new Point((this.ClientSize.Width - formInserirFormador.Width) / 2,
                    (this.ClientSize.Height - formInserirFormador.Height) / 3);
            formInserirFormador.Show();
            formInserirFormador.Activate();
        }

        private void atualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormador.IsDisposed)
            {
                formAtualizarFormador = new FormAtualizarFormador();
            }
            formAtualizarFormador.MdiParent = this;
            formAtualizarFormador.StartPosition = FormStartPosition.Manual;
            formAtualizarFormador.Location = new Point((this.ClientSize.Width - formAtualizarFormador.Width) / 2,
                    (this.ClientSize.Height - formAtualizarFormador.Height) / 3);
            formAtualizarFormador.Show();
            formAtualizarFormador.Activate();

        }

        private void apagarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formApagarFormador.IsDisposed)
            {
                formApagarFormador = new FormApagarFormador();
            }
            formApagarFormador.MdiParent = this;
            formApagarFormador.StartPosition = FormStartPosition.Manual;
            formApagarFormador.Location = new Point((this.ClientSize.Width - formApagarFormador.Width) / 2,
                    (this.ClientSize.Height - formApagarFormador.Height) / 3);
            formApagarFormador.Show();
            formApagarFormador.Activate();

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formListarFormador.IsDisposed)
            {
                formListarFormador = new FormListarFormador();
            }
            formListarFormador.MdiParent = this;
            formListarFormador.StartPosition = FormStartPosition.Manual;
            formListarFormador.Location = new Point((this.ClientSize.Width - formListarFormador.Width) / 2,
                    (this.ClientSize.Height - formListarFormador.Height) / 3);
            formListarFormador.Show();
            formListarFormador.Activate();
        }
    }
}
