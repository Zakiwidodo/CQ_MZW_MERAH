namespace PratikumADO
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(27, 274);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(236, 274);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hitung Mk";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(128, 121);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(41, 20);
            this.hasil.TabIndex = 4;
            this.hasil.Text = "hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(172, 121);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 26);
            this.txtHasil.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

