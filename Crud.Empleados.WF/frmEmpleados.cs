using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona alta = new Persona();

            try
            {
                alta.Nombre = tbNombre.Text;
                alta.Apellido = tbApellido.Text;
                alta.Edad = int.Parse(tbEdad.Text);
                alta.Proyecto = tbProyecto.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            
            
        }
    }
}
