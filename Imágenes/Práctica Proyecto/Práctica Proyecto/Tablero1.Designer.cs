namespace Práctica_Proyecto
{
    partial class Tablero1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero1));
            this.dataTablero1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.btnComandos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEstadoA = new System.Windows.Forms.Button();
            this.btnTerminarP = new System.Windows.Forms.Button();
            this.lblContGalleta = new System.Windows.Forms.Label();
            this.pictureVida1 = new System.Windows.Forms.PictureBox();
            this.pictureVida2 = new System.Windows.Forms.PictureBox();
            this.pictureVida3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablero1
            // 
            this.dataTablero1.AllowUserToOrderColumns = true;
            this.dataTablero1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataTablero1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataTablero1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTablero1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTablero1.ColumnHeadersHeight = 100;
            this.dataTablero1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTablero1.ColumnHeadersVisible = false;
            this.dataTablero1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataTablero1.Location = new System.Drawing.Point(23, 21);
            this.dataTablero1.MultiSelect = false;
            this.dataTablero1.Name = "dataTablero1";
            this.dataTablero1.RowHeadersVisible = false;
            this.dataTablero1.RowHeadersWidth = 100;
            this.dataTablero1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTablero1.Size = new System.Drawing.Size(600, 600);
            this.dataTablero1.TabIndex = 1;
            this.dataTablero1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data2_CellFormatting);
            this.dataTablero1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTablero1_KeyUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.Width = 21;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.Name = "Column2";
            this.Column2.Width = 21;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.Name = "Column3";
            this.Column3.Width = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "/ 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Galletitas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(714, 254);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 8;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntos.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(726, 281);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(0, 23);
            this.labelPuntos.TabIndex = 10;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(629, 308);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(56, 23);
            this.lblVidas.TabIndex = 11;
            this.lblVidas.Text = "Vidas";
            // 
            // btnComandos
            // 
            this.btnComandos.BackColor = System.Drawing.Color.Transparent;
            this.btnComandos.Location = new System.Drawing.Point(648, 392);
            this.btnComandos.Name = "btnComandos";
            this.btnComandos.Size = new System.Drawing.Size(117, 23);
            this.btnComandos.TabIndex = 12;
            this.btnComandos.Text = "Comandos";
            this.btnComandos.UseVisualStyleBackColor = false;
            this.btnComandos.Click += new System.EventHandler(this.btnComandos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(662, 421);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(117, 23);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir Tablero";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEstadoA
            // 
            this.btnEstadoA.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadoA.Location = new System.Drawing.Point(496, 2);
            this.btnEstadoA.Name = "btnEstadoA";
            this.btnEstadoA.Size = new System.Drawing.Size(127, 23);
            this.btnEstadoA.TabIndex = 14;
            this.btnEstadoA.Text = "Estado de Avatar";
            this.btnEstadoA.UseVisualStyleBackColor = false;
            this.btnEstadoA.Click += new System.EventHandler(this.btnEstadoA_Click);
            // 
            // btnTerminarP
            // 
            this.btnTerminarP.Location = new System.Drawing.Point(651, 450);
            this.btnTerminarP.Name = "btnTerminarP";
            this.btnTerminarP.Size = new System.Drawing.Size(117, 23);
            this.btnTerminarP.TabIndex = 15;
            this.btnTerminarP.Text = "Terminar Partrida";
            this.btnTerminarP.UseVisualStyleBackColor = true;
            this.btnTerminarP.Click += new System.EventHandler(this.btnTerminarP_Click);
            // 
            // lblContGalleta
            // 
            this.lblContGalleta.AutoSize = true;
            this.lblContGalleta.BackColor = System.Drawing.Color.Transparent;
            this.lblContGalleta.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContGalleta.Location = new System.Drawing.Point(645, 226);
            this.lblContGalleta.Name = "lblContGalleta";
            this.lblContGalleta.Size = new System.Drawing.Size(0, 23);
            this.lblContGalleta.TabIndex = 16;
            // 
            // pictureVida1
            // 
            this.pictureVida1.Image = ((System.Drawing.Image)(resources.GetObject("pictureVida1.Image")));
            this.pictureVida1.Location = new System.Drawing.Point(691, 308);
            this.pictureVida1.Name = "pictureVida1";
            this.pictureVida1.Size = new System.Drawing.Size(31, 27);
            this.pictureVida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVida1.TabIndex = 17;
            this.pictureVida1.TabStop = false;
            // 
            // pictureVida2
            // 
            this.pictureVida2.Image = ((System.Drawing.Image)(resources.GetObject("pictureVida2.Image")));
            this.pictureVida2.Location = new System.Drawing.Point(728, 308);
            this.pictureVida2.Name = "pictureVida2";
            this.pictureVida2.Size = new System.Drawing.Size(31, 27);
            this.pictureVida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVida2.TabIndex = 18;
            this.pictureVida2.TabStop = false;
            // 
            // pictureVida3
            // 
            this.pictureVida3.Image = ((System.Drawing.Image)(resources.GetObject("pictureVida3.Image")));
            this.pictureVida3.Location = new System.Drawing.Point(765, 308);
            this.pictureVida3.Name = "pictureVida3";
            this.pictureVida3.Size = new System.Drawing.Size(31, 27);
            this.pictureVida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVida3.TabIndex = 19;
            this.pictureVida3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Puntos:";
            // 
            // Tablero1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(803, 634);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureVida3);
            this.Controls.Add(this.pictureVida2);
            this.Controls.Add(this.pictureVida1);
            this.Controls.Add(this.lblContGalleta);
            this.Controls.Add(this.btnTerminarP);
            this.Controls.Add(this.btnEstadoA);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnComandos);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTablero1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tablero1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVida3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataTablero1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Button btnComandos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEstadoA;
        private System.Windows.Forms.Button btnTerminarP;
        private System.Windows.Forms.Label lblContGalleta;
        private System.Windows.Forms.PictureBox pictureVida1;
        private System.Windows.Forms.PictureBox pictureVida2;
        private System.Windows.Forms.PictureBox pictureVida3;
        private System.Windows.Forms.Label label4;
    }
}

