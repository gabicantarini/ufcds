namespace WindowsFormsBD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formandoInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.formandoAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.formandoApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.formFormandoListar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadeInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarNacionalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarNacionalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listarNacionalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.formadorApagar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.formadorListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem13,
            this.formadorToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formandoInserir,
            this.formandoAtualizar,
            this.formandoApagar,
            this.toolStripMenuItem1,
            this.formFormandoListar});
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.areaToolStripMenuItem.Text = "Formandos";
            // 
            // formandoInserir
            // 
            this.formandoInserir.Name = "formandoInserir";
            this.formandoInserir.Size = new System.Drawing.Size(182, 34);
            this.formandoInserir.Text = "Inserir";
            this.formandoInserir.Click += new System.EventHandler(this.inserirFormandoMenuItem_Click);
            // 
            // formandoAtualizar
            // 
            this.formandoAtualizar.Name = "formandoAtualizar";
            this.formandoAtualizar.Size = new System.Drawing.Size(182, 34);
            this.formandoAtualizar.Text = "Atualizar";
            this.formandoAtualizar.Click += new System.EventHandler(this.atualizarFormandoMenuItem_Click);
            // 
            // formandoApagar
            // 
            this.formandoApagar.Name = "formandoApagar";
            this.formandoApagar.Size = new System.Drawing.Size(182, 34);
            this.formandoApagar.Text = "Apagar";
            this.formandoApagar.Click += new System.EventHandler(this.apagarFormandoMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // formFormandoListar
            // 
            this.formFormandoListar.Name = "formFormandoListar";
            this.formFormandoListar.Size = new System.Drawing.Size(182, 34);
            this.formFormandoListar.Text = "Listar";
            this.formFormandoListar.Click += new System.EventHandler(this.listarFormandoMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripSeparator1,
            this.toolStripMenuItem7});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(64, 29);
            this.toolStripMenuItem3.Text = "Area";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(182, 34);
            this.toolStripMenuItem4.Text = "&Inserir";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(182, 34);
            this.toolStripMenuItem5.Text = "&Atualizar";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(182, 34);
            this.toolStripMenuItem6.Text = "Apagar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(182, 34);
            this.toolStripMenuItem7.Text = "&Listar";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nacionalidadeInserir,
            this.atualizarNacionalidade,
            this.apagarNacionalidade,
            this.toolStripSeparator3,
            this.listarNacionalidade});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(140, 29);
            this.toolStripMenuItem13.Text = "Nacionalidade";
            // 
            // nacionalidadeInserir
            // 
            this.nacionalidadeInserir.Name = "nacionalidadeInserir";
            this.nacionalidadeInserir.Size = new System.Drawing.Size(270, 34);
            this.nacionalidadeInserir.Text = "Inserir";
            this.nacionalidadeInserir.Click += new System.EventHandler(this.inserirNacionalidadeMenuItem_Click);
            // 
            // atualizarNacionalidade
            // 
            this.atualizarNacionalidade.Name = "atualizarNacionalidade";
            this.atualizarNacionalidade.Size = new System.Drawing.Size(270, 34);
            this.atualizarNacionalidade.Text = "Atualizar";
            this.atualizarNacionalidade.Click += new System.EventHandler(this.atualizarNacionalidade_Click);
            // 
            // apagarNacionalidade
            // 
            this.apagarNacionalidade.Name = "apagarNacionalidade";
            this.apagarNacionalidade.Size = new System.Drawing.Size(270, 34);
            this.apagarNacionalidade.Text = "A&pagar";
            this.apagarNacionalidade.Click += new System.EventHandler(this.apagarNacionalidadeMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // listarNacionalidade
            // 
            this.listarNacionalidade.Name = "listarNacionalidade";
            this.listarNacionalidade.Size = new System.Drawing.Size(270, 34);
            this.listarNacionalidade.Text = "&Listar";
            this.listarNacionalidade.Click += new System.EventHandler(this.listarNacionalidadeMenuItem_Click);
            // 
            // formadorToolStripMenu
            // 
            this.formadorToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formadorInserir,
            this.formadorAtualizar,
            this.formadorApagar,
            this.toolStripSeparator2,
            this.formadorListar});
            this.formadorToolStripMenu.Name = "formadorToolStripMenu";
            this.formadorToolStripMenu.Size = new System.Drawing.Size(107, 29);
            this.formadorToolStripMenu.Text = "Formador";
            // 
            // formadorInserir
            // 
            this.formadorInserir.Name = "formadorInserir";
            this.formadorInserir.Size = new System.Drawing.Size(182, 34);
            this.formadorInserir.Text = "&Inserir";
            // 
            // formadorAtualizar
            // 
            this.formadorAtualizar.Name = "formadorAtualizar";
            this.formadorAtualizar.Size = new System.Drawing.Size(182, 34);
            this.formadorAtualizar.Text = "&Atualizar";
            // 
            // formadorApagar
            // 
            this.formadorApagar.Name = "formadorApagar";
            this.formadorApagar.Size = new System.Drawing.Size(182, 34);
            this.formadorApagar.Text = "A&pagar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // formadorListar
            // 
            this.formadorListar.Name = "formadorListar";
            this.formadorListar.Size = new System.Drawing.Size(182, 34);
            this.formadorListar.Text = "&Listar";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 639);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Text = "Gestão de Formandos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formandoInserir;
        private System.Windows.Forms.ToolStripMenuItem formandoAtualizar;
        private System.Windows.Forms.ToolStripMenuItem formandoApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formFormandoListar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem formadorToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem formadorInserir;
        private System.Windows.Forms.ToolStripMenuItem formadorAtualizar;
        private System.Windows.Forms.ToolStripMenuItem formadorApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem formadorListar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadeInserir;
        private System.Windows.Forms.ToolStripMenuItem atualizarNacionalidade;
        private System.Windows.Forms.ToolStripMenuItem apagarNacionalidade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listarNacionalidade;
    }
}