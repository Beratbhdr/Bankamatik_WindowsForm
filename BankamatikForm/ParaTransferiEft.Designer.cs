namespace BankamatikForm
{
    partial class ParaTransferiEft
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
            this.txt_transferet = new System.Windows.Forms.Button();
            this.txt_transferedilecekmiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ıbanno = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_transferet
            // 
            this.txt_transferet.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transferet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_transferet.Location = new System.Drawing.Point(427, 216);
            this.txt_transferet.Name = "txt_transferet";
            this.txt_transferet.Size = new System.Drawing.Size(204, 50);
            this.txt_transferet.TabIndex = 0;
            this.txt_transferet.Text = "TRANSFER ET";
            this.txt_transferet.UseVisualStyleBackColor = true;
            this.txt_transferet.Click += new System.EventHandler(this.txt_transferet_Click);
            // 
            // txt_transferedilecekmiktar
            // 
            this.txt_transferedilecekmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_transferedilecekmiktar.Location = new System.Drawing.Point(427, 156);
            this.txt_transferedilecekmiktar.Name = "txt_transferedilecekmiktar";
            this.txt_transferedilecekmiktar.Size = new System.Drawing.Size(197, 26);
            this.txt_transferedilecekmiktar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "TRANSFER EDECEĞİNİZ MİKTAR :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "IBAN NO :";
            // 
            // txt_ıbanno
            // 
            this.txt_ıbanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ıbanno.Location = new System.Drawing.Point(427, 101);
            this.txt_ıbanno.Name = "txt_ıbanno";
            this.txt_ıbanno.Size = new System.Drawing.Size(197, 26);
            this.txt_ıbanno.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(34, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 71);
            this.button6.TabIndex = 20;
            this.button6.Text = "GERİYE DÖN";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ParaTransferiEft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ıbanno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_transferedilecekmiktar);
            this.Controls.Add(this.txt_transferet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ParaTransferiEft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaTransferiEft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_transferet;
        private System.Windows.Forms.TextBox txt_transferedilecekmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ıbanno;
        private System.Windows.Forms.Button button6;
    }
}