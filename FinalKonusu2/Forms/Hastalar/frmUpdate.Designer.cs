
namespace FinalKonusu2.Forms.Hastalar
{
    partial class frmUpdate
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastayastxt = new System.Windows.Forms.TextBox();
            this.hastasoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hastaadtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(141, 203);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(121, 43);
            this.btnguncelle.TabIndex = 27;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gittiği Bölüm";
            // 
            // hastayastxt
            // 
            this.hastayastxt.Location = new System.Drawing.Point(141, 101);
            this.hastayastxt.Name = "hastayastxt";
            this.hastayastxt.Size = new System.Drawing.Size(100, 22);
            this.hastayastxt.TabIndex = 25;
            // 
            // hastasoyadtxt
            // 
            this.hastasoyadtxt.Location = new System.Drawing.Point(141, 73);
            this.hastasoyadtxt.Name = "hastasoyadtxt";
            this.hastasoyadtxt.Size = new System.Drawing.Size(100, 22);
            this.hastasoyadtxt.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hasta Yaş";
            // 
            // Hastaadtxt
            // 
            this.Hastaadtxt.Location = new System.Drawing.Point(141, 30);
            this.Hastaadtxt.Name = "Hastaadtxt";
            this.Hastaadtxt.Size = new System.Drawing.Size(100, 22);
            this.Hastaadtxt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hasta Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hasta Ad";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Items.AddRange(new object[] {
            "Dahiliye",
            "Cildiye",
            "KBB"});
            this.cmbBolum.Location = new System.Drawing.Point(141, 144);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(121, 24);
            this.cmbBolum.TabIndex = 28;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastayastxt);
            this.Controls.Add(this.hastasoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hastaadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdate";
            this.Text = "frmUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hastayastxt;
        private System.Windows.Forms.TextBox hastasoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hastaadtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBolum;
    }
}