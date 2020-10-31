namespace Tarea_5.Fomularios
{
    partial class FrmE1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.dtgvganancia = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvganancia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORCENTAJE DE GANANCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de venta";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtproducto.Location = new System.Drawing.Point(112, 57);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 20);
            this.txtproducto.TabIndex = 4;
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcosto.Location = new System.Drawing.Point(326, 57);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 20);
            this.txtcosto.TabIndex = 5;
            // 
            // txtventa
            // 
            this.txtventa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtventa.Location = new System.Drawing.Point(544, 57);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(100, 20);
            this.txtventa.TabIndex = 6;
            // 
            // dtgvganancia
            // 
            this.dtgvganancia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvganancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvganancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.costo,
            this.venta,
            this.ganancia});
            this.dtgvganancia.Location = new System.Drawing.Point(55, 154);
            this.dtgvganancia.Name = "dtgvganancia";
            this.dtgvganancia.Size = new System.Drawing.Size(444, 185);
            this.dtgvganancia.TabIndex = 7;
            // 
            // producto
            // 
            this.producto.HeaderText = "Nombre de Producto";
            this.producto.Name = "producto";
            // 
            // costo
            // 
            this.costo.HeaderText = "Precio de costo";
            this.costo.Name = "costo";
            // 
            // venta
            // 
            this.venta.HeaderText = "Precio de venta";
            this.venta.Name = "venta";
            // 
            // ganancia
            // 
            this.ganancia.HeaderText = "Porcentaje de ganancia";
            this.ganancia.Name = "ganancia";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Yellow;
            this.btncalcular.Location = new System.Drawing.Point(112, 111);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnlimpiar.Location = new System.Drawing.Point(287, 111);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.Location = new System.Drawing.Point(424, 111);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Cerrar";
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // FrmE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.dtgvganancia);
            this.Controls.Add(this.txtventa);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE1";
            this.Text = "FrmE1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvganancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.DataGridView dtgvganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancia;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}