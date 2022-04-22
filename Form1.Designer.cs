namespace OFICIOS_EXTRACCION
{
    partial class Form1
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
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoReconocimiento = new System.Windows.Forms.Label();
            this.rtxtInfoExtraida = new System.Windows.Forms.RichTextBox();
            this.chkModoOCRpdf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Location = new System.Drawing.Point(418, 12);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(110, 23);
            this.btnAbrirArchivo.TabIndex = 0;
            this.btnAbrirArchivo.Text = "Cargar archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato,
            this.Info});
            this.dgvDatos.Location = new System.Drawing.Point(11, 250);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(528, 311);
            this.dgvDatos.TabIndex = 1;
            // 
            // Dato
            // 
            this.Dato.HeaderText = "Dato";
            this.Dato.Name = "Dato";
            this.Dato.Width = 150;
            // 
            // Info
            // 
            this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Info.HeaderText = "Informacion";
            this.Info.Name = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicacion de extraccion de informacion";
            // 
            // lblTipoReconocimiento
            // 
            this.lblTipoReconocimiento.AutoSize = true;
            this.lblTipoReconocimiento.Location = new System.Drawing.Point(570, 20);
            this.lblTipoReconocimiento.Name = "lblTipoReconocimiento";
            this.lblTipoReconocimiento.Size = new System.Drawing.Size(0, 13);
            this.lblTipoReconocimiento.TabIndex = 4;
            // 
            // rtxtInfoExtraida
            // 
            this.rtxtInfoExtraida.Location = new System.Drawing.Point(11, 41);
            this.rtxtInfoExtraida.Name = "rtxtInfoExtraida";
            this.rtxtInfoExtraida.Size = new System.Drawing.Size(528, 203);
            this.rtxtInfoExtraida.TabIndex = 5;
            this.rtxtInfoExtraida.Text = "";
            // 
            // chkModoOCRpdf
            // 
            this.chkModoOCRpdf.AutoSize = true;
            this.chkModoOCRpdf.Location = new System.Drawing.Point(546, 124);
            this.chkModoOCRpdf.Name = "chkModoOCRpdf";
            this.chkModoOCRpdf.Size = new System.Drawing.Size(73, 17);
            this.chkModoOCRpdf.TabIndex = 6;
            this.chkModoOCRpdf.Text = "PDF OCR";
            this.chkModoOCRpdf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 573);
            this.Controls.Add(this.chkModoOCRpdf);
            this.Controls.Add(this.rtxtInfoExtraida);
            this.Controls.Add(this.lblTipoReconocimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Label lblTipoReconocimiento;
        private System.Windows.Forms.RichTextBox rtxtInfoExtraida;
        public System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.CheckBox chkModoOCRpdf;
    }
}

