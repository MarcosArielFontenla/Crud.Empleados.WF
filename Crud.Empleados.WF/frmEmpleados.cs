using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados.Data;
using Empleados.Negocio;


namespace Crud.Empleados.WF
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la aplicación...");
            Close();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            var negocio = new PersonaNegocio();
            dgvEmpleados.DataSource = negocio.GetPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e) // guarda el ingreso del usuario, siempre y cuando NO SALTE al catch 
        {
            var nuevaPersona = new Persona();
            var negocio = new PersonaNegocio();

            try
            {
                nuevaPersona.Nombre = tbNombre.Text;
                nuevaPersona.Apellido = tbApellido.Text;
                nuevaPersona.Edad = int.Parse(tbEdad.Text);
                nuevaPersona.Cargo = tbCargo.Text;
                nuevaPersona.Proyecto = tbProyecto.Text;
                negocio.GuardarPersona(nuevaPersona);
                
                MessageBox.Show("Agregado exitosamente");
                MostrarEmpleados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbEdad.Text = "";
            tbCargo.Text = "";
            tbProyecto.Text = "";
        }
    }
}
