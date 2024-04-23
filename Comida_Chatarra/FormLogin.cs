using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Libreria para conectar con SQL Server

namespace Comida_Chatarra
{
    public partial class FormLogin : Form
    {
        // Crear una instancia de la clase Conexcion
        Conexcion conexionClass = new Conexcion();
        public FormLogin()
        {
            InitializeComponent();
        }

        // Conexion con SQL Server
        //SqlConnection conexcion = new SqlConnection("server = LAPTOP-UME3LS19 ; database = EMPRESA ; Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_USUARIO_Enter(object sender, EventArgs e)
        {
            if(text_USUARIO.Text == "USUARIO")
            {
                text_USUARIO.Text = "";
                text_USUARIO.ForeColor = Color.LightGray;
            }
        }

        private void text_USUARIO_Leave(object sender, EventArgs e)
        {
            if(text_USUARIO.Text == "")
            {
                text_USUARIO.Text = "USUARIO";
                text_USUARIO.ForeColor = Color.DimGray;
            }
        }

        private void text_CONTRASEÑA_Enter(object sender, EventArgs e)
        {
            if (text_CONTRASEÑA.Text == "CONTRASEÑA")
            {
                text_CONTRASEÑA.Text = "";
                text_CONTRASEÑA.ForeColor = Color.LightGray;
                text_CONTRASEÑA.UseSystemPasswordChar = true;
            }
        }

        private void text_CONTRASEÑA_Leave(object sender, EventArgs e)
        {
            if(text_CONTRASEÑA.Text == "")
            {
                text_CONTRASEÑA.Text = "CONTRASEÑA";
                text_CONTRASEÑA.ForeColor = Color.DimGray;
                text_CONTRASEÑA.UseSystemPasswordChar = false;
            }
        }

        private void button_ACCEDER_Click(object sender, EventArgs e)
        {
            // Obtener la conexión desde la clase Conexcion
            using (SqlConnection conexion = conexionClass.ObtenerConexion())
            {
                conexion.Open(); // Abrir la conexión con SQL Server

                string consulta = "SELECT * FROM USUARIOS WHERE USUARIO = @Usuario AND CONTRASENA = @Contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                // Usar parámetros para evitar la inyección de SQL
                comando.Parameters.AddWithValue("@Usuario", text_USUARIO.Text);
                comando.Parameters.AddWithValue("@Contrasena", text_CONTRASEÑA.Text);

                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    // INGRESAMOS FORMINICIO
                    FormInicio ventanaInicio = new FormInicio();
                    //FormMenu ventana = new FormMenu();
                    this.Hide();
                    ventanaInicio.Show();
                    //MessageBox.Show("Bienvenido al Sistema", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al ingresar al Sistema", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cierra la conexión después de su uso.
                conexion.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
         
    }
}
