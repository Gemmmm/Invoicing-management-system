
namespace DXApplication1.manage
{
    partial class sale
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgcata = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgysname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgprice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgnum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.price = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.totalprice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbeizhu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.购物单 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phoneDataSet5 = new DXApplication1.PhoneDataSet5();
            this.tsaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_saleTableAdapter = new DXApplication1.PhoneDataSet5TableAdapters.t_saleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(33, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(792, 306);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "购货单";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(28, 28);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "增加";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Location = new System.Drawing.Point(684, 267);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "提交";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(603, 267);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "打印";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(109, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "刷新";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tsaleBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(29, 65);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(735, 177);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand,
            this.购物单});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colid,
            this.colgname,
            this.colgcata,
            this.colgysname,
            this.colgprice,
            this.colgnum,
            this.price,
            this.totalprice,
            this.colbeizhu,
            this.bandedGridColumn3,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.bandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colgname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand
            // 
            this.gridBand.Caption = "销售单";
            this.gridBand.Columns.Add(this.colid);
            this.gridBand.Columns.Add(this.colgname);
            this.gridBand.Columns.Add(this.colgcata);
            this.gridBand.Columns.Add(this.colgysname);
            this.gridBand.Columns.Add(this.colgprice);
            this.gridBand.Columns.Add(this.colgnum);
            this.gridBand.Columns.Add(this.price);
            this.gridBand.Columns.Add(this.totalprice);
            this.gridBand.Columns.Add(this.colbeizhu);
            this.gridBand.Name = "gridBand";
            this.gridBand.VisibleIndex = 0;
            this.gridBand.Width = 600;
            // 
            // colid
            // 
            this.colid.Caption = "编号";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colgname
            // 
            this.colgname.Caption = "名称";
            this.colgname.FieldName = "goodsname";
            this.colgname.Name = "colgname";
            this.colgname.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "goodsname", "{0}")});
            this.colgname.Visible = true;
            // 
            // colgcata
            // 
            this.colgcata.Caption = "单位";
            this.colgcata.FieldName = "danwei";
            this.colgcata.Name = "colgcata";
            this.colgcata.Visible = true;
            // 
            // colgysname
            // 
            this.colgysname.Caption = "供应商";
            this.colgysname.FieldName = "gysname";
            this.colgysname.Name = "colgysname";
            this.colgysname.Visible = true;
            // 
            // colgprice
            // 
            this.colgprice.Caption = "仓库";
            this.colgprice.FieldName = "cangku";
            this.colgprice.Name = "colgprice";
            this.colgprice.Visible = true;
            // 
            // colgnum
            // 
            this.colgnum.Caption = "数量";
            this.colgnum.FieldName = "num";
            this.colgnum.Name = "colgnum";
            this.colgnum.Visible = true;
            // 
            // price
            // 
            this.price.Caption = "价格";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Visible = true;
            // 
            // totalprice
            // 
            this.totalprice.Caption = "总价格";
            this.totalprice.FieldName = "totleprice";
            this.totalprice.Name = "totalprice";
            this.totalprice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totleprice", "SUM={0:0.##}")});
            this.totalprice.Visible = true;
            // 
            // colbeizhu
            // 
            this.colbeizhu.Caption = "备注";
            this.colbeizhu.FieldName = "beizhu";
            this.colbeizhu.Name = "colbeizhu";
            this.colbeizhu.Visible = true;
            // 
            // 购物单
            // 
            this.购物单.Caption = "操作";
            this.购物单.Columns.Add(this.bandedGridColumn2);
            this.购物单.Name = "购物单";
            this.购物单.VisibleIndex = 1;
            this.购物单.Width = 75;
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
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "修改";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "修改";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // phoneDataSet5
            // 
            this.phoneDataSet5.DataSetName = "PhoneDataSet5";
            this.phoneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsaleBindingSource
            // 
            this.tsaleBindingSource.DataMember = "t_sale";
            this.tsaleBindingSource.DataSource = this.phoneDataSet5;
            // 
            // t_saleTableAdapter
            // 
            this.t_saleTableAdapter.ClearBeforeFill = true;
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 391);
            this.Controls.Add(this.groupControl1);
            this.Name = "sale";
            this.Text = "sale";
            this.Load += new System.EventHandler(this.sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgcata;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgysname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgprice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgnum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn price;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn totalprice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbeizhu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand 购物单;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PhoneDataSet5 phoneDataSet5;
        private System.Windows.Forms.BindingSource tsaleBindingSource;
        private PhoneDataSet5TableAdapters.t_saleTableAdapter t_saleTableAdapter;
    }
}