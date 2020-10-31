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
    public partial class FrmE1 : Form
    {
        public FrmE1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //adicionar renglon
            int n = dtgvganancia.Rows.Add();
            double preciocosto, precioventa, ganancia;
            preciocosto = double.Parse(txtcosto.Text);
            precioventa = double.Parse(txtventa.Text);
            ganancia = precioventa - preciocosto;
            dtgvganancia.Rows[n].Cells[0].Value = txtproducto.Text;
            dtgvganancia.Rows[n].Cells[1].Value = "L. "+txtcosto.Text;
            dtgvganancia.Rows[n].Cells[2].Value = "L. "+txtventa.Text;
            dtgvganancia.Rows[n].Cells[3].Value = "L."+ganancia;
            txtproducto.Text = "";
            txtventa.Text = "";
            txtcosto.Text = "";

        }
    }
}