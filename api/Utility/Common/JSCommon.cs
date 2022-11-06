using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using ngJSApp;

namespace JSLibrary
{
    public class JSCommon
    {
        public static SqlConnection GetSQLConnection() {
            return new SqlConnection(Startup.DBConnectionString);
        }

        //public static string GetSQLConnectionString()
        //{
        //    var Server = ConfigurationManager.AppSettings["Server"];
        //    var Database = ConfigurationManager.AppSettings["Database"];
        //    var UserId = ConfigurationManager.AppSettings["UserID"];
        //    var password = ConfigurationManager.AppSettings["Password"];
        //    var configuration = new ConfigurationBuilder()
        //          .SetBasePath(env.ContentRootPath)
        //          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

        //    Configuration = builder.Build();
        //    var StringBuilder = new SqlConnectionStringBuilder
        //    {
        //        DataSource = Server,
        //        InitialCatalog = Database,
        //        UserID = UserId,
        //        Password = password

        //    };
        //    return StringBuilder.ToString();
        //}


        public static class SQL
        {
            public static DataTable GetDataTable(string SQL) {
                DataTable dt = null;
                using (var sqlConn = JSCommon.GetSQLConnection()) {
                    sqlConn.Open();
                    dt = DBCollection.GetDataTable(SQL, sqlConn);
                    sqlConn.Close();
                }
                return dt;
            }

            public static DataTable GetDataTable(SqlConnection SqlConn,string SQL) {

                return DBCollection.GetDataTable(SQL, SqlConn);
            }

            public static void Execute(string SQL)
            {
                using (var sqlConn = GetSQLConnection())
                {
                    sqlConn.Open();
                    var sqlCmd = new SqlCommand(SQL, sqlConn);
                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();
                };
            }

            public static void Execute(SqlTransaction sqlTransaction, string SQL)
            {
                var sqlCmd = new SqlCommand(SQL, sqlTransaction.Connection, sqlTransaction);
                sqlCmd.ExecuteNonQuery();
            }


            public static object ExecuteScalar(string SQL)
            {
                object returnValue = null;
                using (var sqlConn = GetSQLConnection())
                {
                    sqlConn.Open();
                    var sqlCmd = new SqlCommand(SQL, sqlConn);
                    var Rs = sqlCmd.ExecuteReader();
                    if ( Rs.HasRows)
                    {
                        Rs.Read();
                        returnValue = Rs[0];

                    }
                    Rs.Close();
                    sqlConn.Close();
                };
                if (returnValue == DBNull.Value) return null;
                return returnValue;
            }

            public static DataTable GetSQLSchema(string SQL, bool AllColumns)
            {
                //SQL = SQL.ToUpper();
                //if (SQL.ToUpper().Contains("WHERE"))
                //{
                //    SQL = SQL + " AND ID = -1";
                //}
                //else
                //{
                //    SQL = SQL + " WHERE ID = -1";
                //}

                if (AllColumns == true) {
                    SQL = "SELECT TOP 1 * " + SQL.Substring(SQL.ToUpper().IndexOf("FROM"));
                }

                DataTable dt = null;
                using (var conn = JSCommon.GetSQLConnection())
                {
                    string sql = SQL;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt = reader.GetSchemaTable();
                    conn.Close();
                }
                return dt;
            }
            
        }
    }
}
