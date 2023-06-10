
namespace Crismobil
{
    partial class Update_Angajati
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
            this.buttoncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.radioButtonnume = new System.Windows.Forms.RadioButton();
            this.radioButtonpren = new System.Windows.Forms.RadioButton();
            this.radioButtontel = new System.Windows.Forms.RadioButton();
            this.radioButtonpost = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxangajati = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.Gold;
            this.buttoncancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttoncancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.Location = new System.Drawing.Point(640, 0);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(121, 52);
            this.buttoncancel.TabIndex = 0;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonupdate);
            this.panel1.Controls.Add(this.buttoncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 52);
            this.panel1.TabIndex = 17;
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonupdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(0, 0);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(121, 52);
            this.buttonupdate.TabIndex = 1;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // radioButtonnume
            // 
            this.radioButtonnume.AutoSize = true;
            this.radioButtonnume.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonnume.Location = new System.Drawing.Point(34, 97);
            this.radioButtonnume.Name = "radioButtonnume";
            this.radioButtonnume.Size = new System.Drawing.Size(98, 28);
            this.radioButtonnume.TabIndex = 18;
            this.radioButtonnume.TabStop = true;
            this.radioButtonnume.Text = "Numele";
            this.radioButtonnume.UseVisualStyleBackColor = true;
            this.radioButtonnume.CheckedChanged += new System.EventHandler(this.radioButtonnume_CheckedChanged);
            // 
            // radioButtonpren
            // 
            this.radioButtonpren.AutoSize = true;
            this.radioButtonpren.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonpren.Location = new System.Drawing.Point(34, 155);
            this.radioButtonpren.Name = "radioButtonpren";
            this.radioButtonpren.Size = new System.Drawing.Size(123, 28);
            this.radioButtonpren.TabIndex = 19;
            this.radioButtonpren.TabStop = true;
            this.radioButtonpren.Text = "Prenumele";
            this.radioButtonpren.UseVisualStyleBackColor = true;
            this.radioButtonpren.CheckedChanged += new System.EventHandler(this.radioButtonpren_CheckedChanged);
            // 
            // radioButtontel
            // 
            this.radioButtontel.AutoSize = true;
            this.radioButtontel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtontel.Location = new System.Drawing.Point(34, 210);
            this.radioButtontel.Name = "radioButtontel";
            this.radioButtontel.Size = new System.Drawing.Size(148, 28);
            this.radioButtontel.TabIndex = 20;
            this.radioButtontel.TabStop = true;
            this.radioButtontel.Text = "Nr de Telefon";
            this.radioButtontel.UseVisualStyleBackColor = true;
            this.radioButtontel.CheckedChanged += new System.EventHandler(this.radioButtontel_CheckedChanged);
            // 
            // radioButtonpost
            // 
            this.radioButtonpost.AutoSize = true;
            this.radioButtonpost.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonpost.Location = new System.Drawing.Point(34, 267);
            this.radioButtonpost.Name = "radioButtonpost";
            this.radioButtonpost.Size = new System.Drawing.Size(84, 28);
            this.radioButtonpost.TabIndex = 21;
            this.radioButtonpost.TabStop = true;
            this.radioButtonpost.Text = "Postul";
            this.radioButtonpost.UseVisualStyleBackColor = true;
            this.radioButtonpost.CheckedChanged += new System.EventHandler(this.radioButtonpost_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Introduceti Valoarea Noua";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxangajati
            // 
            this.comboBoxangajati.FormattingEnabled = true;
            this.comboBoxangajati.Location = new System.Drawing.Point(232, 101);
            this.comboBoxangajati.Name = "comboBoxangajati";
            this.comboBoxangajati.Size = new System.Drawing.Size(189, 24);
            this.comboBoxangajati.TabIndex = 23;
            this.comboBoxangajati.Text = "Selectati Angajatul";
            this.comboBoxangajati.SelectedIndexChanged += new System.EventHandler(this.comboBoxangajati_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Selectati Angajatul";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Introduceti Valoarea Noua";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 24);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.Text = "Selectati Angajatul";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(473, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 22);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "Introduceti Valoarea Noua";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(232, 271);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(189, 24);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.Text = "Selectati Angajatul";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(473, 271);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 22);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "Introduceti Valoarea Noua";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Selectati campul ce trebuie modificat";
            // 
            // Update_Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxangajati);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonpost);
            this.Controls.Add(this.radioButtontel);
            this.Controls.Add(this.radioButtonpren);
            this.Controls.Add(this.radioButtonnume);
            this.Controls.Add(this.panel1);
            this.Name = "Update_Angajati";
            this.Text = "Update_Angajati";
            this.Load += new System.EventHandler(this.Update_Angajati_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.RadioButton radioButtonnume;
        private System.Windows.Forms.RadioButton radioButtonpren;
        private System.Windows.Forms.RadioButton radioButtontel;
        private System.Windows.Forms.RadioButton radioButtonpost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxangajati;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}