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
    public partial class FrmE5 : Form
    {
        public FrmE5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = dtgvproducto.Rows.Add();
            double precio, cantidad, impuesto,subtotal,tp,timp;
            precio = double.Parse(txtprecio.Text);
            cantidad = double.Parse(txtcantidad.Text);
            tp = (precio * cantidad);
            impuesto = tp * 0.15;
            subtotal = tp + impuesto;
            timp = subtotal + impuesto;
            dtgvproducto.Rows[n].Cells[0].Value = txtcodigo.Text;
            dtgvproducto.Rows[n].Cells[1].Value = txtproducto.Text;
            dtgvproducto.Rows[n].Cells[2].Value = txtcantidad.Text;
            dtgvproducto.Rows[n].Cells[4].Value = impuesto;
            dtgvproducto.Rows[n].Cells[3].Value = subtotal;
            dtgvproducto.Rows[n].Cells[5].Value = timp;
            txtproducto.Text = "";
            txtcodigo.Text = "";
            txtcantidad.Text = "";
            txtprecio.Text = "";
            decimal total = 0;
            foreach(DataGridViewRow row in dtgvproducto.Rows)
            {
                total += Convert.ToDecimal(row.Cells["totalcomimp"].Value);
            }
            txttotal.Text = total.ToString();
            decimal totalt = 0;
            foreach(DataGridViewRow row in dtgvproducto.Rows)
            {
                totalt += Convert.ToDecimal(row.Cells["impuesto"].Value);
            }
            txtimpuesto.Text = totalt.ToString();




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
