
namespace aplikaceZbozi
{
    partial class oknoSeZbozim
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

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oknoSeZbozim));
            this.lbNazev = new System.Windows.Forms.Label();
            this.tbPopis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMnozstviPopis = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbMnozstvi = new System.Windows.Forms.Label();
            this.btKoupit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNazev
            // 
            this.lbNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNazev.Location = new System.Drawing.Point(1, 4);
            this.lbNazev.Name = "lbNazev";
            this.lbNazev.Size = new System.Drawing.Size(250, 20);
            this.lbNazev.TabIndex = 0;
            this.lbNazev.Text = "WWWWWWWWWWWWWWW";
            this.lbNazev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPopis
            // 
            this.tbPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPopis.Location = new System.Drawing.Point(5, 31);
            this.tbPopis.Multiline = true;
            this.tbPopis.Name = "tbPopis";
            this.tbPopis.ReadOnly = true;
            this.tbPopis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPopis.Size = new System.Drawing.Size(242, 189);
            this.tbPopis.TabIndex = 1;
            this.tbPopis.Text = resources.GetString("tbPopis.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena:";
            // 
            // lbMnozstviPopis
            // 
            this.lbMnozstviPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMnozstviPopis.Location = new System.Drawing.Point(3, 243);
            this.lbMnozstviPopis.Name = "lbMnozstviPopis";
            this.lbMnozstviPopis.Size = new System.Drawing.Size(100, 23);
            this.lbMnozstviPopis.TabIndex = 3;
            this.lbMnozstviPopis.Text = "Zbývá na skladě:";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCena.Location = new System.Drawing.Point(109, 223);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(133, 20);
            this.lbCena.TabIndex = 4;
            this.lbCena.Text = "1 000 000 000 Kč";
            // 
            // lbMnozstvi
            // 
            this.lbMnozstvi.AutoSize = true;
            this.lbMnozstvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMnozstvi.Location = new System.Drawing.Point(109, 243);
            this.lbMnozstvi.Name = "lbMnozstvi";
            this.lbMnozstvi.Size = new System.Drawing.Size(27, 20);
            this.lbMnozstvi.TabIndex = 5;
            this.lbMnozstvi.Text = "20";
            // 
            // btKoupit
            // 
            this.btKoupit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKoupit.Location = new System.Drawing.Point(7, 269);
            this.btKoupit.Name = "btKoupit";
            this.btKoupit.Size = new System.Drawing.Size(231, 28);
            this.btKoupit.TabIndex = 6;
            this.btKoupit.Text = "Koupit";
            this.btKoupit.UseVisualStyleBackColor = true;
            // 
            // oknoSeZbozim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btKoupit);
            this.Controls.Add(this.lbMnozstvi);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbMnozstviPopis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPopis);
            this.Controls.Add(this.lbNazev);
            this.Name = "oknoSeZbozim";
            this.Size = new System.Drawing.Size(250, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNazev;
        private System.Windows.Forms.TextBox tbPopis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMnozstviPopis;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbMnozstvi;
        private System.Windows.Forms.Button btKoupit;
    }
}
