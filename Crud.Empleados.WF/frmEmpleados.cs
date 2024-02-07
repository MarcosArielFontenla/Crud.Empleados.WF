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
using Empleados.Data.Data;
using Empleados.Negocio;
using Empleados.Negocio.Services;


namespace Crud.Empleados.WF
{
    public partial class frmEmpleados : Form
    {
        private EmpleadoService _empleadoService;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e) 
        {
            GuardarEmpleado();
            MostrarEmpleados();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado();
            MostrarEmpleados();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
            MostrarEmpleados();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la aplicación...");
            Close();
        }

        private void MostrarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = _empleadoService.GetEmpleadosService();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los datos " + ex.Message);
            }
        }

        private void GuardarEmpleado()
        {
            var empleado = new Empleado
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Edad = Convert.ToInt32(tbEdad.Text),
                Cargo = tbCargo.Text,
                Proyecto = tbProyecto.Text
            };

            try
            {
                _empleadoService.GuardarEmpleadoService(empleado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar " + ex.Message);
            }
        }

        private void EditarEmpleado()
        {
            var empleado = new Empleado
            {
                Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value),
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Edad = Convert.ToInt32(tbEdad.Text),
                Cargo = tbCargo.Text,
                Proyecto = tbProyecto.Text
            };

            try
            {
                _empleadoService.EditarEmpleadoService(empleado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar " + ex.Message);
            }
        }

        private void EliminarEmpleado()
        {
            var id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);

            try
            {
                _empleadoService.EliminarEmpleadoService(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar " + ex.Message);
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
