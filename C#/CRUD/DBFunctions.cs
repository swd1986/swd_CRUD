using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DB
{
    class DBFunctions
    {

       public static SqlConnection conn;

        public static int DBConnection(string InitialDB, string IPDataSource, string UserID, string Password)
        {

            SqlConnectionStringBuilder connect =
                new SqlConnectionStringBuilder();

            connect.InitialCatalog = InitialDB;
            connect.DataSource = @IPDataSource;
            connect.ConnectTimeout = 30;
            //connect.Encrypt = true;
            //connect.IntegratedSecurity = true;
            connect.UserID = UserID;
            connect.Password = Password;    //здесь нужно шифровать

            conn = new SqlConnection();
            try
            {
                conn.ConnectionString = connect.ConnectionString;
                //пробуем подключится
                conn.Open();
            }

            catch (SqlException)
            {
                return 0;
            }

            return 1;
        }


        public static DataTable GetQuerySQL(string SQLStr)
        {

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(SQLStr, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dt.Load(reader);

            return(dt);
        }



    }

  
     
}
