using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.services;
using DXApplication1.model;
using System.Data;
using System.Data.SqlClient;
namespace DXApplication1
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public  bool CanLogin = false; 
        private string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private SqlConnection myConnection;
        private SqlDataAdapter da;

        private DataSet ds = new DataSet();
        private DataTable LogTable;
        private DataRow LogRow;

        private string StrSQL = "SELECT * from t_user";
       public User user = new User();

        public login()
        {
            
            InitializeComponent();
            Login_Load(null, null);
            this.myConnection = new SqlConnection(connectionString);
            this.da = new SqlDataAdapter(this.StrSQL, this.myConnection);
            this.ds.Clear();
            this.da.Fill(ds, "t_user");
            this.LogTable = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.text1.Text;
            String password = this.text2.Text;
            if (username == "")
            {
                MessageBox.Show("请输入用户名！", "系统消息");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("请输入密码！", "系统消息");
                return;
            }
            else
            {
             for (int i = 0; i < LogTable.Rows.Count; i++)
                {
                    this.LogRow = LogTable.Rows[i];
                    //只有当输入的用户名和密码同时对应上数据库中记录时，才能通过校验
                    if (LogRow[1].ToString().Trim() == username.Trim().ToLower() && LogRow[2].ToString().Trim().ToLower() == password.Trim())
                    {
                       user.id = LogRow[0].ToString().Trim();//保存用户ID
                        user.username = LogRow[1].ToString().Trim();//保存用户名
                        user.password = LogRow[2].ToString().Trim();//保存用户名
                        user.role = LogRow[3].ToString().Trim();//保存用户
                        user.state = LogRow[4].ToString().Trim();//保存用户
                        CanLogin = true;
                        this.Close();
                      return;
                    }
                }
                MessageBox.Show("您输入的用户号或密码不正确!");
            
            }

          
        }
        private void Login_Load(object sender, EventArgs e)
        {
          
          toolStripStatusLabel1.Text = "欢迎使用！";
              
         
        }
    }
}