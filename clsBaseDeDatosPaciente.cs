using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBancoDeSangre
{
    internal class clsBaseDeDatosPaciente
    {
        OleDbConnection conexionBd;
        OleDbCommand comandoBd;
        OleDbDataReader lectorBd;

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdBancoDeSangre";

        public string estadoConexion = "";

        public string datosTabla = "";

        public void ConectarBD()
        {
            try
            {
                conexionBd = new OleDbConnection();
                conexionBd.ConnectionString = cadenaConexion;
                conexionBd.Open();
                //MessageBox.Show( "Estado de conexion: Correcto");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Estado de conexion: Incorrecto" + ex.Message);
            }
        }

        //public void BuscarGrupo()
        //{
        //    conexionBd = new OleDbConnection();
        //    conexionBd.ConnectionString = cadenaConexion;
        //    conexionBd.Open();
        //    comandoBd = new OleDbCommand();

        //    comandoBd.Connection = conexionBd;
        //    comandoBd.CommandType = System.Data.CommandType.TableDirect;
        //    comandoBd.CommandText = "Grupo Sanguineo";

        //    lectorBd = comandoBd.ExecuteReader();

        //    if(lectorBd.HasRows)
        //    {
        //        foreach (DataRow fila in lectorBd.HasRows)
        //        {
        //            // Crear una nueva fila en la grilla
        //            int indiceFila = dataGridView1.Rows.Add();

        //            // Iterar sobre las columnas y asignar los valores a la nueva fila de la grilla
        //            foreach (DataColumn columna in dataTable.Columns)
        //            {
        //                dataGridView1.Rows[indiceFila].Cells[columna.ColumnName].Value = fila[columna];
        //            }
        //        }
        //    }
        //}
    }
}
