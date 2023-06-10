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
using System.Windows.Documents;
using System.Threading;

namespace Crismobil
{
    public partial class Insert_Angajati : Form
    {
        Connect connect = new Connect();
        public Insert_Angajati()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Angajati_Load(object sender, EventArgs e)
        {

        }


        private void Insert_Angajat()
        {



            //try
            //{
                connect.DeschidereConectare();

                SqlCommand command = new SqlCommand("Inert_Angajati", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id_User", SqlDbType.VarChar).Value = Get_Id_User();
                command.Parameters.Add("@Nume_Angajat", SqlDbType.VarChar).Value = textBoxnume.Text;
                command.Parameters.Add("@Pren_Angajat", SqlDbType.VarChar).Value = textBoxpren.Text ;
                command.Parameters.Add("@Nr_Tel", SqlDbType.VarChar).Value = textBoxnrtel.Text;
                command.Parameters.Add("@Postul", SqlDbType.VarChar).Value = textBoxpost.Text;

              
                command.ExecuteNonQuery();
                connect.InchidereConectare();
                //MessageBox.Show("Inserat cu Succes !");

        //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Eroare !");
            //}
}

        private void Insert_Utilizator()
        {
            string pass = " ";

            if (textBoxpass.Text == textBoxpass2.Text)
            {
                pass = textBoxpass.Text;
            }
            else
            {
                MessageBox.Show("Parolele nu coincid !");
                Reset();

            }
            
            //try
            //{
                connect.DeschidereConectare();

                ///////////////////////
                SqlCommand command = new SqlCommand("Inert_Utilizatori", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBoxlogin.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = pass;
                command.ExecuteNonQuery();
                ////////////////////
                ///
                connect.InchidereConectare();
                MessageBox.Show("Inserat cu Succes !");

        //}
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Eroare !");
        //    }
}


        private int Get_Id_User()
        {
            int lastInsertedId = 0;



            connect.DeschidereConectare();
                string query = "SELECT MAX( Id_User) FROM Utilizator;";

                using (SqlCommand command = new SqlCommand(query, connect.DeschidereConectare()))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        lastInsertedId = Convert.ToInt32(result);
                    }
                }
            

            return lastInsertedId;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBoxlogin.Clear();
            textBoxpass.Clear();
            textBoxpass2.Clear();
            textBoxnume.Clear();
            textBoxpren.Clear();
            textBoxnrtel.Clear();
            textBoxpost.Clear();

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                Insert_Utilizator();
                //Thread.Sleep(2000);
                Insert_Angajat();
                Reset();
                MessageBox.Show("Inserat cu Succes !");
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare !");
            }
        }
    }
}
