
namespace aplikaceZbozi
{
    partial class Registrace
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHeslo = new System.Windows.Forms.TextBox();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            this.btRegist = new System.Windows.Forms.Button();
            this.btPrihlas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHeslo2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(108, 47);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Heslo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Přihlašovací jméno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHeslo
            // 
            this.tbHeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHeslo.Location = new System.Drawing.Point(168, 44);
            this.tbHeslo.Name = "tbHeslo";
            this.tbHeslo.Size = new System.Drawing.Size(150, 26);
            this.tbHeslo.TabIndex = 9;
            this.tbHeslo.Text = "Heslo";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbJmeno.Location = new System.Drawing.Point(168, 12);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(150, 26);
            this.tbJmeno.TabIndex = 8;
            this.tbJmeno.Text = "Devvastor";
            // 
            // btRegist
            // 
            this.btRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRegist.Location = new System.Drawing.Point(168, 108);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(150, 30);
            this.btRegist.TabIndex = 7;
            this.btRegist.Text = "Registrovat";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // btPrihlas
            // 
            this.btPrihlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPrihlas.Location = new System.Drawing.Point(12, 108);
            this.btPrihlas.Name = "btPrihlas";
            this.btPrihlas.Size = new System.Drawing.Size(150, 30);
            this.btPrihlas.TabIndex = 6;
            this.btPrihlas.Text = "Zpět na přihlášení";
            this.btPrihlas.UseVisualStyleBackColor = true;
            this.btPrihlas.Click += new System.EventHandler(this.btPrihlas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(62, 79);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Heslo znovu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHeslo2
            // 
            this.tbHeslo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHeslo2.Location = new System.Drawing.Point(168, 76);
            this.tbHeslo2.Name = "tbHeslo2";
            this.tbHeslo2.Size = new System.Drawing.Size(150, 26);
            this.tbHeslo2.TabIndex = 12;
            this.tbHeslo2.Text = "Heslo";
            // 
            // Registrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHeslo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeslo);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.btPrihlas);
            this.Name = "Registrace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registrace_FormClosed);
            this.Load += new System.EventHandler(this.Registrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHeslo;
        private System.Windows.Forms.TextBox tbJmeno;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.Button btPrihlas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHeslo2;
    }
}