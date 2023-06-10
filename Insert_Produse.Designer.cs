
namespace Crismobil
{
    partial class Insert_Produse
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
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxcategorii = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxprodus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxculoarea = new System.Windows.Forms.ComboBox();
            this.textBoxpret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.buttoncancel.Location = new System.Drawing.Point(544, 0);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(121, 52);
            this.buttoncancel.TabIndex = 0;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttoninsert);
            this.panel1.Controls.Add(this.buttoncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 52);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selectati Categoria:";
            // 
            // comboBoxcategorii
            // 
            this.comboBoxcategorii.FormattingEnabled = true;
            this.comboBoxcategorii.Location = new System.Drawing.Point(203, 84);
            this.comboBoxcategorii.Name = "comboBoxcategorii";
            this.comboBoxcategorii.Size = new System.Drawing.Size(197, 24);
            this.comboBoxcategorii.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Denumirea Produs:";
            // 
            // textBoxprodus
            // 
            this.textBoxprodus.Location = new System.Drawing.Point(203, 146);
            this.textBoxprodus.Name = "textBoxprodus";
            this.textBoxprodus.Size = new System.Drawing.Size(197, 22);
            this.textBoxprodus.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selectati Culoarea:";
            // 
            // comboBoxculoarea
            // 
            this.comboBoxculoarea.FormattingEnabled = true;
            this.comboBoxculoarea.Location = new System.Drawing.Point(203, 211);
            this.comboBoxculoarea.Name = "comboBoxculoarea";
            this.comboBoxculoarea.Size = new System.Drawing.Size(197, 24);
            this.comboBoxculoarea.TabIndex = 22;
            // 
            // textBoxpret
            // 
            this.textBoxpret.Location = new System.Drawing.Point(203, 273);
            this.textBoxpret.Name = "textBoxpret";
            this.textBoxpret.Size = new System.Drawing.Size(111, 22);
            this.textBoxpret.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pretul:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lei.";
            // 
            // Insert_Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxpret);
            this.Controls.Add(this.comboBoxculoarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxprodus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxcategorii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Insert_Produse";
            this.Text = "Insert_Produse";
            this.Load += new System.EventHandler(this.Insert_Produse_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxcategorii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxprodus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxculoarea;
        private System.Windows.Forms.TextBox textBoxpret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}