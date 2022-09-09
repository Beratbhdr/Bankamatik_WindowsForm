namespace BankamatikForm
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txt_kartlı_text = new System.Windows.Forms.Button();
            this.txt_kartsız_text = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 445);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // txt_kartlı_text
            // 
            this.txt_kartlı_text.BackColor = System.Drawing.Color.White;
            this.txt_kartlı_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_kartlı_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_kartlı_text.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kartlı_text.ForeColor = System.Drawing.Color.Red;
            this.txt_kartlı_text.Location = new System.Drawing.Point(407, 213);
            this.txt_kartlı_text.Name = "txt_kartlı_text";
            this.txt_kartlı_text.Size = new System.Drawing.Size(264, 81);
            this.txt_kartlı_text.TabIndex = 0;
            this.txt_kartlı_text.Text = "KARTLI İŞLEMLER";
            this.txt_kartlı_text.UseVisualStyleBackColor = false;
            this.txt_kartlı_text.Click += new System.EventHandler(this.txt_kartlı_text_Click);
            // 
            // txt_kartsız_text
            // 
            this.txt_kartsız_text.BackColor = System.Drawing.Color.White;
            this.txt_kartsız_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_kartsız_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_kartsız_text.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kartsız_text.ForeColor = System.Drawing.Color.Red;
            this.txt_kartsız_text.Location = new System.Drawing.Point(50, 213);
            this.txt_kartsız_text.Name = "txt_kartsız_text";
            this.txt_kartsız_text.Size = new System.Drawing.Size(267, 81);
            this.txt_kartsız_text.TabIndex = 0;
            this.txt_kartsız_text.Text = "KARTSIZ İŞLEMLER";
            this.txt_kartsız_text.UseVisualStyleBackColor = false;
            this.txt_kartsız_text.Click += new System.EventHandler(this.txt_kartsız_text_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "BANKAMATİĞE HOŞGLDİNİZ.";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kartsız_text);
            this.Controls.Add(this.txt_kartlı_text);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "in";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button txt_kartlı_text;
        private System.Windows.Forms.Button txt_kartsız_text;
        private System.Windows.Forms.Label label1;
    }
}

