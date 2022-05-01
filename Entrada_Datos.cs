using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Clases;

namespace TP4
{
    public partial class Entrada_Datos : Form
    {

        private int N;
        private int desde;
        private int hasta;
        DataTable vendedor_1;

        public Entrada_Datos()
        {
            InitializeComponent();
        }

        private void Entrada_Datos_Load(object sender, EventArgs e)
        {
            btn_ver_tabla.Enabled = false;
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (validar_y_asignar_campos())
            {
                Simulacion_Montecarlo simulador = new Simulacion_Montecarlo(N, desde, hasta);
                vendedor_1 = simulador.generar_simulacion();
                btn_ver_tabla.Enabled = true;
            }
            
        }

        private void btn_ver_tabla_Click(object sender, EventArgs e)
        {
            Tabla_Montecarlo tabla_montecarlo_form = new Tabla_Montecarlo(vendedor_1);
            tabla_montecarlo_form.Show();
        }

        private bool validar_y_asignar_campos()
        {
            if (string.IsNullOrEmpty(txt_N.Text) || string.IsNullOrEmpty(txt_desde.Text) || string.IsNullOrEmpty(txt_hasta.Text))
            {
                MessageBox.Show("Una de las entradas está vacía.");
                return false;
            } else
            {
                N = int.Parse(txt_N.Text);
                desde = int.Parse(txt_desde.Text);
                hasta = int.Parse(txt_hasta.Text);
                return true;
            }

        }

        // Permite introducir solo valores numericos.
        private void txt_N_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_box_press(sender, e);
        }

        // Permite introducir solo valores numericos.
        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_box_press(sender, e);
        }

        // Permite introducir solo valores numericos.
        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_box_press(sender, e);
        }

        // Permite introducir solo valores numericos.
        private void txt_box_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
