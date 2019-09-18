using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;

namespace DXApplication1.manage
{
    public partial class goodsmanage : DevExpress.XtraEditors.XtraForm
    {
        public goodsmanage()
        {
            InitializeComponent();
        }

        private void goodsmanage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet1.t_goods”中。您可以根据需要移动或删除它。
            this.t_goodsTableAdapter.Fill(this.phoneDataSet1.t_goods);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            goodsadd gs = new goodsadd();
            gs.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)gridControl1.FocusedView;
            int selectRow = bandedGridView1.GetSelectedRows()[0];
            string id = this.bandedGridView1.GetRowCellValue(selectRow, "id").ToString();
            goodsupdate gu = new goodsupdate(id);
            gu.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("是否删除该记录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                ColumnView view = (ColumnView)gridControl1.FocusedView;
                int selectRow =bandedGridView1.GetSelectedRows()[0];
                string id = this.bandedGridView1.GetRowCellValue(selectRow, "id").ToString();
                string taskNum = id;
                string connectionString = "Initial CataLog = Phone; integrated security=sspi";
                SqlConnection con = new SqlConnection(connectionString);
                string deleteString = "delete from t_goods where id='" + taskNum + "'";
                //MessageBox.Show(deleteString);
                SqlCommand cmd = new SqlCommand(deleteString, con);
                con.Open();
                cmd.ExecuteNonQuery();
                view.DeleteSelectedRows();
            }
            else
            {
                return;
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.t_goodsTableAdapter.Fill(this.phoneDataSet1.t_goods);

        }


        private void tgoodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        }
 
}