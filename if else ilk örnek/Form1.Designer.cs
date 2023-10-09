namespace if_else_ilk_örnek
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
            this.btnDegistir = new System.Windows.Forms.Button();
            this.cbSari = new System.Windows.Forms.CheckBox();
            this.lblYapildi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(32, 12);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(126, 108);
            this.btnDegistir.TabIndex = 0;
            this.btnDegistir.Text = "Renk değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSari.Location = new System.Drawing.Point(32, 126);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(56, 24);
            this.cbSari.TabIndex = 2;
            this.cbSari.Text = "Sarı";
            this.cbSari.UseVisualStyleBackColor = true;
            // 
            // lblYapildi
            // 
            this.lblYapildi.AutoSize = true;
            this.lblYapildi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYapildi.Location = new System.Drawing.Point(12, 162);
            this.lblYapildi.Name = "lblYapildi";
            this.lblYapildi.Size = new System.Drawing.Size(196, 25);
            this.lblYapildi.TabIndex = 3;
            this.lblYapildi.Text = "Hangi renk yapıldı: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 234);
            this.Controls.Add(this.lblYapildi);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.btnDegistir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.CheckBox cbSari;
        private System.Windows.Forms.Label lblYapildi;
    }
}

