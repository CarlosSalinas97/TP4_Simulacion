using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Clases
{
    public class Simulacion_Montecarlo
    {
        Random random = new Random();
        private int N;
        private int desde;
        private int hasta;
        DataTable vendedor_1;
        DataTable vendedor_2;
        DataTable vendedor_3;
        DataTable vendedor_4;
        DataTable resumen_ventas;
        DataTable autos_vendidos;
        DataTable tipo_auto;
        DataTable comision_mediano;
        DataTable comision_lujo;

        public Simulacion_Montecarlo(int N, int desde, int hasta)
        {
            this.N = N;
            this.desde = desde;
            this.hasta = hasta;
            vendedor_1 = new DataTable();
            vendedor_2 = new DataTable();
            vendedor_3 = new DataTable();
            vendedor_4 = new DataTable();
            resumen_ventas = new DataTable();
            autos_vendidos = probabilidad_autos_vendidos();
            tipo_auto = probabilidad_tipo_auto_vendido();
            comision_mediano = probabilidad_comision_mediano();
            comision_lujo = probabilidad_comision_lujo();
        }

        private void generar_columnas_vendedores(DataTable dataTable) {
            dataTable.Columns.Add("Reloj", typeof(int));
            dataTable.Columns.Add("RND-AV", typeof(double));
            dataTable.Columns.Add("Autos vendidos", typeof(int));
            dataTable.Columns.Add("RND-A1", typeof(double));
            dataTable.Columns.Add("Auto 1", typeof(string));
            dataTable.Columns.Add("RND-A2", typeof(double));
            dataTable.Columns.Add("Auto 2", typeof(string));
            dataTable.Columns.Add("RND-A3", typeof(double));
            dataTable.Columns.Add("Auto 3", typeof(string));
            dataTable.Columns.Add("RND-A4", typeof(double));
            dataTable.Columns.Add("Auto 4", typeof(string));
            dataTable.Columns.Add("RND-C1", typeof(double));
            dataTable.Columns.Add("Comision 1", typeof(int));
            dataTable.Columns.Add("RND-C2", typeof(double));
            dataTable.Columns.Add("Comision 2", typeof(int));
            dataTable.Columns.Add("RND-C3", typeof(double));
            dataTable.Columns.Add("Comision 3", typeof(int));
            dataTable.Columns.Add("RND-C4", typeof(double));
            dataTable.Columns.Add("Comision 4", typeof(int));
            dataTable.Columns.Add("Comision total", typeof(int));
            dataTable.Columns.Add("Comision total AC", typeof(int));
        }

        public void generar_simulacion(DataTable dataTable)
        {
           for (int i = 1; i <= N; i++)
            {
                double rnd_av = redondear(random.NextDouble());
                int autos_vendidos = buscar_valor(rnd_av, dataTable);
                


                dataTable.Rows.Add(i);
            }
        }

        private int buscar_valor(double rnd, DataTable dataTable)
        {
            double value = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (rnd >= double.Parse(row["intervalo desde"].ToString()) && rnd <= double.Parse(row["intervalo hasta"].ToString()))
                {
                    return int.Parse(row["Autos vendidos"].ToString());
                }
            }
            return 999;
        }

        private DataTable probabilidad_autos_vendidos()
        {
            DataTable autos_vendidos = new DataTable();
            autos_vendidos.Columns.Add("Autos vendidos", typeof(int));
            autos_vendidos.Columns.Add("Probabilidad", typeof(double));
            autos_vendidos.Columns.Add("intervalo desde", typeof(double));
            autos_vendidos.Columns.Add("intervalo hasta", typeof(double));

            autos_vendidos.Rows.Add(0, 0.2, 0.00, 0.19);
            autos_vendidos.Rows.Add(1, 0.3, 0.20, 0.49);
            autos_vendidos.Rows.Add(2, 0.3, 0.50, 0.79);
            autos_vendidos.Rows.Add(3, 0.15, 0.80, 0.94);
            autos_vendidos.Rows.Add(4, 0.05, 0.95, 0.99);

            return autos_vendidos;
        }

        private DataTable probabilidad_tipo_auto_vendido()
        {
            DataTable tipo_auto_vendido = new DataTable();
            tipo_auto_vendido.Columns.Add("Tipo", typeof(string));
            tipo_auto_vendido.Columns.Add("Probabilidad", typeof(double));
            tipo_auto_vendido.Columns.Add("intervalo desde", typeof(double));
            tipo_auto_vendido.Columns.Add("intervalo hasta", typeof(double));

            tipo_auto_vendido.Rows.Add("Compacto", 0.5, 0.00, 0.49);
            tipo_auto_vendido.Rows.Add("Mediano", 0.35, 0.50, 0.84);
            tipo_auto_vendido.Rows.Add("De lujo", 0.15, 0.85, 0.99);

            return tipo_auto_vendido;
        }

        private DataTable probabilidad_comision_mediano()
        {
            DataTable comision_mediano = new DataTable();
            comision_mediano.Columns.Add("Comision", typeof(int));
            comision_mediano.Columns.Add("Probabilidad", typeof(double));
            comision_mediano.Columns.Add("intervalo desde", typeof(double));
            comision_mediano.Columns.Add("intervalo hasta", typeof(double));

            comision_mediano.Rows.Add(400, 0.4, 0.00, 0.39);
            comision_mediano.Rows.Add(500, 0.6, 0.40, 0.99);

            return comision_mediano;
        }

        private DataTable probabilidad_comision_lujo()
        {
            DataTable comision_lujo = new DataTable();
            comision_lujo.Columns.Add("Comision", typeof(int));
            comision_lujo.Columns.Add("Probabilidad", typeof(double));
            comision_lujo.Columns.Add("intervalo desde", typeof(double));
            comision_lujo.Columns.Add("intervalo hasta", typeof(double));

            comision_lujo.Rows.Add(1000, 0.35, 0.00, 0.34);
            comision_lujo.Rows.Add(1500, 0.4, 0.35, 0.74);
            comision_lujo.Rows.Add(2000, 0.25, 0.75, 0.99);

            return comision_lujo;
        }

        private double redondear(double value)
        {
            return Math.Truncate(value * 100) / 100;
        }
    }
}
