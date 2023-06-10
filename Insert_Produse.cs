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
    public partial class Insert_Produse : Form
    {
        Connect connect = new Connect();
        public Insert_Produse()
        {
            InitializeComponent();
        }

        private void Insert_Produse_Load(object sender, EventArgs e)
        {
            Read_Categorii();
            Read_Culoarea();
        }


        private void Read_Categorii()
        {
            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Denumire_Categorie,Id_Categorie FROM Categorii;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    int idCategorii = reader.GetInt32(1); // idCategorii

                    string displayValue1 = value1;

                    comboBoxcategorii.Items.Add(new ComboBoxItem(displayValue1, idCategorii));
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

                    comboBoxculoarea.Items.Add(new ComboBoxItem(displayValue1, idColor));
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


        private void Insert_Produs()
        {

            try
            {
                int selectedCat = ((ComboBoxItem)comboBoxcategorii.SelectedItem).Value;
                int selectedCol = ((ComboBoxItem)comboBoxculoarea.SelectedItem).Value;

                SqlCommand command = new SqlCommand("Inert_Produse", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Denumire_Produs", SqlDbType.VarChar).Value = textBoxprodus.Text;
                command.Parameters.Add("@Categorie", SqlDbType.VarChar).Value = selectedCat;
                command.Parameters.Add("@Id_Culoare", SqlDbType.VarChar).Value = selectedCol;
                command.Parameters.Add("@Pret", SqlDbType.VarChar).Value = Convert.ToInt32(textBoxpret.Text);

                connect.DeschidereConectare();
                command.ExecuteNonQuery();
                connect.InchidereConectare();
                MessageBox.Show("Inserat cu Succes !");
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare !");
            }
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            Insert_Produs();
            Reset();
        }

        private void Reset(){
            textBoxprodus.Clear();
            comboBoxcategorii.ResetText();
            comboBoxculoarea.ResetText();
            textBoxpret.Clear();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
