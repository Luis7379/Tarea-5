namespace Tarea_5.Fomularios
{
    partial class FrmMenu
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
            this.btnE1 = new System.Windows.Forms.Button();
            this.btnE2 = new System.Windows.Forms.Button();
            this.btnE3 = new System.Windows.Forms.Button();
            this.btnE4 = new System.Windows.Forms.Button();
            this.btnE5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnE1
            // 
            this.btnE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnE1.Location = new System.Drawing.Point(77, 43);
            this.btnE1.Name = "btnE1";
            this.btnE1.Size = new System.Drawing.Size(75, 23);
            this.btnE1.TabIndex = 0;
            this.btnE1.Text = "Ejercicio 1";
            this.btnE1.UseVisualStyleBackColor = false;
            this.btnE1.Click += new System.EventHandler(this.btnE1_Click);
            // 
            // btnE2
            // 
            this.btnE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnE2.Location = new System.Drawing.Point(77, 99);
            this.btnE2.Name = "btnE2";
            this.btnE2.Size = new System.Drawing.Size(75, 23);
            this.btnE2.TabIndex = 1;
            this.btnE2.Text = "Ejercicio 2";
            this.btnE2.UseVisualStyleBackColor = false;
            this.btnE2.Click += new System.EventHandler(this.btnE2_Click);
            // 
            // btnE3
            // 
            this.btnE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnE3.Location = new System.Drawing.Point(77, 155);
            this.btnE3.Name = "btnE3";
            this.btnE3.Size = new System.Drawing.Size(75, 23);
            this.btnE3.TabIndex = 2;
            this.btnE3.Text = "Ejercicio 3";
            this.btnE3.UseVisualStyleBackColor = false;
            this.btnE3.Click += new System.EventHandler(this.btnE3_Click);
            // 
            // btnE4
            // 
            this.btnE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnE4.Location = new System.Drawing.Point(261, 43);
            this.btnE4.Name = "btnE4";
            this.btnE4.Size = new System.Drawing.Size(75, 23);
            this.btnE4.TabIndex = 3;
            this.btnE4.Text = "Ejercicio 4";
            this.btnE4.UseVisualStyleBackColor = false;
            this.btnE4.Click += new System.EventHandler(this.btnE4_Click);
            // 
            // btnE5
            // 
            this.btnE5.BackColor = System.Drawing.Color.Silver;
            this.btnE5.Location = new System.Drawing.Point(261, 98);
            this.btnE5.Name = "btnE5";
            this.btnE5.Size = new System.Drawing.Size(75, 23);
            this.btnE5.TabIndex = 4;
            this.btnE5.Text = "Ejercicio 5";
            this.btnE5.UseVisualStyleBackColor = false;
            this.btnE5.Click += new System.EventHandler(this.btnE5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione El Programa";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(511, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnE5);
            this.Controls.Add(this.btnE4);
            this.Controls.Add(this.btnE3);
            this.Controls.Add(this.btnE2);
            this.Controls.Add(this.btnE1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnE1;
        private System.Windows.Forms.Button btnE2;
        private System.Windows.Forms.Button btnE3;
        private System.Windows.Forms.Button btnE4;
        private System.Windows.Forms.Button btnE5;
        private System.Windows.Forms.Label label1;
    }
}