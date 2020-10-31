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
    public partial class FrmE3 : Form
    {
        public FrmE3()
        {
            InitializeComponent();
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            int n = dtgvnotas.Rows.Add();
            double n1, n2, n3,total,resta;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtn3.Text);
            total = n1 + n2 + n3;
            resta = 65 - total;
            dtgvnotas.Rows[n].Cells[0].Value = txtnombre.Text;
            dtgvnotas.Rows[n].Cells[1].Value = txtn1.Text;
            dtgvnotas.Rows[n].Cells[2].Value = txtn2.Text;
            dtgvnotas.Rows[n].Cells[3].Value = txtn3.Text;
            dtgvnotas.Rows[n].Cells[4].Value = total;
            dtgvnotas.Rows[n].Cells[5].Value = resta;
            txtn1.Text = "";
            txtn2.Text = "";
            txtn3.Text = "";
            txtnombre.Text = "";

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
