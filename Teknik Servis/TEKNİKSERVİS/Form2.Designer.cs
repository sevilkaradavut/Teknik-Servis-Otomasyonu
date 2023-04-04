namespace TEKNİKSERVİS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnliste = new System.Windows.Forms.Button();
            this.btnıptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbadsoyad = new System.Windows.Forms.TextBox();
            this.btnarama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, -1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(965, 247);
            this.dataGridView4.TabIndex = 74;
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btngeri.BackgroundImage")));
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeri.Location = new System.Drawing.Point(36, 252);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(141, 75);
            this.btngeri.TabIndex = 75;
            this.btngeri.Text = "GERİ";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnliste
            // 
            this.btnliste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnliste.BackgroundImage")));
            this.btnliste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnliste.Location = new System.Drawing.Point(275, 253);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(134, 77);
            this.btnliste.TabIndex = 76;
            this.btnliste.Text = "TÜM LİSTE";
            this.btnliste.UseVisualStyleBackColor = true;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // btnıptal
            // 
            this.btnıptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnıptal.BackgroundImage")));
            this.btnıptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnıptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnıptal.Location = new System.Drawing.Point(761, 251);
            this.btnıptal.Name = "btnıptal";
            this.btnıptal.Size = new System.Drawing.Size(125, 78);
            this.btnıptal.TabIndex = 77;
            this.btnıptal.Text = "İPTAL";
            this.btnıptal.UseVisualStyleBackColor = true;
            this.btnıptal.Click += new System.EventHandler(this.btnıptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "MUSTERİ AD SOYAD ";
            // 
            // tbadsoyad
            // 
            this.tbadsoyad.Location = new System.Drawing.Point(398, 410);
            this.tbadsoyad.Name = "tbadsoyad";
            this.tbadsoyad.Size = new System.Drawing.Size(145, 20);
            this.tbadsoyad.TabIndex = 79;
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnarama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnarama.BackgroundImage")));
            this.btnarama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarama.Location = new System.Drawing.Point(522, 253);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(135, 74);
            this.btnarama.TabIndex = 80;
            this.btnarama.Text = "ARAMA";
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(964, 483);
            this.Controls.Add(this.btnarama);
            this.Controls.Add(this.tbadsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnıptal);
            this.Controls.Add(this.btnliste);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnliste;
        private System.Windows.Forms.Button btnıptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbadsoyad;
        private System.Windows.Forms.Button btnarama;
    }
}