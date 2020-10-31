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
    public partial class FrmE2 : Form
    {
        public FrmE2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n = dtgvlitros.Rows.Add();
            double litros,ltsn;
            litros = double.Parse(txttaamaño.Text);
            ltsn = litros * 1000;
            dtgvlitros.Rows[n].Cells[0].Value = "Mts. "+txttaamaño.Text;
            dtgvlitros.Rows[n].Cells[1].Value = "Litros." + ltsn;
            txttaamaño.Text = "";

        }

        private void FrmE2_Load(object sender, EventArgs e)
        {

        }
    }
}
