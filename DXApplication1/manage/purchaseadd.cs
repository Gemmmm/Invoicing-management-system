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
    public partial class purchaseadd : DevExpress.XtraEditors.XtraForm
    {
        public purchaseadd()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purchaseadd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“phoneDataSet2.t_gongyishang”中。您可以根据需要移动或删除它。
            this.t_gongyishangTableAdapter.Fill(this.phoneDataSet2.t_gongyishang);
        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (textEdit1.Text == "")
            {
                MessageBox.Show("名称不能为空！");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("单位不能为空！");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("供应商不能为空！");
            }
            else if (comboBox4.Text == "")
            {
                MessageBox.Show("仓库不能为空！");
            }
            else if (textEdit2.Text == "")
            {
                MessageBox.Show("价格不能为空！");
            }
            else if (textEdit3.Text == "")
            {
                MessageBox.Show("数量不能为空！");
            }
            else if (textEdit4.Text == "")
            {
                MessageBox.Show("备注不能为空！");
            }
            int num = Convert.ToInt32(textEdit3.Text);
            double price = Convert.ToDouble(textEdit2.Text);
            
            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";
            SqlConnection cn = new SqlConnection(s);
            try
            {
                string sql = string.Format("select count(*) from t_purchase where id='{0}'", "1000");
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                int a = (int)cmd.ExecuteScalar();//返回一个值，看用户是否存在
                StringBuilder strsql = new StringBuilder();
                StringBuilder strsql1 = new StringBuilder();
                if (a == 0)
                {
                    strsql.Append("insert into t_purchase(gysname,goodsname,danwei,cangku,price,totleprice,date,beizhu,num)");
                    strsql.Append("values(");
                    strsql.Append("'" + comboBox3.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textEdit1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + comboBox2.Text.Trim().ToString() + "',");
                    strsql.Append("'" + comboBox4.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textEdit2.Text.Trim().ToString() + "',");
                    strsql.Append("'" + (num*price).ToString() + "',");
                    strsql.Append("'" + dateEdit1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textEdit4.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textEdit3.Text.Trim().ToString() + "'");
                    strsql.Append(")");

                    strsql1.Append("insert into t_purchaselist(goodsname,danwei,cangku,price,totleprice,date,beizhu,num)");
                    strsql1.Append("values(");
                    strsql1.Append("'" + textEdit1.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + comboBox2.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + comboBox3.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + textEdit2.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + (num * price).ToString() + "',");
                    strsql1.Append("'" + dateEdit1.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + textEdit4.Text.Trim().ToString() + "',");
                    strsql1.Append("'" + textEdit3.Text.Trim().ToString() + "'");
                    strsql1.Append(")");

                    using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(), cn))
                    {
                        cmd2.ExecuteNonQuery();

                    }
                    using (SqlCommand cmd3 = new SqlCommand(strsql1.ToString(), cn))
                    {
                        cmd3.ExecuteNonQuery();

                    }
                    MessageBox.Show("添加成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Close();

                }



                else
                {

                    MessageBox.Show("该信息已存在！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Close();
                }


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