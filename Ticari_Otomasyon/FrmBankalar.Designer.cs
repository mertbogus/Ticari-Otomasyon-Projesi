
namespace Ticari_Otomasyon
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Luefirma = new DevExpress.XtraEditors.LookUpEdit();
            this.txthesaptur = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Txtadres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txtyetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txthesapno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.Txtsube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Msktarih = new System.Windows.Forms.MaskedTextBox();
            this.Btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Msktel = new System.Windows.Forms.MaskedTextBox();
            this.Txtiban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luefirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtyetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txthesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtiban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1451, 1015);
            this.gridControl1.TabIndex = 3;
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
            this.groupControl1.Controls.Add(this.Luefirma);
            this.groupControl1.Controls.Add(this.txthesaptur);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.Txtadres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.Txtyetkili);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txthesapno);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.Txtsube);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.Cmbilce);
            this.groupControl1.Controls.Add(this.Cmbil);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.Msktarih);
            this.groupControl1.Controls.Add(this.Btnsil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.Btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Msktel);
            this.groupControl1.Controls.Add(this.Txtiban);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Txtad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1470, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(404, 754);
            this.groupControl1.TabIndex = 4;
            // 
            // Luefirma
            // 
            this.Luefirma.Location = new System.Drawing.Point(145, 539);
            this.Luefirma.Name = "Luefirma";
            this.Luefirma.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Luefirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Luefirma.Properties.Appearance.Options.UseBackColor = true;
            this.Luefirma.Properties.Appearance.Options.UseFont = true;
            this.Luefirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Luefirma.Size = new System.Drawing.Size(194, 30);
            this.Luefirma.TabIndex = 44;
            // 
            // txthesaptur
            // 
            this.txthesaptur.Location = new System.Drawing.Point(148, 498);
            this.txthesaptur.Name = "txthesaptur";
            this.txthesaptur.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.txthesaptur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthesaptur.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txthesaptur.Properties.Appearance.Options.UseBackColor = true;
            this.txthesaptur.Properties.Appearance.Options.UseFont = true;
            this.txthesaptur.Properties.Appearance.Options.UseForeColor = true;
            this.txthesaptur.Size = new System.Drawing.Size(191, 28);
            this.txthesaptur.TabIndex = 43;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(30, 504);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(105, 22);
            this.labelControl13.TabIndex = 42;
            this.labelControl13.Text = "HESAPTÜRÜ:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(73, 542);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 22);
            this.labelControl10.TabIndex = 40;
            this.labelControl10.Text = "FİRMA:";
            // 
            // Txtadres
            // 
            this.Txtadres.Location = new System.Drawing.Point(148, 457);
            this.Txtadres.Name = "Txtadres";
            this.Txtadres.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtadres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtadres.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtadres.Properties.Appearance.Options.UseBackColor = true;
            this.Txtadres.Properties.Appearance.Options.UseFont = true;
            this.Txtadres.Properties.Appearance.Options.UseForeColor = true;
            this.Txtadres.Size = new System.Drawing.Size(191, 28);
            this.Txtadres.TabIndex = 39;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(73, 460);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 22);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "ADRES:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(64, 377);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 22);
            this.labelControl6.TabIndex = 37;
            this.labelControl6.Text = "TELEFON:";
            // 
            // Txtyetkili
            // 
            this.Txtyetkili.Location = new System.Drawing.Point(148, 325);
            this.Txtyetkili.Name = "Txtyetkili";
            this.Txtyetkili.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtyetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtyetkili.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtyetkili.Properties.Appearance.Options.UseBackColor = true;
            this.Txtyetkili.Properties.Appearance.Options.UseFont = true;
            this.Txtyetkili.Properties.Appearance.Options.UseForeColor = true;
            this.Txtyetkili.Size = new System.Drawing.Size(191, 28);
            this.Txtyetkili.TabIndex = 36;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 328);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 22);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "YETKİLİ:";
            // 
            // Txthesapno
            // 
            this.Txthesapno.Location = new System.Drawing.Point(148, 286);
            this.Txthesapno.Name = "Txthesapno";
            this.Txthesapno.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txthesapno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txthesapno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txthesapno.Properties.Appearance.Options.UseBackColor = true;
            this.Txthesapno.Properties.Appearance.Options.UseFont = true;
            this.Txthesapno.Properties.Appearance.Options.UseForeColor = true;
            this.Txthesapno.Size = new System.Drawing.Size(191, 28);
            this.Txthesapno.TabIndex = 34;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(55, 289);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(84, 22);
            this.labelControl12.TabIndex = 33;
            this.labelControl12.Text = "HESAPNO:";
            // 
            // Txtsube
            // 
            this.Txtsube.Location = new System.Drawing.Point(148, 208);
            this.Txtsube.Name = "Txtsube";
            this.Txtsube.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtsube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtsube.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtsube.Properties.Appearance.Options.UseBackColor = true;
            this.Txtsube.Properties.Appearance.Options.UseFont = true;
            this.Txtsube.Properties.Appearance.Options.UseForeColor = true;
            this.Txtsube.Size = new System.Drawing.Size(191, 28);
            this.Txtsube.TabIndex = 32;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(86, 211);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 22);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "ŞUBE:";
            // 
            // Cmbilce
            // 
            this.Cmbilce.Location = new System.Drawing.Point(148, 168);
            this.Cmbilce.Name = "Cmbilce";
            this.Cmbilce.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Cmbilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbilce.Properties.Appearance.Options.UseBackColor = true;
            this.Cmbilce.Properties.Appearance.Options.UseFont = true;
            this.Cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbilce.Size = new System.Drawing.Size(191, 28);
            this.Cmbilce.TabIndex = 28;
            // 
            // Cmbil
            // 
            this.Cmbil.Location = new System.Drawing.Point(148, 133);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbil.Properties.Appearance.Options.UseBackColor = true;
            this.Cmbil.Properties.Appearance.Options.UseFont = true;
            this.Cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbil.Size = new System.Drawing.Size(191, 28);
            this.Cmbil.TabIndex = 27;
            this.Cmbil.SelectedIndexChanged += new System.EventHandler(this.Cmbil_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(92, 174);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 22);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "İLÇE:";
            // 
            // Msktarih
            // 
            this.Msktarih.BackColor = System.Drawing.Color.Linen;
            this.Msktarih.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msktarih.ForeColor = System.Drawing.Color.Black;
            this.Msktarih.Location = new System.Drawing.Point(148, 414);
            this.Msktarih.Mask = "00/00/0000";
            this.Msktarih.Name = "Msktarih";
            this.Msktarih.Size = new System.Drawing.Size(191, 29);
            this.Msktarih.TabIndex = 23;
            this.Msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // Btnsil
            // 
            this.Btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsil.Appearance.Options.UseFont = true;
            this.Btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnsil.ImageOptions.Image")));
            this.Btnsil.Location = new System.Drawing.Point(280, 592);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(116, 44);
            this.Btnsil.TabIndex = 21;
            this.Btnsil.Text = "Sil";
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(145, 592);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(129, 44);
            this.BtnGuncelle.TabIndex = 20;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnkaydet.Appearance.Options.UseFont = true;
            this.Btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btnkaydet.ImageOptions.Image")));
            this.Btnkaydet.Location = new System.Drawing.Point(5, 592);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(116, 44);
            this.Btnkaydet.TabIndex = 19;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(114, 136);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 22);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(73, 421);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 22);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TARİH:";
            // 
            // Msktel
            // 
            this.Msktel.BackColor = System.Drawing.Color.Linen;
            this.Msktel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msktel.ForeColor = System.Drawing.Color.Black;
            this.Msktel.Location = new System.Drawing.Point(148, 370);
            this.Msktel.Mask = "(999) 000-0000";
            this.Msktel.Name = "Msktel";
            this.Msktel.Size = new System.Drawing.Size(191, 29);
            this.Msktel.TabIndex = 8;
            // 
            // Txtiban
            // 
            this.Txtiban.Location = new System.Drawing.Point(148, 246);
            this.Txtiban.Name = "Txtiban";
            this.Txtiban.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtiban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtiban.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtiban.Properties.Appearance.Options.UseBackColor = true;
            this.Txtiban.Properties.Appearance.Options.UseFont = true;
            this.Txtiban.Properties.Appearance.Options.UseForeColor = true;
            this.Txtiban.Size = new System.Drawing.Size(191, 28);
            this.Txtiban.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(88, 249);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "İBAN:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(148, 99);
            this.Txtad.Name = "Txtad";
            this.Txtad.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtad.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtad.Properties.Appearance.Options.UseBackColor = true;
            this.Txtad.Properties.Appearance.Options.UseFont = true;
            this.Txtad.Properties.Appearance.Options.UseForeColor = true;
            this.Txtad.Size = new System.Drawing.Size(191, 28);
            this.Txtad.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "BANKA AD:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(148, 59);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtid.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txtid.Properties.Appearance.Options.UseBackColor = true;
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Properties.Appearance.Options.UseForeColor = true;
            this.Txtid.Size = new System.Drawing.Size(191, 28);
            this.Txtid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(114, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmBankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Luefirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtyetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txthesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtsube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtiban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbil;
        private DevExpress.XtraEditors.SimpleButton Btnsil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton Btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit Txtiban;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txtad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit Txtadres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit Txtyetkili;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txthesapno;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit Txtsube;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbilce;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox Msktarih;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox Msktel;
        private DevExpress.XtraEditors.TextEdit txthesaptur;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LookUpEdit Luefirma;
    }
}