using JSLibrary;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace JSLibrary
{
    public class JSUtility
    {

        public static object _ExecSQLProc(dynamic CurrentUser, string SQL, string Params, bool IsReturnObject, int ID_CurrentObject) {
            //dynamic CurrentUser = Session["CurrentUser"] as dynamic;
            dynamic CurrentObject = null;
            List<SqlParameter> ProcParameters = null;
            if (Params != null) {


                List<dynamic> Parameters = GetProcedureParameters(SQL);

                JObject dParams = JObject.Parse(Params);
                if (IsReturnObject) {
                    if (ID_CurrentObject > 0) {
                        dParams.Add("ID", ID_CurrentObject);
                    }
                }
                var properties = dParams.Properties();
                ProcParameters = new List<SqlParameter>();
                foreach (var p in Parameters) {

                    if (p.system_type_id == 243) //USER DEFINE TYPES
                    {
                        var sqlParam = new SqlParameter();
                        sqlParam.SqlDbType = SqlDbType.Structured;
                        sqlParam.ParameterName = p.Name;

                        var ArrayParams = (JArray)dParams[p.Name.Replace("@", "")];
                        if (ArrayParams == null) continue;
                        if (ArrayParams.Count > 0) {
                            var dtParams = new DataTable();
                            string[] UserTypeParameters = ((String)p.TypeParameters).Split(new char[] { ',' }).ToArray();

                            foreach (string param in UserTypeParameters) {

                                int ID_Type = Int32.Parse(param.Split(new char[] { '$' })[1]);
                                string Name = param.Split(new char[] { '$' })[0].Trim();
                                dtParams.Columns.Add(Name, GetTypeByID(ID_Type));

                            }

                            foreach (var obj in ArrayParams) {
                                var newRow = dtParams.NewRow();
                                foreach (DataColumn column in dtParams.Columns) {
                                    if (obj.Type.ToString() == "Integer") {
                                        newRow[column.ColumnName] = (int)obj;
                                    } else {
                                        if (obj[column.ColumnName] != null) {
                                            newRow[column.ColumnName] = obj[column.ColumnName];
                                        }
                                    }
                                }
                                dtParams.Rows.Add(newRow);
                            }
                            sqlParam.Value = dtParams;
                        }

                        ProcParameters.Add(sqlParam);
                    } else {
                        var sqlParam = new SqlParameter();
                        sqlParam.ParameterName = p.Name;
                        if (p.Name == "@ID_User") {
                            // sqlParam.ParameterName = p.Name;
                            sqlParam.Value = CurrentUser.ID;
                        } else if (p.Name == "@ID_Warehouse" && dParams[p.Name.Replace("@", "")] == null) {
                            //CurrentUser.ID_Warehouse
                        } else if (p.Name == "@ID_Session") {
                            //sqlParam.ParameterName = p.Name;

                            //Type typeOfDynamic = dParams.GetType();
                            bool exist = ((JObject)dParams).Properties().Where(pt => pt.Name.Equals("ID_Session")).Any();
                            //bool exist = typeOfDynamic.GetProperties().Where(pt => pt.Name.Equals("ID_Session")).Any();
                            if (exist) {
                                //try {
                                if (((JValue)dParams["ID_Session"]).Value != null) {

                                    sqlParam.Value = Int32.Parse(dParams["ID_Session"].ToString());
                                } else {
                                    sqlParam.Value = CurrentUser.ID_Session;
                                }


                                //} catch (Exception e) {
                                //    sqlParam.Value = CurrentUser.ID_Session;
                                //}
                            } else {
                                sqlParam.Value = CurrentUser.ID_Session;
                            }
                            //if (((IDictionary<string, object>)dParams).Keys.Contains("ID_Session")) {
                            //    sqlParam.Value = dParams["ID_Session"];
                            //} else {
                            //    sqlParam.Value = CurrentUser.ID_Session;
                            //}
                        } else if (p.Name == "@ID_Company") {
                            //CurrentUser.ID_Company
                        } else if (p.Name == "@ID") {

                            JValue value = dParams[p.Name.Replace("@", "")];
                            if (value == null) {
                                sqlParam.Value = -1;
                            } else {
                                sqlParam.DbType = DbType.Int32;
                                sqlParam.Value = (Int32)dParams[p.Name.Replace("@", "")];
                            }

                        } else {

                            JValue value = dParams[p.Name.Replace("@", "")];

                            if (value == null) {
                                sqlParam.Value = DBNull.Value;
                            } else {
                                if (value.Type == JTokenType.String) {
                                    sqlParam.Value = ((string)dParams[p.Name.Replace("@", "")]);//.Replace("'", "''");
                                } else if (value.Type == JTokenType.Boolean) {
                                    sqlParam.DbType = DbType.Boolean;
                                    sqlParam.Value = Boolean.Parse(((string)dParams[p.Name.Replace("@", "")]).ToLower());
                                } else if (value.Type == JTokenType.Integer) {
                                    sqlParam.DbType = DbType.Int32;
                                    sqlParam.Value = (Int32)dParams[p.Name.Replace("@", "")];
                                } else if (value.Type == JTokenType.Null || value.Type == JTokenType.None) {

                                    sqlParam.Value = DBNull.Value;
                                } else if (value.Type == JTokenType.Date) {
                                    sqlParam.DbType = DbType.DateTime;
                                    sqlParam.Value = DateTime.Parse(value.ToString());
                                }

                            }


                        }

                        ProcParameters.Add(sqlParam);

                    }


                }


                //foreach (var p in properties)
                //{
                //
                //    Console.Write(dParams[p.Name].GetType().Name);
                //    var pType = dParams[p.Name].GetType();
                //    if (pType == typeof(JArray))
                //    {
                //
                //    }
                //}
            }

            

            using (var sqlConn = JSCommon.GetSQLConnection()) {
                sqlConn.Open();
                SqlTransaction sqlTransaction = null;
                if (IsReturnObject == false) {
                    sqlTransaction = sqlConn.BeginTransaction();
                }
                //if (IsTransaction == true) {
                //    if ( sqlTransaction == null ) sqlTransaction = sqlConn.BeginTransaction();
                //}

                try {
                    var SqlCmd = new SqlCommand(SQL, sqlConn);
                    if (sqlTransaction != null) {
                        SqlCmd.Transaction = sqlTransaction;
                    }
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    if (ProcParameters != null) {
                        foreach (var sqlParams in ProcParameters) {
                            SqlCmd.Parameters.Add(sqlParams);
                        }
                    }

                    if (IsReturnObject) {
                        var DataSet = new DataSet();
                        new SqlDataAdapter(SqlCmd).Fill(DataSet);

                        if (DataSet.Tables.Count == 0 || DataSet.Tables.Count == 1) return null;
                        var ObjectDetailPropertyNames = (from c in DataSet.Tables[0].Columns.Cast<DataColumn>()
                                                         select c.ColumnName).ToList();
                        var _CurrentObject = DBCollection.GetDynamicObjectList(DataSet.Tables[1], false);
                        if (_CurrentObject == null) return null;
                        IDictionary<string, object> dynamicObject = _CurrentObject.Single();
                        for (int i = 1; i < ObjectDetailPropertyNames.Count; i++) {
                            dynamicObject.Add(ObjectDetailPropertyNames[i], DBCollection.GetDynamicObjectList(DataSet.Tables[i + 1],false));

                        }
                        CurrentObject = dynamicObject;
                    } else {
                        SqlCmd.ExecuteNonQuery();
                    }

                    if (sqlTransaction != null) {
                        sqlTransaction.Commit();
                    }
                } catch (SqlException e) {
                    if (sqlTransaction != null) {
                        sqlTransaction.Rollback();
                    }
                    //try {
                    //    string appPath = HttpContext.Current.Server.MapPath("~/App_Content");
                    //    if (Directory.Exists(appPath + @"\Log\") == false) {
                    //        Directory.CreateDirectory(appPath + @"\Log\");
                    //    }

                    //    System.IO.StreamWriter sw = System.IO.File.AppendText(appPath + @"\Log\" + DateTime.Now.ToString("yyyy-MM-dd") + "_Log.txt");
                    //    try {
                    //        string logLine = System.String.Format("{0:G}: {1} ---> {2}.", System.DateTime.Now, SQL, e.Message);
                    //        sw.WriteLine(logLine);
                    //    } finally {
                    //        sw.Close();
                    //    }
                    //} catch { }
                    throw new JsAppException(e.Message, e.Number, SQL);
                    //
                    //
                    //
                }
                //catch (Exception e)  
                //
                //
                //{
                //    if (AppHub._connections.Count != 0)
                //    {
                //
                //        string ConnectionId = ((IEnumerable<string>)AppHub._connections.GetConnections(Int32.Parse(CurrentUser.ID.ToString()))).First();
                //        var context = GlobalHost.ConnectionManager.GetHubContext<AppHub>();
                //        context.Clients.Client(ConnectionId).onSqlException(e.Message);
                //    }
                //    throw new ApplicationException(e.Message);
                //}
                finally {
                    sqlConn.Close();
                    System.GC.Collect();
                }
            }


            return CurrentObject;
        }

        public static List<dynamic> GetProcedureParameters(string ProcedureName) {
            return new DBCollection().GetDynamicCollections("SELECT * FROM fGetStoredProcedureParameters('" + ProcedureName + "');");
        }

        //
        //
        //

        public static Type GetTypeByID(int type) {

            Type t = null;
            switch (type) {
                case 34: //image
                    t = typeof(String);
                    break;
                case 35: //text
                    t = typeof(String);
                    break;
                case 36: //uniqueidentifier
                    t = typeof(String);
                    break;
                case 40: //date
                    t = typeof(DateTime);
                    break;
                case 41: //time
                    t = typeof(DateTime);
                    break;
                case 42: //datetime2
                    t = typeof(DateTime);
                    break;
                case 43: //datetimeoffset
                    t = typeof(DateTime);
                    break;
                case 48: //tinyint
                    t = typeof(Int32);
                    break;
                case 52: //smallint
                    t = typeof(Int32);
                    break;
                case 56: //int
                    t = typeof(Int32);
                    break;
                case 58: //smalldatetime
                    t = typeof(DateTime);
                    break;
                case 59: //real
                    t = typeof(float);
                    break;
                case 60: //money
                    t = typeof(float);
                    break;
                case 61: //datetime
                    t = typeof(DateTime);
                    break;
                case 62: //float
                    t = typeof(float);
                    break;
                case 98: //sql_variant
                    t = typeof(String);
                    break;
                case 99: //ntext
                    t = typeof(String);
                    break;
                case 104: //bit
                    t = typeof(bool);

                    break;
                case 106: //decimal
                    t = typeof(Decimal);
                    break;
                case 108: //numeric
                    t = typeof(Int32);
                    break;
                case 122: //smallmoney
                    t = typeof(Decimal);
                    break;
                case 127: //bigint
                    t = typeof(Int32);
                    break;
                case 165: //varbinary
                    t = typeof(String);
                    break;
                case 167: //varchar
                    t = typeof(String);
                    break;
                case 173: //binary
                    t = typeof(String);
                    break;
                case 175: //char
                    t = typeof(String);
                    break;
                case 189: //timestamp
                    t = typeof(String);
                    break;
                case 231: //nvarchar
                    t = typeof(String);
                    break;
                case 239: //nchar
                    t = typeof(String);
                    break;
                case 241: //xml
                    t = typeof(String);
                    break;
            }

            return t;
        }

    }
}