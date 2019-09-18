using DXApplication1.PhoneDataSetTableAdapters;
namespace DXApplication1.manage
{
    partial class purchaselist
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
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgcata = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgprice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgnum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbeizhu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.phoneDataSet4 = new DXApplication1.PhoneDataSet4();
            this.tpurchaselistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_purchaselistTableAdapter = new DXApplication1.PhoneDataSet4TableAdapters.t_purchaselistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpurchaselistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tpurchaselistBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(661, 399);
            this.gridControl1.TabIndex = 1;
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
            this.bandedGridColumn4,
            this.bandedGridColumn3,
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
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.colbeizhu);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 600;
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
            this.colgname.FieldName = "goodsname";
            this.colgname.Name = "colgname";
            this.colgname.Visible = true;
            // 
            // colgcata
            // 
            this.colgcata.Caption = "单位";
            this.colgcata.FieldName = "danwei";
            this.colgcata.Name = "colgcata";
            this.colgcata.Visible = true;
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
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "价格";
            this.bandedGridColumn4.FieldName = "price";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "总价格";
            this.bandedGridColumn3.FieldName = "totleprice";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
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
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.update_Click);
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
            this.repositoryItemHyperLinkEdit2.Click += new System.EventHandler(this.delete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(574, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "刷新";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // phoneDataSet4
            // 
            this.phoneDataSet4.DataSetName = "PhoneDataSet4";
            this.phoneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpurchaselistBindingSource
            // 
            this.tpurchaselistBindingSource.DataMember = "t_purchaselist";
            this.tpurchaselistBindingSource.DataSource = this.phoneDataSet4;
            // 
            // t_purchaselistTableAdapter
            // 
            this.t_purchaselistTableAdapter.ClearBeforeFill = true;
            // 
            // purchaselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 399);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "purchaselist";
            this.Text = "purchaselist";
            this.Load += new System.EventHandler(this.purchaselist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpurchaselistBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private PhoneDataSet4 phoneDataSet4;
        private System.Windows.Forms.BindingSource tpurchaselistBindingSource;
        private PhoneDataSet4TableAdapters.t_purchaselistTableAdapter t_purchaselistTableAdapter;
    }
}