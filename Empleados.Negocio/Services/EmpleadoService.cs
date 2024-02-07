using Empleados.Data;
using Empleados.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Negocio.Services
{
    public class EmpleadoService
    {
        private AccesoDatos _accesoDatos;

        public EmpleadoService()
        {
        }

        public List<Empleado> GetEmpleadosService()
        {
            return _accesoDatos.GetEmpleados();
        }

        public Empleado GetEmpleadoByIdService(int id)
        {
            return _accesoDatos.GetEmpleadoById(id);
        }

        public void GuardarEmpleadoService(Empleado empleado)
        {
            _accesoDatos.GuardarEmpleado(empleado);
        }

        public void EditarEmpleadoService(Empleado empleado)
        {
            _accesoDatos.EditarEmpleado(empleado);
        }

        public void EliminarEmpleadoService(int id)
        {
            _accesoDatos.EliminarEmpleado(id);
        }
    }
}
