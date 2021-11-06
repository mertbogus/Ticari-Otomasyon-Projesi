
namespace Ticari_Otomasyon
{
    partial class Frmurunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmurunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Rchdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txtfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Nudadet = new System.Windows.Forms.NumericUpDown();
            this.Txtalis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Mskyil = new System.Windows.Forms.MaskedTextBox();
            this.Txtmodel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtalis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1468, 1009);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.Btnsil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.Rchdetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Txtfiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.Nudadet);
            this.groupControl1.Controls.Add(this.Txtalis);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Mskyil);
            this.groupControl1.Controls.Add(this.Txtmodel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txtmarka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1486, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(404, 1000);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Btnsil
            // 
            this.Btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.Appearance.Options.UseFont = true;
            this.Btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnsil.ImageOptions.Image")));
            this.Btnsil.Location = new System.Drawing.Point(283, 490);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(116, 37);
            this.Btnsil.TabIndex = 12;
            this.Btnsil.Text = "Sil";
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(148, 490);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(116, 37);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(8, 490);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(116, 37);
            this.Btnkaydet.TabIndex = 10;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // Rchdetay
            // 
            this.Rchdetay.BackColor = System.Drawing.Color.Linen;
            this.Rchdetay.ForeColor = System.Drawing.Color.Black;
            this.Rchdetay.Location = new System.Drawing.Point(123, 366);
            this.Rchdetay.Name = "Rchdetay";
            this.Rchdetay.Size = new System.Drawing.Size(232, 96);
            this.Rchdetay.TabIndex = 9;
            this.Rchdetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(67, 257);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 22);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "ADET:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(57, 366);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 22);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "DETAY:";
            // 
            // Txtfiyat
            // 
            this.Txtfiyat.Location = new System.Drawing.Point(123, 326);
            this.Txtfiyat.Name = "Txtfiyat";
            this.Txtfiyat.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtfiyat.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtfiyat.Properties.Appearance.Options.UseBackColor = true;
            this.Txtfiyat.Properties.Appearance.Options.UseFont = true;
            this.Txtfiyat.Properties.Appearance.Options.UseForeColor = true;
            this.Txtfiyat.Size = new System.Drawing.Size(191, 28);
            this.Txtfiyat.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(8, 319);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(109, 22);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "SATIŞ FİYAT:";
            // 
            // Nudadet
            // 
            this.Nudadet.BackColor = System.Drawing.Color.Linen;
            this.Nudadet.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nudadet.ForeColor = System.Drawing.Color.Black;
            this.Nudadet.Location = new System.Drawing.Point(123, 253);
            this.Nudadet.Name = "Nudadet";
            this.Nudadet.Size = new System.Drawing.Size(191, 29);
            this.Nudadet.TabIndex = 6;
            // 
            // Txtalis
            // 
            this.Txtalis.Location = new System.Drawing.Point(123, 288);
            this.Txtalis.Name = "Txtalis";
            this.Txtalis.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtalis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtalis.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtalis.Properties.Appearance.Options.UseBackColor = true;
            this.Txtalis.Properties.Appearance.Options.UseFont = true;
            this.Txtalis.Properties.Appearance.Options.UseForeColor = true;
            this.Txtalis.Size = new System.Drawing.Size(191, 28);
            this.Txtalis.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 291);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 22);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "ALİS FİYAT:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(91, 222);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 22);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL";
            // 
            // Mskyil
            // 
            this.Mskyil.BackColor = System.Drawing.Color.Linen;
            this.Mskyil.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mskyil.ForeColor = System.Drawing.Color.Black;
            this.Mskyil.Location = new System.Drawing.Point(123, 218);
            this.Mskyil.Mask = "0000";
            this.Mskyil.Name = "Mskyil";
            this.Mskyil.Size = new System.Drawing.Size(191, 29);
            this.Mskyil.TabIndex = 5;
            this.Mskyil.ValidatingType = typeof(int);
            // 
            // Txtmodel
            // 
            this.Txtmodel.Location = new System.Drawing.Point(123, 184);
            this.Txtmodel.Name = "Txtmodel";
            this.Txtmodel.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtmodel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmodel.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtmodel.Properties.Appearance.Options.UseBackColor = true;
            this.Txtmodel.Properties.Appearance.Options.UseFont = true;
            this.Txtmodel.Properties.Appearance.Options.UseForeColor = true;
            this.Txtmodel.Size = new System.Drawing.Size(191, 28);
            this.Txtmodel.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(53, 187);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 22);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "MODEL:";
            // 
            // Txtmarka
            // 
            this.Txtmarka.Location = new System.Drawing.Point(123, 150);
            this.Txtmarka.Name = "Txtmarka";
            this.Txtmarka.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtmarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmarka.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtmarka.Properties.Appearance.Options.UseBackColor = true;
            this.Txtmarka.Properties.Appearance.Options.UseFont = true;
            this.Txtmarka.Properties.Appearance.Options.UseForeColor = true;
            this.Txtmarka.Size = new System.Drawing.Size(191, 28);
            this.Txtmarka.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(53, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "MARKA:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(123, 116);
            this.Txtad.Name = "Txtad";
            this.Txtad.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtad.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtad.Properties.Appearance.Options.UseBackColor = true;
            this.Txtad.Properties.Appearance.Options.UseFont = true;
            this.Txtad.Properties.Appearance.Options.UseForeColor = true;
            this.Txtad.Size = new System.Drawing.Size(191, 28);
            this.Txtad.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(88, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "AD:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(123, 82);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtid.Properties.Appearance.Options.UseBackColor = true;
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Properties.Appearance.Options.UseForeColor = true;
            this.Txtid.Size = new System.Drawing.Size(191, 28);
            this.Txtid.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(92, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(148, 553);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(116, 37);
            this.Btntemizle.TabIndex = 18;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Frmurunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frmurunler";
            this.Text = "Frmurunler";
            this.Load += new System.EventHandler(this.Frmurunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nudadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtalis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown Nudadet;
        private DevExpress.XtraEditors.TextEdit Txtalis;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox Mskyil;
        private DevExpress.XtraEditors.TextEdit Txtmodel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txtad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private System.Windows.Forms.RichTextBox Rchdetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit Txtfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton Btnsil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton Btntemizle;
    }
}