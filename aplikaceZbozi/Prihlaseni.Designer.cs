
namespace aplikaceZbozi
{
    partial class Prihlaseni
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
            this.btPrihlas = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPrihlas
            // 
            this.btPrihlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPrihlas.Location = new System.Drawing.Point(10, 76);
            this.btPrihlas.Name = "btPrihlas";
            this.btPrihlas.Size = new System.Drawing.Size(150, 30);
            this.btPrihlas.TabIndex = 0;
            this.btPrihlas.Text = "Přihlásit se";
            this.btPrihlas.UseVisualStyleBackColor = true;
            this.btPrihlas.Click += new System.EventHandler(this.btPrihlas_Click);
            // 
            // btRegist
            // 
            this.btRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRegist.Location = new System.Drawing.Point(168, 76);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(150, 30);
            this.btRegist.TabIndex = 1;
            this.btRegist.Text = "Registrace";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // tbJmeno
            // 
            this.tbJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJmeno.Location = new System.Drawing.Point(168, 12);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(150, 26);
            this.tbJmeno.TabIndex = 2;
            this.tbJmeno.Text = "Devvastor";
            // 
            // tbHeslo
            // 
            this.tbHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHeslo.Location = new System.Drawing.Point(168, 44);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(150, 26);
            this.tbHeslo.TabIndex = 3;
            this.tbHeslo.Text = "Heslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Přihlašovací jméno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(106, 47);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Heslo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Prihlaseni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.btPrihlas);
            this.Name = "Prihlaseni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přihlášení";
            this.Load += new System.EventHandler(this.Prihlaseni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPrihlas;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

