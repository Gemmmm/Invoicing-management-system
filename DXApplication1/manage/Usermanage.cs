using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DXApplication1.model;

namespace DXApplication1.manage
{
    public partial class Usermanage : DevExpress.XtraEditors.XtraForm
    {
        index index1;
        public Usermanage()
        {
            InitializeComponent();
        }
        public Usermanage(index i)
        {
            InitializeComponent();
            this.index1 = i;
        }

        private void Usermanage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet7.t_user”中。您可以根据需要移动或删除它。
            this.t_userTableAdapter.Fill(this.phoneDataSet7.t_user);
      
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除该记录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {  
                ColumnView view = (ColumnView)gridControl1.FocusedView;               
                int selectRow = gridView1.GetSelectedRows()[0];
                string id = this.gridView1.GetRowCellValue(selectRow, "id").ToString();
                string taskNum = id;             
                string connectionString = "Initial CataLog = Phone; integrated security=sspi";
                SqlConnection con = new SqlConnection(connectionString);
                string deleteString = "delete from t_user where id='" + taskNum + "'";
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


        private void update_click(object sender, EventArgs e)
        {
            int selectRow = gridView1.GetSelectedRows()[0];
            string id = this.gridView1.GetRowCellValue(selectRow, "id").ToString();
           
            Userupdate uu = new Userupdate(id);
            uu.Owner = this;
            uu.ShowDialog();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Useradd ua = new Useradd();
            ua.Owner = this;
            ua.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;

            ColumnView view = (ColumnView)gridControl1.FocusedView
;
            GridColumn column = null;
            if (!text.Trim().Equals(""))
            {

                column = view.Columns["username"];

            }
            else
            {
                MessageBox.Show("请输入用户名或姓名!");
            }

            if (column != null)
            {
                int rhFound = 0;
                //从第0行开始查询,查询的列,匹配列中的值
                rhFound = view.LocateByDisplayText(0, column, text);

                //如果行值正常,即条件满足，存在
                if (rhFound != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                {
                    view.FocusedRowHandle = rhFound;
                    view.FocusedColumn = column;
                    view.SelectRow(rhFound);

                }
                else
                {
                    MessageBox.Show("无此用户名或姓名!");
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.t_userTableAdapter.Fill(this.phoneDataSet7.t_user);
      
        }

    

   
        

      

    }
}