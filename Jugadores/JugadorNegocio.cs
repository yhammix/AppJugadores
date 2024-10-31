using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Jugadores
{
    internal class JugadorNegocio
    {
        public List<Jugador> listar() 
        {  
            List<Jugador> lista=new List<Jugador>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=SELECCION_DB; integrated security=true";
                comando.CommandType=System.Data.CommandType.Text;
                comando.CommandText = "SELECT Numero, Nombre, CLub, UrlImagen From JUGADORES";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Jugador aux = new Jugador();

                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (String)lector["Nombre"];
                    aux.Club = (string)lector["Club"];
                    aux.UrlImagen = (string)lector["UrlImagen"];

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

    }
}
