using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryBancoDeSangre
{
    internal class clsBaseDeDatosUser
    {
        OleDbConnection conexionBd;
        OleDbCommand comandoBd;
        OleDbDataReader lectorBd;

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdBancoDeSangre.accdb";

        public string estadoConexion = "";

        public string datosTabla = "";

        public void ConectarBD()
        {
            try
            {
                conexionBd = new OleDbConnection();
                conexionBd.ConnectionString = cadenaConexion;
                conexionBd.Open();
                estadoConexion = "Estado de conexion: Correcto";
               

            }
            catch (Exception ex)
            {
                estadoConexion = "Estado de conexion: Incorrecto" + ex.Message;
            }
        }

        public static bool respuesta;


        public void BuscarUser()
        {
            conexionBd = new OleDbConnection();
            conexionBd.ConnectionString = cadenaConexion;
            conexionBd.Open();
            comandoBd = new OleDbCommand();

            comandoBd.Connection = conexionBd;
            comandoBd.CommandType = System.Data.CommandType.TableDirect;
            comandoBd.CommandText = "users";

            lectorBd = comandoBd.ExecuteReader();

            if(lectorBd.HasRows)
            {
                while(lectorBd.Read())
                {
                    string userBd = lectorBd[1].ToString();
                    string passBd = lectorBd[2].ToString();

                    if (userBd == frmLogin.user && passBd == frmLogin.pass)
                    {
                        respuesta = true;
                        break;
                    }
                    else
                    {
                        respuesta = false;
                        break;
                    }

                }
            }
        }

    }
}
