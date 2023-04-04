namespace TEKNİKSERVİS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.tbparca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.btnparcalist = new System.Windows.Forms.Button();
            this.btnparcarama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.SuspendLayout();
            // 
            // tbparca
            // 
            this.tbparca.Location = new System.Drawing.Point(325, 303);
            this.tbparca.Name = "tbparca";
            this.tbparca.Size = new System.Drawing.Size(172, 20);
            this.tbparca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARCA :";
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(-3, 2);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(710, 232);
            this.dataGridView8.TabIndex = 2;
            // 
            // btnparcalist
            // 
            this.btnparcalist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnparcalist.BackgroundImage")));
            this.btnparcalist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnparcalist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnparcalist.Location = new System.Drawing.Point(47, 266);
            this.btnparcalist.Name = "btnparcalist";
            this.btnparcalist.Size = new System.Drawing.Size(121, 90);
            this.btnparcalist.TabIndex = 4;
            this.btnparcalist.Text = "PARCA LİSTELE";
            this.btnparcalist.UseVisualStyleBackColor = true;
            this.btnparcalist.Click += new System.EventHandler(this.btnparcalist_Click);
            // 
            // btnparcarama
            // 
            this.btnparcarama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnparcarama.BackgroundImage")));
            this.btnparcarama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnparcarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnparcarama.Location = new System.Drawing.Point(564, 266);
            this.btnparcarama.Name = "btnparcarama";
            this.btnparcarama.Size = new System.Drawing.Size(112, 90);
            this.btnparcarama.TabIndex = 5;
            this.btnparcarama.Text = "PARCA ARAMA";
            this.btnparcarama.UseVisualStyleBackColor = true;
            this.btnparcarama.Click += new System.EventHandler(this.btnparcarama_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 456);
            this.Controls.Add(this.btnparcarama);
            this.Controls.Add(this.btnparcalist);
            this.Controls.Add(this.dataGridView8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbparca);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbparca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.Button btnparcalist;
        private System.Windows.Forms.Button btnparcarama;
    }
}