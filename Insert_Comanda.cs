
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

namespace Crismobil
{
    public partial class Insert_Comanda : Form
    {
        Connect connect = new Connect();
        public Insert_Comanda()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Comanda_Load(object sender, EventArgs e)
        {
            try
            {
                //apeleaza afisarea angajati
                Read_Angajati();
                //apeleaza afisare materiale
                Read_Materiale();
                //apeleaza afisarea culoare
                Read_Culoarea();
            }
            catch(Exception)
            {

            }
           
        }

        private void Read_Angajati()
        {
            try
            {
                connect.DeschidereConectare();

                //comboBox angajati
                SqlCommand command = new SqlCommand("SELECT Nume_Angajat, Pren_Angajat, Id_User FROM Angajati;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    string value2 = reader.GetString(1); // Coloana2
                    int idUser = reader.GetInt32(2); // Id_User

                    string displayValue = value1 + " - " + value2;

                    comboBox1.Items.Add(new ComboBoxItem(displayValue, idUser));
                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch(Exception)
            {

            }
        }

        private void Read_Materiale()
        {
            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Denumire,Id_Material FROM Materiale;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    int idMaterial = reader.GetInt32(1); // Id_Material

                    string displayValue1 = value1;

                    comboBoxmaterial.Items.Add(new ComboBoxItem(displayValue1, idMaterial));
                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

            }
        }
        private void Read_Culoarea()
        {
            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Denumire_Color,Id_Color FROM Culori;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    int idColor = reader.GetInt32(1); // Id_Color

                    string displayValue1 = value1;

                    comboBoxcolor.Items.Add(new ComboBoxItem(displayValue1, idColor));
                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

            }
        }



        public class ComboBoxItem
        {
            public string DisplayValue { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string displayValue, int value)
            {
                DisplayValue = displayValue;
                Value = value;
            }

            public override string ToString()
            {
                return DisplayValue;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //afiseaza id-ulong numelui selectat
           //  int selectedIdUser = ((ComboBoxItem)comboBoxcolor.SelectedItem).Value;
            //MessageBox.Show(selectedIdUser.ToString());

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedItem = comboBox1.SelectedItem.ToString();
            
         
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dataCom1 = dateTimePicker1.Value;
                DateTime dataFin1 = dateTimePicker2.Value;
                string formatDorit = "yyyy-MM-dd";
                string dataCom = dataCom1.ToString(formatDorit);
                string dataFin = dataFin1.ToString(formatDorit);

                int selectedIdUser = ((ComboBoxItem)comboBox1.SelectedItem).Value;
                int selectedIdMaterial = ((ComboBoxItem)comboBoxmaterial.SelectedItem).Value;
                int selectedIdColor = ((ComboBoxItem)comboBoxcolor.SelectedItem).Value;



                SqlCommand command = new SqlCommand("Inert_Comanda", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Nume_Cl", SqlDbType.VarChar).Value = textBoxnume.Text;
                command.Parameters.Add("@Prenume_Cl", SqlDbType.VarChar).Value = textBoxprenume.Text;
                command.Parameters.Add("@Nr_Tel", SqlDbType.VarChar).Value = textBoxnr.Text;
                command.Parameters.Add("@Data_Comenzii", SqlDbType.VarChar).Value = dataCom;
                command.Parameters.Add("@Data_Finisarii", SqlDbType.VarChar).Value = dataFin;
                command.Parameters.Add("@Id_Material", SqlDbType.VarChar).Value = selectedIdMaterial;
                command.Parameters.Add("@Marimea", SqlDbType.VarChar).Value = textBoxmarimea.Text;
                command.Parameters.Add("@Culoarea", SqlDbType.VarChar).Value = selectedIdColor;
                command.Parameters.Add("@Angajat_Comanda", SqlDbType.VarChar).Value = selectedIdUser.ToString();
                command.Parameters.Add("@Pret", SqlDbType.VarChar).Value = Convert.ToInt32(textBoxpretul.Text);



                connect.DeschidereConectare();
                command.ExecuteNonQuery();
                connect.InchidereConectare();
                Reset();
                MessageBox.Show("Inserat cu Succes !");
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare !");
            }

        }


        private void Reset()
        {
            textBoxnume.Clear();
            textBoxprenume.Clear();
            textBoxnr.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            comboBox1.ResetText();
            textBoxpretul.Clear();
            comboBoxmaterial.ResetText();
            comboBoxcolor.ResetText();
            textBoxmarimea.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Detalii_Comanda a1 = new Detalii_Comanda();
            a1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
