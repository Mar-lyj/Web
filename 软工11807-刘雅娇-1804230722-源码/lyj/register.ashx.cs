using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace jQuery_Ajax_Register
{
    /// <summary>
    /// register 的摘要说明
    /// </summary>
    public class register : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string name = context.Request["username"];
            string email = context.Request["email"];
            string chname = context.Request["chname"];
            string phone = context.Request["phone"];
            string sex = context.Request["gender"];
            string birth = context.Request["birth"];

            //1.连接数据库
            SqlConnection conn = new SqlConnection("server=bds275280454.my3w.com;database=bds275280454_db;uid=bds275280454;pwd=bds275280454@633");
            //SqlConnection conn = new SqlConnection("server=.\\SQLyog - 64 bit;database=userinfo;integrated security=true");
            //2.数据操作对象
            string sql = "insert into UserInfo(U_Name,U_pwd,U_Email,U_ChName,U_Phone,U_sex,U_Birth) values('" + name + "','" + pwd + "','" + email + "','" + chname + "','" + phone + "','" + sex + "','" + birth + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //3.执行sql语句
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            //4.判断结果
            if (result >= 1)
            {
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}