namespace TEKNİKSERVİS
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.Btnlis = new System.Windows.Forms.Button();
            this.Btnara = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbyapılanis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnlis
            // 
            this.Btnlis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnlis.BackgroundImage")));
            this.Btnlis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnlis.Location = new System.Drawing.Point(30, 238);
            this.Btnlis.Name = "Btnlis";
            this.Btnlis.Size = new System.Drawing.Size(141, 77);
            this.Btnlis.TabIndex = 0;
            this.Btnlis.Text = "YAPILACAK İŞ  LİSTESİ";
            this.Btnlis.UseVisualStyleBackColor = true;
            this.Btnlis.Click += new System.EventHandler(this.Btnlis_Click);
            // 
            // Btnara
            // 
            this.Btnara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnara.BackgroundImage")));
            this.Btnara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnara.Location = new System.Drawing.Point(414, 238);
            this.Btnara.Name = "Btnara";
            this.Btnara.Size = new System.Drawing.Size(142, 73);
            this.Btnara.TabIndex = 1;
            this.Btnara.Text = "ARAMA";
            this.Btnara.UseVisualStyleBackColor = true;
            this.Btnara.Click += new System.EventHandler(this.Btnara_Click);
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(0, 0);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(567, 178);
            this.dataGridView10.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "YAPILACAK İS";
            // 
            // tbyapılanis
            // 
            this.tbyapılanis.Location = new System.Drawing.Point(227, 269);
            this.tbyapılanis.Name = "tbyapılanis";
            this.tbyapılanis.Size = new System.Drawing.Size(141, 20);
            this.tbyapılanis.TabIndex = 4;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(568, 376);
            this.Controls.Add(this.tbyapılanis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.Btnara);
            this.Controls.Add(this.Btnlis);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnlis;
        private System.Windows.Forms.Button Btnara;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbyapılanis;
    }
}