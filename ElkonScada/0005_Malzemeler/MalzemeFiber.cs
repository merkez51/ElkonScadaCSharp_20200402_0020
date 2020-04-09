using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace ElkonScada._0005_Malzemeler
{
    public partial class MalzemeFiber : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Firmalar;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public MalzemeFiber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FiberMalzeme_Load(object sender, EventArgs e)
        {

        }
    }
}
