
namespace String_ukol_1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_sifrovat = new System.Windows.Forms.Button();
            this.button_odsifrovat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label_sifra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button_sifrovat
            // 
            this.button_sifrovat.Location = new System.Drawing.Point(38, 107);
            this.button_sifrovat.Name = "button_sifrovat";
            this.button_sifrovat.Size = new System.Drawing.Size(101, 29);
            this.button_sifrovat.TabIndex = 2;
            this.button_sifrovat.Text = "Šifrovat";
            this.button_sifrovat.UseVisualStyleBackColor = true;
            this.button_sifrovat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_odsifrovat
            // 
            this.button_odsifrovat.Location = new System.Drawing.Point(145, 107);
            this.button_odsifrovat.Name = "button_odsifrovat";
            this.button_odsifrovat.Size = new System.Drawing.Size(101, 29);
            this.button_odsifrovat.TabIndex = 4;
            this.button_odsifrovat.Text = "Odšifrovat";
            this.button_odsifrovat.UseVisualStyleBackColor = true;
            this.button_odsifrovat.Click += new System.EventHandler(this.button_odsifrovat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text na šifrování:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Posun šifrování:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(30, 154);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 44);
            this.label.TabIndex = 7;
            this.label.Text = "Šifra:";
            // 
            // label_sifra
            // 
            this.label_sifra.AutoSize = true;
            this.label_sifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sifra.ForeColor = System.Drawing.Color.White;
            this.label_sifra.Location = new System.Drawing.Point(137, 154);
            this.label_sifra.Name = "label_sifra";
            this.label_sifra.Size = new System.Drawing.Size(34, 44);
            this.label_sifra.TabIndex = 8;
            this.label_sifra.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(346, 218);
            this.Controls.Add(this.label_sifra);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_odsifrovat);
            this.Controls.Add(this.button_sifrovat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(364, 265);
            this.MinimumSize = new System.Drawing.Size(364, 265);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String úkol 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_sifrovat;
        private System.Windows.Forms.Button button_odsifrovat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_sifra;
    }
}

