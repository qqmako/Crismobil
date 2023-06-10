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
    public partial class VizComenzi : Form
    {
        Connect connect = new Connect();
        public VizComenzi()
        {
            InitializeComponent();
        }

        private void VizComenzi_Load(object sender, EventArgs e)
        {

            connect.DeschidereConectare();

            string query = "SELECT * FROM Afisare_Comanda;";
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

        private void dataGridView1_Resize(object sender, EventArgs e)
        {

        }

        private void VizComenzi_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            Insert_Comanda f = new Insert_Comanda();
            f.Show();
        }
    }
}
