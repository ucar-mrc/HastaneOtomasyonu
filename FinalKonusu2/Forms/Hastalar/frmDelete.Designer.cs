
namespace FinalKonusu2.Forms.Hastalar
{
    partial class frmDelete
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
            this.btnsil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastayastxt = new System.Windows.Forms.TextBox();
            this.hastasoyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hastaadtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbolum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(142, 208);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(121, 43);
            this.btnsil.TabIndex = 18;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gittiği Bölüm";
            // 
            // hastayastxt
            // 
            this.hastayastxt.Enabled = false;
            this.hastayastxt.Location = new System.Drawing.Point(142, 106);
            this.hastayastxt.Name = "hastayastxt";
            this.hastayastxt.Size = new System.Drawing.Size(100, 22);
            this.hastayastxt.TabIndex = 15;
            // 
            // hastasoyadtxt
            // 
            this.hastasoyadtxt.Enabled = false;
            this.hastasoyadtxt.Location = new System.Drawing.Point(142, 78);
            this.hastasoyadtxt.Name = "hastasoyadtxt";
            this.hastasoyadtxt.Size = new System.Drawing.Size(100, 22);
            this.hastasoyadtxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta Yaş";
            // 
            // Hastaadtxt
            // 
            this.Hastaadtxt.Enabled = false;
            this.Hastaadtxt.Location = new System.Drawing.Point(142, 35);
            this.Hastaadtxt.Name = "Hastaadtxt";
            this.Hastaadtxt.Size = new System.Drawing.Size(100, 22);
            this.Hastaadtxt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hasta Ad";
            // 
            // txtbolum
            // 
            this.txtbolum.Enabled = false;
            this.txtbolum.Location = new System.Drawing.Point(142, 149);
            this.txtbolum.Name = "txtbolum";
            this.txtbolum.Size = new System.Drawing.Size(100, 22);
            this.txtbolum.TabIndex = 19;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 333);
            this.Controls.Add(this.txtbolum);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastayastxt);
            this.Controls.Add(this.hastasoyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hastaadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.Load += new System.EventHandler(this.frmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hastayastxt;
        private System.Windows.Forms.TextBox hastasoyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hastaadtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolum;
    }
}