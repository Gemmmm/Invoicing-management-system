using DXApplication1.PhoneDataSetTableAdapters;
namespace DXApplication1.manage
{
    partial class goodsmanage
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tgoodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgcata = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgprice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgnum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbeizhu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.phoneDataSet1 = new DXApplication1.PhoneDataSet1();
            this.tgoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_goodsTableAdapter = new DXApplication1.PhoneDataSet1TableAdapters.t_goodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgoodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgoodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tgoodsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(751, 366);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colid,
            this.colgname,
            this.colgcata,
            this.colgprice,
            this.colgnum,
            this.colbeizhu,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "内容";
            this.gridBand1.Columns.Add(this.colid);
            this.gridBand1.Columns.Add(this.colgname);
            this.gridBand1.Columns.Add(this.colgcata);
            this.gridBand1.Columns.Add(this.colgprice);
            this.gridBand1.Columns.Add(this.colgnum);
            this.gridBand1.Columns.Add(this.colbeizhu);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 450;
            // 
            // colid
            // 
            this.colid.Caption = "编号";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            // 
            // colgname
            // 
            this.colgname.Caption = "名称";
            this.colgname.FieldName = "gname";
            this.colgname.Name = "colgname";
            this.colgname.Visible = true;
            // 
            // colgcata
            // 
            this.colgcata.Caption = "型号";
            this.colgcata.FieldName = "gcata";
            this.colgcata.Name = "colgcata";
            this.colgcata.Visible = true;
            // 
            // colgprice
            // 
            this.colgprice.Caption = "价格";
            this.colgprice.FieldName = "gprice";
            this.colgprice.Name = "colgprice";
            this.colgprice.Visible = true;
            // 
            // colgnum
            // 
            this.colgnum.Caption = "数量";
            this.colgnum.FieldName = "gnum";
            this.colgnum.Name = "colgnum";
            this.colgnum.Visible = true;
            // 
            // colbeizhu
            // 
            this.colbeizhu.Caption = "备注";
            this.colbeizhu.FieldName = "beizhu";
            this.colbeizhu.Name = "colbeizhu";
            this.colbeizhu.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "操作";
            this.gridBand2.Columns.Add(this.bandedGridColumn1);
            this.gridBand2.Columns.Add(this.bandedGridColumn2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 150;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "修改";
            this.bandedGridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "修改";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "删除";
            this.bandedGridColumn2.ColumnEdit = this.repositoryItemHyperLinkEdit2;
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            this.repositoryItemHyperLinkEdit2.NullText = "删除";
            this.repositoryItemHyperLinkEdit2.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(575, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "增加";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(656, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "刷新";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // phoneDataSet1
            // 
            this.phoneDataSet1.DataSetName = "PhoneDataSet1";
            this.phoneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tgoodsBindingSource
            // 
            this.tgoodsBindingSource.DataMember = "t_goods";
            this.tgoodsBindingSource.DataSource = this.phoneDataSet1;
            // 
            // t_goodsTableAdapter
            // 
            this.t_goodsTableAdapter.ClearBeforeFill = true;
            // 
            // goodsmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 366);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "goodsmanage";
            this.Text = "goodsmanage";
            this.Load += new System.EventHandler(this.goodsmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgoodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgoodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgcata;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgprice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgnum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbeizhu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource tgoodsBindingSource1;
        private PhoneDataSet1 phoneDataSet1;
        private System.Windows.Forms.BindingSource tgoodsBindingSource;
        private PhoneDataSet1TableAdapters.t_goodsTableAdapter t_goodsTableAdapter;
    }
}