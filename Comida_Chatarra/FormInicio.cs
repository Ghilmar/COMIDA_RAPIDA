using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing; // Libreria para usar colores
using System.Drawing.Drawing2D; // Libreria para usar colores   
using System.ComponentModel; // Libreria para usar colores

namespace Comida_Chatarra
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        //redondear esquinas de un boton
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // INGRESAMOS menu
            FormMenu ventana = new FormMenu();
            this.Hide();
            ventana.Show();
        }

        private void button_inicio_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // INGRESAMOS FORMINICIO
            FormInicio ventanaInicio = new FormInicio();
            this.Hide();
            ventanaInicio.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            // INGRESAMOS menu
            FormMenu ventana = new FormMenu();
            this.Hide();
            ventana.Show();
        }

        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            // INGRESAMOS A ALMACEN
            FormAlmacen ventana = new FormAlmacen();
            this.Hide();
            ventana.Show();
        }
    }
}
