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
    public partial class gysupdate : DevExpress.XtraEditors.XtraForm
    {
        String id;
        private string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private SqlConnection myConnection;
        private SqlDataAdapter da;

        private DataSet ds = new DataSet();
        private DataTable LogTable;
        private DataRow LogRow;
        private string StrSQL = "SELECT * from t_gongyishang";
        public gysupdate()
        {
            InitializeComponent();
        }
        public gysupdate( String i)
        {
            InitializeComponent();
            id = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";

            SqlConnection cn = new SqlConnection(s);

            try
            {
          
                StringBuilder strsql = new StringBuilder();
                strsql.Append("update t_gongyishang set gongyingname =");
                strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                strsql.Append("humanname =");
                strsql.Append("'" + textBox2.Text.Trim().ToString() + "',");
                strsql.Append("phonenum =");
                strsql.Append("'" + textBox3.Text.Trim().ToString() + "',");
                strsql.Append("beizhu=");
                strsql.Append("'" + textBox4.Text.Trim().ToString() + "'");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gysupdate_Load(object sender, EventArgs e)
        {
            this.myConnection = new SqlConnection(connectionString);
            this.da = new SqlDataAdapter(this.StrSQL, this.myConnection);
            this.ds.Clear();
            this.da.Fill(ds, "t_user");
            this.LogTable = ds.Tables[0];
            //MessageBox.Show(id);
      
            for (int i = 0; i < LogTable.Rows.Count; i++)
            {
                this.LogRow = LogTable.Rows[i];
                //只有当输入的用户名和密码同时对应上数据库中记录时，才能通过校验

                if (LogRow[0].ToString().Trim() == id.Trim().ToLower())
                {

                   textBox1.Text = LogRow[1].ToString().Trim();//保存用户ID
                   textBox2.Text = LogRow[2].ToString().Trim();//保存用户名
                   textBox3.Text = LogRow[3].ToString().Trim();//保存用户名
                   textBox4.Text = LogRow[4].ToString().Trim();//保存用户
                    //MessageBox.Show(" " + LogRow[0].ToString() + "" + LogRow[2].ToString() + "" + LogRow[4].ToString());

                }
            }
        }
    }
}