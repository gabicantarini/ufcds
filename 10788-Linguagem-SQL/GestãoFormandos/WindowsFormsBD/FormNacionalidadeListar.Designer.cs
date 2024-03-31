namespace WindowsFormsBD
{
    partial class FormNacionalidadeListar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRegistos = new System.Windows.Forms.Label();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(609, 403);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblRegistos
            // 
            this.lblRegistos.AutoSize = true;
            this.lblRegistos.Location = new System.Drawing.Point(87, 493);
            this.lblRegistos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistos.Name = "lblRegistos";
            this.lblRegistos.Size = new System.Drawing.Size(101, 20);
            this.lblRegistos.TabIndex = 10;
            this.lblRegistos.Text = "Nº Registos: ";
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(428, 486);
            this.btnImprime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(112, 35);
            this.btnImprime.TabIndex = 12;
            this.btnImprime.Text = "Imprimir ";
            this.btnImprime.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(569, 486);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 35);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // FormListarNacionalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 565);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblRegistos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListarNacionalidade";
            this.Text = "Listar Nacionalidade";
            this.Load += new System.EventHandler(this.FormListarNacionalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRegistos;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.Button btnRefresh;
    }
}