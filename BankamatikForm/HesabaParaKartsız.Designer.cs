namespace BankamatikForm
{
    partial class HesabaParaKartsız
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
            this.txt_yatırılıcaktutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parayatırkartsız = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_yatırılıcaktutar
            // 
            this.txt_yatırılıcaktutar.Location = new System.Drawing.Point(383, 174);
            this.txt_yatırılıcaktutar.Name = "txt_yatırılıcaktutar";
            this.txt_yatırılıcaktutar.Size = new System.Drawing.Size(166, 20);
            this.txt_yatırılıcaktutar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "YATIRILACAK TUTAR :";
            // 
            // txt_parayatırkartsız
            // 
            this.txt_parayatırkartsız.BackColor = System.Drawing.Color.White;
            this.txt_parayatırkartsız.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_parayatırkartsız.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parayatırkartsız.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_parayatırkartsız.Location = new System.Drawing.Point(488, 231);
            this.txt_parayatırkartsız.Name = "txt_parayatırkartsız";
            this.txt_parayatırkartsız.Size = new System.Drawing.Size(193, 48);
            this.txt_parayatırkartsız.TabIndex = 3;
            this.txt_parayatırkartsız.Text = "PARAYI YATIR";
            this.txt_parayatırkartsız.UseVisualStyleBackColor = false;
            this.txt_parayatırkartsız.Click += new System.EventHandler(this.txt_parayatırkartsız_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "HESAP NO :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(30, 321);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 83);
            this.button6.TabIndex = 20;
            this.button6.Text = "GERİYE DÖN";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // HesabaParaKartsız
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_yatırılıcaktutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_parayatırkartsız);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HesabaParaKartsız";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesabaParaKartsız";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_yatırılıcaktutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_parayatırkartsız;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
    }
}