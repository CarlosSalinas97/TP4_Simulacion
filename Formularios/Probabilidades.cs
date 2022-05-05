using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4.Formularios
{
    public partial class Probabilidades : Form
    {
        DataTable probabilidad_cant;
        DataTable probabilidad_tipo;
        DataTable probabilidad_com_med;
        DataTable probabilidad_com_delujo;
        Entrada_Datos entrada_datos;

        public Probabilidades(
            Entrada_Datos entrada_datos,
            DataTable probabilidad_cant,
            DataTable probabilidad_tipo,
            DataTable probabilidad_com_med,
            DataTable probabilidad_com_delujo)
        {
            InitializeComponent();
            this.entrada_datos = entrada_datos;
            this.probabilidad_cant = probabilidad_cant;
            this.probabilidad_tipo = probabilidad_tipo;
            this.probabilidad_com_med = probabilidad_com_med;
            this.probabilidad_com_delujo = probabilidad_com_delujo;
        }

        private void Probabilidades_Load(object sender, EventArgs e)
        {
            data_prob_cant.DataSource = probabilidad_cant;
            data_prob_tipo.DataSource = probabilidad_tipo;
            data_prob_med.DataSource = probabilidad_com_med;
            data_prob_delujo.DataSource = probabilidad_com_delujo;
        }

        private DataTable asignar_probabilidades(DataGridView dataGrid)
        {
            DataTable nueva_dt = new DataTable();
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                if (column.Visible)
                {
                    nueva_dt.Columns.Add(column.Name);
                }
            }

            double max_anterior = 0.0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                object[] cellValues = new object[dataGrid.Columns.Count];
                for (int i = 0; i < row.Cells.Count-1; i++)
                {
                    if (i < 2)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    else
                    {
                        if (cellValues[1] != null)
                        {
                            double probabilidad = double.Parse(cellValues[1].ToString()) / 100;
                            double min_intervalo = max_anterior == 0.0 ? 0.0 : max_anterior + 0.01;
                            cellValues[2] = redondear(min_intervalo);
                            double max_intervalo = min_intervalo + probabilidad - 0.01;
                            cellValues[3] = redondear(max_intervalo);
                            max_anterior = max_intervalo;
                        }
                    }
                }
                nueva_dt.Rows.Add(cellValues);
            }
            nueva_dt.Rows.RemoveAt(nueva_dt.Rows.Count - 1);
            return nueva_dt;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validar_probabilidades()
        {
            bool validar_cant = recorrer_dtg(data_prob_cant);
            bool validar_tipo = recorrer_dtg(data_prob_tipo);
            bool validar_com_med = recorrer_dtg(data_prob_med);
            bool validar_com_delujo = recorrer_dtg(data_prob_delujo);

            return validar_cant && validar_tipo && validar_com_med && validar_com_delujo;
        }

        private bool recorrer_dtg(DataGridView dataGridView)
        {
            int acumulador = 0;
            foreach (DataGridViewRow dataRow in dataGridView.Rows)
            {
                if (dataRow.Cells[1].Value != null)
                {
                    acumulador += int.Parse(dataRow.Cells[1].Value.ToString());
                } 
            }

            string nombre_tabla = "";
            switch (dataGridView.Name)
            {
                case "data_prob_cant":
                    nombre_tabla = "Cantidad de autos vendidos";
                    break;
                case "data_prob_tipo":
                    nombre_tabla = "Tipo de autos vendidos";
                    break;
                case "data_prob_delujo":
                    nombre_tabla = "Comisión autos de lujo";
                    break;
                case "data_prob_med":
                    nombre_tabla = "Comisión autos medianos";
                    break;
            }

            if (acumulador != 100)
            {
                MessageBox.Show("La probabilidad total de la tabla '" + nombre_tabla + "' es distinto a 100.");
                return false;
            } else
            {
                return true;
            }
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            probabilidad_cant = asignar_probabilidades(data_prob_cant);
            probabilidad_tipo = asignar_probabilidades(data_prob_tipo);
            probabilidad_com_med = asignar_probabilidades(data_prob_med);
            probabilidad_com_delujo = asignar_probabilidades(data_prob_delujo);
            data_prob_cant.DataSource = probabilidad_cant;
            data_prob_tipo.DataSource = probabilidad_tipo;
            data_prob_med.DataSource = probabilidad_com_med;
            data_prob_delujo.DataSource = probabilidad_com_delujo;
            if (validar_probabilidades())
            {
                MessageBox.Show("Se modificó con éxito las probabilidades.");
                this.entrada_datos.probabilidad_cant = probabilidad_cant;
                this.entrada_datos.probabilidad_tipo = probabilidad_tipo;
                this.entrada_datos.probabilidad_com_med = probabilidad_com_med;
                this.entrada_datos.probabilidad_com_delujo = probabilidad_com_delujo;
            }
        }

        private double redondear(double value)
        {
            return Math.Truncate(value * 100) / 100;
        }
    }
}
