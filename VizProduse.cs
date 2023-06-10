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

namespace Crismobil
{
    public partial class VizProduse : Form
    {
        Connect connect = new Connect();
        public VizProduse()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VizProduse_Load(object sender, EventArgs e)
        {
            connect.DeschidereConectare();

            string query = "SELECT * FROM Produsele;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect.DeschidereConectare());

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;



            //connect.InchidereConectare();
            //adapter.Dispose();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black; // culoarea textului
                column.DefaultCellStyle.BackColor = Color.White; // culoarea fundalului
            }
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            Insert_Produse a1 = new Insert_Produse();
            a1.Show();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            Update_Produse a = new Update_Produse();
            a.Show();
        }
    }
}
