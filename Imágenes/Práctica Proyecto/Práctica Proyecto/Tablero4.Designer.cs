namespace Práctica_Proyecto
{
    partial class Tablero4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero4));
            this.dataTablero4 = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Columna6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblContador = new System.Windows.Forms.Label();
            this.labelpuntos = new System.Windows.Forms.Label();
            this.buttonEstaA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonComand = new System.Windows.Forms.Button();
            this.buttonImprimiri = new System.Windows.Forms.Button();
            this.labelName4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTablero4
            // 
            this.dataTablero4.AllowUserToOrderColumns = true;
            this.dataTablero4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataTablero4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataTablero4.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataTablero4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTablero4.ColumnHeadersHeight = 100;
            this.dataTablero4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTablero4.ColumnHeadersVisible = false;
            this.dataTablero4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5,
            this.Columna6});
            this.dataTablero4.Location = new System.Drawing.Point(25, 34);
            this.dataTablero4.MultiSelect = false;
            this.dataTablero4.Name = "dataTablero4";
            this.dataTablero4.RowHeadersVisible = false;
            this.dataTablero4.RowHeadersWidth = 100;
            this.dataTablero4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTablero4.Size = new System.Drawing.Size(600, 600);
            this.dataTablero4.TabIndex = 0;
            this.dataTablero4.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataTablero4_CellFormatting);
            this.dataTablero4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataTablero4_KeyUp);
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "";
            this.Columna1.Name = "Columna1";
            this.Columna1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Columna1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Columna1.Width = 21;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "";
            this.Columna2.Name = "Columna2";
            this.Columna2.Width = 21;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "";
            this.Columna3.Name = "Columna3";
            this.Columna3.Width = 21;
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "";
            this.Columna4.Name = "Columna4";
            this.Columna4.Width = 21;
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "";
            this.Columna5.Name = "Columna5";
            this.Columna5.Width = 21;
            // 
            // Columna6
            // 
            this.Columna6.HeaderText = "";
            this.Columna6.Name = "Columna6";
            this.Columna6.Width = 21;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(691, 293);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 23);
            this.lblContador.TabIndex = 1;
            // 
            // labelpuntos
            // 
            this.labelpuntos.AutoSize = true;
            this.labelpuntos.BackColor = System.Drawing.Color.Transparent;
            this.labelpuntos.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpuntos.Location = new System.Drawing.Point(780, 360);
            this.labelpuntos.Name = "labelpuntos";
            this.labelpuntos.Size = new System.Drawing.Size(0, 23);
            this.labelpuntos.TabIndex = 2;
            // 
            // buttonEstaA
            // 
            this.buttonEstaA.Location = new System.Drawing.Point(502, 12);
            this.buttonEstaA.Name = "buttonEstaA";
            this.buttonEstaA.Size = new System.Drawing.Size(123, 23);
            this.buttonEstaA.TabIndex = 3;
            this.buttonEstaA.Text = "Estado del Avatar";
            this.buttonEstaA.UseVisualStyleBackColor = true;
            this.buttonEstaA.Click += new System.EventHandler(this.buttonEstaA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(710, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "/ 6 Galletitas";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(680, 498);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(138, 23);
            this.btnTerminar.TabIndex = 5;
            this.btnTerminar.Text = "Terminar Partida";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Puntos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre: ";
            // 
            // buttonComand
            // 
            this.buttonComand.Location = new System.Drawing.Point(680, 440);
            this.buttonComand.Name = "buttonComand";
            this.buttonComand.Size = new System.Drawing.Size(138, 23);
            this.buttonComand.TabIndex = 23;
            this.buttonComand.Text = "Comandos";
            this.buttonComand.UseVisualStyleBackColor = true;
            this.buttonComand.Click += new System.EventHandler(this.buttonComand_Click);
            // 
            // buttonImprimiri
            // 
            this.buttonImprimiri.Location = new System.Drawing.Point(680, 469);
            this.buttonImprimiri.Name = "buttonImprimiri";
            this.buttonImprimiri.Size = new System.Drawing.Size(138, 23);
            this.buttonImprimiri.TabIndex = 24;
            this.buttonImprimiri.Text = "Imprimir Tablero";
            this.buttonImprimiri.UseVisualStyleBackColor = true;
            // 
            // labelName4
            // 
            this.labelName4.AutoSize = true;
            this.labelName4.BackColor = System.Drawing.Color.Transparent;
            this.labelName4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName4.ForeColor = System.Drawing.Color.Black;
            this.labelName4.Location = new System.Drawing.Point(725, 329);
            this.labelName4.Name = "labelName4";
            this.labelName4.Size = new System.Drawing.Size(0, 23);
            this.labelName4.TabIndex = 25;
            // 
            // Tablero4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(863, 649);
            this.ControlBox = false;
            this.Controls.Add(this.labelName4);
            this.Controls.Add(this.buttonImprimiri);
            this.Controls.Add(this.buttonComand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEstaA);
            this.Controls.Add(this.labelpuntos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dataTablero4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tablero4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tablero4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTablero4;
        private System.Windows.Forms.DataGridViewImageColumn Columna1;
        private System.Windows.Forms.DataGridViewImageColumn Columna2;
        private System.Windows.Forms.DataGridViewImageColumn Columna3;
        private System.Windows.Forms.DataGridViewImageColumn Columna4;
        private System.Windows.Forms.DataGridViewImageColumn Columna5;
        private System.Windows.Forms.DataGridViewImageColumn Columna6;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label labelpuntos;
        private System.Windows.Forms.Button buttonEstaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonComand;
        private System.Windows.Forms.Button buttonImprimiri;
        private System.Windows.Forms.Label labelName4;
    }
}