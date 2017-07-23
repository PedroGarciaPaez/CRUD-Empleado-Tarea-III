using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_CRUD_empleado
{
    public partial class Lista_de_empleados : Form
    {
        public Lista_de_empleados()
        {
            InitializeComponent();
        }

        private void Lista_de_empleados_Load(object sender, EventArgs e)
        {

            Operacioness op = new Operacioness();
            op.Conectar();
            dgvEmpleado.DataSource = op.ConsultaConResultado("  SELECT * FROM empleado ");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Operacioness op = new Operacioness();//haciendo una instancia de la clase

            if (radioid.Checked == true)
            {

                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM empleado WhERE id_empleado  LIKE '%" + txtBuscar.Text.Trim() + "%'");
            }

            else if (radionombre.Checked == true)
            {


                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM  empleado WhERE nombre LIKE  '%" + txtBuscar.Text.Trim() + "%'");
            }

            else if (radioapellido.Checked == true)
            {

                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM  empleado WhERE  apellido LIKE  '%" + txtBuscar.Text.Trim() + "%'");
            }

            else if (radiocedula.Checked == true)
            {
                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM  empleado WhERE cedula LIKE  '%" + txtBuscar.Text.Trim() + "%'");
            }
            else if (txtBuscar.Text.Length == 0)
            {
                dgvEmpleado.DataSource = op.ConsultaConResultado("SELECT * FROM  empleado");
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            frmEmpleado emple = new frmEmpleado();
            emple.Show();

        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmEmpleado  emp = new frmEmpleado();
            DataGridViewRow rellenar = dgvEmpleado.Rows[e.RowIndex];
            emp.id.Text = rellenar.Cells["id_empleado"].Value.ToString();
            emp.txtcedula.Text = rellenar.Cells["cedula"].Value.ToString();
            emp.txtnombre.Text = rellenar.Cells["nombre"].Value.ToString();
            emp.txtapellido.Text = rellenar.Cells["apellido"].Value.ToString();
           // emp.txtsexo.Text = rellenar.Cells["sexo"].Value.ToString();
            emp.txtfechanacimiento.Text = rellenar.Cells["fecha_nacimiento"].Value.ToString();
            emp.txtfechaingreso.Text = rellenar.Cells["fecha_de_ingreso"].Value.ToString();
            emp.txtsalario.Text = rellenar.Cells["sueldo"].Value.ToString();
            
            emp.Show();

        }
    }
}
