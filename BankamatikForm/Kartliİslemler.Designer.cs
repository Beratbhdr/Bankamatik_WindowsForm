namespace BankamatikForm
{
    partial class Kartsifregiris
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
            this.txt_giris2kartlı = new System.Windows.Forms.Button();
            this.txt_kartsifresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_giris2kartlı
            // 
            this.txt_giris2kartlı.BackColor = System.Drawing.Color.White;
            this.txt_giris2kartlı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_giris2kartlı.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giris2kartlı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_giris2kartlı.Location = new System.Drawing.Point(207, 232);
            this.txt_giris2kartlı.Name = "txt_giris2kartlı";
            this.txt_giris2kartlı.Size = new System.Drawing.Size(294, 43);
            this.txt_giris2kartlı.TabIndex = 0;
            this.txt_giris2kartlı.Text = "GİRİŞ\r\n";
            this.txt_giris2kartlı.UseVisualStyleBackColor = false;
            this.txt_giris2kartlı.Click += new System.EventHandler(this.txt_giris2kartlı_Click);
            // 
            // txt_kartsifresi
            // 
            this.txt_kartsifresi.BackColor = System.Drawing.Color.White;
            this.txt_kartsifresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kartsifresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_kartsifresi.Location = new System.Drawing.Point(359, 191);
            this.txt_kartsifresi.Name = "txt_kartsifresi";
            this.txt_kartsifresi.Size = new System.Drawing.Size(175, 22);
            this.txt_kartsifresi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "KART ŞİFRENİZ :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(500, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 83);
            this.button6.TabIndex = 20;
            this.button6.Text = "GERİYE DÖN";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Kartsifregiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kartsifresi);
            this.Controls.Add(this.txt_giris2kartlı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kartsifregiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kartliİslemler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_giris2kartlı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kartsifresi;
        private System.Windows.Forms.Button button6;
    }
}