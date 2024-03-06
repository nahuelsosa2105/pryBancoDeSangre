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
                //MessageBox.Show( "Estado de conexion: Correcto");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Estado de conexion: Incorrecto" + ex.Message);
            }
            conexionBd.Close();
        }

        public void BuscarGrupo(DataGridView grilla)
        {
            // Utiliza tu cadena de conexión existente


            // Crea la conexión
            conexionBd = new OleDbConnection();
            conexionBd.ConnectionString = cadenaConexion;
            // Abre la conexión
            conexionBd.Open();

                // Utiliza la conexión en el bloque try
                try
                {
                    // Consulta SQL para obtener datos de la tabla
                    string query = "SELECT * FROM [Datos Paciente]";

                    // Crea el comando con la consulta SQL y la conexión
                    using (OleDbCommand comandoBd = new OleDbCommand(query, conexionBd))
                    {
                        // Crea un DataReader para leer los datos
                        using (OleDbDataReader reader = comandoBd.ExecuteReader())
                        {
                            // Verifica si hay filas para leer
                            if (reader.HasRows)
                            {
                                // Limpiar la grilla antes de agregar nuevas filas
                                grilla.Rows.Clear();

                                // Itera a través de las filas y muestra los datos en la grilla
                                while (reader.Read())
                                {
                                    // Crea una nueva fila para el DataGridView
                                    DataGridViewRow nuevaFila = new DataGridViewRow();

                                    // Itera a través de las columnas y asigna los valores
                                    for (int i = 0; i < grilla.Columns.Count; i++)
                                    {
                                        nuevaFila.Cells[i].Value = reader[grilla.Columns[i].Name];
                                    }

                                    // Agrega la nueva fila al DataGridView
                                    grilla.Rows.Add(nuevaFila);
                                }
                            }
                            else
                            {
                                // No se encontraron datos
                                Console.WriteLine("No hay datos disponibles.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que pueda ocurrir durante la ejecución
                    Console.WriteLine("Error: " + ex.Message);
                }
            
        }

    }
}
