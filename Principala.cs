using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crismobil
{
    public partial class Principala : Form
    {
        public Principala()
        {
            InitializeComponent();
           
        }
        private void ascunde()
        {
            panelprincipal.Visible = false; 
    
        }
        private void afiseaza()
        {
            panelprincipal.Visible = true;

        }

        private Form active = null;
        private void openChild(Form child)
        {
            if (active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(child);
            panelprincipal.Tag = child;
            child.BringToFront();
            child.Show();

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

        private void buttoncomenzi_Click(object sender, EventArgs e)
        {
            afiseaza();
            openChild(new VizComenzi());
        }

        private void buttonproduse_Click(object sender, EventArgs e)
        {
            afiseaza();
            openChild(new VizProduse());
        }

        private void buttonangajati_Click(object sender, EventArgs e)
        {
            afiseaza();
            openChild(new VizAngajati());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ascunde();
        }
    }
}
