
namespace aplikaceZbozi
{
    partial class Editace
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
            this.listZbozi = new System.Windows.Forms.ListBox();
            this.tbNazevZbozi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPopisZbozi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCenaZbozi = new System.Windows.Forms.NumericUpDown();
            this.nudMnozstviZbozi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKategorieNazev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNadKategorieKategorie = new System.Windows.Forms.Label();
            this.lbNadKategorieZbozi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btUlozitKategorii = new System.Windows.Forms.Button();
            this.btUlozitZbozi = new System.Windows.Forms.Button();
            this.btOdstranKategorii = new System.Windows.Forms.Button();
            this.btOdstranZbozi = new System.Windows.Forms.Button();
            this.cbxUpravaKategorie = new System.Windows.Forms.CheckBox();
            this.cbxUpravaZbozi = new System.Windows.Forms.CheckBox();
            this.stromKategorii = new aplikaceZbozi.StromKategorii();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaZbozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMnozstviZbozi)).BeginInit();
            this.SuspendLayout();
            // 
            // listZbozi
            // 
            this.listZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listZbozi.FormattingEnabled = true;
            this.listZbozi.ItemHeight = 20;
            this.listZbozi.Location = new System.Drawing.Point(251, 12);
            this.listZbozi.Name = "listZbozi";
            this.listZbozi.Size = new System.Drawing.Size(182, 384);
            this.listZbozi.TabIndex = 3;
            this.listZbozi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listZbozi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listZbozi_MouseDown);
            // 
            // tbNazevZbozi
            // 
            this.tbNazevZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNazevZbozi.Location = new System.Drawing.Point(873, 62);
            this.tbNazevZbozi.MaxLength = 15;
            this.tbNazevZbozi.Name = "tbNazevZbozi";
            this.tbNazevZbozi.Size = new System.Drawing.Size(286, 26);
            this.tbNazevZbozi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(810, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Název:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(810, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Popis:";
            // 
            // tbPopisZbozi
            // 
            this.tbPopisZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPopisZbozi.Location = new System.Drawing.Point(873, 91);
            this.tbPopisZbozi.MaxLength = 255;
            this.tbPopisZbozi.Multiline = true;
            this.tbPopisZbozi.Name = "tbPopisZbozi";
            this.tbPopisZbozi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPopisZbozi.Size = new System.Drawing.Size(286, 172);
            this.tbPopisZbozi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(810, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(810, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zbývá na skladě:";
            // 
            // nudCenaZbozi
            // 
            this.nudCenaZbozi.Location = new System.Drawing.Point(943, 272);
            this.nudCenaZbozi.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudCenaZbozi.Name = "nudCenaZbozi";
            this.nudCenaZbozi.Size = new System.Drawing.Size(216, 20);
            this.nudCenaZbozi.TabIndex = 12;
            this.nudCenaZbozi.ThousandsSeparator = true;
            // 
            // nudMnozstviZbozi
            // 
            this.nudMnozstviZbozi.Location = new System.Drawing.Point(943, 304);
            this.nudMnozstviZbozi.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudMnozstviZbozi.Name = "nudMnozstviZbozi";
            this.nudMnozstviZbozi.Size = new System.Drawing.Size(216, 20);
            this.nudMnozstviZbozi.TabIndex = 13;
            this.nudMnozstviZbozi.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(439, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Název:";
            // 
            // tbKategorieNazev
            // 
            this.tbKategorieNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKategorieNazev.Location = new System.Drawing.Point(502, 65);
            this.tbKategorieNazev.Name = "tbKategorieNazev";
            this.tbKategorieNazev.Size = new System.Drawing.Size(286, 26);
            this.tbKategorieNazev.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(544, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Úprava kategorie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(944, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Úprava zboží";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(439, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nadřazená kategorie:";
            // 
            // lbNadKategorieKategorie
            // 
            this.lbNadKategorieKategorie.AutoSize = true;
            this.lbNadKategorieKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNadKategorieKategorie.Location = new System.Drawing.Point(606, 39);
            this.lbNadKategorieKategorie.Name = "lbNadKategorieKategorie";
            this.lbNadKategorieKategorie.Size = new System.Drawing.Size(56, 20);
            this.lbNadKategorieKategorie.TabIndex = 21;
            this.lbNadKategorieKategorie.Text = "Pračky";
            // 
            // lbNadKategorieZbozi
            // 
            this.lbNadKategorieZbozi.AutoSize = true;
            this.lbNadKategorieZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNadKategorieZbozi.Location = new System.Drawing.Point(897, 39);
            this.lbNadKategorieZbozi.Name = "lbNadKategorieZbozi";
            this.lbNadKategorieZbozi.Size = new System.Drawing.Size(56, 20);
            this.lbNadKategorieZbozi.TabIndex = 23;
            this.lbNadKategorieZbozi.Text = "Pračky";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(810, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kategorie:";
            // 
            // btUlozitKategorii
            // 
            this.btUlozitKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUlozitKategorii.Location = new System.Drawing.Point(618, 97);
            this.btUlozitKategorii.Name = "btUlozitKategorii";
            this.btUlozitKategorii.Size = new System.Drawing.Size(170, 30);
            this.btUlozitKategorii.TabIndex = 24;
            this.btUlozitKategorii.Text = "Uložit";
            this.btUlozitKategorii.UseVisualStyleBackColor = true;
            this.btUlozitKategorii.Click += new System.EventHandler(this.btUlozitKategorii_Click);
            // 
            // btUlozitZbozi
            // 
            this.btUlozitZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUlozitZbozi.Location = new System.Drawing.Point(990, 328);
            this.btUlozitZbozi.Name = "btUlozitZbozi";
            this.btUlozitZbozi.Size = new System.Drawing.Size(170, 30);
            this.btUlozitZbozi.TabIndex = 25;
            this.btUlozitZbozi.Text = "Uložit";
            this.btUlozitZbozi.UseVisualStyleBackColor = true;
            this.btUlozitZbozi.Click += new System.EventHandler(this.btUlozitZbozi_Click);
            // 
            // btOdstranKategorii
            // 
            this.btOdstranKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOdstranKategorii.Location = new System.Drawing.Point(12, 403);
            this.btOdstranKategorii.Name = "btOdstranKategorii";
            this.btOdstranKategorii.Size = new System.Drawing.Size(233, 35);
            this.btOdstranKategorii.TabIndex = 26;
            this.btOdstranKategorii.Text = "Odstranit";
            this.btOdstranKategorii.UseVisualStyleBackColor = true;
            this.btOdstranKategorii.Click += new System.EventHandler(this.btOdstranKategorii_Click);
            // 
            // btOdstranZbozi
            // 
            this.btOdstranZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btOdstranZbozi.Location = new System.Drawing.Point(251, 403);
            this.btOdstranZbozi.Name = "btOdstranZbozi";
            this.btOdstranZbozi.Size = new System.Drawing.Size(182, 35);
            this.btOdstranZbozi.TabIndex = 27;
            this.btOdstranZbozi.Text = "Odstranit";
            this.btOdstranZbozi.UseVisualStyleBackColor = true;
            this.btOdstranZbozi.Click += new System.EventHandler(this.btOdstranZbozi_Click);
            // 
            // cbxUpravaKategorie
            // 
            this.cbxUpravaKategorie.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxUpravaKategorie.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxUpravaKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxUpravaKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxUpravaKategorie.Location = new System.Drawing.Point(443, 97);
            this.cbxUpravaKategorie.Name = "cbxUpravaKategorie";
            this.cbxUpravaKategorie.Size = new System.Drawing.Size(170, 30);
            this.cbxUpravaKategorie.TabIndex = 29;
            this.cbxUpravaKategorie.Text = "Editování existující";
            this.cbxUpravaKategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxUpravaKategorie.UseVisualStyleBackColor = true;
            this.cbxUpravaKategorie.CheckedChanged += new System.EventHandler(this.cbxUpravaKategorie_CheckedChanged);
            // 
            // cbxUpravaZbozi
            // 
            this.cbxUpravaZbozi.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxUpravaZbozi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxUpravaZbozi.Checked = true;
            this.cbxUpravaZbozi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUpravaZbozi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxUpravaZbozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxUpravaZbozi.Location = new System.Drawing.Point(814, 327);
            this.cbxUpravaZbozi.Name = "cbxUpravaZbozi";
            this.cbxUpravaZbozi.Size = new System.Drawing.Size(170, 30);
            this.cbxUpravaZbozi.TabIndex = 30;
            this.cbxUpravaZbozi.Text = "Nové zboží";
            this.cbxUpravaZbozi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxUpravaZbozi.UseVisualStyleBackColor = true;
            this.cbxUpravaZbozi.CheckedChanged += new System.EventHandler(this.cbxUpravaZbozi_CheckedChanged);
            // 
            // stromKategorii
            // 
            this.stromKategorii.AllowDrop = true;
            this.stromKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stromKategorii.Location = new System.Drawing.Point(12, 12);
            this.stromKategorii.Name = "stromKategorii";
            this.stromKategorii.Size = new System.Drawing.Size(233, 385);
            this.stromKategorii.TabIndex = 2;
            this.stromKategorii.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.stromKategorii.DragDrop += new System.Windows.Forms.DragEventHandler(this.stromKategorii_DragDrop);
            this.stromKategorii.DragEnter += new System.Windows.Forms.DragEventHandler(this.stromKategorii_DragEnter);
            // 
            // Editace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.cbxUpravaZbozi);
            this.Controls.Add(this.cbxUpravaKategorie);
            this.Controls.Add(this.btOdstranZbozi);
            this.Controls.Add(this.btOdstranKategorii);
            this.Controls.Add(this.btUlozitZbozi);
            this.Controls.Add(this.btUlozitKategorii);
            this.Controls.Add(this.lbNadKategorieZbozi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbNadKategorieKategorie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKategorieNazev);
            this.Controls.Add(this.nudMnozstviZbozi);
            this.Controls.Add(this.nudCenaZbozi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPopisZbozi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNazevZbozi);
            this.Controls.Add(this.listZbozi);
            this.Controls.Add(this.stromKategorii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editace";
            this.Text = "Editace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editace_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaZbozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMnozstviZbozi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StromKategorii stromKategorii;
        private System.Windows.Forms.ListBox listZbozi;
        private System.Windows.Forms.TextBox tbNazevZbozi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPopisZbozi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCenaZbozi;
        private System.Windows.Forms.NumericUpDown nudMnozstviZbozi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKategorieNazev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNadKategorieKategorie;
        private System.Windows.Forms.Label lbNadKategorieZbozi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btUlozitKategorii;
        private System.Windows.Forms.Button btUlozitZbozi;
        private System.Windows.Forms.Button btOdstranKategorii;
        private System.Windows.Forms.Button btOdstranZbozi;
        private System.Windows.Forms.CheckBox cbxUpravaKategorie;
        private System.Windows.Forms.CheckBox cbxUpravaZbozi;
    }
}