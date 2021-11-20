
namespace ProyectPingPC
{
    partial class frmListaPing
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.panelCuerpo = new System.Windows.Forms.Panel();
            this.panelPiePagina = new System.Windows.Forms.Panel();
            this.btnCopiarLista = new System.Windows.Forms.Button();
            this.btnCorrerPrueba = new System.Windows.Forms.Button();
            this.splitContainerCuerpo = new System.Windows.Forms.SplitContainer();
            this.tbxListaDatos = new System.Windows.Forms.TextBox();
            this.dgvListaDatos = new System.Windows.Forms.DataGridView();
            this.tbxListaResultados = new System.Windows.Forms.TextBox();
            this.dgvListaResultados = new System.Windows.Forms.DataGridView();
            this.panelCabecera.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCuerpo)).BeginInit();
            this.splitContainerCuerpo.Panel1.SuspendLayout();
            this.splitContainerCuerpo.Panel2.SuspendLayout();
            this.splitContainerCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.btnCorrerPrueba);
            this.panelCabecera.Controls.Add(this.btnCopiarLista);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1202, 107);
            this.panelCabecera.TabIndex = 0;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.Controls.Add(this.splitContainerCuerpo);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 107);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(1202, 595);
            this.panelCuerpo.TabIndex = 0;
            // 
            // panelPiePagina
            // 
            this.panelPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPiePagina.Location = new System.Drawing.Point(0, 640);
            this.panelPiePagina.Name = "panelPiePagina";
            this.panelPiePagina.Size = new System.Drawing.Size(1202, 62);
            this.panelPiePagina.TabIndex = 0;
            // 
            // btnCopiarLista
            // 
            this.btnCopiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarLista.Location = new System.Drawing.Point(59, 30);
            this.btnCopiarLista.Name = "btnCopiarLista";
            this.btnCopiarLista.Size = new System.Drawing.Size(159, 31);
            this.btnCopiarLista.TabIndex = 6;
            this.btnCopiarLista.Text = "Pegar Lista Excel";
            this.btnCopiarLista.UseVisualStyleBackColor = true;
            this.btnCopiarLista.Click += new System.EventHandler(this.btnCopiarLista_Click);
            // 
            // btnCorrerPrueba
            // 
            this.btnCorrerPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCorrerPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCorrerPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrerPrueba.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrerPrueba.ForeColor = System.Drawing.Color.White;
            this.btnCorrerPrueba.Location = new System.Drawing.Point(556, 30);
            this.btnCorrerPrueba.Name = "btnCorrerPrueba";
            this.btnCorrerPrueba.Size = new System.Drawing.Size(176, 38);
            this.btnCorrerPrueba.TabIndex = 7;
            this.btnCorrerPrueba.Text = "Correr Prueba";
            this.btnCorrerPrueba.UseVisualStyleBackColor = false;
            this.btnCorrerPrueba.Click += new System.EventHandler(this.btnCorrerPrueba_Click);
            // 
            // splitContainerCuerpo
            // 
            this.splitContainerCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCuerpo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCuerpo.Name = "splitContainerCuerpo";
            // 
            // splitContainerCuerpo.Panel1
            // 
            this.splitContainerCuerpo.Panel1.Controls.Add(this.tbxListaDatos);
            this.splitContainerCuerpo.Panel1.Controls.Add(this.dgvListaDatos);
            // 
            // splitContainerCuerpo.Panel2
            // 
            this.splitContainerCuerpo.Panel2.Controls.Add(this.tbxListaResultados);
            this.splitContainerCuerpo.Panel2.Controls.Add(this.dgvListaResultados);
            this.splitContainerCuerpo.Size = new System.Drawing.Size(1202, 595);
            this.splitContainerCuerpo.SplitterDistance = 592;
            this.splitContainerCuerpo.TabIndex = 1;
            // 
            // tbxListaDatos
            // 
            this.tbxListaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxListaDatos.Location = new System.Drawing.Point(19, 440);
            this.tbxListaDatos.Multiline = true;
            this.tbxListaDatos.Name = "tbxListaDatos";
            this.tbxListaDatos.Size = new System.Drawing.Size(556, 75);
            this.tbxListaDatos.TabIndex = 8;
            // 
            // dgvListaDatos
            // 
            this.dgvListaDatos.AllowUserToAddRows = false;
            this.dgvListaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDatos.Location = new System.Drawing.Point(19, 27);
            this.dgvListaDatos.Name = "dgvListaDatos";
            this.dgvListaDatos.Size = new System.Drawing.Size(556, 394);
            this.dgvListaDatos.TabIndex = 0;
            // 
            // tbxListaResultados
            // 
            this.tbxListaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxListaResultados.Location = new System.Drawing.Point(16, 440);
            this.tbxListaResultados.Multiline = true;
            this.tbxListaResultados.Name = "tbxListaResultados";
            this.tbxListaResultados.Size = new System.Drawing.Size(565, 75);
            this.tbxListaResultados.TabIndex = 8;
            // 
            // dgvListaResultados
            // 
            this.dgvListaResultados.AllowUserToOrderColumns = true;
            this.dgvListaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaResultados.Location = new System.Drawing.Point(16, 27);
            this.dgvListaResultados.Name = "dgvListaResultados";
            this.dgvListaResultados.Size = new System.Drawing.Size(565, 394);
            this.dgvListaResultados.TabIndex = 0;
            // 
            // frmListaPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 702);
            this.Controls.Add(this.panelPiePagina);
            this.Controls.Add(this.panelCuerpo);
            this.Controls.Add(this.panelCabecera);
            this.Name = "frmListaPing";
            this.Text = "Ping de redes";
            this.panelCabecera.ResumeLayout(false);
            this.panelCuerpo.ResumeLayout(false);
            this.splitContainerCuerpo.Panel1.ResumeLayout(false);
            this.splitContainerCuerpo.Panel1.PerformLayout();
            this.splitContainerCuerpo.Panel2.ResumeLayout(false);
            this.splitContainerCuerpo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCuerpo)).EndInit();
            this.splitContainerCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelCuerpo;
        private System.Windows.Forms.Panel panelPiePagina;
        private System.Windows.Forms.Button btnCorrerPrueba;
        private System.Windows.Forms.Button btnCopiarLista;
        private System.Windows.Forms.SplitContainer splitContainerCuerpo;
        private System.Windows.Forms.TextBox tbxListaDatos;
        private System.Windows.Forms.DataGridView dgvListaDatos;
        private System.Windows.Forms.TextBox tbxListaResultados;
        private System.Windows.Forms.DataGridView dgvListaResultados;
    }
}

