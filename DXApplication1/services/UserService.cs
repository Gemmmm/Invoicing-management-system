using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DXApplication1.model;
using System.Data;
using System.Data.SqlClient;
namespace DXApplication1.services
{
    class UserService
    {
	
        private static SqlConnection myConnection;
        private static string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private static SqlDataAdapter da;

        private static DataSet ds = new DataSet();
        private static DataTable LogTable;
        private static  DataRow LogRow;
        private static User user = new User();
        public static User getUser(String name, string pwd)
        {
          
            myConnection = new SqlConnection(connectionString);
            da = new SqlDataAdapter("SELECT * from t_user", myConnection);
            ds.Clear();
            da.Fill(ds, "t_user");
            LogTable = ds.Tables[0];
            for (int i = 0; i < LogTable.Rows.Count; i++)
            {
                LogRow = LogTable.Rows[i];
                //只有当输入的用户名和密码同时对应上数据库中记录时，才能通过校验
                if (LogRow[1].ToString().Trim() == name.Trim()&& LogRow[2].ToString().Trim()==pwd.Trim())
                {
                    user.id = LogRow[0].ToString().Trim();//保存用户ID
                    user.username = LogRow[1].ToString().Trim().ToLower(); ;//保存用户名
                    user.role = LogRow[3].ToString().Trim();//保存用户权限
                }
            }
            return user;
 
        }
    }
}
