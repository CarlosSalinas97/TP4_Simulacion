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
        public DataTable vendedor_1;
        public DataTable vendedor_2;
        public DataTable vendedor_3;
        public DataTable vendedor_4;
        DataTable autos_vendidos;
        DataTable tipo_auto;
        DataTable comision_mediano;
        DataTable comision_lujo;

        public Simulacion_Montecarlo(int N)
        {
            this.N = N;
            vendedor_1 = new DataTable();
            vendedor_2 = new DataTable();
            vendedor_3 = new DataTable();
            vendedor_4 = new DataTable();
            autos_vendidos = probabilidad_autos_vendidos();
            tipo_auto = probabilidad_tipo_auto_vendido();
            comision_mediano = probabilidad_comision_mediano();
            comision_lujo = probabilidad_comision_lujo();
            generar_columnas_vendedores(vendedor_1);
            generar_simulacion(vendedor_1);
            generar_columnas_vendedores(vendedor_2);
            generar_simulacion(vendedor_2);
            generar_columnas_vendedores(vendedor_3);
            generar_simulacion(vendedor_3);
            generar_columnas_vendedores(vendedor_4);
            generar_simulacion(vendedor_4);
        }

        private void generar_columnas_vendedores(DataTable dataTable) {
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

        public void generar_simulacion(DataTable dataTable)
        {
            int com_total_anterior = 0;
            for (int i = 1; i <= N; i++)
            {
                double rnd_av = redondear(random.NextDouble());
                int autos_vendidos = buscar_autos_vendidos(rnd_av);
                double rnd_a1 = 0;
                double rnd_a2 = 0;
                double rnd_a3 = 0;
                double rnd_a4 = 0;
                double rnd_c1 = 0;
                double rnd_c2 = 0;
                double rnd_c3 = 0;
                double rnd_c4 = 0;
                string auto_1 = "";
                string auto_2 = "";
                string auto_3 = "";
                string auto_4 = "";
                int com_1 = 0;
                int com_2 = 0;
                int com_3 = 0;
                int com_4 = 0;

                if (autos_vendidos > 3)
                {
                    rnd_a4 = redondear(random.NextDouble());
                    auto_4 = buscar_tipo_auto(rnd_a4);
                    rnd_c4 = auto_4 == "Compacto" ? 0 : redondear(random.NextDouble());
                    com_4 = calcular_comision(auto_4, rnd_c4);
                }

                if (autos_vendidos > 2)
                {
                    rnd_a3 = redondear(random.NextDouble());
                    auto_3 = buscar_tipo_auto(rnd_a3);
                    rnd_c3 = auto_3 == "Compacto" ? 0 : redondear(random.NextDouble());
                    com_3 = calcular_comision(auto_3, rnd_c3);
                }

                if (autos_vendidos > 1)
                {
                    rnd_a2 = redondear(random.NextDouble());
                    auto_2 = buscar_tipo_auto(rnd_a2);
                    rnd_c2 = auto_2 == "Compacto" ? 0 : redondear(random.NextDouble());
                    com_2 = calcular_comision(auto_2, rnd_c2);
                }

                if (autos_vendidos > 0)
                {
                    rnd_a1 = redondear(random.NextDouble());
                    auto_1 = buscar_tipo_auto(rnd_a1);
                    rnd_c1 = auto_1 == "Compacto" ? 0 : redondear(random.NextDouble());
                    com_1 = calcular_comision(auto_1, rnd_c1);
                }

                int com_total = com_1 + com_2 + com_3 + com_4;
                int com_total_acumulada = com_total + com_total_anterior;
                com_total_anterior = com_total_acumulada;
                dataTable.Rows.Add(i, rnd_av, autos_vendidos,
                    rnd_a1 != 0 ? rnd_a1 : "",
                    auto_1,
                    rnd_a2 != 0 ? rnd_a2 : "",
                    auto_2,
                    rnd_a3 != 0 ? rnd_a3 : "",
                    auto_3,
                    rnd_a4 != 0 ? rnd_a4 : "",
                    auto_4,
                    rnd_c1 != 0 ? rnd_c1 : "",
                    com_1 != 0 ? com_1 : "",
                    rnd_c2 != 0 ? rnd_c2 : "",
                    com_2 != 0 ? com_2 : "",
                    rnd_c3 != 0 ? rnd_c3 : "",
                    com_3 != 0 ? com_3 : "",
                    rnd_c4 != 0 ? rnd_c4 : "",
                    com_4 != 0 ? com_4 : "",
                    com_total, com_total_acumulada);
            }
        }

        private int calcular_comision(string tipo_auto, double rnd)
        {
            if (tipo_auto == "Compacto")
            {
                return 250;
            } else if (tipo_auto == "Mediano")
            {
                return buscar_comision(rnd, comision_mediano);
            } else if (tipo_auto == "De lujo")
            {
                return buscar_comision(rnd, comision_lujo);
            }
            return -1;
        }

        private int buscar_autos_vendidos(double rnd)
        {
            foreach (DataRow row in autos_vendidos.Rows)
            {
                if (rnd >= double.Parse(row["intervalo desde"].ToString()) && rnd <= double.Parse(row["intervalo hasta"].ToString()))
                {
                    return int.Parse(row["Autos vendidos"].ToString());
                }
            }
            return -1;
        }

        private string buscar_tipo_auto(double rnd)
        {
            
            foreach (DataRow row in tipo_auto.Rows)
            {
                if (rnd >= double.Parse(row["intervalo desde"].ToString()) && rnd <= double.Parse(row["intervalo hasta"].ToString()))
                {
                    return row["Tipo"].ToString();
                }
            }
            return "ERROR";
        }

        private int buscar_comision(double rnd, DataTable dataTable)
        {

            foreach (DataRow row in dataTable.Rows)
            {
                if (rnd >= double.Parse(row["intervalo desde"].ToString()) && rnd <= double.Parse(row["intervalo hasta"].ToString()))
                {
                    return int.Parse(row["Comision"].ToString());
                }
            }
            return -1;
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
