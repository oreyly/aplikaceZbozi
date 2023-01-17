
namespace aplikaceZbozi
{
    partial class Rozcesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.btObchod = new System.Windows.Forms.Button();
            this.btEditor = new System.Windows.Forms.Button();
            this.btKoupeno = new System.Windows.Forms.Button();
            this.btKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btObchod
            // 
            this.btObchod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btObchod.Location = new System.Drawing.Point(12, 32);
            this.btObchod.Name = "btObchod";
            this.btObchod.Size = new System.Drawing.Size(98, 26);
            this.btObchod.TabIndex = 1;
            this.btObchod.Text = "Obchod";
            this.btObchod.UseVisualStyleBackColor = true;
            this.btObchod.Click += new System.EventHandler(this.btObchod_Click);
            // 
            // btEditor
            // 
            this.btEditor.Enabled = false;
            this.btEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEditor.Location = new System.Drawing.Point(12, 64);
            this.btEditor.Name = "btEditor";
            this.btEditor.Size = new System.Drawing.Size(98, 26);
            this.btEditor.TabIndex = 2;
            this.btEditor.Text = "Editor";
            this.btEditor.UseVisualStyleBackColor = true;
            this.btEditor.Click += new System.EventHandler(this.btEditor_Click);
            // 
            // btKoupeno
            // 
            this.btKoupeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKoupeno.Location = new System.Drawing.Point(12, 96);
            this.btKoupeno.Name = "btKoupeno";
            this.btKoupeno.Size = new System.Drawing.Size(98, 26);
            this.btKoupeno.TabIndex = 3;
            this.btKoupeno.Text = "Zakoupeno";
            this.btKoupeno.UseVisualStyleBackColor = true;
            this.btKoupeno.Click += new System.EventHandler(this.btKoupeno_Click);
            // 
            // btKonec
            // 
            this.btKonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btKonec.Location = new System.Drawing.Point(12, 128);
            this.btKonec.Name = "btKonec";
            this.btKonec.Size = new System.Drawing.Size(98, 26);
            this.btKonec.TabIndex = 4;
            this.btKonec.Text = "Konec";
            this.btKonec.UseVisualStyleBackColor = true;
            this.btKonec.Click += new System.EventHandler(this.btKonec_Click);
            // 
            // Rozcesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 160);
            this.Controls.Add(this.btKonec);
            this.Controls.Add(this.btKoupeno);
            this.Controls.Add(this.btEditor);
            this.Controls.Add(this.btObchod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rozcesti";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rozcesti_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btObchod;
        private System.Windows.Forms.Button btEditor;
        private System.Windows.Forms.Button btKoupeno;
        private System.Windows.Forms.Button btKonec;
    }
}