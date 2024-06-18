using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Pregutna1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ConectarYLeerDatos()
        {
            try
            {
                // Obtener la cadena de conexión del archivo de configuración
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MySqlConexion"].ConnectionString;

                // Crear una conexión a la base de datos
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    // Abrir la conexión
                    conexion.Open();
                    //MessageBox.Show("Conexión exitosa");

                    // Crear una consulta SQL
                    string consultaSQL = "SELECT * FROM Estudiante";

                    // Crear un adaptador de datos
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consultaSQL, conexion);

                    // Crear un DataTable para almacenar los datos
                    DataTable tablaEstudiantes = new DataTable();

                    // Llenar el DataTable con los datos de la base de datos
                    adaptador.Fill(tablaEstudiantes);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridViewEstudiantes.DataSource = tablaEstudiantes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private void MostrarUnEstutiante(string matriculaEstudiante)
        {
            try
            {
                // Obtener la cadena de conexión del archivo de configuración
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MySqlConexion"].ConnectionString;

                // Crear una conexión a la base de datos
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    // Abrir la conexión
                    //conexion.Open();
                    //MessageBox.Show("Conexión exitosa");

                    // Crear una consulta SQL con un parámetro
                    string consultaSQL = "SELECT * FROM Estudiante WHERE NumeroMatricula = @Matricula";

                    // Crear un adaptador de datos
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consultaSQL, conexion);

                    // Agregar el parámetro al adaptador
                    adaptador.SelectCommand.Parameters.AddWithValue("@Matricula", matriculaEstudiante);

                    // Crear un DataTable para almacenar los datos
                    DataTable tablaEstudiantes = new DataTable();

                    // Llenar el DataTable con los datos de la base de datos
                    adaptador.Fill(tablaEstudiantes);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridViewEstudiantes.DataSource = tablaEstudiantes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConectarYLeerDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombreEstudiante = txtNombreEstudiante.Text.Trim();
            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                MostrarUnEstutiante(nombreEstudiante);
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre de estudiante.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cadena de conexión del archivo de configuración
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MySqlConexion"].ConnectionString;

                // Crear una conexión a la base de datos
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    // Abrir la conexión
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
