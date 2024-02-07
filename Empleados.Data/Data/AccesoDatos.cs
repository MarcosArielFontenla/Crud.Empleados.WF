using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Empleados.Data.Data
{
    public class AccesoDatos
    {
        private string _conexionString = "server=DESKTOP-J6DPR7A; database=Empleados_DB; integrated security = true";

        public List<Empleado> GetEmpleados()
        {
            var empleado = new List<Empleado>();
            string query = "SELECT * FROM Empleados";

            using (SqlConnection conexion = new SqlConnection(_conexionString))
            {
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader dataReader = comando.ExecuteReader();

                    while(dataReader.Read())
                    {
                        empleado.Add(new Empleado
                        {
                            Id = dataReader.GetInt32(0),
                            Nombre = dataReader.GetString(1),
                            Apellido = dataReader.GetString(2),
                            Edad = dataReader.GetInt32(3),
                            Cargo = dataReader.GetString(4),
                            Proyecto = dataReader.GetString(5)
                        });
                    }
                    dataReader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
            return empleado;
        }

        public Empleado GetEmpleadoById(int id)
        {
            string query = "SELECT Id, Nombre, Apellido, Edad, Cargo, Proyecto FROM Empleados WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(_conexionString))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", id);

                try
                {
                    conexion.Open();
                    SqlDataReader dataReader = comando.ExecuteReader();

                    dataReader.Read();
                    var empleado = new Empleado
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Apellido = dataReader.GetString(2),
                        Edad = dataReader.GetInt32(3),
                        Cargo = dataReader.GetString(4),
                        Proyecto = dataReader.GetString(5)
                    };

                    dataReader.Close();
                    conexion.Close();
                    return empleado;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            string query = "INSERT INTO Empleados (Nombre, Apellido, Edad, Cargo, Proyecto) VALUES (@Nombre, @Apellido, @Edad, @Cargo, @Proyecto)";

            using (SqlConnection conexion = new SqlConnection(_conexionString))
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@Edad", empleado.Edad);
                comando.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                comando.Parameters.AddWithValue("@Proyecto", empleado.Proyecto);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void EditarEmpleado(Empleado editarEmpleado)
        {
            string query = "UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, Cargo = @Cargo, Proyecto = @Proyecto WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(_conexionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", editarEmpleado.Id);
                comando.Parameters.AddWithValue("@Nombre", editarEmpleado.Nombre);
                comando.Parameters.AddWithValue("@Apellido", editarEmpleado.Apellido);
                comando.Parameters.AddWithValue("@Edad", editarEmpleado.Edad);
                comando.Parameters.AddWithValue("@Cargo", editarEmpleado.Cargo);
                comando.Parameters.AddWithValue("@Proyecto", editarEmpleado.Proyecto);
                comando.ExecuteNonQuery();

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }

        public void EliminarEmpleado(int id)
        {
            string query = "DELETE FROM Empleados WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(_conexionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Id", id);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la base de datos " + ex.Message);
                }
            }
        }
    }
}
