namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdrNegatif = new System.Windows.Forms.RadioButton();
            this.rdrPozitif = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdr7 = new System.Windows.Forms.RadioButton();
            this.rdr5 = new System.Windows.Forms.RadioButton();
            this.rdr3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdrNegatif);
            this.groupBox1.Controls.Add(this.rdrPozitif);
            this.groupBox1.Location = new System.Drawing.Point(216, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rdrNegatif
            // 
            this.rdrNegatif.AutoSize = true;
            this.rdrNegatif.Location = new System.Drawing.Point(6, 42);
            this.rdrNegatif.Name = "rdrNegatif";
            this.rdrNegatif.Size = new System.Drawing.Size(71, 17);
            this.rdrNegatif.TabIndex = 0;
            this.rdrNegatif.TabStop = true;
            this.rdrNegatif.Text = "NEGATİF";
            this.rdrNegatif.UseVisualStyleBackColor = true;
            // 
            // rdrPozitif
            // 
            this.rdrPozitif.AutoSize = true;
            this.rdrPozitif.Location = new System.Drawing.Point(6, 19);
            this.rdrPozitif.Name = "rdrPozitif";
            this.rdrPozitif.Size = new System.Drawing.Size(66, 17);
            this.rdrPozitif.TabIndex = 0;
            this.rdrPozitif.TabStop = true;
            this.rdrPozitif.Text = "POZİTİF";
            this.rdrPozitif.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdr7);
            this.groupBox2.Controls.Add(this.rdr5);
            this.groupBox2.Controls.Add(this.rdr3);
            this.groupBox2.Location = new System.Drawing.Point(216, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdr7
            // 
            this.rdr7.AutoSize = true;
            this.rdr7.Location = new System.Drawing.Point(3, 62);
            this.rdr7.Name = "rdr7";
            this.rdr7.Size = new System.Drawing.Size(31, 17);
            this.rdr7.TabIndex = 0;
            this.rdr7.TabStop = true;
            this.rdr7.Text = "7";
            this.rdr7.UseVisualStyleBackColor = true;
            // 
            // rdr5
            // 
            this.rdr5.AutoSize = true;
            this.rdr5.Location = new System.Drawing.Point(3, 39);
            this.rdr5.Name = "rdr5";
            this.rdr5.Size = new System.Drawing.Size(31, 17);
            this.rdr5.TabIndex = 0;
            this.rdr5.TabStop = true;
            this.rdr5.Text = "5";
            this.rdr5.UseVisualStyleBackColor = true;
            // 
            // rdr3
            // 
            this.rdr3.AutoSize = true;
            this.rdr3.Location = new System.Drawing.Point(3, 16);
            this.rdr3.Name = "rdr3";
            this.rdr3.Size = new System.Drawing.Size(31, 17);
            this.rdr3.TabIndex = 0;
            this.rdr3.TabStop = true;
            this.rdr3.Text = "3";
            this.rdr3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "AKTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(488, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 186);
            this.listBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 492);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdrNegatif;
        private System.Windows.Forms.RadioButton rdrPozitif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdr7;
        private System.Windows.Forms.RadioButton rdr5;
        private System.Windows.Forms.RadioButton rdr3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
    }
}

