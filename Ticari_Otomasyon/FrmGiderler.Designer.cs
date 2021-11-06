
namespace Ticari_Otomasyon
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.Rchadres = new System.Windows.Forms.RichTextBox();
            this.Txtekstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txtdogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Cmbyil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Txtelektrik = new DevExpress.XtraEditors.TextEdit();
            this.Txtsu = new DevExpress.XtraEditors.TextEdit();
            this.Txtinternet = new DevExpress.XtraEditors.TextEdit();
            this.Txtmaas = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtdogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbyil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtelektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmaas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1400, 1269);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Txtmaas);
            this.groupControl1.Controls.Add(this.Txtinternet);
            this.groupControl1.Controls.Add(this.Txtsu);
            this.groupControl1.Controls.Add(this.Txtelektrik);
            this.groupControl1.Controls.Add(this.Cmbay);
            this.groupControl1.Controls.Add(this.Cmbyil);
            this.groupControl1.Controls.Add(this.Btntemizle);
            this.groupControl1.Controls.Add(this.Rchadres);
            this.groupControl1.Controls.Add(this.Txtekstra);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Btnsil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.Txtdogalgaz);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1411, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(486, 902);
            this.groupControl1.TabIndex = 6;
            // 
            // Btntemizle
            // 
            this.Btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btntemizle.Appearance.Options.UseFont = true;
            this.Btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btntemizle.ImageOptions.Image")));
            this.Btntemizle.Location = new System.Drawing.Point(256, 642);
            this.Btntemizle.Margin = new System.Windows.Forms.Padding(4);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(222, 41);
            this.Btntemizle.TabIndex = 31;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Rchadres
            // 
            this.Rchadres.BackColor = System.Drawing.Color.Linen;
            this.Rchadres.Location = new System.Drawing.Point(187, 443);
            this.Rchadres.Margin = new System.Windows.Forms.Padding(4);
            this.Rchadres.Name = "Rchadres";
            this.Rchadres.Size = new System.Drawing.Size(238, 125);
            this.Rchadres.TabIndex = 30;
            this.Rchadres.Text = "";
            // 
            // Txtekstra
            // 
            this.Txtekstra.Location = new System.Drawing.Point(187, 390);
            this.Txtekstra.Margin = new System.Windows.Forms.Padding(4);
            this.Txtekstra.Name = "Txtekstra";
            this.Txtekstra.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtekstra.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtekstra.Properties.Appearance.Options.UseBackColor = true;
            this.Txtekstra.Properties.Appearance.Options.UseFont = true;
            this.Txtekstra.Properties.Appearance.Options.UseForeColor = true;
            this.Txtekstra.Size = new System.Drawing.Size(239, 28);
            this.Txtekstra.TabIndex = 29;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(98, 397);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(70, 22);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "EKSTRA:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(98, 432);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 22);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "ADRES:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(90, 353);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 22);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "MAAŞLAR";
            // 
            // Btnsil
            // 
            this.Btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.Appearance.Options.UseFont = true;
            this.Btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnsil.ImageOptions.Image")));
            this.Btnsil.Location = new System.Drawing.Point(6, 642);
            this.Btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(222, 41);
            this.Btnsil.TabIndex = 21;
            this.Btnsil.Text = "Sil";
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(258, 593);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(222, 41);
            this.BtnGuncelle.TabIndex = 20;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(6, 593);
            this.Btnkaydet.Margin = new System.Windows.Forms.Padding(4);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(222, 41);
            this.Btnkaydet.TabIndex = 19;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(140, 215);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 22);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "SU:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(84, 305);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 22);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "İNTERNET";
            // 
            // Txtdogalgaz
            // 
            this.Txtdogalgaz.Location = new System.Drawing.Point(187, 260);
            this.Txtdogalgaz.Margin = new System.Windows.Forms.Padding(4);
            this.Txtdogalgaz.Name = "Txtdogalgaz";
            this.Txtdogalgaz.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtdogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtdogalgaz.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtdogalgaz.Properties.Appearance.Options.UseBackColor = true;
            this.Txtdogalgaz.Properties.Appearance.Options.UseFont = true;
            this.Txtdogalgaz.Properties.Appearance.Options.UseForeColor = true;
            this.Txtdogalgaz.Size = new System.Drawing.Size(239, 28);
            this.Txtdogalgaz.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(78, 263);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 22);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "DOĞALGAZ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(75, 180);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 22);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "ELEKTİRİK:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(141, 136);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "AY:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(142, 91);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "YIL";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(187, 45);
            this.Txtid.Margin = new System.Windows.Forms.Padding(4);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtid.Properties.Appearance.Options.UseBackColor = true;
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Properties.Appearance.Options.UseForeColor = true;
            this.Txtid.Size = new System.Drawing.Size(239, 28);
            this.Txtid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(143, 49);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // Cmbyil
            // 
            this.Cmbyil.Location = new System.Drawing.Point(187, 91);
            this.Cmbyil.Name = "Cmbyil";
            this.Cmbyil.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Cmbyil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbyil.Properties.Appearance.Options.UseBackColor = true;
            this.Cmbyil.Properties.Appearance.Options.UseFont = true;
            this.Cmbyil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbyil.Properties.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.Cmbyil.Size = new System.Drawing.Size(239, 30);
            this.Cmbyil.TabIndex = 32;
            // 
            // Cmbay
            // 
            this.Cmbay.Location = new System.Drawing.Point(187, 131);
            this.Cmbay.Name = "Cmbay";
            this.Cmbay.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Cmbay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbay.Properties.Appearance.Options.UseBackColor = true;
            this.Cmbay.Properties.Appearance.Options.UseFont = true;
            this.Cmbay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbay.Properties.Items.AddRange(new object[] {
            "OCAK",
            "ŞUBAT",
            "MART",
            "NİSAN",
            "MAYIS",
            "HAZİRAN",
            "TEMMUZ",
            "AĞUSTOS",
            "EYLÜL",
            "EKİM",
            "KASIM",
            "ARALIK"});
            this.Cmbay.Size = new System.Drawing.Size(239, 30);
            this.Cmbay.TabIndex = 33;
            // 
            // Txtelektrik
            // 
            this.Txtelektrik.Location = new System.Drawing.Point(187, 174);
            this.Txtelektrik.Margin = new System.Windows.Forms.Padding(4);
            this.Txtelektrik.Name = "Txtelektrik";
            this.Txtelektrik.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtelektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtelektrik.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtelektrik.Properties.Appearance.Options.UseBackColor = true;
            this.Txtelektrik.Properties.Appearance.Options.UseFont = true;
            this.Txtelektrik.Properties.Appearance.Options.UseForeColor = true;
            this.Txtelektrik.Size = new System.Drawing.Size(239, 28);
            this.Txtelektrik.TabIndex = 34;
            // 
            // Txtsu
            // 
            this.Txtsu.Location = new System.Drawing.Point(187, 212);
            this.Txtsu.Margin = new System.Windows.Forms.Padding(4);
            this.Txtsu.Name = "Txtsu";
            this.Txtsu.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtsu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtsu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtsu.Properties.Appearance.Options.UseBackColor = true;
            this.Txtsu.Properties.Appearance.Options.UseFont = true;
            this.Txtsu.Properties.Appearance.Options.UseForeColor = true;
            this.Txtsu.Size = new System.Drawing.Size(239, 28);
            this.Txtsu.TabIndex = 35;
            // 
            // Txtinternet
            // 
            this.Txtinternet.Location = new System.Drawing.Point(187, 302);
            this.Txtinternet.Margin = new System.Windows.Forms.Padding(4);
            this.Txtinternet.Name = "Txtinternet";
            this.Txtinternet.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtinternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtinternet.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtinternet.Properties.Appearance.Options.UseBackColor = true;
            this.Txtinternet.Properties.Appearance.Options.UseFont = true;
            this.Txtinternet.Properties.Appearance.Options.UseForeColor = true;
            this.Txtinternet.Size = new System.Drawing.Size(239, 28);
            this.Txtinternet.TabIndex = 36;
            // 
            // Txtmaas
            // 
            this.Txtmaas.Location = new System.Drawing.Point(187, 347);
            this.Txtmaas.Margin = new System.Windows.Forms.Padding(4);
            this.Txtmaas.Name = "Txtmaas";
            this.Txtmaas.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtmaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtmaas.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtmaas.Properties.Appearance.Options.UseBackColor = true;
            this.Txtmaas.Properties.Appearance.Options.UseFont = true;
            this.Txtmaas.Properties.Appearance.Options.UseForeColor = true;
            this.Txtmaas.Size = new System.Drawing.Size(239, 28);
            this.Txtmaas.TabIndex = 37;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "FrmGiderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txtekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtdogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbyil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtelektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtinternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtmaas.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit Txtmaas;
        private DevExpress.XtraEditors.TextEdit Txtinternet;
        private DevExpress.XtraEditors.TextEdit Txtsu;
        private DevExpress.XtraEditors.TextEdit Txtelektrik;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbay;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbyil;
        private DevExpress.XtraEditors.SimpleButton Btntemizle;
        private System.Windows.Forms.RichTextBox Rchadres;
        private DevExpress.XtraEditors.TextEdit Txtekstra;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton Btnsil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit Txtdogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}