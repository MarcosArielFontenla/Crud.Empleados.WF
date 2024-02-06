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
        public List<Persona> GetPersonas() // conexion a la base de datos
        {
            List<Persona> listaPersonas = new List<Persona>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-J6DPR7A; database=Empleados_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Nombre, Apellido, Edad, Cargo, Proyecto FROM Empleados";
                comando.Connection = conexion;

                conexion.Open();
                reader = comando.ExecuteReader();

                while(reader.Read()) 
                {
                    Persona persona = new Persona();
                    persona.Nombre = (string)reader["Nombre"];
                    persona.Apellido = (string)reader["Apellido"];
                    persona.Edad = reader.GetInt32(2);
                    persona.Cargo = (string)reader["Cargo"];
                    persona.Proyecto = (string)reader["Proyecto"];

                    listaPersonas.Add(persona);
                }
                conexion.Close();
                return listaPersonas;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void GuardarPersona(Persona nuevaPersona) //  para insertar el registro a la base de datos
        {
            var datos = new AccesoDatos();

            try
            {
                datos.SetQuery($"INSERT INTO Empleados(Nombre, Apellido, Edad, Cargo, Proyecto) VALUES('{nuevaPersona.Nombre}', '{nuevaPersona.Apellido}', {nuevaPersona.Edad}, '{nuevaPersona.Cargo}', '{nuevaPersona.Proyecto}')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void EditarPersona(Persona editarPersona)
        {
            // to-do
        }
    }
}
