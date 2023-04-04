namespace TEKNİKSERVİS
{
    partial class Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpersonell = new System.Windows.Forms.TextBox();
            this.tbpersonelad = new System.Windows.Forms.TextBox();
            this.tbpersonelsoyad = new System.Windows.Forms.TextBox();
            this.tbpersoneldahili = new System.Windows.Forms.TextBox();
            this.tbmaasno = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnpersonelgosterim = new System.Windows.Forms.Button();
            this.btnpersonelkayıt = new System.Windows.Forms.Button();
            this.btnpersonelsil = new System.Windows.Forms.Button();
            this.btnpersonellistele = new System.Windows.Forms.Button();
            this.btnpersonelguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "PersonelNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "PersonelAd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "PersonelSoyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(380, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "PersonelDahili";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(389, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Maas_No";
            // 
            // tbpersonell
            // 
            this.tbpersonell.Location = new System.Drawing.Point(181, 30);
            this.tbpersonell.Name = "tbpersonell";
            this.tbpersonell.Size = new System.Drawing.Size(159, 20);
            this.tbpersonell.TabIndex = 75;
            // 
            // tbpersonelad
            // 
            this.tbpersonelad.Location = new System.Drawing.Point(181, 87);
            this.tbpersonelad.Name = "tbpersonelad";
            this.tbpersonelad.Size = new System.Drawing.Size(159, 20);
            this.tbpersonelad.TabIndex = 76;
            // 
            // tbpersonelsoyad
            // 
            this.tbpersonelsoyad.Location = new System.Drawing.Point(181, 153);
            this.tbpersonelsoyad.Name = "tbpersonelsoyad";
            this.tbpersonelsoyad.Size = new System.Drawing.Size(159, 20);
            this.tbpersonelsoyad.TabIndex = 77;
            // 
            // tbpersoneldahili
            // 
            this.tbpersoneldahili.Location = new System.Drawing.Point(526, 34);
            this.tbpersoneldahili.Name = "tbpersoneldahili";
            this.tbpersoneldahili.Size = new System.Drawing.Size(159, 20);
            this.tbpersoneldahili.TabIndex = 78;
            // 
            // tbmaasno
            // 
            this.tbmaasno.Location = new System.Drawing.Point(526, 121);
            this.tbmaasno.Name = "tbmaasno";
            this.tbmaasno.Size = new System.Drawing.Size(159, 20);
            this.tbmaasno.TabIndex = 79;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 311);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(984, 179);
            this.dataGridView2.TabIndex = 80;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnpersonelgosterim
            // 
            this.btnpersonelgosterim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonelgosterim.BackgroundImage")));
            this.btnpersonelgosterim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonelgosterim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelgosterim.Location = new System.Drawing.Point(12, 217);
            this.btnpersonelgosterim.Name = "btnpersonelgosterim";
            this.btnpersonelgosterim.Size = new System.Drawing.Size(133, 86);
            this.btnpersonelgosterim.TabIndex = 81;
            this.btnpersonelgosterim.Text = "PERSONEL KAYIT GÖSTERİM";
            this.btnpersonelgosterim.UseVisualStyleBackColor = true;
            this.btnpersonelgosterim.Click += new System.EventHandler(this.btnpersonelgosterim_Click);
            // 
            // btnpersonelkayıt
            // 
            this.btnpersonelkayıt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonelkayıt.BackgroundImage")));
            this.btnpersonelkayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonelkayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelkayıt.Location = new System.Drawing.Point(422, 219);
            this.btnpersonelkayıt.Name = "btnpersonelkayıt";
            this.btnpersonelkayıt.Size = new System.Drawing.Size(150, 86);
            this.btnpersonelkayıt.TabIndex = 82;
            this.btnpersonelkayıt.Text = "PERSONEL KAYIT";
            this.btnpersonelkayıt.UseVisualStyleBackColor = true;
            this.btnpersonelkayıt.Click += new System.EventHandler(this.btnpersonelkayıt_Click);
            // 
            // btnpersonelsil
            // 
            this.btnpersonelsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonelsil.BackgroundImage")));
            this.btnpersonelsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonelsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelsil.Location = new System.Drawing.Point(634, 216);
            this.btnpersonelsil.Name = "btnpersonelsil";
            this.btnpersonelsil.Size = new System.Drawing.Size(150, 87);
            this.btnpersonelsil.TabIndex = 83;
            this.btnpersonelsil.Text = "SİL";
            this.btnpersonelsil.UseVisualStyleBackColor = true;
            this.btnpersonelsil.Click += new System.EventHandler(this.btnpersonelsil_Click);
            // 
            // btnpersonellistele
            // 
            this.btnpersonellistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonellistele.BackgroundImage")));
            this.btnpersonellistele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonellistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonellistele.Location = new System.Drawing.Point(867, 217);
            this.btnpersonellistele.Name = "btnpersonellistele";
            this.btnpersonellistele.Size = new System.Drawing.Size(129, 83);
            this.btnpersonellistele.TabIndex = 85;
            this.btnpersonellistele.Text = "LİSTELE";
            this.btnpersonellistele.UseVisualStyleBackColor = true;
            this.btnpersonellistele.Click += new System.EventHandler(this.btnpersonellistele_Click);
            // 
            // btnpersonelguncelle
            // 
            this.btnpersonelguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpersonelguncelle.BackgroundImage")));
            this.btnpersonelguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpersonelguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelguncelle.Location = new System.Drawing.Point(199, 216);
            this.btnpersonelguncelle.Name = "btnpersonelguncelle";
            this.btnpersonelguncelle.Size = new System.Drawing.Size(150, 87);
            this.btnpersonelguncelle.TabIndex = 86;
            this.btnpersonelguncelle.Text = "GUNCELLE";
            this.btnpersonelguncelle.UseVisualStyleBackColor = true;
            this.btnpersonelguncelle.Click += new System.EventHandler(this.btnpersonelguncelle_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 502);
            this.Controls.Add(this.btnpersonelguncelle);
            this.Controls.Add(this.btnpersonellistele);
            this.Controls.Add(this.btnpersonelsil);
            this.Controls.Add(this.btnpersonelkayıt);
            this.Controls.Add(this.btnpersonelgosterim);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tbmaasno);
            this.Controls.Add(this.tbpersoneldahili);
            this.Controls.Add(this.tbpersonelsoyad);
            this.Controls.Add(this.tbpersonelad);
            this.Controls.Add(this.tbpersonell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Personel";
            this.Text = "Personel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbpersonell;
        private System.Windows.Forms.TextBox tbpersonelad;
        private System.Windows.Forms.TextBox tbpersonelsoyad;
        private System.Windows.Forms.TextBox tbpersoneldahili;
        private System.Windows.Forms.TextBox tbmaasno;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnpersonelgosterim;
        private System.Windows.Forms.Button btnpersonelkayıt;
        private System.Windows.Forms.Button btnpersonelsil;
        private System.Windows.Forms.Button btnpersonellistele;
        private System.Windows.Forms.Button btnpersonelguncelle;
    }
}