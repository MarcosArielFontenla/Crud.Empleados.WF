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
        private SqlDataReader dr;

        public SqlDataReader Reader
        {
            get { return dr; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=DESKTOP-J6DPR7A; database=Empleados_DB; integrated security = true");
            comando = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }
      
        public void EjecutarReader()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void EjecutarAccion()
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

        public void CerrarConexion()
        {
            if (dr != null)
                dr.Close();

            conexion.Close();
        }
    }
}
