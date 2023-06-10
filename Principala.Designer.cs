
namespace Crismobil
{
    partial class Principala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principala));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonraport = new System.Windows.Forms.Button();
            this.buttonangajati = new System.Windows.Forms.Button();
            this.buttonproduse = new System.Windows.Forms.Button();
            this.buttoncomenzi = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.buttonraport);
            this.panel1.Controls.Add(this.buttonangajati);
            this.panel1.Controls.Add(this.buttonproduse);
            this.panel1.Controls.Add(this.buttoncomenzi);
            this.panel1.Controls.Add(this.buttonexit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 619);
            this.panel1.TabIndex = 0;
            // 
            // buttonraport
            // 
            this.buttonraport.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonraport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonraport.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonraport.Location = new System.Drawing.Point(0, 281);
            this.buttonraport.Name = "buttonraport";
            this.buttonraport.Size = new System.Drawing.Size(290, 63);
            this.buttonraport.TabIndex = 5;
            this.buttonraport.Text = "Raport";
            this.buttonraport.UseVisualStyleBackColor = false;
            // 
            // buttonangajati
            // 
            this.buttonangajati.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonangajati.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonangajati.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonangajati.Location = new System.Drawing.Point(0, 218);
            this.buttonangajati.Name = "buttonangajati";
            this.buttonangajati.Size = new System.Drawing.Size(290, 63);
            this.buttonangajati.TabIndex = 4;
            this.buttonangajati.Text = "Angajati";
            this.buttonangajati.UseVisualStyleBackColor = false;
            this.buttonangajati.Click += new System.EventHandler(this.buttonangajati_Click);
            // 
            // buttonproduse
            // 
            this.buttonproduse.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonproduse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonproduse.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonproduse.Location = new System.Drawing.Point(0, 155);
            this.buttonproduse.Name = "buttonproduse";
            this.buttonproduse.Size = new System.Drawing.Size(290, 63);
            this.buttonproduse.TabIndex = 3;
            this.buttonproduse.Text = "Produse";
            this.buttonproduse.UseVisualStyleBackColor = false;
            this.buttonproduse.Click += new System.EventHandler(this.buttonproduse_Click);
            // 
            // buttoncomenzi
            // 
            this.buttoncomenzi.BackColor = System.Drawing.Color.DarkOrange;
            this.buttoncomenzi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttoncomenzi.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncomenzi.Location = new System.Drawing.Point(0, 92);
            this.buttoncomenzi.Name = "buttoncomenzi";
            this.buttoncomenzi.Size = new System.Drawing.Size(290, 63);
            this.buttoncomenzi.TabIndex = 2;
            this.buttoncomenzi.Text = "Comenzi";
            this.buttoncomenzi.UseVisualStyleBackColor = false;
            this.buttoncomenzi.Click += new System.EventHandler(this.buttoncomenzi_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonexit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonexit.Location = new System.Drawing.Point(0, 566);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(290, 53);
            this.buttonexit.TabIndex = 1;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Crismobil.Properties.Resources.logo2017;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelprincipal
            // 
            this.panelprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprincipal.Location = new System.Drawing.Point(290, 0);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(906, 619);
            this.panelprincipal.TabIndex = 1;
            // 
            // Principala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 619);
            this.Controls.Add(this.panelprincipal);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principala";
            this.Text = "Principala";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonraport;
        private System.Windows.Forms.Button buttonangajati;
        private System.Windows.Forms.Button buttonproduse;
        private System.Windows.Forms.Button buttoncomenzi;
        private System.Windows.Forms.Panel panelprincipal;
    }
}