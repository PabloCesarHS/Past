
namespace WFPruebasBus
{
    partial class frmPrincipal
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
            this.dgvListaDatos = new System.Windows.Forms.DataGridView();
            this.dgvListaResultados = new System.Windows.Forms.DataGridView();
            this.chbModificarAClase = new System.Windows.Forms.CheckBox();
            this.cbListaClases = new System.Windows.Forms.ComboBox();
            this.btnCopiarLista = new System.Windows.Forms.Button();
            this.btnCorrerPrueba = new System.Windows.Forms.Button();
            this.panelControles = new System.Windows.Forms.Panel();
            this.panelCuerpo = new System.Windows.Forms.Panel();
            this.panelPiePagina = new System.Windows.Forms.Panel();
            this.btnForzarConver = new System.Windows.Forms.Button();
            this.chbCambiarApi = new System.Windows.Forms.CheckBox();
            this.tbxCambioApi = new System.Windows.Forms.TextBox();
            this.tbxListaDatos = new System.Windows.Forms.TextBox();
            this.tbxListaResultados = new System.Windows.Forms.TextBox();
            this.splitContainerCuerpo = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultados)).BeginInit();
            this.panelControles.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCuerpo)).BeginInit();
            this.splitContainerCuerpo.Panel1.SuspendLayout();
            this.splitContainerCuerpo.Panel2.SuspendLayout();
            this.splitContainerCuerpo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvListaDatos.Size = new System.Drawing.Size(691, 446);
            this.dgvListaDatos.TabIndex = 0;
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
            this.dgvListaResultados.Size = new System.Drawing.Size(702, 446);
            this.dgvListaResultados.TabIndex = 0;
            // 
            // chbModificarAClase
            // 
            this.chbModificarAClase.AutoSize = true;
            this.chbModificarAClase.Location = new System.Drawing.Point(36, 23);
            this.chbModificarAClase.Name = "chbModificarAClase";
            this.chbModificarAClase.Size = new System.Drawing.Size(119, 18);
            this.chbModificarAClase.TabIndex = 3;
            this.chbModificarAClase.Text = "Modificar a Clase";
            this.chbModificarAClase.UseVisualStyleBackColor = true;
            // 
            // cbListaClases
            // 
            this.cbListaClases.FormattingEnabled = true;
            this.cbListaClases.Location = new System.Drawing.Point(362, 21);
            this.cbListaClases.Name = "cbListaClases";
            this.cbListaClases.Size = new System.Drawing.Size(347, 22);
            this.cbListaClases.TabIndex = 4;
            // 
            // btnCopiarLista
            // 
            this.btnCopiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarLista.Location = new System.Drawing.Point(161, 17);
            this.btnCopiarLista.Name = "btnCopiarLista";
            this.btnCopiarLista.Size = new System.Drawing.Size(159, 31);
            this.btnCopiarLista.TabIndex = 5;
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
            this.btnCorrerPrueba.Location = new System.Drawing.Point(1199, 100);
            this.btnCorrerPrueba.Name = "btnCorrerPrueba";
            this.btnCorrerPrueba.Size = new System.Drawing.Size(176, 38);
            this.btnCorrerPrueba.TabIndex = 6;
            this.btnCorrerPrueba.Text = "Correr Prueba";
            this.btnCorrerPrueba.UseVisualStyleBackColor = false;
            this.btnCorrerPrueba.Click += new System.EventHandler(this.btnCorrerPrueba_Click);
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.groupBox1);
            this.panelControles.Controls.Add(this.btnCorrerPrueba);
            this.panelControles.Controls.Add(this.btnForzarConver);
            this.panelControles.Controls.Add(this.btnCopiarLista);
            this.panelControles.Controls.Add(this.cbListaClases);
            this.panelControles.Controls.Add(this.chbModificarAClase);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControles.Location = new System.Drawing.Point(0, 0);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(1474, 181);
            this.panelControles.TabIndex = 7;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.Controls.Add(this.splitContainerCuerpo);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 181);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(1474, 647);
            this.panelCuerpo.TabIndex = 8;
            // 
            // panelPiePagina
            // 
            this.panelPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPiePagina.Location = new System.Drawing.Point(0, 765);
            this.panelPiePagina.Name = "panelPiePagina";
            this.panelPiePagina.Size = new System.Drawing.Size(1474, 63);
            this.panelPiePagina.TabIndex = 9;
            // 
            // btnForzarConver
            // 
            this.btnForzarConver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForzarConver.Location = new System.Drawing.Point(725, 17);
            this.btnForzarConver.Name = "btnForzarConver";
            this.btnForzarConver.Size = new System.Drawing.Size(159, 31);
            this.btnForzarConver.TabIndex = 5;
            this.btnForzarConver.Text = "Forzar Convercion";
            this.btnForzarConver.UseVisualStyleBackColor = true;
            this.btnForzarConver.Click += new System.EventHandler(this.btnCopiarLista_Click);
            // 
            // chbCambiarApi
            // 
            this.chbCambiarApi.AutoSize = true;
            this.chbCambiarApi.Location = new System.Drawing.Point(85, 23);
            this.chbCambiarApi.Name = "chbCambiarApi";
            this.chbCambiarApi.Size = new System.Drawing.Size(143, 18);
            this.chbCambiarApi.TabIndex = 7;
            this.chbCambiarApi.Text = "Cambiar Api Consulta";
            this.chbCambiarApi.UseVisualStyleBackColor = true;
            // 
            // tbxCambioApi
            // 
            this.tbxCambioApi.Location = new System.Drawing.Point(234, 21);
            this.tbxCambioApi.Name = "tbxCambioApi";
            this.tbxCambioApi.Size = new System.Drawing.Size(459, 22);
            this.tbxCambioApi.TabIndex = 8;
            // 
            // tbxListaDatos
            // 
            this.tbxListaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxListaDatos.Location = new System.Drawing.Point(19, 492);
            this.tbxListaDatos.Multiline = true;
            this.tbxListaDatos.Name = "tbxListaDatos";
            this.tbxListaDatos.Size = new System.Drawing.Size(691, 75);
            this.tbxListaDatos.TabIndex = 8;
            // 
            // tbxListaResultados
            // 
            this.tbxListaResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxListaResultados.Location = new System.Drawing.Point(16, 492);
            this.tbxListaResultados.Multiline = true;
            this.tbxListaResultados.Name = "tbxListaResultados";
            this.tbxListaResultados.Size = new System.Drawing.Size(702, 75);
            this.tbxListaResultados.TabIndex = 8;
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
            this.splitContainerCuerpo.Size = new System.Drawing.Size(1474, 647);
            this.splitContainerCuerpo.SplitterDistance = 727;
            this.splitContainerCuerpo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCambioApi);
            this.groupBox1.Controls.Add(this.chbCambiarApi);
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 828);
            this.Controls.Add(this.panelPiePagina);
            this.Controls.Add(this.panelCuerpo);
            this.Controls.Add(this.panelControles);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrincipal";
            this.Text = "Pruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultados)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.panelCuerpo.ResumeLayout(false);
            this.splitContainerCuerpo.Panel1.ResumeLayout(false);
            this.splitContainerCuerpo.Panel1.PerformLayout();
            this.splitContainerCuerpo.Panel2.ResumeLayout(false);
            this.splitContainerCuerpo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCuerpo)).EndInit();
            this.splitContainerCuerpo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDatos;
        private System.Windows.Forms.DataGridView dgvListaResultados;
        private System.Windows.Forms.CheckBox chbModificarAClase;
        private System.Windows.Forms.ComboBox cbListaClases;
        private System.Windows.Forms.Button btnCopiarLista;
        private System.Windows.Forms.Button btnCorrerPrueba;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Panel panelCuerpo;
        private System.Windows.Forms.Panel panelPiePagina;
        private System.Windows.Forms.TextBox tbxCambioApi;
        private System.Windows.Forms.CheckBox chbCambiarApi;
        private System.Windows.Forms.Button btnForzarConver;
        private System.Windows.Forms.TextBox tbxListaResultados;
        private System.Windows.Forms.TextBox tbxListaDatos;
        private System.Windows.Forms.SplitContainer splitContainerCuerpo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

