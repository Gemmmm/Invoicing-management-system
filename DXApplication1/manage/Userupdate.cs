using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DXApplication1.model;
using System.Data.SqlClient;

namespace DXApplication1.manage
{
    public partial class Userupdate : Form
    {
        String  id;
         User user=new User();
        private string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private SqlConnection myConnection;
        private SqlDataAdapter da;

        private DataSet ds = new DataSet();
        private DataTable LogTable;
        private DataRow LogRow;
        private string StrSQL = "SELECT * from t_user";
        public Userupdate()
        {
            InitializeComponent();
        }
        public Userupdate(String u)
        {
            InitializeComponent();
            this.id = u;
            //Userupdate_Load(null,null);

        }

        private void Userupdate_Load(object sender, EventArgs e)
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

                    user.id = LogRow[0].ToString().Trim();//保存用户ID
                    user.username = LogRow[1].ToString().Trim();//保存用户名
                    user.password = LogRow[2].ToString().Trim();//保存用户名
                    user.role = LogRow[3].ToString().Trim();//保存用户
                    user.state = LogRow[4].ToString().Trim();//保存用户;
                    //MessageBox.Show(" " + LogRow[0].ToString() + "" + LogRow[2].ToString() + "" + LogRow[4].ToString());
                    
                }
            }
            textBox1.Text = user.username;
            textBox2.Text = user.password;
            comboBox1.Text = user.role;
            if (user.state.Equals("开启"))
                toggleSwitch1.IsOn = true;
            else
                toggleSwitch1.IsOn = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";

            SqlConnection cn = new SqlConnection(s);

            try
            {
                String Switch1= null;

                if (toggleSwitch1.IsOn == true)
                    Switch1="开启";
                else
                    Switch1 = "关闭";
                    StringBuilder strsql = new StringBuilder();
                    strsql.Append("update t_user set username =");
                    strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                    strsql.Append("password =");
                    strsql.Append("'" + textBox2.Text.Trim().ToString() + "',");
                    strsql.Append("role =");
                    strsql.Append("'" + comboBox1.Text.Trim().ToString() + "',");
                    strsql.Append("state=");
                    strsql.Append("'" + Switch1 + "'");
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
