
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
    public partial class Detalii_Comanda : Form
    {
        Connect connect = new Connect();
        public Detalii_Comanda()
        {
            InitializeComponent();
        }


        private void Detalii_Comanda_Load(object sender, EventArgs e)
        {
            comboBoxprodus.Visible = false;

            Read_Comenzi();
            Read_Categorii();
           
        }

        private void Read_Comenzi()
        {
            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Id_Comanda FROM Comanda;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int idComanda = reader.GetInt32(0); // idComanda

                    string displayValue1 = idComanda.ToString();

                    comboBoxcomenzi.Items.Add(new ComboBoxItem(displayValue1, idComanda));
                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception ){

            }
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
        private void Read_Produse()
        {
            int selectedCat = 0;

           
                selectedCat = ((ComboBoxItem)comboBoxcategorii.SelectedItem).Value;


                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Denumire_Produs,Id_Produs FROM Produse WHERE Categorie = " + selectedCat, connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    int idProd = reader.GetInt32(1); // idProd

                    string displayValue1 = value1;

                    comboBoxprodus.Items.Add(new ComboBoxItem(displayValue1, idProd));
                }
                reader.Close();
                connect.InchidereConectare();
            
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


        private void Insert_Continutul_Comenzii()
        {

            try
            {
                int selectedComanda = ((ComboBoxItem)comboBoxcomenzi.SelectedItem).Value;

                SqlCommand command = new SqlCommand("Inert_Continut_Comanda", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id_Comanda", SqlDbType.VarChar).Value = selectedComanda;
                command.Parameters.Add("@Cantitatea", SqlDbType.VarChar).Value = Convert.ToInt32(numericUpDowncantitate.Value);

                connect.DeschidereConectare();
                command.ExecuteNonQuery();
                connect.InchidereConectare();
            }
            catch(Exception)
            {

            }
        }

        private void Inert_Continut_Prod()
        {
            try
            {
                connect.DeschidereConectare();
                int idContinut = 0;
                //comboBox Materiale
                SqlCommand command1 = new SqlCommand("SELECT Id_Continutul FROM Continut_Produse;", connect.DeschidereConectare());
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {

                    idContinut = reader1.GetInt32(0); // idComanda

                }
                reader1.Close();
                connect.InchidereConectare()
    ;
                int selectedProdus = ((ComboBoxItem)comboBoxprodus.SelectedItem).Value;

                SqlCommand command = new SqlCommand("Inert_Continut_Prod", connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id_Continutul", SqlDbType.VarChar).Value = idContinut;
                command.Parameters.Add("@Id_Produs", SqlDbType.VarChar).Value = selectedProdus;

                connect.DeschidereConectare();
                command.ExecuteNonQuery();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void comboBoxcomenzi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            try
            {
                Insert_Continutul_Comenzii();
                Inert_Continut_Prod();
                Reset();
                MessageBox.Show("Inserat cu succes !");
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxcategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxprodus.Items.Clear();
                comboBoxprodus.ResetText();
                if (comboBoxcategorii.SelectedIndex > -1)
                {
                    comboBoxprodus.Visible = true;
                    Read_Produse();
                }
            }
            catch (Exception)
            {

            }
        }
        private void Reset()
        {
            comboBoxcomenzi.ResetText();
            comboBoxcategorii.ResetText();
            comboBoxprodus.ResetText();
            numericUpDowncantitate.ResetText();
        }

    }
}
