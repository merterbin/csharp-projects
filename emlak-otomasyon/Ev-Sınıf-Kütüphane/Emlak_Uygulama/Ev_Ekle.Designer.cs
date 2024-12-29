namespace Emlak_Uygulama
{
    partial class Ev_Ekle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.semtCB = new System.Windows.Forms.ComboBox();
            this.yilTB = new System.Windows.Forms.TextBox();
            this.katTB = new System.Windows.Forms.TextBox();
            this.odaSayiTB = new System.Windows.Forms.TextBox();
            this.metreTB = new System.Windows.Forms.TextBox();
            this.satisCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.turCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "EV EKLE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Semt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yapım Yılı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Oda Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Metrekare:";
            // 
            // semtCB
            // 
            this.semtCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.semtCB.FormattingEnabled = true;
            this.semtCB.Items.AddRange(new object[] {
            "Merkez",
            "Almus",
            "Artova",
            "Başçiftlik",
            "Erbaa",
            "Niksar",
            "Pazar",
            "Reşadiye",
            "Sulusaray",
            "Turhal",
            "Yeşilyurt",
            "Zile"});
            this.semtCB.Location = new System.Drawing.Point(166, 80);
            this.semtCB.Name = "semtCB";
            this.semtCB.Size = new System.Drawing.Size(89, 28);
            this.semtCB.TabIndex = 2;
            // 
            // yilTB
            // 
            this.yilTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yilTB.Location = new System.Drawing.Point(164, 120);
            this.yilTB.Name = "yilTB";
            this.yilTB.Size = new System.Drawing.Size(90, 27);
            this.yilTB.TabIndex = 3;
            // 
            // katTB
            // 
            this.katTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katTB.Location = new System.Drawing.Point(164, 163);
            this.katTB.Name = "katTB";
            this.katTB.Size = new System.Drawing.Size(90, 27);
            this.katTB.TabIndex = 3;
            // 
            // odaSayiTB
            // 
            this.odaSayiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odaSayiTB.Location = new System.Drawing.Point(164, 206);
            this.odaSayiTB.Name = "odaSayiTB";
            this.odaSayiTB.Size = new System.Drawing.Size(90, 27);
            this.odaSayiTB.TabIndex = 4;
            // 
            // metreTB
            // 
            this.metreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metreTB.Location = new System.Drawing.Point(164, 249);
            this.metreTB.Name = "metreTB";
            this.metreTB.Size = new System.Drawing.Size(90, 27);
            this.metreTB.TabIndex = 3;
            // 
            // satisCB
            // 
            this.satisCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisCB.FormattingEnabled = true;
            this.satisCB.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.satisCB.Location = new System.Drawing.Point(164, 338);
            this.satisCB.Name = "satisCB";
            this.satisCB.Size = new System.Drawing.Size(89, 28);
            this.satisCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satıs Sekli:";
            // 
            // turCB
            // 
            this.turCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turCB.FormattingEnabled = true;
            this.turCB.Items.AddRange(new object[] {
            "Daire",
            "Müstakil",
            "Dubleks",
            "Villa",
            "Yazlık"});
            this.turCB.Location = new System.Drawing.Point(164, 294);
            this.turCB.Name = "turCB";
            this.turCB.Size = new System.Drawing.Size(89, 28);
            this.turCB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "EV EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ev_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metreTB);
            this.Controls.Add(this.odaSayiTB);
            this.Controls.Add(this.katTB);
            this.Controls.Add(this.yilTB);
            this.Controls.Add(this.semtCB);
            this.Controls.Add(this.turCB);
            this.Controls.Add(this.satisCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ev_Ekle";
            this.Text = "Ev_Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox semtCB;
        private System.Windows.Forms.TextBox yilTB;
        private System.Windows.Forms.TextBox katTB;
        private System.Windows.Forms.TextBox odaSayiTB;
        private System.Windows.Forms.TextBox metreTB;
        private System.Windows.Forms.ComboBox satisCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turCB;
        private System.Windows.Forms.Button button1;
    }
}