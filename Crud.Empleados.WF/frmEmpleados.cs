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
            _empleadoService = new EmpleadoService();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e) 
        {
            GuardarEmpleado();
            RefreshData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEmpleado();
            RefreshData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
            RefreshData();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la aplicación...");
            Close();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                tbNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                tbApellido.Text = dgvEmpleados.CurrentRow.Cells["Apellido"].Value.ToString();
                tbEdad.Text = dgvEmpleados.CurrentRow.Cells["Edad"].Value.ToString();
                tbCargo.Text = dgvEmpleados.CurrentRow.Cells["Cargo"].Value.ToString();
                tbProyecto.Text = dgvEmpleados.CurrentRow.Cells["Proyecto"].Value.ToString();
            }
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
            try
            {
                if (dgvEmpleados.CurrentRow != null && dgvEmpleados.CurrentRow.Cells[0].Value != null)
                {
                    int id;

                    if (int.TryParse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString(), out id))
                    {
                        var empleado = new Empleado
                        {
                            Id = id,
                            Nombre = tbNombre.Text,
                            Apellido = tbApellido.Text,
                            Edad = Convert.ToInt32(tbEdad.Text),
                            Cargo = tbCargo.Text,
                            Proyecto = tbProyecto.Text
                        };

                        _empleadoService.EditarEmpleadoService(empleado);
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila antes de editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar " + ex.Message);
            }
        }

        private void EliminarEmpleado()
        {
            var id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Id"].Value);

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

        private void RefreshData()
        {
            MostrarEmpleados();
            LimpiarCampos();
        }
    }
}
