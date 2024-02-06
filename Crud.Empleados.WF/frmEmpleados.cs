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
            Application.Exit();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            PersonaNegocio negocio = new PersonaNegocio();
            dgvEmpleados.DataSource = negocio.listar();
        }
        

        private void btnGuardar_Click(object sender, EventArgs e) // guarda el ingreso del usuario, siempre y cuando NO SALTE al catch 
        {
            Persona alta = new Persona();
            PersonaNegocio negocio = new PersonaNegocio();
            try
            {
                alta.Nombre = tbNombre.Text;
                alta.Apellido = tbApellido.Text;
                alta.Edad = int.Parse(tbEdad.Text);
                alta.Cargo = tbCargo.Text;
                alta.Proyecto = tbProyecto.Text;

                negocio.guardar(alta);
                MessageBox.Show("Agregado exitosamente");

                cargar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }



        }

       
    }
}
