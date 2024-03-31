namespace WindowsFormsBD
{
    partial class FormNacionalidadeInserir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iso2 = new System.Windows.Forms.TextBox();
            this.nacionalidade = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.tnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALF2(ISO2):";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nacionalidade:";
            // 
            // iso2
            // 
            this.iso2.Location = new System.Drawing.Point(182, 58);
            this.iso2.Name = "iso2";
            this.iso2.Size = new System.Drawing.Size(169, 26);
            this.iso2.TabIndex = 2;
            // 
            // nacionalidade
            // 
            this.nacionalidade.Location = new System.Drawing.Point(182, 122);
            this.nacionalidade.Name = "nacionalidade";
            this.nacionalidade.Size = new System.Drawing.Size(451, 26);
            this.nacionalidade.TabIndex = 3;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(105, 57);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(196, 69);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // tnGravar
            // 
            this.tnGravar.Location = new System.Drawing.Point(436, 57);
            this.tnGravar.Name = "tnGravar";
            this.tnGravar.Size = new System.Drawing.Size(198, 69);
            this.tnGravar.TabIndex = 5;
            this.tnGravar.Text = "Gravar";
            this.tnGravar.UseVisualStyleBackColor = true;
            this.tnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nacionalidade);
            this.groupBox1.Controls.Add(this.iso2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tnGravar);
            this.groupBox2.Controls.Add(this.cancelar);
            this.groupBox2.Location = new System.Drawing.Point(81, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // FormNacionalidadeInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNacionalidadeInserir";
            this.Text = "Inserir Nacionalidade";
            this.Load += new System.EventHandler(this.FormAdicionarNacionalidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iso2;
        private System.Windows.Forms.TextBox nacionalidade;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button tnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}