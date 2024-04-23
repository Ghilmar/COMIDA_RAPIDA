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
    public partial class FormAlmacen : Form
    {
        public FormAlmacen()
        {
            InitializeComponent();
        }

        private void FormAlmacen_Load(object sender, EventArgs e)
        {

            // Crear una instancia de la clase Conexcion
            Conexcion conexionClass = new Conexcion();
            dtGridViewProductos.DataSource = Index();

        }

        public DataTable Index()
        {
            // Crear una instancia de la clase Conexcion
            Conexcion conexionClass = new Conexcion();

            // Crear una instancia de la clase SqlCommand
            DataTable datatable = new DataTable();
            string sql = "SELECT * FROM productos";
            SqlCommand comando = new SqlCommand(sql, conexionClass.ObtenerConexion());

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            adapter.Fill(datatable);

            return datatable;
        }

        private void limpiar_checkBox2()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controles) =>
            {
                foreach (Control control in controles)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        funcion(control.Controls);
            };
            funcion(Controls);
        }

        private void limpiar_todo_Click2()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controles) =>
            {
                foreach (Control control in controles)
                    if (control is TextBox)
                        (control as TextBox).Text = "";
                    else
                        funcion(control.Controls);
            };
            funcion(Controls);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            // INGRESAMOS A ALMACEN
            FormAlmacen ventana = new FormAlmacen();
            this.Hide();
            ventana.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // INGRESAMOS menu
            FormMenu ventana = new FormMenu();
            this.Hide();
            ventana.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // INGRESAMOS FORMINICIO
            FormInicio ventanaInicio = new FormInicio();
            this.Hide();
            ventanaInicio.Show();
        }

        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_AGREGAR_Click(object sender, EventArgs e)
        {
            Conexcion myCom = new Conexcion();
            using (SqlConnection conexion = myCom.ObtenerConexion())
            {
                conexion.Open();

                // Verificar si los TextBox están vacíos
                if (string.IsNullOrWhiteSpace(txtBoxID.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxNOM_PRODUCTO.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxPRECIO.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxSTOCK.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // No ejecutar la consulta si hay campos vacíos
                }


                string sql = "INSERT INTO Productos (ID_Producto, Nombre, Precio, Stock) VALUES (@ID_Producto, @Nombre, @Precio, @Stock)";
                using (SqlCommand comando1 = new SqlCommand(sql, conexion))
                {
                    comando1.Parameters.AddWithValue("@ID_Producto", txtBoxID.Text);
                    comando1.Parameters.AddWithValue("@Nombre", txtBoxNOM_PRODUCTO.Text);
                    comando1.Parameters.AddWithValue("@Precio", txtBoxPRECIO.Text);
                    comando1.Parameters.AddWithValue("@Stock", txtBoxSTOCK.Text);

                    comando1.ExecuteNonQuery();


                    MessageBox.Show("Producto agregado correctamente");
                    limpiar_todo_Click2();
                    limpiar_checkBox2();

                    dtGridViewProductos.DataSource = Index();

                }
            }
        }

        private void buttonELIMINAR_Click(object sender, EventArgs e)
        {
            
                // Usando la clase Conex2 en un bloque using
                using (Conex2 myCom = new Conex2())
                {
                    using (SqlConnection conexion = myCom.ObtenerConexion())
                    {
                        //conexion.Open();

                        // Verificar si el TextBox de ID está vacío
                        if (string.IsNullOrWhiteSpace(txtBoxEliminar.Text))
                        {
                            MessageBox.Show("Por favor, ingrese el ID del producto a eliminar.", "ID Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // No ejecutar la consulta si el ID está vacío
                        }

                        // Verificar si el ID ingresado es un número válido
                        if (!int.TryParse(txtBoxEliminar.Text, out int idProducto))
                        {
                            MessageBox.Show("Por favor, ingrese un ID de producto válido.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // No ejecutar la consulta si el ID no es válido
                        }

                        string sql = "DELETE FROM Productos WHERE ID_Producto = @ID_Producto";
                        using (SqlCommand comandoEliminar = new SqlCommand(sql, conexion))
                        {
                            comandoEliminar.Parameters.AddWithValue("@ID_Producto", idProducto);

                            int filasAfectadas = comandoEliminar.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente");
                                dtGridViewProductos.DataSource = Index(); // Actualizar el DataGridView
                                limpiar_todo_Click2();
                                limpiar_checkBox2();
                        }
                            else
                            {
                                MessageBox.Show("No se encontró un producto con el ID especificado.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    
                }
            }

        }
    }
}
