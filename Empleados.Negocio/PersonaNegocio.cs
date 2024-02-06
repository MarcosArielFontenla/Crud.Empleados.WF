using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Empleados.Data;



namespace Empleados.Negocio
{
    public class PersonaNegocio

    {
        public List<Persona> listar() // conexion a la base de datos
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=Empleados_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Nombre, Apellido, Edad, Cargo, Proyecto From Empleados";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read()) 
                {
                    Persona aux = new Persona();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.Edad = lector.GetInt32(2);
                    aux.Cargo = (string)lector["Cargo"];
                    aux.Proyecto = (string)lector["Proyecto"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void guardar(Persona nueva) //  para insertar el registro a la base de datos
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Empleados(Nombre, Apellido, Edad, Cargo, Proyecto)values('" + nueva.Nombre + "','" + nueva.Apellido + "', " + nueva.Edad + ",'" + nueva.Cargo + "','" + nueva.Proyecto + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void editar (Persona modificar)
        {

        }



    }
}
