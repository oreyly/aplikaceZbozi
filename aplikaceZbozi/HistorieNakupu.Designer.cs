
namespace aplikaceZbozi
{
    partial class HistorieNakupu
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
            this.flpSeznamZbozi = new System.Windows.Forms.FlowLayoutPanel();
            this.oknoSeZbozim1 = new aplikaceZbozi.oknoSeZbozim();
            this.oknoSeZbozim2 = new aplikaceZbozi.oknoSeZbozim();
            this.rbLevne = new System.Windows.Forms.RadioButton();
            this.rbDrahe = new System.Windows.Forms.RadioButton();
            this.rbAz = new System.Windows.Forms.RadioButton();
            this.rbZa = new System.Windows.Forms.RadioButton();
            this.rbNejvice = new System.Windows.Forms.RadioButton();
            this.stromKategorii = new StromKategorii();
            this.rbNejmene = new System.Windows.Forms.RadioButton();
            this.flpSeznamZbozi.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSeznamZbozi
            // 
            this.flpSeznamZbozi.AutoScroll = true;
            this.flpSeznamZbozi.BackColor = System.Drawing.Color.White;
            this.flpSeznamZbozi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSeznamZbozi.Controls.Add(this.oknoSeZbozim1);
            this.flpSeznamZbozi.Controls.Add(this.oknoSeZbozim2);
            this.flpSeznamZbozi.Location = new System.Drawing.Point(251, 43);
            this.flpSeznamZbozi.Name = "flpSeznamZbozi";
            this.flpSeznamZbozi.Size = new System.Drawing.Size(530, 469);
            this.flpSeznamZbozi.TabIndex = 0;
            // 
            // oknoSeZbozim1
            // 
            this.oknoSeZbozim1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oknoSeZbozim1.Location = new System.Drawing.Point(3, 3);
            this.oknoSeZbozim1.Name = "oknoSeZbozim1";
            this.oknoSeZbozim1.Size = new System.Drawing.Size(250, 300);
            this.oknoSeZbozim1.TabIndex = 0;
            // 
            // oknoSeZbozim2
            // 
            this.oknoSeZbozim2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oknoSeZbozim2.Location = new System.Drawing.Point(259, 3);
            this.oknoSeZbozim2.Name = "oknoSeZbozim2";
            this.oknoSeZbozim2.Size = new System.Drawing.Size(250, 300);
            this.oknoSeZbozim2.TabIndex = 1;
            // 
            // rbLevne
            // 
            this.rbLevne.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLevne.AutoSize = true;
            this.rbLevne.Checked = true;
            this.rbLevne.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbLevne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLevne.Location = new System.Drawing.Point(251, 12);
            this.rbLevne.Name = "rbLevne";
            this.rbLevne.Size = new System.Drawing.Size(72, 25);
            this.rbLevne.TabIndex = 10;
            this.rbLevne.TabStop = true;
            this.rbLevne.Text = "Nejlevnější";
            this.rbLevne.UseVisualStyleBackColor = true;
            this.rbLevne.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // rbDrahe
            // 
            this.rbDrahe.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDrahe.AutoSize = true;
            this.rbDrahe.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbDrahe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDrahe.Location = new System.Drawing.Point(344, 12);
            this.rbDrahe.Name = "rbDrahe";
            this.rbDrahe.Size = new System.Drawing.Size(64, 25);
            this.rbDrahe.TabIndex = 11;
            this.rbDrahe.Text = "Nejdražší";
            this.rbDrahe.UseVisualStyleBackColor = true;
            this.rbDrahe.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // rbAz
            // 
            this.rbAz.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAz.AutoSize = true;
            this.rbAz.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbAz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAz.Location = new System.Drawing.Point(429, 12);
            this.rbAz.Name = "rbAz";
            this.rbAz.Size = new System.Drawing.Size(36, 25);
            this.rbAz.TabIndex = 12;
            this.rbAz.Text = "A-Z";
            this.rbAz.UseVisualStyleBackColor = true;
            this.rbAz.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // rbZa
            // 
            this.rbZa.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbZa.AutoSize = true;
            this.rbZa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbZa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbZa.Location = new System.Drawing.Point(487, 12);
            this.rbZa.Name = "rbZa";
            this.rbZa.Size = new System.Drawing.Size(36, 25);
            this.rbZa.TabIndex = 13;
            this.rbZa.Text = "Z-A";
            this.rbZa.UseVisualStyleBackColor = true;
            this.rbZa.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // rbNejvice
            // 
            this.rbNejvice.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNejvice.AutoSize = true;
            this.rbNejvice.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbNejvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNejvice.Location = new System.Drawing.Point(544, 12);
            this.rbNejvice.Name = "rbNejvice";
            this.rbNejvice.Size = new System.Drawing.Size(106, 25);
            this.rbNejvice.TabIndex = 14;
            this.rbNejvice.Text = "Nejvíce na skladě";
            this.rbNejvice.UseVisualStyleBackColor = true;
            this.rbNejvice.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // stromKategorii
            // 
            this.stromKategorii.AllowDrop = true;
            this.stromKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stromKategorii.Location = new System.Drawing.Point(12, 12);
            this.stromKategorii.Name = "stromKategorii";
            this.stromKategorii.Size = new System.Drawing.Size(233, 500);
            this.stromKategorii.TabIndex = 3;
            this.stromKategorii.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // rbNejmene
            // 
            this.rbNejmene.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNejmene.AutoSize = true;
            this.rbNejmene.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rbNejmene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNejmene.Location = new System.Drawing.Point(671, 12);
            this.rbNejmene.Name = "rbNejmene";
            this.rbNejmene.Size = new System.Drawing.Size(110, 25);
            this.rbNejmene.TabIndex = 15;
            this.rbNejmene.Text = "Nejméně na skladě";
            this.rbNejmene.UseVisualStyleBackColor = true;
            this.rbNejmene.CheckedChanged += new System.EventHandler(this.rbLevne_CheckedChanged);
            // 
            // Obchod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.rbNejmene);
            this.Controls.Add(this.rbNejvice);
            this.Controls.Add(this.rbZa);
            this.Controls.Add(this.rbAz);
            this.Controls.Add(this.rbDrahe);
            this.Controls.Add(this.rbLevne);
            this.Controls.Add(this.stromKategorii);
            this.Controls.Add(this.flpSeznamZbozi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Obchod";
            this.Text = "Obchod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editace_FormClosed);
            this.flpSeznamZbozi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpSeznamZbozi { get; set; }
        public StromKategorii stromKategorii { get; set; }
        private oknoSeZbozim oknoSeZbozim1;
        private oknoSeZbozim oknoSeZbozim2;
        private System.Windows.Forms.RadioButton rbLevne;
        private System.Windows.Forms.RadioButton rbDrahe;
        private System.Windows.Forms.RadioButton rbAz;
        private System.Windows.Forms.RadioButton rbZa;
        private System.Windows.Forms.RadioButton rbNejvice;
        private System.Windows.Forms.RadioButton rbNejmene;
    }
}