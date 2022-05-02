﻿using System;
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
        DataTable tabla_vendedor_2;
        DataTable tabla_vendedor_3;
        DataTable tabla_vendedor_4;

        public Entrada_Datos()
        {
            InitializeComponent();
        }

        private void Entrada_Datos_Load(object sender, EventArgs e)
        {
            btn_ver_tabla.Enabled = false;
            btn_ver_tabla_vendedor1.Enabled = false;
            btn_ver_tabla_vendedor2.Enabled = false;
            btn_ver_tabla_vendedor3.Enabled = false;
            btn_ver_tabla_vendedor4.Enabled = false;

            lbl_vendedor1.Text = "Comisión promedio Vendedor 1: $";
            lbl_vendedor2.Text = "Comisión promedio Vendedor 2: $";
            lbl_vendedor3.Text = "Comisión promedio Vendedor 3: $";
            lbl_vendedor4.Text = "Comisión promedio Vendedor 4: $";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            lbl_vendedor1.Text = "Comisión promedio Vendedor 1: $";
            lbl_vendedor2.Text = "Comisión promedio Vendedor 2: $";
            lbl_vendedor3.Text = "Comisión promedio Vendedor 3: $";
            lbl_vendedor4.Text = "Comisión promedio Vendedor 4: $";
            if (validar_y_asignar_campos())
            {
                tabla_vendedor_1 = new DataTable();
                generar_columnas(tabla_vendedor_1);
                tabla_vendedor_2 = new DataTable();
                generar_columnas(tabla_vendedor_2);
                tabla_vendedor_3 = new DataTable();
                generar_columnas(tabla_vendedor_3);
                tabla_vendedor_4 = new DataTable();
                generar_columnas(tabla_vendedor_4);

                btn_ver_tabla.Enabled = false;
                btn_ver_tabla_vendedor1.Enabled = false;
                btn_ver_tabla_vendedor2.Enabled = false;
                btn_ver_tabla_vendedor3.Enabled = false;
                btn_ver_tabla_vendedor4.Enabled = false;
                Simulacion_Montecarlo simulador = new Simulacion_Montecarlo(N);

                for (int i = desde; i <= hasta; i++)
                {
                    tabla_vendedor_1.ImportRow(simulador.vendedor_1.Rows[i-1]);
                    tabla_vendedor_2.ImportRow(simulador.vendedor_2.Rows[i - 1]);
                    tabla_vendedor_3.ImportRow(simulador.vendedor_3.Rows[i - 1]);
                    tabla_vendedor_4.ImportRow(simulador.vendedor_4.Rows[i - 1]);
                }

                tabla_vendedor_1.ImportRow(simulador.vendedor_1.Rows[N-1]);
                tabla_vendedor_2.ImportRow(simulador.vendedor_2.Rows[N - 1]);
                tabla_vendedor_3.ImportRow(simulador.vendedor_3.Rows[N - 1]);
                tabla_vendedor_4.ImportRow(simulador.vendedor_4.Rows[N - 1]);

                btn_ver_tabla.Enabled = true;
                btn_ver_tabla_vendedor1.Enabled = true;
                btn_ver_tabla_vendedor2.Enabled = true;
                btn_ver_tabla_vendedor3.Enabled = true;
                btn_ver_tabla_vendedor4.Enabled = true;

                //MessageBox.Show(simulador.vendedor_1.Rows[N - 1]["Comision total AC"].ToString());
                double pv1 = redondear(double.Parse(simulador.vendedor_1.Rows[N - 1]["Comision total AC"].ToString()) / N);
                double pv2 = redondear(double.Parse(simulador.vendedor_2.Rows[N - 1]["Comision total AC"].ToString()) / N);
                double pv3 = redondear(double.Parse(simulador.vendedor_3.Rows[N - 1]["Comision total AC"].ToString()) / N);
                double pv4 = redondear(double.Parse(simulador.vendedor_4.Rows[N - 1]["Comision total AC"].ToString()) / N);
                lbl_vendedor1.Text += pv1.ToString();
                lbl_vendedor2.Text += pv2.ToString();
                lbl_vendedor3.Text += pv3.ToString();
                lbl_vendedor4.Text += pv4.ToString();

            }
            
        }

        private void btn_ver_tabla_Click(object sender, EventArgs e)
        {
            mostrar_tabla_vendedor1();
            mostrar_tabla_vendedor2();
            mostrar_tabla_vendedor3();
            mostrar_tabla_vendedor4();
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

        private void btn_ver_tabla_vendedor1_Click(object sender, EventArgs e)
        {
            mostrar_tabla_vendedor1();
        }

        private void mostrar_tabla_vendedor1()
        {
            Tabla_Montecarlo tabla_montecarlo_form_v1 = new Tabla_Montecarlo(tabla_vendedor_1);
            tabla_montecarlo_form_v1.Text = tabla_montecarlo_form_v1.Text + " " + "Vendedor 1";
            tabla_montecarlo_form_v1.Show();
        }

        private void btn_ver_tabla_vendedor2_Click(object sender, EventArgs e)
        {
            mostrar_tabla_vendedor2();
        }

        private void mostrar_tabla_vendedor2()
        {
            Tabla_Montecarlo tabla_montecarlo_form_v2 = new Tabla_Montecarlo(tabla_vendedor_2);
            tabla_montecarlo_form_v2.Text = tabla_montecarlo_form_v2.Text + " " + "Vendedor 2";
            tabla_montecarlo_form_v2.Show();
        }

        private void btn_ver_tabla_vendedor3_Click(object sender, EventArgs e)
        {
            mostrar_tabla_vendedor3();
        }

        private void mostrar_tabla_vendedor3()
        {
            Tabla_Montecarlo tabla_montecarlo_form_v3 = new Tabla_Montecarlo(tabla_vendedor_3);
            tabla_montecarlo_form_v3.Text = tabla_montecarlo_form_v3.Text + " " + "Vendedor 3";
            tabla_montecarlo_form_v3.Show();
        }

        private void btn_ver_tabla_vendedor4_Click(object sender, EventArgs e)
        {
            mostrar_tabla_vendedor4();
        }

        private void mostrar_tabla_vendedor4()
        {
            Tabla_Montecarlo tabla_montecarlo_form_v4 = new Tabla_Montecarlo(tabla_vendedor_4);
            tabla_montecarlo_form_v4.Text = tabla_montecarlo_form_v4.Text + " " + "Vendedor 4";
            tabla_montecarlo_form_v4.Show();
        }

        private double redondear(double value)
        {
            return Math.Truncate(value * 100) / 100;
        }
    }
}
