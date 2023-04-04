namespace TEKNİKSERVİS
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnbitiss = new System.Windows.Forms.Button();
            this.tbbitenis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlisstee = new System.Windows.Forms.Button();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbitiss
            // 
            this.btnbitiss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbitiss.BackgroundImage")));
            this.btnbitiss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbitiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbitiss.Location = new System.Drawing.Point(442, 251);
            this.btnbitiss.Name = "btnbitiss";
            this.btnbitiss.Size = new System.Drawing.Size(120, 72);
            this.btnbitiss.TabIndex = 0;
            this.btnbitiss.Text = "BİTEN İS ARAMA";
            this.btnbitiss.UseVisualStyleBackColor = true;
            this.btnbitiss.Click += new System.EventHandler(this.btnbitiss_Click);
            // 
            // tbbitenis
            // 
            this.tbbitenis.Location = new System.Drawing.Point(223, 284);
            this.tbbitenis.Name = "tbbitenis";
            this.tbbitenis.Size = new System.Drawing.Size(171, 20);
            this.tbbitenis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "BİTEN İS";
            // 
            // btnlisstee
            // 
            this.btnlisstee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlisstee.BackgroundImage")));
            this.btnlisstee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlisstee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlisstee.Location = new System.Drawing.Point(41, 251);
            this.btnlisstee.Name = "btnlisstee";
            this.btnlisstee.Size = new System.Drawing.Size(120, 72);
            this.btnlisstee.TabIndex = 3;
            this.btnlisstee.Text = "BİTEN LİSTE";
            this.btnlisstee.UseVisualStyleBackColor = true;
            this.btnlisstee.Click += new System.EventHandler(this.btnlisstee_Click);
            // 
            // dataGridView9
            // 
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(1, -3);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(573, 197);
            this.dataGridView9.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 370);
            this.Controls.Add(this.dataGridView9);
            this.Controls.Add(this.btnlisstee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbbitenis);
            this.Controls.Add(this.btnbitiss);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbitiss;
        private System.Windows.Forms.TextBox tbbitenis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlisstee;
        private System.Windows.Forms.DataGridView dataGridView9;
    }
}