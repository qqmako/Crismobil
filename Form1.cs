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
    public partial class Form1 : Form
    {
        
        Connect connect = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            const string message = "Doriti sa inchideti ?";
            const string caption = "Iesire";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            //verifica daca este asa utilizator
            ExecutaProcedura();

        }

        

        public void ExecutaProcedura()
        {
            Principala p1 = new Principala();
            bool rezultat = false;
            try
            {
                connect.DeschidereConectare();

                using (SqlCommand command = new SqlCommand("VerificaUtilizator", connect.DeschidereConectare()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Adăugare parametrii procedurii
                    //command.Parameters.AddWithValue("@NumeUtilizator", textBoxlog.Text);
                    //command.Parameters.AddWithValue("@Parola", textBoxpass.Text);
                    //
                    command.Parameters.AddWithValue("@NumeUtilizator", "user1");
                    command.Parameters.AddWithValue("@Parola", "pass1");

                    // Executarea procedurii și obținerea rezultatului

                    rezultat = (bool)command.ExecuteScalar();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare de conectare cu baza de date ! \n Incercati din nou.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rezultat)
            {
                p1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola sau login gresit ! \n Incercati din nou.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






    }
}
