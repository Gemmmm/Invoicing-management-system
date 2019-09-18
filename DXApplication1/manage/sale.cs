﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DXApplication1.report;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;

namespace DXApplication1.manage
{
    public partial class sale : DevExpress.XtraEditors.XtraForm
    {
        public sale()
        {
            InitializeComponent();
        }

        private void sale_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet5.t_sale”中。您可以根据需要移动或删除它。
            this.t_saleTableAdapter.Fill(this.phoneDataSet5.t_sale);;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ReportPrintTool pt = new ReportPrintTool(new XtraReport2());
            pt.ShowPreview();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除该记录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                ColumnView view = (ColumnView)gridControl1.FocusedView;
               /* int selectRow = bandedGridView1.GetSelectedRows()[0];
                string id = this.bandedGridView1.GetRowCellValue(selectRow, "id").ToString();
                string taskNum = id;
                string connectionString = "Initial CataLog = Phone; integrated security=sspi";
                SqlConnection con = new SqlConnection(connectionString);
                string deleteString = "delete from t_sale where id='" + taskNum + "'";
                //MessageBox.Show(deleteString);
                SqlCommand cmd = new SqlCommand(deleteString, con);
                con.Open();
                cmd.ExecuteNonQuery();*/
                view.DeleteSelectedRows();
            }
            else
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet6.t_sale”中。您可以根据需要移动或删除它。
            this.t_saleTableAdapter.Fill(this.phoneDataSet5.t_sale);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                //ColumnView view = (ColumnView)gridControl1.FocusedView;
                //int selectRow = bandedGridView1.GetSelectedRows()[0];
                //string id = this.bandedGridView1.GetRowCellValue(selectRow, "id").ToString();
                //string taskNum = id;
                string connectionString = "Initial CataLog = Phone; integrated security=sspi";
                SqlConnection con = new SqlConnection(connectionString);
                string deleteString = "delete from t_sale";
                //MessageBox.Show(deleteString);
                SqlCommand cmd = new SqlCommand(deleteString, con);
                con.Open();
                cmd.ExecuteNonQuery();
                //view.DeleteSelectedRows();
                // TODO: 这行代码将数据加载到表“phoneDataSet5.t_purchase”中。您可以根据需要移动或删除它。
                this.t_saleTableAdapter.Fill(this.phoneDataSet5.t_sale); ;
                MessageBox.Show("提交成功","系统");
            }
            else
            {
                return;
            }
        }
        }

}
