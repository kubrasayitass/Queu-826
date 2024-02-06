namespace Queu_örnek_826
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnCagir1 = new System.Windows.Forms.Button();
            this.btnCagir2 = new System.Windows.Forms.Button();
            this.btnCagir3 = new System.Windows.Forms.Button();
            this.lblCagir1 = new System.Windows.Forms.Label();
            this.lblCagir2 = new System.Windows.Forms.Label();
            this.lblCagir3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Sıra al";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(147, 31);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(87, 34);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "müşteri çağır";
            this.btnGetir.UseVisualStyleBackColor = true;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(153, 85);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(46, 18);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "label1";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(21, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // btnCagir1
            // 
            this.btnCagir1.Location = new System.Drawing.Point(3, 130);
            this.btnCagir1.Name = "btnCagir1";
            this.btnCagir1.Size = new System.Drawing.Size(75, 41);
            this.btnCagir1.TabIndex = 4;
            this.btnCagir1.Text = "çağır1";
            this.btnCagir1.UseVisualStyleBackColor = true;
            this.btnCagir1.Click += new System.EventHandler(this.btnCagir1_Click);
            // 
            // btnCagir2
            // 
            this.btnCagir2.Location = new System.Drawing.Point(172, 130);
            this.btnCagir2.Name = "btnCagir2";
            this.btnCagir2.Size = new System.Drawing.Size(75, 41);
            this.btnCagir2.TabIndex = 5;
            this.btnCagir2.Text = "çağır2";
            this.btnCagir2.UseVisualStyleBackColor = true;
            this.btnCagir2.Click += new System.EventHandler(this.btnCagir2_Click);
            // 
            // btnCagir3
            // 
            this.btnCagir3.Location = new System.Drawing.Point(348, 130);
            this.btnCagir3.Name = "btnCagir3";
            this.btnCagir3.Size = new System.Drawing.Size(75, 41);
            this.btnCagir3.TabIndex = 6;
            this.btnCagir3.Text = "çağır3";
            this.btnCagir3.UseVisualStyleBackColor = true;
            this.btnCagir3.Click += new System.EventHandler(this.btnCagir3_Click);
            // 
            // lblCagir1
            // 
            this.lblCagir1.AutoSize = true;
            this.lblCagir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCagir1.Location = new System.Drawing.Point(18, 199);
            this.lblCagir1.Name = "lblCagir1";
            this.lblCagir1.Size = new System.Drawing.Size(46, 18);
            this.lblCagir1.TabIndex = 7;
            this.lblCagir1.Text = "label1";
            // 
            // lblCagir2
            // 
            this.lblCagir2.AutoSize = true;
            this.lblCagir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCagir2.Location = new System.Drawing.Point(188, 199);
            this.lblCagir2.Name = "lblCagir2";
            this.lblCagir2.Size = new System.Drawing.Size(46, 18);
            this.lblCagir2.TabIndex = 8;
            this.lblCagir2.Text = "label1";
            // 
            // lblCagir3
            // 
            this.lblCagir3.AutoSize = true;
            this.lblCagir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCagir3.Location = new System.Drawing.Point(358, 199);
            this.lblCagir3.Name = "lblCagir3";
            this.lblCagir3.Size = new System.Drawing.Size(46, 18);
            this.lblCagir3.TabIndex = 9;
            this.lblCagir3.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 282);
            this.Controls.Add(this.lblCagir3);
            this.Controls.Add(this.lblCagir2);
            this.Controls.Add(this.lblCagir1);
            this.Controls.Add(this.btnCagir3);
            this.Controls.Add(this.btnCagir2);
            this.Controls.Add(this.btnCagir1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnCagir1;
        private System.Windows.Forms.Button btnCagir2;
        private System.Windows.Forms.Button btnCagir3;
        private System.Windows.Forms.Label lblCagir1;
        private System.Windows.Forms.Label lblCagir2;
        private System.Windows.Forms.Label lblCagir3;
    }
}

