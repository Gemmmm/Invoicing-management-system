using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DXApplication1.services
{
    /// <summary>
    /// LinkDataBase 的摘要说明。
    /// </summary>
    public class LinkDataBase
    {
        private string strSQL;
        //与SQL Server的连接字符串设置
        private string connectionString = "workstation id=localhost;Integrated Security=SSPI;database=Phone";
        //与数据库的连接
        private SqlConnection myConnection;

        private SqlCommandBuilder sqlCmdBld;
        private DataSet ds = new DataSet();
        private SqlDataAdapter da;

        public LinkDataBase()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /////////////////////////////////  操作脱机数据库(创建了该类的实例时直接用)  /////////////////////////////////////////////////////

        //根据输入的SQL语句检索数据库数据
        public DataSet SelectDataBase(string tempStrSQL, string tempTableName)
        {
            this.strSQL = tempStrSQL;
            this.myConnection = new SqlConnection(connectionString);
            this.da = new SqlDataAdapter(this.strSQL, this.myConnection);
            this.ds.Clear();
            this.da.Fill(ds, tempTableName);
            return ds;//返回填充了数据的DataSet，其中数据表以tempTableName给出的字符串命名
        }

        //数据库数据更新(传DataSet和DataTable的对象)
        public DataSet UpdateDataBase(DataSet changedDataSet, string tableName)
        {
            this.myConnection = new SqlConnection(connectionString);
            this.da = new SqlDataAdapter(this.strSQL, this.myConnection);
            this.sqlCmdBld = new SqlCommandBuilder(da);
            this.da.Update(changedDataSet, tableName);
            return changedDataSet;//返回更新了的数据库表
        }

        /////////////////////////////////  直接操作数据库(未创建该类的实例时直接用)  /////////////////////////////////////////////////////

        //检索数据库数据(传字符串,直接操作数据库)
        public DataTable SelectDataBase(string tempStrSQL)
        {
            this.myConnection = new SqlConnection(connectionString);
            DataSet tempDataSet = new DataSet();
            this.da = new SqlDataAdapter(tempStrSQL, this.myConnection);
            this.da.Fill(tempDataSet);
            return tempDataSet.Tables[0];
        }

        //数据库数据更新(传字符串，直接操作数据库)
        public int UpdateDataBase(string tempStrSQL)
        {
            this.myConnection = new SqlConnection(connectionString);
            //使用Command之前一定要先打开连接,后关闭连接,而DataAdapter则会自动打开关闭连接
            myConnection.Open();
            SqlCommand tempSqlCommand = new SqlCommand(tempStrSQL, this.myConnection);
            int intNumber = tempSqlCommand.ExecuteNonQuery();//返回数据库中影响的行数
            myConnection.Close();
            return intNumber;
        }
    }
}
