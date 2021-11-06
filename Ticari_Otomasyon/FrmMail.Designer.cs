
namespace Ticari_Otomasyon
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.Txtmailadresi = new DevExpress.XtraEditors.TextEdit();
            this.Txtmailkonu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Rchmailicerik = new System.Windows.Forms.RichTextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Btnmailgonder = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmailadresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmailkonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // Txtmailadresi
            // 
            this.Txtmailadresi.Location = new System.Drawing.Point(139, 134);
            this.Txtmailadresi.Name = "Txtmailadresi";
            this.Txtmailadresi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmailadresi.Properties.Appearance.Options.UseFont = true;
            this.Txtmailadresi.Size = new System.Drawing.Size(273, 30);
            this.Txtmailadresi.TabIndex = 1;
            // 
            // Txtmailkonu
            // 
            this.Txtmailkonu.Location = new System.Drawing.Point(139, 197);
            this.Txtmailkonu.Name = "Txtmailkonu";
            this.Txtmailkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmailkonu.Properties.Appearance.Options.UseFont = true;
            this.Txtmailkonu.Size = new System.Drawing.Size(273, 30);
            this.Txtmailkonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // Rchmailicerik
            // 
            this.Rchmailicerik.Location = new System.Drawing.Point(139, 250);
            this.Rchmailicerik.Name = "Rchmailicerik";
            this.Rchmailicerik.Size = new System.Drawing.Size(273, 204);
            this.Rchmailicerik.TabIndex = 4;
            this.Rchmailicerik.Text = "";
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(415, 107);
            this.panelControl1.TabIndex = 5;
            // 
            // Btnmailgonder
            // 
            this.Btnmailgonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btnmailgonder.Location = new System.Drawing.Point(223, 469);
            this.Btnmailgonder.Name = "Btnmailgonder";
            this.Btnmailgonder.Size = new System.Drawing.Size(189, 45);
            this.Btnmailgonder.TabIndex = 6;
            this.Btnmailgonder.Text = "Gönder";
            this.Btnmailgonder.Click += new System.EventHandler(this.Btnmailgonder_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(223, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MAİL GÖNDERME PANELİ";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 532);
            this.Controls.Add(this.Btnmailgonder);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Rchmailicerik);
            this.Controls.Add(this.Txtmailkonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtmailadresi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMail";
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txtmailadresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmailkonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit Txtmailadresi;
        private DevExpress.XtraEditors.TextEdit Txtmailkonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Rchmailicerik;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btnmailgonder;
    }
}