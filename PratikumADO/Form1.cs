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

namespace PratikumADO
{
    public partial class Form1: Form
    {

        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-OMSO8ATA\\KIKI;Initial Catalog=DBAkademikADO;Integrated Security=True"
                );
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
