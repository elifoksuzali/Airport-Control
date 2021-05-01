namespace AirPortProject
{
    partial class Muayayene
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
            this.muayeneText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.butonEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.puanText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.muayeneTipitext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firmaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // muayeneText
            // 
            this.muayeneText.Location = new System.Drawing.Point(223, 71);
            this.muayeneText.Name = "muayeneText";
            this.muayeneText.Size = new System.Drawing.Size(100, 20);
            this.muayeneText.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "muayene no";
            // 
            // butonEkle
            // 
            this.butonEkle.Location = new System.Drawing.Point(195, 269);
            this.butonEkle.Name = "butonEkle";
            this.butonEkle.Size = new System.Drawing.Size(149, 23);
            this.butonEkle.TabIndex = 65;
            this.butonEkle.Text = "Ekle";
            this.butonEkle.UseVisualStyleBackColor = true;
            this.butonEkle.Click += new System.EventHandler(this.butonEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "firma adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 54;
            // 
            // puanText
            // 
            this.puanText.Location = new System.Drawing.Point(223, 142);
            this.puanText.Name = "puanText";
            this.puanText.Size = new System.Drawing.Size(100, 20);
            this.puanText.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "puan";
            // 
            // muayeneTipitext
            // 
            this.muayeneTipitext.Location = new System.Drawing.Point(223, 105);
            this.muayeneTipitext.Name = "muayeneTipitext";
            this.muayeneTipitext.Size = new System.Drawing.Size(100, 20);
            this.muayeneTipitext.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "muayene tipi";
            // 
            // firmaText
            // 
            this.firmaText.Location = new System.Drawing.Point(223, 189);
            this.firmaText.Name = "firmaText";
            this.firmaText.Size = new System.Drawing.Size(100, 20);
            this.firmaText.TabIndex = 68;
            // 
            // Muayayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firmaText);
            this.Controls.Add(this.muayeneText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.butonEkle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.puanText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.muayeneTipitext);
            this.Controls.Add(this.label1);
            this.Name = "Muayayene";
            this.Text = "Muayayene";
            this.Load += new System.EventHandler(this.Muayayene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox muayeneText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button butonEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox puanText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox muayeneTipitext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firmaText;
    }
}