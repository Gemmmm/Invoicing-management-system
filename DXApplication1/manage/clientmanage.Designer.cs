namespace DXApplication1.manage
{
    partial class clientmanage
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
            this.cname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colccata = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcphone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcaddr = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.phoneDataSet = new DXApplication1.PhoneDataSet();
            this.tclientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_clientTableAdapter = new DXApplication1.PhoneDataSetTableAdapters.t_clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tclientBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(661, 388);
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
            this.cname,
            this.colccata,
            this.colcphone,
            this.colcaddr,
            this.gridColumn1,
            this.gridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colid);
            this.gridBand1.Columns.Add(this.cname);
            this.gridBand1.Columns.Add(this.colccata);
            this.gridBand1.Columns.Add(this.colcphone);
            this.gridBand1.Columns.Add(this.colcaddr);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 375;
            // 
            // colid
            // 
            this.colid.Caption = "编号";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            // 
            // cname
            // 
            this.cname.Caption = "姓名";
            this.cname.FieldName = "cname";
            this.cname.Name = "cname";
            this.cname.Visible = true;
            // 
            // colccata
            // 
            this.colccata.Caption = "类别";
            this.colccata.FieldName = "ccata";
            this.colccata.Name = "colccata";
            this.colccata.Visible = true;
            // 
            // colcphone
            // 
            this.colcphone.Caption = "电话";
            this.colcphone.FieldName = "cphone";
            this.colcphone.Name = "colcphone";
            this.colcphone.Visible = true;
            // 
            // colcaddr
            // 
            this.colcaddr.Caption = "地址";
            this.colcaddr.FieldName = "caddr";
            this.colcaddr.Name = "colcaddr";
            this.colcaddr.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "操作";
            this.gridBand2.Columns.Add(this.gridColumn1);
            this.gridBand2.Columns.Add(this.gridColumn2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 150;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "修改";
            this.gridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "修改";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "删除";
            this.gridColumn2.ColumnEdit = this.repositoryItemHyperLinkEdit2;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            this.repositoryItemHyperLinkEdit2.NullText = "删除";
            this.repositoryItemHyperLinkEdit2.Click += new System.EventHandler(this.delete_Click);
            // 
            // phoneDataSet
            // 
            this.phoneDataSet.DataSetName = "PhoneDataSet";
            this.phoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tclientBindingSource
            // 
            this.tclientBindingSource.DataMember = "t_client";
            this.tclientBindingSource.DataSource = this.phoneDataSet;
            // 
            // t_clientTableAdapter
            // 
            this.t_clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 388);
            this.Controls.Add(this.gridControl1);
            this.Name = "clientmanage";
            this.Text = "clientmanage";
            this.Load += new System.EventHandler(this.clientmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tclientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn cname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colccata;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcphone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcaddr;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private PhoneDataSet phoneDataSet;
        private System.Windows.Forms.BindingSource tclientBindingSource;
        private PhoneDataSetTableAdapters.t_clientTableAdapter t_clientTableAdapter;
    }
}