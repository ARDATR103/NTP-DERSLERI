namespace veritabanı_bağlama
{
    partial class Form1
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
            this.datagridView1 = new System.Windows.Forms.DataGridView();
            this.btnogrtablosu = new System.Windows.Forms.Button();
            this.btnbolumtablosu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridView1
            // 
            this.datagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView1.Location = new System.Drawing.Point(95, 115);
            this.datagridView1.Name = "datagridView1";
            this.datagridView1.Size = new System.Drawing.Size(399, 184);
            this.datagridView1.TabIndex = 0;
            // 
            // btnogrtablosu
            // 
            this.btnogrtablosu.Location = new System.Drawing.Point(12, 12);
            this.btnogrtablosu.Name = "btnogrtablosu";
            this.btnogrtablosu.Size = new System.Drawing.Size(96, 23);
            this.btnogrtablosu.TabIndex = 1;
            this.btnogrtablosu.Text = "ogrenci tablosu";
            this.btnogrtablosu.UseVisualStyleBackColor = true;
            this.btnogrtablosu.Click += new System.EventHandler(this.btnogrtablosu_Click);
            // 
            // btnbolumtablosu
            // 
            this.btnbolumtablosu.Location = new System.Drawing.Point(379, 12);
            this.btnbolumtablosu.Name = "btnbolumtablosu";
            this.btnbolumtablosu.Size = new System.Drawing.Size(94, 23);
            this.btnbolumtablosu.TabIndex = 3;
            this.btnbolumtablosu.Text = "bolum tablosu";
            this.btnbolumtablosu.UseVisualStyleBackColor = true;
            this.btnbolumtablosu.Click += new System.EventHandler(this.btnbolumtablosu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 383);
            this.Controls.Add(this.btnbolumtablosu);
            this.Controls.Add(this.btnogrtablosu);
            this.Controls.Add(this.datagridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridView1;
        private System.Windows.Forms.Button btnogrtablosu;
        private System.Windows.Forms.Button btnbolumtablosu;
    }
}

