namespace MatematikFonskiyonları
{
    partial class Form1
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
            this.BtnMutlak = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnYukarı = new System.Windows.Forms.Button();
            this.BtnAsagi = new System.Windows.Forms.Button();
            this.BtnKok = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnTan = new System.Windows.Forms.Button();
            this.BtnPi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtnMax = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUs = new System.Windows.Forms.Button();
            this.BtnKalan = new System.Windows.Forms.Button();
            this.BtnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMutlak
            // 
            this.BtnMutlak.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMutlak.Location = new System.Drawing.Point(12, 150);
            this.BtnMutlak.Name = "BtnMutlak";
            this.BtnMutlak.Size = new System.Drawing.Size(117, 40);
            this.BtnMutlak.TabIndex = 0;
            this.BtnMutlak.Text = "Mutlak Değer";
            this.BtnMutlak.UseVisualStyleBackColor = false;
            this.BtnMutlak.Click += new System.EventHandler(this.BtnMutlak_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(104, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(352, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 413);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sonuç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // BtnYukarı
            // 
            this.BtnYukarı.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnYukarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYukarı.Location = new System.Drawing.Point(12, 213);
            this.BtnYukarı.Name = "BtnYukarı";
            this.BtnYukarı.Size = new System.Drawing.Size(117, 40);
            this.BtnYukarı.TabIndex = 6;
            this.BtnYukarı.Text = "Yuvarla(->)";
            this.BtnYukarı.UseVisualStyleBackColor = false;
            this.BtnYukarı.Click += new System.EventHandler(this.BtnYukarı_Click);
            // 
            // BtnAsagi
            // 
            this.BtnAsagi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAsagi.Location = new System.Drawing.Point(153, 213);
            this.BtnAsagi.Name = "BtnAsagi";
            this.BtnAsagi.Size = new System.Drawing.Size(117, 40);
            this.BtnAsagi.TabIndex = 7;
            this.BtnAsagi.Text = "Yuvarla(<-)";
            this.BtnAsagi.UseVisualStyleBackColor = false;
            this.BtnAsagi.Click += new System.EventHandler(this.BtnAsagi_Click);
            // 
            // BtnKok
            // 
            this.BtnKok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKok.Location = new System.Drawing.Point(153, 150);
            this.BtnKok.Name = "BtnKok";
            this.BtnKok.Size = new System.Drawing.Size(117, 40);
            this.BtnKok.TabIndex = 8;
            this.BtnKok.Text = "Kök Alma";
            this.BtnKok.UseVisualStyleBackColor = false;
            this.BtnKok.Click += new System.EventHandler(this.BtnKok_Click);
            // 
            // BtnSin
            // 
            this.BtnSin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSin.Location = new System.Drawing.Point(12, 284);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(117, 40);
            this.BtnSin.TabIndex = 9;
            this.BtnSin.Text = "Sinüs";
            this.BtnSin.UseVisualStyleBackColor = false;
            this.BtnSin.Click += new System.EventHandler(this.BtnSin_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCos.Location = new System.Drawing.Point(153, 284);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(117, 40);
            this.BtnCos.TabIndex = 10;
            this.BtnCos.Text = "Kosinüs";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnCos_Click);
            // 
            // BtnTan
            // 
            this.BtnTan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTan.Location = new System.Drawing.Point(12, 351);
            this.BtnTan.Name = "BtnTan";
            this.BtnTan.Size = new System.Drawing.Size(117, 40);
            this.BtnTan.TabIndex = 11;
            this.BtnTan.Text = "Tanjant";
            this.BtnTan.UseVisualStyleBackColor = false;
            this.BtnTan.Click += new System.EventHandler(this.BtnTan_Click);
            // 
            // BtnPi
            // 
            this.BtnPi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPi.Location = new System.Drawing.Point(153, 351);
            this.BtnPi.Name = "BtnPi";
            this.BtnPi.Size = new System.Drawing.Size(117, 40);
            this.BtnPi.TabIndex = 12;
            this.BtnPi.Text = "Pi";
            this.BtnPi.UseVisualStyleBackColor = false;
            this.BtnPi.Click += new System.EventHandler(this.BtnPi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(499, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(401, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sonuç:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(397, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sayı 1:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(489, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(397, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sayı 2:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(489, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 26);
            this.textBox3.TabIndex = 17;
            // 
            // BtnMax
            // 
            this.BtnMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMax.Location = new System.Drawing.Point(406, 213);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(117, 40);
            this.BtnMax.TabIndex = 19;
            this.BtnMax.Text = "Maksimum";
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(556, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Minimum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUs
            // 
            this.BtnUs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUs.Location = new System.Drawing.Point(406, 150);
            this.BtnUs.Name = "BtnUs";
            this.BtnUs.Size = new System.Drawing.Size(117, 40);
            this.BtnUs.TabIndex = 21;
            this.BtnUs.Text = "Üs Alma";
            this.BtnUs.UseVisualStyleBackColor = false;
            this.BtnUs.Click += new System.EventHandler(this.BtnUs_Click);
            // 
            // BtnKalan
            // 
            this.BtnKalan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKalan.Location = new System.Drawing.Point(556, 150);
            this.BtnKalan.Name = "BtnKalan";
            this.BtnKalan.Size = new System.Drawing.Size(117, 40);
            this.BtnKalan.TabIndex = 22;
            this.BtnKalan.Text = "Kalan Bulma";
            this.BtnKalan.UseVisualStyleBackColor = false;
            this.BtnKalan.Click += new System.EventHandler(this.BtnKalan_Click);
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLog.Location = new System.Drawing.Point(480, 284);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(117, 40);
            this.BtnLog.TabIndex = 23;
            this.BtnLog.Text = "Logaritma";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(715, 410);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.BtnKalan);
            this.Controls.Add(this.BtnUs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnPi);
            this.Controls.Add(this.BtnTan);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnKok);
            this.Controls.Add(this.BtnAsagi);
            this.Controls.Add(this.BtnYukarı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnMutlak);
            this.Name = "Form1";
            this.Text = "Matematiksel Fonskiyonlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMutlak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnYukarı;
        private System.Windows.Forms.Button BtnAsagi;
        private System.Windows.Forms.Button BtnKok;
        private System.Windows.Forms.Button BtnSin;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnTan;
        private System.Windows.Forms.Button BtnPi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnUs;
        private System.Windows.Forms.Button BtnKalan;
        private System.Windows.Forms.Button BtnLog;
    }
}

