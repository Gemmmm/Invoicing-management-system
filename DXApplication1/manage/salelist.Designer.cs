
using DXApplication1.PhoneDataSetTableAdapters;
namespace DXApplication1.manage
{
    partial class salelist
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
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.phoneDataSet6 = new DXApplication1.PhoneDataSet6();
            this.tsalelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_salelistTableAdapter = new DXApplication1.PhoneDataSet6TableAdapters.t_salelistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalelistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tsalelistBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(534, 312);
            this.gridControl1.TabIndex = 2;
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
            this.gridBand2.Columns.Add(this.bandedGridColumn2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 75;
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
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "修改";
            // 
            // phoneDataSet6
            // 
            this.phoneDataSet6.DataSetName = "PhoneDataSet6";
            this.phoneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsalelistBindingSource
            // 
            this.tsalelistBindingSource.DataMember = "t_salelist";
            this.tsalelistBindingSource.DataSource = this.phoneDataSet6;
            // 
            // t_salelistTableAdapter
            // 
            this.t_salelistTableAdapter.ClearBeforeFill = true;
            // 
            // salelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.gridControl1);
            this.Name = "salelist";
            this.Text = "salelist";
            this.Load += new System.EventHandler(this.salelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsalelistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgcata;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgprice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgnum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbeizhu;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private PhoneDataSet6 phoneDataSet6;
        private System.Windows.Forms.BindingSource tsalelistBindingSource;
        private PhoneDataSet6TableAdapters.t_salelistTableAdapter t_salelistTableAdapter;
    }
}