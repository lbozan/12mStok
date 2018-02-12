namespace DevxTest
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtBitTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBasTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAra = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IslemTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GirisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CikisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitContainerControl1.Panel1.Controls.Add(this.btnExport);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnYazdir);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnAra);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtBitTarih);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtBasTarih);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtAra);
            this.splitContainerControl1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.splitContainerControl1.Panel1.Text = "topPanel";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "bottomPanel";
            this.splitContainerControl1.Size = new System.Drawing.Size(739, 446);
            this.splitContainerControl1.SplitterPosition = 102;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(361, 57);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 25);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara..";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtBitTarih
            // 
            this.txtBitTarih.EditValue = null;
            this.txtBitTarih.Location = new System.Drawing.Point(577, 21);
            this.txtBitTarih.Name = "txtBitTarih";
            this.txtBitTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBitTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBitTarih.Size = new System.Drawing.Size(144, 20);
            this.txtBitTarih.TabIndex = 2;
            // 
            // txtBasTarih
            // 
            this.txtBasTarih.EditValue = null;
            this.txtBasTarih.Location = new System.Drawing.Point(361, 21);
            this.txtBasTarih.Name = "txtBasTarih";
            this.txtBasTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBasTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBasTarih.Size = new System.Drawing.Size(139, 20);
            this.txtBasTarih.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(519, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Bitiş Tarihi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(282, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Başlangıç Tarihi:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Arama:";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(77, 21);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(189, 20);
            this.txtAra.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(739, 339);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SiraNo,
            this.IslemTuru,
            this.EvrakNo,
            this.Tarih,
            this.GirisMiktar,
            this.CikisMiktar,
            this.StokMiktar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintFooter = false;
            this.gridView1.OptionsPrint.PrintGroupFooter = false;
            // 
            // SiraNo
            // 
            this.SiraNo.Caption = "Sıra No";
            this.SiraNo.FieldName = "SiraNo";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.OptionsColumn.AllowEdit = false;
            this.SiraNo.Visible = true;
            this.SiraNo.VisibleIndex = 0;
            // 
            // IslemTuru
            // 
            this.IslemTuru.Caption = "İşlem Türü";
            this.IslemTuru.FieldName = "IslemTuru";
            this.IslemTuru.Name = "IslemTuru";
            this.IslemTuru.OptionsColumn.AllowEdit = false;
            this.IslemTuru.Visible = true;
            this.IslemTuru.VisibleIndex = 1;
            // 
            // EvrakNo
            // 
            this.EvrakNo.Caption = "Evrak No";
            this.EvrakNo.FieldName = "IslemTuru";
            this.EvrakNo.Name = "EvrakNo";
            this.EvrakNo.OptionsColumn.AllowEdit = false;
            this.EvrakNo.Visible = true;
            this.EvrakNo.VisibleIndex = 2;
            // 
            // GirisMiktar
            // 
            this.GirisMiktar.Caption = "Giriş Miktarı";
            this.GirisMiktar.FieldName = "GirisMiktar";
            this.GirisMiktar.Name = "GirisMiktar";
            this.GirisMiktar.OptionsColumn.AllowEdit = false;
            this.GirisMiktar.Visible = true;
            this.GirisMiktar.VisibleIndex = 4;
            // 
            // CikisMiktar
            // 
            this.CikisMiktar.Caption = "Çıkış Miktarı";
            this.CikisMiktar.FieldName = "CikisMiktar";
            this.CikisMiktar.Name = "CikisMiktar";
            this.CikisMiktar.OptionsColumn.AllowEdit = false;
            this.CikisMiktar.Visible = true;
            this.CikisMiktar.VisibleIndex = 5;
            // 
            // StokMiktar
            // 
            this.StokMiktar.Caption = "Stok Miktarı";
            this.StokMiktar.FieldName = "StokMiktar";
            this.StokMiktar.Name = "StokMiktar";
            this.StokMiktar.OptionsColumn.AllowEdit = false;
            this.StokMiktar.Visible = true;
            this.StokMiktar.VisibleIndex = 6;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.OptionsColumn.AllowEdit = false;
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 3;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(577, 58);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(659, 58);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 446);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBitTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBitTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBasTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.DateEdit txtBasTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAra;
        private DevExpress.XtraEditors.DateEdit txtBitTarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn IslemTuru;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn GirisMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn CikisMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn StokMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}

