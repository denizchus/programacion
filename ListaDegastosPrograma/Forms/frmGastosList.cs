using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDegastosPrograma.Forms
{
    public partial class frmGastosList : Form
    {
        admGastos aConexion = new admGastos();
        public frmGastosList()
        {
            InitializeComponent();
        }

        private void gastosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGastosList_Load(object sender, EventArgs e)
        {
            dslistadegastos.Gastos.Clear();
            string selectSQl = "Select * from gastos";
            if (aConexion.selectData(selectSQl, dslistadegastos.Gastos) != true)
                MessageBox.Show("No se ha podido cargar ningun dato de los productos, contacte el departamento de desarrollo tecnico", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
