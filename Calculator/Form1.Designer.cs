namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSayi2.Location = new System.Drawing.Point(226, 39);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.PlaceholderText = "İkinci sayıyı giriniz";
            this.txtSayi2.Size = new System.Drawing.Size(184, 34);
            this.txtSayi2.TabIndex = 1;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSayi1.Location = new System.Drawing.Point(36, 39);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.PlaceholderText = "İlk sayıyı giriniz";
            this.txtSayi1.Size = new System.Drawing.Size(184, 34);
            this.txtSayi1.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopla.Location = new System.Drawing.Point(36, 79);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(374, 45);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            this.btnTopla.MouseLeave += new System.EventHandler(this.btnTopla_MouseLeave);
            this.btnTopla.MouseHover += new System.EventHandler(this.btnTopla_MouseHover);
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarp.Location = new System.Drawing.Point(36, 181);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(374, 45);
            this.btnCarp.TabIndex = 2;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            this.btnCarp.MouseLeave += new System.EventHandler(this.btnCarp_MouseLeave);
            this.btnCarp.MouseHover += new System.EventHandler(this.btnCarp_MouseHover);
            // 
            // btnBol
            // 
            this.btnBol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBol.Location = new System.Drawing.Point(36, 232);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(374, 45);
            this.btnBol.TabIndex = 2;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            this.btnBol.MouseLeave += new System.EventHandler(this.btnBol_MouseLeave);
            this.btnBol.MouseHover += new System.EventHandler(this.btnBol_MouseHover);
            // 
            // btnCikart
            // 
            this.btnCikart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCikart.Location = new System.Drawing.Point(36, 130);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(374, 45);
            this.btnCikart.TabIndex = 2;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            this.btnCikart.MouseLeave += new System.EventHandler(this.btnCikart_MouseLeave);
            this.btnCikart.MouseHover += new System.EventHandler(this.btnCikart_MouseHover);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSonuc.Location = new System.Drawing.Point(36, 365);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(374, 57);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMesaj.Location = new System.Drawing.Point(36, 291);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(374, 57);
            this.lblMesaj.TabIndex = 3;
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(460, 472);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSayi2;
        private TextBox txtSayi1;
        private Button btnTopla;
        private Button btnCarp;
        private Button btnBol;
        private Button btnCikart;
        private Label lblSonuc;
        private Label lblMesaj;
    }
}