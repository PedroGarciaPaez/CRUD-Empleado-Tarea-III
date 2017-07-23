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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            string p = txtfechanacimiento.Text;
            DateTime a = Convert.ToDateTime(p);
            int calcularedad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
            txtcalcularedad.Text = Convert.ToString(calcularedad +"  Años");
        }

        private void btnantiguedad_Click(object sender, EventArgs e)
        {
            string p = txtfechaingreso.Text;
            DateTime a = Convert.ToDateTime(p);
            int calcularedad = DateTime.Today.AddTicks(-a.Ticks).Year - 1;
            txtcalcularantiguedad.Text = Convert.ToString(calcularedad + "  Años");
        }

        private void btnguardadr_Click(object sender, EventArgs e)
        {
            Operacioness oper = new Operacioness();
            oper.ConsultasSinResultados ("INSERT INTO empleado (nombre, apellido, cedula, direccion, fecha_nacimiento, fecha_de_ingreso, sueldo, id_puesto) VALUES('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txtcedula.Text + "', ' ', '" + txtfechanacimiento.Text + "', '" + txtfechaingreso.Text + "', '" + txtsalario.Text + "', ' ')");

          
        }
    }
}
