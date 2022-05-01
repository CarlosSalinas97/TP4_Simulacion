using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Tabla_Montecarlo : Form
    {
        DataTable vendedor1;
        public Tabla_Montecarlo(DataTable tabla_vendedor_1)
        {
            this.vendedor1 = tabla_vendedor_1;
            InitializeComponent();
        }

        private void Tabla_Montecarlo_Load(object sender, EventArgs e)
        {
            data_vendedor_1.DataSource = vendedor1;
        }
    }
}
