using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Diseño_CRUD_empleado
{
    public partial class CRUD_Cargo : Form
    {

        public CRUD_Cargo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operacioness op = new Operacioness();//haciendo una instancia de la clase

            if (radioid.Checked == true)
            {

                dgvPuesto.DataSource = op.ConsultaConResultado("SELECT * FROM puesto WhERE id_puesto  LIKE '%" + txtBuscar.Text.Trim() + "%'");
            }

            else if (radionombre.Checked == true)
            {
                dgvPuesto.DataSource = op.ConsultaConResultado("select * from puesto where nombre_puesto like '%" + txtBuscar.Text.Trim() + "%'");
            }
        }

        private void CRUD_Cargo_Load(object sender, EventArgs e)
        {
            Operacioness op = new Operacioness();
            dgvPuesto.DataSource = op.ConsultaConResultado("select * from puesto");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Operacioness op = new Operacioness();


            if (lidpuesto.Text == "")
            {
                if (txtNombrePuesto.Text != "")
                {

                    op.ConsultasSinResultados("INSERT INTO puesto(nombre_puesto) values('" + txtNombrePuesto.Text + "')");
                    MessageBox.Show(txtNombrePuesto.Text + " GUARDADO", "DATOS GUARDADOS ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("FALTA NOMBRE DEL PUESTO", "ENTRE NOMBRE DEL PUESTO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombrePuesto.Focus();
                }
            }
            else if (lidpuesto.Text != "")
            {
                if (MessageBox.Show("REALMENTE DESEA MODIFICAR ESTE CAMPO ", "UPDATE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    op.ConsultasSinResultados("UPDATE puesto SET id_puesto = '" + lidpuesto.Text + "', nombre_puesto = '" + txtNombrePuesto.Text + "' WHERE cod_cargo LIKE '%" + txtCodCargo.Text + "%'");//todo funciona correctamente
                    MessageBox.Show(lidpuesto.Text + " GUARDADO CORRECTAMENTE", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            lidpuesto.Text = "";
            txtNombrePuesto.Text = "";
        }
    }
}
             

        private void dgvPuesto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rellenar = dgvPuesto.Rows[e.RowIndex];
            lidpuesto.Text = rellenar.Cells["id_puesto"].Value.ToString();
            txtNombrePuesto.Text = rellenar.Cells["nombre_puesto"].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
