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
    public partial class VizAngajati : Form
    {
        Connect connect = new Connect();
        public VizAngajati()
        {
            InitializeComponent();
        }

        private void VizAngajati_Load(object sender, EventArgs e)
        {


            connect.DeschidereConectare();

            string query = "SELECT Nume_Angajat,Pren_Angajat,Nr_Tel,Postul FROM Angajati;";
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
            Insert_Angajati a = new Insert_Angajati();
            a.Show();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            Update_Angajati a = new Update_Angajati();
            a.Show();
        }
    }
}
