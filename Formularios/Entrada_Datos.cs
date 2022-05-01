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
        DataTable tabla_vendedor_1;

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
                tabla_vendedor_1 = new DataTable();
                generar_columnas(tabla_vendedor_1);
                btn_ver_tabla.Enabled = false;
                Simulacion_Montecarlo simulador = new Simulacion_Montecarlo(N, desde, hasta);
                for (int i = desde; i <= hasta; i++)
                {
                    int rango = hasta - desde;
                    tabla_vendedor_1.ImportRow(simulador.vendedor_1.Rows[i-1]);
                }

                tabla_vendedor_1.ImportRow(simulador.vendedor_1.Rows[N-1]);
                btn_ver_tabla.Enabled = true;
            }
            
        }

        private void btn_ver_tabla_Click(object sender, EventArgs e)
        {
            Tabla_Montecarlo tabla_montecarlo_form = new Tabla_Montecarlo(tabla_vendedor_1);
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
                if (desde > N)
                {
                    MessageBox.Show("El rango mínimo 'desde' no puede ser mayor a la cantidad de semanas a simular.");
                    return false;
                }
                if (hasta < desde)
                {
                    MessageBox.Show("El rango máximo 'hasta' no puede ser menor a 'desde'.");
                    return false;
                }
                if (hasta > N)
                {
                    MessageBox.Show("El rango máximo 'hasta' no puede ser mayor a la cantidad de semanas a simular.");
                    return false;
                }
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

        private void generar_columnas(DataTable dataTable)
        {
            dataTable.Columns.Add("Reloj (semanas)", typeof(int));
            dataTable.Columns.Add("RND-AV", typeof(string));
            dataTable.Columns.Add("Autos vendidos", typeof(string));
            dataTable.Columns.Add("RND-A1", typeof(string));
            dataTable.Columns.Add("Auto 1", typeof(string));
            dataTable.Columns.Add("RND-A2", typeof(string));
            dataTable.Columns.Add("Auto 2", typeof(string));
            dataTable.Columns.Add("RND-A3", typeof(string));
            dataTable.Columns.Add("Auto 3", typeof(string));
            dataTable.Columns.Add("RND-A4", typeof(string));
            dataTable.Columns.Add("Auto 4", typeof(string));
            dataTable.Columns.Add("RND-C1", typeof(string));
            dataTable.Columns.Add("Comision 1", typeof(string));
            dataTable.Columns.Add("RND-C2", typeof(string));
            dataTable.Columns.Add("Comision 2", typeof(string));
            dataTable.Columns.Add("RND-C3", typeof(string));
            dataTable.Columns.Add("Comision 3", typeof(string));
            dataTable.Columns.Add("RND-C4", typeof(string));
            dataTable.Columns.Add("Comision 4", typeof(string));
            dataTable.Columns.Add("Comision total", typeof(int));
            dataTable.Columns.Add("Comision total AC", typeof(int));
        }
    }
}
