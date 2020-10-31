using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5.Fomularios
{
    public partial class FrmE4 : Form
    {
        public FrmE4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = dtgvnotas.Rows.Add();
            double n1, n2, n3, n4, prom;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtn3.Text);
            n4 = double.Parse(txtn4.Text);
            prom = (n1 + n2 + n3 + n4) / 4;
            dtgvnotas.Rows[n].Cells[0].Value = txtnombre.Text;
            dtgvnotas.Rows[n].Cells[1].Value = txtn1.Text;
            dtgvnotas.Rows[n].Cells[2].Value = txtn2.Text;
            dtgvnotas.Rows[n].Cells[3].Value = txtn3.Text;
            dtgvnotas.Rows[n].Cells[4].Value = txtn4.Text;
            dtgvnotas.Rows[n].Cells[5].Value = prom;
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtn4.Text = "";
            txtnombre.Text = "";
            if (prom >= 65)
            {
                dtgvnotas.Rows[n].Cells[6].Value = "Aprobado";
            }
            else
            {
                dtgvnotas.Rows[n].Cells[6].Value = "Reprobado";
            }
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
