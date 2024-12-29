using Ev_Sinif_Kütüphane;

namespace Emlak_Uygulama
{
    partial class Emlak_Giris_Ekrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciAdiTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // kullaniciAdiTB
            // 
            this.kullaniciAdiTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kullaniciAdiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTB.Location = new System.Drawing.Point(333, 113);
            this.kullaniciAdiTB.Name = "kullaniciAdiTB";
            this.kullaniciAdiTB.Size = new System.Drawing.Size(171, 45);
            this.kullaniciAdiTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "SIFRE:";
            // 
            // sifreTB
            // 
            this.sifreTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sifreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTB.Location = new System.Drawing.Point(333, 172);
            this.sifreTB.Name = "sifreTB";
            this.sifreTB.Size = new System.Drawing.Size(171, 45);
            this.sifreTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(333, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "GIRIS YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "ERBIN EMLAK GIRIS EKRANI";
            // 
            // Emlak_Giris_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifreTB);
            this.Controls.Add(this.kullaniciAdiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Emlak_Giris_Ekrani";
            this.ShowIcon = false;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciAdiTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}