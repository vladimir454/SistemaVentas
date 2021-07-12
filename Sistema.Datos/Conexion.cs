using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;
        //SerializableAttribute mi contructor 
        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "DESKTOP-F64GRC0";
            this.Usuario = "DESKTOP-F64GRC0\\fanta";
            this.Clave = "";
            this.Seguridad = true;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if(this.Seguridad)//con sql server
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";

                }
                else //con visual estudio 
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Usuer Id="+this.Usuario+";Password="+this.Clave;
                }
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
                 
                
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if(Con ==null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
