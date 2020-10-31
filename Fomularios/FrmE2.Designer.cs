namespace Tarea_5.Fomularios
{
    partial class FrmE2
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
            this.txttaamaño = new System.Windows.Forms.TextBox();
            this.dtgvlitros = new System.Windows.Forms.DataGridView();
            this.tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlitros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño del tanque en Metros";
            // 
            // txttaamaño
            // 
            this.txttaamaño.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttaamaño.Location = new System.Drawing.Point(188, 52);
            this.txttaamaño.Name = "txttaamaño";
            this.txttaamaño.Size = new System.Drawing.Size(100, 20);
            this.txttaamaño.TabIndex = 2;
            // 
            // dtgvlitros
            // 
            this.dtgvlitros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvlitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlitros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tamaño,
            this.litros});
            this.dtgvlitros.Location = new System.Drawing.Point(116, 89);
            this.dtgvlitros.Name = "dtgvlitros";
            this.dtgvlitros.Size = new System.Drawing.Size(240, 150);
            this.dtgvlitros.TabIndex = 3;
            this.dtgvlitros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tamaño
            // 
            this.tamaño.HeaderText = "Tamaño de Tanque";
            this.tamaño.Name = "tamaño";
            // 
            // litros
            // 
            this.litros.HeaderText = "Litros Necesarios";
            this.litros.Name = "litros";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncalcular.Location = new System.Drawing.Point(328, 49);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // FrmE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.dtgvlitros);
            this.Controls.Add(this.txttaamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE2";
            this.Text = "FrmE2";
            this.Load += new System.EventHandler(this.FrmE2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaamaño;
        private System.Windows.Forms.DataGridView dtgvlitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn litros;
        private System.Windows.Forms.Button btncalcular;
    }
}