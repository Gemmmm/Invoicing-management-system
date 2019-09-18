namespace DXApplication1.manage
{
    partial class gysmanage
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
            this.colgongyingname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colhumanname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colphonenum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colbeizhu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemHyperLinkEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.phoneDataSet2 = new DXApplication1.PhoneDataSet2();
            this.tgongyishangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_gongyishangTableAdapter = new DXApplication1.PhoneDataSet2TableAdapters.t_gongyishangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgongyishangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tgongyishangBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHyperLinkEdit2});
            this.gridControl1.Size = new System.Drawing.Size(800, 330);
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
            this.colgongyingname,
            this.colhumanname,
            this.colphonenum,
            this.colbeizhu,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            this.bandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colgongyingname, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "内容";
            this.gridBand1.Columns.Add(this.colid);
            this.gridBand1.Columns.Add(this.colgongyingname);
            this.gridBand1.Columns.Add(this.colhumanname);
            this.gridBand1.Columns.Add(this.colphonenum);
            this.gridBand1.Columns.Add(this.colbeizhu);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 544;
            // 
            // colid
            // 
            this.colid.Caption = "编号";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.Width = 107;
            // 
            // colgongyingname
            // 
            this.colgongyingname.Caption = "供应商名称";
            this.colgongyingname.FieldName = "gongyingname";
            this.colgongyingname.Name = "colgongyingname";
            this.colgongyingname.Visible = true;
            this.colgongyingname.Width = 107;
            // 
            // colhumanname
            // 
            this.colhumanname.Caption = "联系人姓名";
            this.colhumanname.FieldName = "humanname";
            this.colhumanname.Name = "colhumanname";
            this.colhumanname.Visible = true;
            this.colhumanname.Width = 107;
            // 
            // colphonenum
            // 
            this.colphonenum.Caption = "手机号";
            this.colphonenum.FieldName = "phonenum";
            this.colphonenum.Name = "colphonenum";
            this.colphonenum.Visible = true;
            this.colphonenum.Width = 107;
            // 
            // colbeizhu
            // 
            this.colbeizhu.Caption = "备注";
            this.colbeizhu.FieldName = "beizhu";
            this.colbeizhu.Name = "colbeizhu";
            this.colbeizhu.Visible = true;
            this.colbeizhu.Width = 116;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "操作";
            this.gridBand2.Columns.Add(this.bandedGridColumn1);
            this.gridBand2.Columns.Add(this.bandedGridColumn2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 238;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "修改";
            this.bandedGridColumn1.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.Width = 132;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "修改";
            this.repositoryItemHyperLinkEdit1.Click += new System.EventHandler(this.update_click);
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Caption = "删除";
            this.bandedGridColumn2.ColumnEdit = this.repositoryItemHyperLinkEdit2;
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.Width = 106;
            // 
            // repositoryItemHyperLinkEdit2
            // 
            this.repositoryItemHyperLinkEdit2.AutoHeight = false;
            this.repositoryItemHyperLinkEdit2.Name = "repositoryItemHyperLinkEdit2";
            this.repositoryItemHyperLinkEdit2.NullText = "删除";
            this.repositoryItemHyperLinkEdit2.SingleClick = true;
            this.repositoryItemHyperLinkEdit2.Click += new System.EventHandler(this.delete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(575, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "添加";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(656, 14);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "刷新";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // phoneDataSet2
            // 
            this.phoneDataSet2.DataSetName = "PhoneDataSet2";
            this.phoneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tgongyishangBindingSource
            // 
            this.tgongyishangBindingSource.DataMember = "t_gongyishang";
            this.tgongyishangBindingSource.DataSource = this.phoneDataSet2;
            // 
            // t_gongyishangTableAdapter
            // 
            this.t_gongyishangTableAdapter.ClearBeforeFill = true;
            // 
            // gysmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "gysmanage";
            this.Text = "供应商管理";
            this.Load += new System.EventHandler(this.gysmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgongyishangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgongyingname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colhumanname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colphonenum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colbeizhu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private PhoneDataSet2 phoneDataSet2;
        private System.Windows.Forms.BindingSource tgongyishangBindingSource;
        private PhoneDataSet2TableAdapters.t_gongyishangTableAdapter t_gongyishangTableAdapter;
    }
}