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

    public partial class Update_Produse : Form
    {
        Connect connect = new Connect();
        public Update_Produse()
        {
            InitializeComponent();
        }

        private void Update_Produse_Load(object sender, EventArgs e)
        {
            Visible_False();
        }


        private void Visible_False()
        {
            comboBox0.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBoxcat.Visible = false;
            comboBoxcolor.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }


        private void Read_Produse()
        {


            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Denumire_Produs,Id_Produs FROM Produse;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1                 
                    int idProd = reader.GetInt32(2); // Id_Produs

                    string displayValue1 = value1;

                    if (radioButtonden.Checked == true)
                    {
                        comboBox0.Items.Add(new ComboBoxItem(displayValue1, idProd));
                    }
                    if (radioButtoncat.Checked == true)
                    {
                        comboBox1.Items.Add(new ComboBoxItem(displayValue1, idProd));
                    }
                    if (radioButtoncolor.Checked == true)
                    {
                        comboBox2.Items.Add(new ComboBoxItem(displayValue1, idProd));
                    }
                    if (radioButtonpret.Checked == true)
                    {
                        comboBox3.Items.Add(new ComboBoxItem(displayValue1, idProd));
                    }

                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

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
                    int idProd = reader.GetInt32(2); // Id_Cat

                    string displayValue1 = value1;

                    
                        comboBoxcat.Items.Add(new ComboBoxItem(displayValue1, idProd));
                    

                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

            }
        }

        private void Read_Color()
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
                    int idProd = reader.GetInt32(2); // Id_Cat

                    string displayValue1 = value1;


                    comboBoxcat.Items.Add(new ComboBoxItem(displayValue1, idProd));


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

        private void radioButtonden_CheckedChanged(object sender, EventArgs e)
        {
            comboBox0.Items.Clear();
            Read_Produse();

            if (radioButtonden.Checked == true)
            {
                comboBox0.Visible = true;
            }
            else
            {
                //comboBoxangajati.Visible = false;
                comboBox0.ResetText();
                textBox1.Clear();
                Visible_False();

            }
        }

        private void radioButtoncat_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Read_Produse();
            Read_Categorii();

            if (radioButtoncat.Checked == true)
            {
                comboBox1.Visible = true;
            }
            else
            {
                //comboBoxangajati.Visible = false;
                comboBox1.ResetText();
                comboBoxcat.ResetText();
                comboBoxcat.Items.Clear();
                Visible_False();

            }
        }

        private void radioButtoncolor_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Read_Produse();
            Read_Color();

            if (radioButtoncolor.Checked == true)
            {
                comboBox2.Visible = true;
            }
            else
            {
                //comboBoxangajati.Visible = false;
                comboBox2.ResetText();
                comboBoxcolor.ResetText();
                comboBoxcolor.Items.Clear();
                Visible_False();

            }
        }

        private void radioButtonpret_CheckedChanged(object sender, EventArgs e)
        {

            comboBox3.Items.Clear();
            Read_Produse();

            if (radioButtonpret.Checked == true)
            {
                comboBox3.Visible = true;
            }
            else
            {
                comboBox3.ResetText();
                textBox2.Clear();
                Visible_False();

            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }


        private void Update_Produs()
        {
            int selectedAng = 0;
            string val = " ";
            string procedura = " ";
            int value = 0;

            try
            {


                if (radioButtonden.Checked == true)
                {
                    selectedAng = ((ComboBoxItem)comboBox0.SelectedItem).Value;
                    val = textBox1.Text;
                    procedura = "Update_Den";
                }
                if (radioButtoncat.Checked == true)
                {
                    selectedAng = ((ComboBoxItem)comboBox1.SelectedItem).Value;
                    value = ((ComboBoxItem)comboBoxcat.SelectedItem).Value;
                    procedura = "Update_Cat";
                }
                if (radioButtoncolor.Checked == true)
                {
                    selectedAng = ((ComboBoxItem)comboBox2.SelectedItem).Value;
                    value = ((ComboBoxItem)comboBoxcolor.SelectedItem).Value;
                    procedura = "Update_Color";
                }
                if (radioButtonpret.Checked == true)
                {
                    selectedAng = ((ComboBoxItem)comboBox3.SelectedItem).Value;
                    value = Convert.ToInt32(textBox2.Text);
                    procedura = "Update_Pret";
                }



                SqlCommand command = new SqlCommand(procedura, connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;
                if (radioButtonden.Checked == true)
                {
                    command.Parameters.Add("@Id_Produs", SqlDbType.VarChar).Value = selectedAng;
                    command.Parameters.Add("@Val", SqlDbType.VarChar).Value = val;
                }
                else
                {
                    command.Parameters.Add("@Id_Produs", SqlDbType.VarChar).Value = selectedAng;
                    command.Parameters.Add("@Val", SqlDbType.VarChar).Value = value;
                }

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

        private void Reset()
        {
            radioButtoncat.Checked = false;
            radioButtonden.Checked = false;
            radioButtoncolor.Checked = false;
            radioButtonpret.Checked = false;
        }

            private void buttonupdate_Click(object sender, EventArgs e)
        {
            Update_Produs();
            Reset();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
