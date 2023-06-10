
namespace Crismobil
{
    partial class Detalii_Comanda
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
            this.comboBoxcomenzi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxcategorii = new System.Windows.Forms.ComboBox();
            this.comboBoxprodus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDowncantitate = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantitate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxcomenzi
            // 
            this.comboBoxcomenzi.FormattingEnabled = true;
            this.comboBoxcomenzi.Location = new System.Drawing.Point(216, 93);
            this.comboBoxcomenzi.Name = "comboBoxcomenzi";
            this.comboBoxcomenzi.Size = new System.Drawing.Size(189, 24);
            this.comboBoxcomenzi.TabIndex = 0;
            this.comboBoxcomenzi.SelectedIndexChanged += new System.EventHandler(this.comboBoxcomenzi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectati nr comenzii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adaugati produsul";
            // 
            // comboBoxcategorii
            // 
            this.comboBoxcategorii.FormattingEnabled = true;
            this.comboBoxcategorii.Location = new System.Drawing.Point(216, 165);
            this.comboBoxcategorii.Name = "comboBoxcategorii";
            this.comboBoxcategorii.Size = new System.Drawing.Size(189, 24);
            this.comboBoxcategorii.TabIndex = 3;
            this.comboBoxcategorii.Text = "Selectati Categoria";
            this.comboBoxcategorii.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategorii_SelectedIndexChanged);
            // 
            // comboBoxprodus
            // 
            this.comboBoxprodus.FormattingEnabled = true;
            this.comboBoxprodus.Location = new System.Drawing.Point(426, 165);
            this.comboBoxprodus.Name = "comboBoxprodus";
            this.comboBoxprodus.Size = new System.Drawing.Size(189, 24);
            this.comboBoxprodus.TabIndex = 4;
            this.comboBoxprodus.Text = "Selectati Produsul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantitatea";
            // 
            // numericUpDowncantitate
            // 
            this.numericUpDowncantitate.Location = new System.Drawing.Point(216, 239);
            this.numericUpDowncantitate.Name = "numericUpDowncantitate";
            this.numericUpDowncantitate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowncantitate.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttoninsert);
            this.panel1.Controls.Add(this.buttoncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 52);
            this.panel1.TabIndex = 15;
            // 
            // buttoninsert
            // 
            this.buttoninsert.BackColor = System.Drawing.Color.YellowGreen;
            this.buttoninsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttoninsert.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninsert.Location = new System.Drawing.Point(0, 0);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(121, 52);
            this.buttoninsert.TabIndex = 1;
            this.buttoninsert.Text = "Insert";
            this.buttoninsert.UseVisualStyleBackColor = false;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.Gold;
            this.buttoncancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttoncancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.Location = new System.Drawing.Point(634, 0);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(121, 52);
            this.buttoncancel.TabIndex = 0;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // Detalii_Comanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDowncantitate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxprodus);
            this.Controls.Add(this.comboBoxcategorii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxcomenzi);
            this.Name = "Detalii_Comanda";
            this.Text = "Detalii_Comanda";
            this.Load += new System.EventHandler(this.Detalii_Comanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncantitate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxcomenzi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxcategorii;
        private System.Windows.Forms.ComboBox comboBoxprodus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDowncantitate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttoncancel;
    }
}