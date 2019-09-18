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

namespace DXApplication1.manage
{
    public partial class salelist : DevExpress.XtraEditors.XtraForm
    {
        public salelist()
        {
            InitializeComponent();
        }

        private void salelist_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet6.t_salelist”中。您可以根据需要移动或删除它。
            this.t_salelistTableAdapter.Fill(this.phoneDataSet6.t_salelist);
            // TODO: 这行代码将数据加载到表“phoneDataSet.t_salelist”中。您可以根据需要移动或删除它。
          

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
    }
}