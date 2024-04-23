using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_Chatarra
{
    public partial class FormMenu : Form
    {
        double monto_efectivo = 0;
        public FormMenu()
        {
            InitializeComponent();

        }
        //Declaramos Precio de cada producto
        const double hambur_simple = 5;
        const double hambur_doble = 8;
        const double alitas_pollo = 10;
        const double lomito = 12;
        const double jiba = 15;
        const double salchipapa = 7;
        double monto_total = 0;
        //double monto_efectivo = 0;
        double cambio = 0;


        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Hambur_doble.Checked == true)
            {
                TXT_hambur_Doble.Enabled = true;
                TXT_hambur_Doble.Text = "";
                TXT_hambur_Doble.Focus();
            }
            else
            {
                TXT_hambur_Doble.Enabled = false;
                TXT_hambur_Doble.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_todo_Click()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controles) =>
            {
                foreach (Control control in controles)
                    if (control is TextBox)
                        (control as TextBox).Text="0";
                    else
                        funcion(control.Controls);
            };
            funcion(Controls);
        }

        private void limpiar_checkBox()
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

        private void Desaibilitar_Texbox()
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controles) =>
            {
                foreach (Control control in controles)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        funcion(control.Controls);
            };
            funcion(Controls);
        }

        private void Habilitar_Texbox(Control textBoxToEnable)
        {
            Action<Control.ControlCollection> funcion = null;
            funcion = (controles) =>
            {
                foreach (Control control in controles)
                {
                    if (control is TextBox)
                    {
                        // Habilitar solo el TextBox específico
                        (control as TextBox).Enabled = (control == textBoxToEnable);
                    }
                    else
                    {
                        funcion(control.Controls);
                    }
                }
            };
            funcion(Controls);
        }


        private void button2_Click(object sender, EventArgs e) //boton limpiar
        {
            limpiar_todo_Click();
            limpiar_checkBox();
            Desaibilitar_Texbox();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Desaibilitar_Texbox();
        }

      

        private void checkBox_Alitas_Pollo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Alitas_Pollo.Checked == true)
            {
                TXT_Alistas_de_pollo.Enabled = true;
                TXT_Alistas_de_pollo.Text = "";
                TXT_Alistas_de_pollo.Focus();
            }
            else
            {
                TXT_Alistas_de_pollo.Enabled = false;
                TXT_Alistas_de_pollo.Text = "0";
            }
        }

        private void checkBox_Hambur_simpl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Hambur_simpl.Checked == true)
            {
                TXT_hambur_simple.Enabled = true;
                TXT_hambur_simple.Text = "";
                TXT_hambur_simple.Focus();
            }
            else
            {
                TXT_hambur_simple.Enabled = false;
                TXT_hambur_simple.Text = "0";
            }
        }

        private void checkBox_Lomito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Lomito.Checked == true)
            {
                TXT_Lomito.Enabled = true;
                TXT_Lomito.Text = "";
                TXT_Lomito.Focus();
            }
            else
            {
                TXT_Lomito.Enabled = false;
                TXT_Lomito.Text = "0";
            }
        }

        private void checkBox_Jiba_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Jiba.Checked == true)
            {
                TXT_Jiba.Enabled = true;
                TXT_Jiba.Text = "";
                TXT_Jiba.Focus();
            }
            else
            {
                TXT_Jiba.Enabled = false;
                TXT_Jiba.Text = "0";
            }
        }

        private void checkBox_Salchipap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Salchipap.Checked == true)
            {
                TXT_Salchipapa.Enabled = true;
                TXT_Salchipapa.Text = "";
                TXT_Salchipapa.Focus();
            }
            else
            {
                TXT_Salchipapa.Enabled = false;
                TXT_Salchipapa.Text = "0";
            }
        }

        //private void button_Calular_Click(object sender, EventArgs e)
        //{
        //    double[] costo_de_lo_productos = new double[6];

        //    costo_de_lo_productos[0] = Convert.ToDouble(TXT_hambur_simple.Text)     * hambur_simple;
        //    costo_de_lo_productos[1] = Convert.ToDouble(TXT_hambur_Doble.Text)      * hambur_doble;
        //    costo_de_lo_productos[2] = Convert.ToDouble(TXT_Alistas_de_pollo.Text)  * alitas_pollo;
        //    costo_de_lo_productos[3] = Convert.ToDouble(TXT_Lomito.Text)            * lomito;
        //    costo_de_lo_productos[4] = Convert.ToDouble(TXT_Jiba.Text)              * jiba;
        //    costo_de_lo_productos[5] = Convert.ToDouble(TXT_Salchipapa.Text)        * salchipapa;

          
        //    monto_total =   costo_de_lo_productos[0] + 
        //                    costo_de_lo_productos[1] + 
        //                    costo_de_lo_productos[2] + 
        //                    costo_de_lo_productos[3] + 
        //                    costo_de_lo_productos[4] + 
        //                    costo_de_lo_productos[5];

        //    textBox_total_Pagar.Text = Convert.ToString(monto_total); 

        //}


        private void button_Calular_Click(object sender, EventArgs e)
        {
            // Arrays para almacenar cantidades y costos unitarios
            TextBox[] textBoxes = { TXT_hambur_simple, 
                                    TXT_hambur_Doble, 
                                    TXT_Alistas_de_pollo, 
                                    TXT_Lomito, 
                                    TXT_Jiba, 
                                    TXT_Salchipapa };
            double[] costosUnitarios = { hambur_simple, hambur_doble, alitas_pollo, lomito, jiba, salchipapa };

            double[] costo_de_lo_productos = new double[6];
            double monto_total = 0;

          
            

            // Validar las entradas
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (!double.TryParse(textBoxes[i].Text, out double cantidad) || cantidad < 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida para " + textBoxes[i].Name.Substring(4));
                    return;
                }

                costo_de_lo_productos[i] = cantidad * costosUnitarios[i];
            }

            // Calcular el monto total
            monto_total = costo_de_lo_productos.Sum();
            textBox_total_Pagar.Text = Convert.ToString(monto_total);


            // Mostrar el monto total en el textBox_total_Pagar
            textBox_total_Pagar.Text = Convert.ToString(monto_total);
        }


        private void TXT_hambur_simple_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CERRAR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button_INICIO_Click(object sender, EventArgs e)
        {
            // INGRESAMOS FORMINICIO
            FormInicio ventanaInicio = new FormInicio();
            this.Hide();
            ventanaInicio.Show();


     
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void textBoxCambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonto2_TextChanged(object sender, EventArgs e)
        {
            Habilitar_Texbox(textBoxMonto2);
            if (double.TryParse(textBoxMonto2.Text, out monto_efectivo))
            {
                cambio = monto_efectivo - monto_total;
                textBoxCambio.Text = cambio >= 0 ? cambio.ToString() : "0";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCambio.Text = "0";
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            // INGRESAMOS FORMINICIO
            FormInicio ventanaInicio = new FormInicio();
            this.Hide();
            ventanaInicio.Show();
        }

        private void rjButtonPlatos_Click(object sender, EventArgs e)
        {
            // INGRESAMOS menu
            FormMenu ventana = new FormMenu();
            this.Hide();
            ventana.Show();
        }

        private void rjButtonALmacen_Click(object sender, EventArgs e)
        {
            // INGRESAMOS A ALMACEN
            FormAlmacen ventana = new FormAlmacen();
            this.Hide();
            ventana.Show();
        }

        private void textBox_total_Pagar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
