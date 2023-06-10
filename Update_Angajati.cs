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
    public partial class Update_Angajati : Form
    {
        Connect connect = new Connect();
        public Update_Angajati()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Update_Angajati_Load(object sender, EventArgs e)
        {
            Visible_False();
        }

        private void Visible_False()
        {
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBoxangajati.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void radioButtonnume_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxangajati.Items.Clear();

            Read_Angajati();
            if ( radioButtonnume.Checked == true)
            {
                comboBoxangajati.Visible = true;
            }
            else
            {
                //comboBoxangajati.Visible = false;
                comboBoxangajati.ResetText();
              
                textBox1.Clear();
                Visible_False();

            }
        }

        private void comboBoxangajati_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ( comboBoxangajati.SelectedIndex > -1)
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
               
            }
        }

        private void radioButtonpren_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Read_Angajati();
            if (radioButtonpren.Checked == true)
            {
                comboBox1.Visible = true;
            }
            else
            {
               // comboBox1.Visible = false;
                comboBox1.ResetText();
               
                textBox2.Clear();
                Visible_False();
            }
        }

        private void radioButtontel_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Read_Angajati();
            if (radioButtontel.Checked == true)
            {
                comboBox2.Visible = true;
            }
            else
            {
                //comboBox2.Visible = false;
                comboBox2.ResetText();
               
                textBox3.Clear();
                Visible_False();
            }
        }

        private void radioButtonpost_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            Read_Angajati();
            if (radioButtonpost.Checked == true)
            {
                comboBox3.Visible = true;
            }
            else
            {
                //comboBox3.Visible = false;
                comboBox3.ResetText();
                
                textBox4.Clear();
                Visible_False();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > -1)
            {
                textBox2.Visible = true;
                
            }
            else
            {
                textBox2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
            }
        }


        private void Update_Nume()
        {
            int selectedAng = 0;
            string val = " ";
            string procedura = " ";

            try
            {
               

                if ( radioButtonnume.Checked == true)
                {
                     selectedAng = ((ComboBoxItem)comboBoxangajati.SelectedItem).Value;
                    val = textBox1.Text;
                    procedura = "Update_Nume";
                }
                if (radioButtonpren.Checked == true)
                {
                     selectedAng = ((ComboBoxItem)comboBox1.SelectedItem).Value;
                    val = textBox2.Text;
                    procedura = "Update_Pren";
                }
                if (radioButtontel.Checked == true)
                {
                     selectedAng = ((ComboBoxItem)comboBox2.SelectedItem).Value;
                    val = textBox3.Text;
                    procedura = "Update_Tel";
                }
                if (radioButtonpost.Checked == true)
                {
                     selectedAng = ((ComboBoxItem)comboBox3.SelectedItem).Value;
                    val = textBox4.Text;
                    procedura = "Update_Post";
                }



                SqlCommand command = new SqlCommand(procedura, connect.DeschidereConectare());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Id_User", SqlDbType.VarChar).Value = selectedAng;
                command.Parameters.Add("@Val", SqlDbType.VarChar).Value = val;
                

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

        private void Read_Angajati()
        {
            
            
            try
            {
                connect.DeschidereConectare();

                //comboBox Materiale
                SqlCommand command = new SqlCommand("SELECT Nume_Angajat, Pren_Angajat, Id_User FROM Angajati;", connect.DeschidereConectare());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value1 = reader.GetString(0); // Coloana1
                    string value2 = reader.GetString(1); // Coloana1
                    int idUser = reader.GetInt32(2); // Id_Color

                    string displayValue1 = value1 + "  " + value2;

                    if (radioButtonnume.Checked == true)
                    {
                        comboBoxangajati.Items.Add(new ComboBoxItem(displayValue1, idUser));
                    }
                    if (radioButtonpren.Checked == true)
                    {
                        comboBox1.Items.Add(new ComboBoxItem(displayValue1, idUser));
                    }
                    if (radioButtontel.Checked == true)
                    {
                        comboBox2.Items.Add(new ComboBoxItem(displayValue1, idUser));
                    }
                    if (radioButtonpost.Checked == true)
                    {
                        comboBox3.Items.Add(new ComboBoxItem(displayValue1, idUser));
                    }

                }
                reader.Close();
                connect.InchidereConectare();
            }
            catch (Exception)
            {

            }
        }

        private void Reset()
        {
            radioButtonnume.Checked = false;
            radioButtonpren.Checked = false;
            radioButtontel.Checked = false;
            radioButtonpost.Checked = false;
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

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            Update_Nume();
            Reset();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
        }
    }
}
