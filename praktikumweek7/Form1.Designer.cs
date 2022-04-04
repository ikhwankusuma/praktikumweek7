namespace praktikumweek7
{
    partial class praktikumweek7
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
            this.lbkalimat = new System.Windows.Forms.Label();
            this.lbhuruf = new System.Windows.Forms.Label();
            this.lbhasil = new System.Windows.Forms.Label();
            this.lboutput = new System.Windows.Forms.Label();
            this.lbmenjadi = new System.Windows.Forms.Label();
            this.tbkalimat = new System.Windows.Forms.TextBox();
            this.tbmenjadi = new System.Windows.Forms.TextBox();
            this.tbhuruf = new System.Windows.Forms.TextBox();
            this.btkonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbkalimat
            // 
            this.lbkalimat.AutoSize = true;
            this.lbkalimat.Location = new System.Drawing.Point(37, 41);
            this.lbkalimat.Name = "lbkalimat";
            this.lbkalimat.Size = new System.Drawing.Size(94, 13);
            this.lbkalimat.TabIndex = 0;
            this.lbkalimat.Text = "Masukkan Kalimat";
            // 
            // lbhuruf
            // 
            this.lbhuruf.AutoSize = true;
            this.lbhuruf.Location = new System.Drawing.Point(37, 104);
            this.lbhuruf.Name = "lbhuruf";
            this.lbhuruf.Size = new System.Drawing.Size(86, 13);
            this.lbhuruf.TabIndex = 1;
            this.lbhuruf.Text = "Masukkan Huruf";
            // 
            // lbhasil
            // 
            this.lbhasil.AutoSize = true;
            this.lbhasil.Location = new System.Drawing.Point(37, 203);
            this.lbhasil.Name = "lbhasil";
            this.lbhasil.Size = new System.Drawing.Size(30, 13);
            this.lbhasil.TabIndex = 2;
            this.lbhasil.Text = "Hasil";
            // 
            // lboutput
            // 
            this.lboutput.AutoSize = true;
            this.lboutput.Location = new System.Drawing.Point(128, 203);
            this.lboutput.Name = "lboutput";
            this.lboutput.Size = new System.Drawing.Size(49, 13);
            this.lboutput.TabIndex = 3;
            this.lboutput.Text = "..............";
            // 
            // lbmenjadi
            // 
            this.lbmenjadi.AutoSize = true;
            this.lbmenjadi.Location = new System.Drawing.Point(349, 104);
            this.lbmenjadi.Name = "lbmenjadi";
            this.lbmenjadi.Size = new System.Drawing.Size(44, 13);
            this.lbmenjadi.TabIndex = 4;
            this.lbmenjadi.Text = "Menjadi";
            // 
            // tbkalimat
            // 
            this.tbkalimat.Location = new System.Drawing.Point(153, 38);
            this.tbkalimat.Name = "tbkalimat";
            this.tbkalimat.Size = new System.Drawing.Size(338, 20);
            this.tbkalimat.TabIndex = 5;
            this.tbkalimat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbmenjadi
            // 
            this.tbmenjadi.Location = new System.Drawing.Point(413, 101);
            this.tbmenjadi.Name = "tbmenjadi";
            this.tbmenjadi.Size = new System.Drawing.Size(78, 20);
            this.tbmenjadi.TabIndex = 6;
            // 
            // tbhuruf
            // 
            this.tbhuruf.Location = new System.Drawing.Point(153, 101);
            this.tbhuruf.Name = "tbhuruf";
            this.tbhuruf.Size = new System.Drawing.Size(77, 20);
            this.tbhuruf.TabIndex = 7;
            // 
            // btkonversi
            // 
            this.btkonversi.Location = new System.Drawing.Point(187, 152);
            this.btkonversi.Name = "btkonversi";
            this.btkonversi.Size = new System.Drawing.Size(206, 23);
            this.btkonversi.TabIndex = 8;
            this.btkonversi.Text = "Konversi";
            this.btkonversi.UseVisualStyleBackColor = true;
            this.btkonversi.Click += new System.EventHandler(this.btkonversi_Click);
            // 
            // praktikumweek7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btkonversi);
            this.Controls.Add(this.tbhuruf);
            this.Controls.Add(this.tbmenjadi);
            this.Controls.Add(this.tbkalimat);
            this.Controls.Add(this.lbmenjadi);
            this.Controls.Add(this.lboutput);
            this.Controls.Add(this.lbhasil);
            this.Controls.Add(this.lbhuruf);
            this.Controls.Add(this.lbkalimat);
            this.Name = "praktikumweek7";
            this.Text = "praktikumweek7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkalimat;
        private System.Windows.Forms.Label lbhuruf;
        private System.Windows.Forms.Label lbhasil;
        private System.Windows.Forms.Label lboutput;
        private System.Windows.Forms.Label lbmenjadi;
        private System.Windows.Forms.TextBox tbkalimat;
        private System.Windows.Forms.TextBox tbmenjadi;
        private System.Windows.Forms.TextBox tbhuruf;
        private System.Windows.Forms.Button btkonversi;
    }
}

