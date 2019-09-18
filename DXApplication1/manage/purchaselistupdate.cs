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

namespace DXApplication1.manage
{
    public partial class purchaselistupdate : DevExpress.XtraEditors.XtraForm
    {
        String id;
        private string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private SqlConnection myConnection;
        private SqlDataAdapter da;

        private DataSet ds = new DataSet();
        private DataTable LogTable;
        private DataRow LogRow;
        private string StrSQL = "SELECT * from t_purchaselist";
        public purchaselistupdate()
        {
            InitializeComponent();
        }
        public purchaselistupdate(string i)
        {
            InitializeComponent();
            this.id = i;
        }

        private void purchaselistupdate_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet2.t_gongyishang”中。您可以根据需要移动或删除它。
            this.t_gongyishangTableAdapter.Fill(this.phoneDataSet2.t_gongyishang);
            this.myConnection = new SqlConnection(connectionString);
            this.da = new SqlDataAdapter(this.StrSQL, this.myConnection);
            this.ds.Clear();
            this.da.Fill(ds, "t_goods");
            this.LogTable = ds.Tables[0];
            //MessageBox.Show(id);

            for (int i = 0; i < LogTable.Rows.Count; i++)
            {
                this.LogRow = LogTable.Rows[i];
                //只有当输入的用户名和密码同时对应上数据库中记录时，才能通过校验

                if (LogRow[0].ToString().Trim() == id.Trim().ToLower())
                {

                    textEdit1.Text = LogRow[1].ToString().Trim();//保存用户ID
                    comboBox2.Text = LogRow[2].ToString().Trim();//保存用户名
                    comboBox4.Text = LogRow[3].ToString().Trim();//保存用户名
                    textEdit3.Text = LogRow[4].ToString().Trim();//保存用户
                    textEdit2.Text = LogRow[5].ToString().Trim();//保存用户
                    dateEdit1.Text = LogRow[7].ToString().Trim();//保存用户
                    textEdit5.Text = LogRow[6].ToString().Trim();//保存用户
                    textEdit4.Text = LogRow[8].ToString().Trim();//保存用户
                    comboBox3.Text = LogRow[9].ToString().Trim();//保存用户
                    //MessageBox.Show(" " + LogRow[0].ToString() + "" + LogRow[2].ToString() + "" + LogRow[4].ToString());

                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";

            SqlConnection cn = new SqlConnection(s);

            try
            {

                StringBuilder strsql = new StringBuilder();
                strsql.Append("update t_purchaselist set goodsname =");
                strsql.Append("'" + textEdit1.Text.Trim().ToString() + "',");
                strsql.Append("danwei =");
                strsql.Append("'" + comboBox2.Text.Trim().ToString() + "',");
                strsql.Append("cangku =");
                strsql.Append("'" + comboBox4.Text.Trim().ToString() + "',");
                strsql.Append("num=");
                strsql.Append("'" + textEdit3.Text.Trim().ToString() + "',");
                strsql.Append("price=");
                strsql.Append("'" + textEdit2.Text.Trim().ToString() + "',");
                strsql.Append("totleprice=");
                strsql.Append("'" + textEdit5.Text.Trim().ToString() + "',");
                strsql.Append("date=");
                strsql.Append("'" + dateEdit1.Text.Trim().ToString() + "',");
                strsql.Append("gysname =");
                strsql.Append("'" + comboBox3.Text.Trim().ToString() + "',");
                strsql.Append("beizhu=");
                strsql.Append("'" + textEdit4.Text.Trim().ToString() + "'");
                strsql.Append("where id=");
                strsql.Append("'" + id + "'");
                cn.Open();
                SqlCommand cmd2 = new SqlCommand(strsql.ToString(), cn);

                cmd2.ExecuteNonQuery();


                MessageBox.Show("修改成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }

            finally
            {

                cn.Close();
                cn.Dispose();

            }
        }
    }
}