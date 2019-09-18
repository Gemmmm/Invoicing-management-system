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
    public partial class gysadd : DevExpress.XtraEditors.XtraForm
    {
        public gysadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("供应商名称不能为空！");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("联系人姓名不能为空！");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("联系人电话不能为空！");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("备注不能为空！");
            }
            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";

            SqlConnection cn = new SqlConnection(s);
            try
            {
                string sql = string.Format("select count(*) from t_gongyishang where gongyingname='{0}'", textBox1.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();
                int a = (int)cmd.ExecuteScalar();//返回一个值，看用户是否存在
                StringBuilder strsql = new StringBuilder();
                if (a == 0)
                {
                    strsql.Append("insert into t_gongyishang(gongyingname,humanname,phonenum,beizhu)");
                    strsql.Append("values(");
                    strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textBox2.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textBox3.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textBox4.Text.Trim().ToString() + "'");
                    strsql.Append(")");
                    using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(), cn))
                    {
                        cmd2.ExecuteNonQuery();

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