
namespace Crismobil
{
    partial class VizAngajati
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttondelete);
            this.panel1.Controls.Add(this.buttonupdate);
            this.panel1.Controls.Add(this.buttoninsert);
            this.panel1.Controls.Add(this.buttonexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 62);
            this.panel1.TabIndex = 3;
            // 
            // buttonexit
            // 
            this.buttonexit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonexit.Location = new System.Drawing.Point(804, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(129, 62);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "button1";
            this.buttonexit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 509);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttondelete
            // 
            this.buttondelete.BackgroundImage = global::Crismobil.Properties.Resources.delete_remove_bin_icon_icons_com_72400;
            this.buttondelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttondelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttondelete.Location = new System.Drawing.Point(258, 0);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(129, 62);
            this.buttondelete.TabIndex = 5;
            this.buttondelete.UseVisualStyleBackColor = true;
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackgroundImage = global::Crismobil.Properties.Resources.twocirclingarrows_120593;
            this.buttonupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonupdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonupdate.Location = new System.Drawing.Point(129, 0);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(129, 62);
            this.buttonupdate.TabIndex = 4;
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttoninsert
            // 
            this.buttoninsert.BackgroundImage = global::Crismobil.Properties.Resources.database_add_insert_21836;
            this.buttoninsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttoninsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttoninsert.Location = new System.Drawing.Point(0, 0);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(129, 62);
            this.buttoninsert.TabIndex = 3;
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // VizAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VizAngajati";
            this.Text = "VizAngajati";
            this.Load += new System.EventHandler(this.VizAngajati_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
    }
}