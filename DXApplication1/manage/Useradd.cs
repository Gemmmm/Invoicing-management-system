using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication1.manage
{
    public partial class Useradd : Form
    {
        public Useradd()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("密码不能为空！");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("角色不能为空！");
            }
            
            
            String s = "workstation id=localhost;Initial CataLog = Phone; integrated security=sspi";
           
             SqlConnection cn = new SqlConnection(s);
            // cn.Open();

            // String s1 = "insert into t_user values("+textBox1.Text+","+textBox2.Text+","+comboBox1.Text+")";
            // SqlDataAdapter da = new SqlDataAdapter(s1, cn);
            
            // cn.Close();
            // MessageBox.Show(s1);
             //this.Close();
             try
            {
                string sql = string.Format("select count(*) from t_user where username='{0}'", textBox1.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
 
                cn.Open();
                int a = (int)cmd.ExecuteScalar();//返回一个值，看用户是否存在
                StringBuilder strsql = new StringBuilder();
                if (a==0)
                {
                    strsql.Append("insert into t_user(username,password,role,state)");
                    strsql.Append("values(");
                    strsql.Append("'" + textBox1.Text.Trim().ToString() + "',");
                    strsql.Append("'" + textBox2.Text.Trim().ToString() + "',");
                    strsql.Append("'" + comboBox1.Text.Trim().ToString() +"',");
                    strsql.Append("'开启'");
                    strsql.Append(")");
                    using (SqlCommand cmd2 = new SqlCommand(strsql.ToString(), cn))
                    {
                        cmd2.ExecuteNonQuery();
 
                    }
                        this.Owner.Refresh();
                        MessageBox.Show("添加成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                       
                        this.Close();
                    
                }
 
 
               
                else
                {
                    this.Owner.Refresh();
                    MessageBox.Show("用户已存在！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    this.Close();
                }
                
 
            }
 
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
 
            finally
            {
                this.Owner.Refresh();
               cn.Close();
                cn.Dispose();
              
            }

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
