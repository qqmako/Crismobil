
namespace Crismobil
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.textBoxlog = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(194, 49);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(81, 27);
            this.txt.TabIndex = 0;
            this.txt.Text = "Logare";
            // 
            // txtlog
            // 
            this.txtlog.AutoSize = true;
            this.txtlog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlog.Location = new System.Drawing.Point(84, 129);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(74, 27);
            this.txtlog.TabIndex = 1;
            this.txtlog.Text = "Login:";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(76, 207);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(82, 27);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Parola:";
            // 
            // textBoxlog
            // 
            this.textBoxlog.Location = new System.Drawing.Point(186, 134);
            this.textBoxlog.Name = "textBoxlog";
            this.textBoxlog.Size = new System.Drawing.Size(185, 22);
            this.textBoxlog.TabIndex = 3;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(186, 212);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '#';
            this.textBoxpass.Size = new System.Drawing.Size(185, 22);
            this.textBoxpass.TabIndex = 4;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Transparent;
            this.buttonexit.BackgroundImage = global::Crismobil.Properties.Resources._4115230_cancel_close_cross_delete_114048;
            this.buttonexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonexit.Location = new System.Drawing.Point(413, 380);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(76, 59);
            this.buttonexit.TabIndex = 6;
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonlog
            // 
            this.buttonlog.BackColor = System.Drawing.Color.Transparent;
            this.buttonlog.BackgroundImage = global::Crismobil.Properties.Resources.login_square_arrow_button_outline_icon_icons_com_73220;
            this.buttonlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonlog.Location = new System.Drawing.Point(217, 284);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(87, 62);
            this.buttonlog.TabIndex = 5;
            this.buttonlog.UseVisualStyleBackColor = false;
            this.buttonlog.Click += new System.EventHandler(this.buttonlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 451);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonlog);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxlog);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Logare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txtlog;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.TextBox textBoxlog;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button buttonlog;
        private System.Windows.Forms.Button buttonexit;
    }
}

