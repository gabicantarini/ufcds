using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBD
{
    public partial class FormPrincipal : Form
    {
        FormFormandosInserir formInserirFormandos = new FormFormandosInserir();
        FormFormandosApagar formApagarFormandos = new FormFormandosApagar();
        FormFormandosAtualizar formAtualizarFormandos = new FormFormandosAtualizar();
        FormFormandosListar formFormandosListar = new FormFormandosListar();
        FormNacionalidadeInserir formInserirNacionalidade = new FormNacionalidadeInserir();
        FormNacionalidadeApagar formApagarNacionalidade = new FormNacionalidadeApagar();
        FormNacionalidadeAtualizar formAtualizarNacionalidade = new FormNacionalidadeAtualizar();
        FormNacionalidadeListar formListarNacionalidade = new FormNacionalidadeListar();
        //FormAutenticacao formAutenticacao = new FormAutenticacao();
        //FormAreaInserir formInserirArea = new FormAreaInserir();
        //FormAreaAtualizar formAtualizarArea = new FormAreaAtualizar();
        //FormAreaApagar formApagarArea = new FormAreaApagar();
        //FormAreaListar formListarArea = new FormAreaListar();
        //FormFormadorInserir formInserirFormador = new FormFormadorInserir();
        //FormFormadorAtualizar formAtualizarFormador = new FormFormadorAtualizar();
        //FormFormadorApagar formApagarFormador = new FormFormadorApagar();
        //FormFormadorListar formListarFormador = new FormFormadorListar();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void inserirFormandoMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirFormandos.IsDisposed)
            {
                formInserirFormandos = new FormFormandosInserir();
            }
            formInserirFormandos.MdiParent = this;
            formInserirFormandos.StartPosition = FormStartPosition.Manual;
            formInserirFormandos.Location = new Point((this.ClientSize.Width-formInserirFormandos.Width) / 2, 
                (this.ClientSize.Height-formInserirFormandos.Height) / 3);
            formInserirFormandos.Show();
            formInserirFormandos.Activate();

        }

        private void apagarFormandoMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarFormandos.IsDisposed)
            {
                formApagarFormandos = new FormFormandosApagar();
            }
            formApagarFormandos.MdiParent = this;
            formApagarFormandos.StartPosition = FormStartPosition.Manual;
            formApagarFormandos.Location = new Point((this.ClientSize.Width - formApagarFormandos.Width) / 2,
                (this.ClientSize.Height - formApagarFormandos.Height) / 3);
            formApagarFormandos.Show();
            formApagarFormandos.Activate();

        }

        private void atualizarFormandoMenuItem_Click(object sender, EventArgs e)
        {
            if (formAtualizarFormandos.IsDisposed)
            {
                formAtualizarFormandos = new FormFormandosAtualizar();
            }
            formAtualizarFormandos.MdiParent = this;
            formAtualizarFormandos.StartPosition = FormStartPosition.Manual;
            formAtualizarFormandos.Location = new Point((this.ClientSize.Width - formAtualizarFormandos.Width) / 2,
                (this.ClientSize.Height - formAtualizarFormandos.Height) / 3);
            formAtualizarFormandos.Show();
            formAtualizarFormandos.Activate();

        }

        private void listarFormandoMenuItem_Click(object sender, EventArgs e)
        {
            if (formFormandosListar.IsDisposed)
            {
                formFormandosListar = new FormFormandosListar();
            }
            formFormandosListar.MdiParent = this;
            formFormandosListar.StartPosition = FormStartPosition.Manual;
            formFormandosListar.Location = new Point((this.ClientSize.Width - formFormandoListar.Width) / 2,
                    (this.ClientSize.Height - formFormandoListar.Height) / 3);
            formFormandosListar.Show();
            formFormandosListar.Activate();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void inserirNacionalidadeMenuItem_Click(object sender, EventArgs e)
        {
            if (formInserirNacionalidade.IsDisposed)
            {
                formInserirNacionalidade = new FormNacionalidadeInserir();
            }
            formInserirNacionalidade.MdiParent = this;
            formInserirNacionalidade.StartPosition = FormStartPosition.Manual;
            formInserirNacionalidade.Location = new Point((this.ClientSize.Width - formInserirNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formInserirNacionalidade.Height) / 3);
            formInserirNacionalidade.Show();
            formInserirNacionalidade.Activate();
        }

        private void atualizarNacionalidade_Click(object sender, EventArgs e)
        {
            if (formAtualizarNacionalidade.IsDisposed)
            {
                formAtualizarNacionalidade = new FormNacionalidadeAtualizar();
            }
            formAtualizarNacionalidade.MdiParent = this;
            formAtualizarNacionalidade.StartPosition = FormStartPosition.Manual;
            formAtualizarNacionalidade.Location = new Point((this.ClientSize.Width - formAtualizarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formAtualizarNacionalidade.Height) / 3);
            formAtualizarNacionalidade.Show();
            formAtualizarNacionalidade.Activate();
        }

        private void apagarNacionalidadeMenuItem_Click(object sender, EventArgs e)
        {
            if (formApagarNacionalidade.IsDisposed)
            {
                formApagarNacionalidade = new FormNacionalidadeApagar();
            }
            formApagarNacionalidade.MdiParent = this;
            formApagarNacionalidade.StartPosition = FormStartPosition.Manual;
            formApagarNacionalidade.Location = new Point((this.ClientSize.Width - formApagarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formApagarNacionalidade.Height) / 3);
            formApagarNacionalidade.Show();
            formApagarNacionalidade.Activate();
        }

        private void listarNacionalidadeMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarNacionalidade.IsDisposed)
            {
                formListarNacionalidade = new FormNacionalidadeListar();
            }
            formListarNacionalidade.MdiParent = this;
            formListarNacionalidade.StartPosition = FormStartPosition.Manual;
            formListarNacionalidade.Location = new Point((this.ClientSize.Width - formListarNacionalidade.Width) / 2,
                    (this.ClientSize.Height - formListarNacionalidade.Height) / 3);
            formListarNacionalidade.Show();
            formListarNacionalidade.Activate();
        }
    }
}
