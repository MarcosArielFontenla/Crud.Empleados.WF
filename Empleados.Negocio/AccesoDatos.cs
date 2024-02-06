using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Empleados.Negocio
{
    public class AccesoDatos // centraliza la conexion
    {
        //para hacer la lectura
        private SqlConnection conexion; 
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos() 
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=Empleados_DB; integrated security = true");
            comando = new SqlCommand();

        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
      
        public void ejecutarlectura()
        {
            comando.Connection = conexion;
            try
            {
            conexion.Open();
            lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        
    }
}
