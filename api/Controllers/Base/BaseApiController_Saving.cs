using JSLibrary;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ngJSApp.Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ngJSApp.Controllers
{
    public partial class BaseApiController
    {

        private JObject DeletedItems = null;
        //private List<dynamic> UploadedFiles = null;
        private JObject Params = null;
        private dynamic CurrentUser = null;
        private dynamic TempCurrentObject = null;
        private DataTable AuditTrailTable = null;
        private List<UploadFileDetail> UploadedFiles = null;


        protected async System.Threading.Tasks.Task<string> UploadAsync(string Oid_Model, SaveObjectParam param, IFormFileCollection files = null)
        {

            dynamic CurrentObject = JObject.Parse(param.CurrentObject);

            string parentKey = "";
            string ID_CurrentObject = null;
            string filename = null;


            if (CurrentObject["ID"] != null)
            {
                parentKey = "ID";
                ID_CurrentObject = CurrentObject["ID"];
            }
            else 
            {
                parentKey = "Oid";
                ID_CurrentObject = CurrentObject["Oid"];
            }


            if (files.Count > 0)
            {
                UploadedFiles = JArray.Parse(param.UploadFileDetails).ToObject<List<UploadFileDetail>>();
                string webRootPath = env.WebRootPath;
                string contentRootPath = env.ContentRootPath;
                foreach (var f in files)
                {
                    var det = UploadedFiles.SingleOrDefault(d => d.FileId == f.FileName);
                    if (det.IsImage == true)
                    {
                        //create thumbnail
                        var img = Image.FromStream(f.OpenReadStream());
                        var fileName = det.FileName;
                        var extension = fileName.Substring(det.FileName.LastIndexOf("."));
                        var newFileName = fileName.Substring(0, det.FileName.LastIndexOf(".")) + $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}" + extension;
                        var path = webRootPath + @"\Content\Image\" + newFileName;
                        det.NewFileName = newFileName;
                        det.NewPath = path;
                        img.Save(path, img.RawFormat);
                        //
                        //
                        //
                        Image thumbNail = Utility.FixedSize(img, 80, 80);
                        thumbNail.Save(webRootPath + @"\Content\Thumbnail\" + newFileName, img.RawFormat);

                        filename = newFileName;
                    }
                    else
                    {

                    }
                }
            }

            using (var sqlConn = JSCommon.GetSQLConnection())
            {
                sqlConn.Open();
                var sqlTrans = sqlConn.BeginTransaction();
                try
                {
                    if (UploadedFiles != null)
                    {
                        if (UploadedFiles.Count > 0)
                        {
                            var dets = UploadedFiles.Select(s => new tFileUpload()
                            {
                                Name = s.FileName,
                                FileName = s.FileName,
                                ID_CurrentObject = s.ID_CurrentObject,
                                ID_Model = Guid.Parse(Oid_Model),
                                Path = s.NewPath,
                            });
                            ctx.tFileUpload.AddRange(dets);
                            ctx.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();

                    throw;
                }
                finally
                {

                    sqlConn.Close();
                }

            }

            return filename;
        }

        protected string Save(string Oid_Model, SaveObjectParam param, IFormFileCollection files = null)
        {
            this.CurrentUser = new ExpandoObject();

            if (param.CurrentUser == "undefined") param.CurrentUser = "";
                 
            if (String.IsNullOrWhiteSpace(param.CurrentUser))
            {

                (this.CurrentUser as IDictionary<string, object>).Add("ID", 1);
                (this.CurrentUser as IDictionary<string, object>).Add("ID_Session", 1);
                (this.CurrentUser as IDictionary<string, object>).Add("Name", "System");
            }
            else
            {
                dynamic currentUser = JObject.Parse(param.CurrentUser);

                (this.CurrentUser as IDictionary<string, object>).Add("ID", currentUser["ID_User"]);
                (this.CurrentUser as IDictionary<string, object>).Add("ID_Session", currentUser["ID_UserSession"]);
                (this.CurrentUser as IDictionary<string, object>).Add("Name", "");
            }
        

            dynamic CurrentObject = JObject.Parse(param.CurrentObject);
            if (String.IsNullOrWhiteSpace(param.DeletedItems) != true && param.DeletedItems != "undefined") {
                this.DeletedItems = JObject.Parse(param.DeletedItems);
            }
            if (param.PreviousObject == "undefined") param.PreviousObject = null;
            if (String.IsNullOrWhiteSpace(param.PreviousObject) == false) TempCurrentObject = JObject.Parse(param.PreviousObject);
            if (TempCurrentObject != null)  
            {
                AuditTrailTable = new DataTable();
                AuditTrailTable.Columns.Add("ModelProperty", typeof(string));
                AuditTrailTable.Columns.Add("PropertyName", typeof(string));
                AuditTrailTable.Columns.Add("OldValue", typeof(string));
                AuditTrailTable.Columns.Add("NewValue", typeof(string));
                AuditTrailTable.Columns.Add("ID_AuditTrailType", typeof(int));
                AuditTrailTable.Columns.Add("ID_PropertyType", typeof(int));
                AuditTrailTable.Columns.Add("ID_Model", typeof(Guid));
            };
            var Model = new DBCollection().GetDynamicCollections("SELECT *, ISNULL(Caption,Name) AS Caption FROM dbo._vModel WHERE Oid = '" + Oid_Model + "'")[0];
            var Properties = new DBCollection().GetDynamicCollections("SELECT * FROM dbo._vModelPropertiesCrud WHERE ID_Model = '" + Oid_Model + "'");
            //
            //
            //
            bool ishasFiles = true;
            if (files == null) ishasFiles = false;
            if (ishasFiles) {

                if (files.Count == 0) ishasFiles = false;
            }

            if (ishasFiles) {
                UploadedFiles = JArray.Parse(param.UploadFileDetails).ToObject<List<UploadFileDetail>>();
                string webRootPath = env.WebRootPath;
                string contentRootPath = env.ContentRootPath;
                foreach (var f in files) {
                    var det = UploadedFiles.SingleOrDefault(d => d.FileId == f.FileName);
                    if (det.IsImage == true)
                    {
                        //create thumbnail
                        var img = Image.FromStream(f.OpenReadStream());
                        var fileName = det.FileName;
                        var extension = fileName.Substring(det.FileName.LastIndexOf("."));
                        var newFileName = fileName.Substring(0, det.FileName.LastIndexOf(".")) + $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}"  + extension;
                        var path = webRootPath + @"\Content\Image\" + newFileName;
                        det.NewFileName = newFileName;
                        det.NewPath = path;
                        img.Save(path, img.RawFormat);
                        //
                        //
                        //
                        Image thumbNail = Utility.FixedSize(img, 80, 80);
                        thumbNail.Save(webRootPath + @"\Content\Thumbnail\" + newFileName, img.RawFormat);
                    }
                    else { 
                    
                    }
                }
            }
            string PrimaryKey = Model.PrimaryKey;
            string TableName = Model.TableName;
            bool IsNew = (PrimaryKey == "ID" ? (CurrentObject.ID == -1 || CurrentObject.ID == null) : (CurrentObject.Oid == null));
            string ID_Parent = null;
            using (var sqlConn = JSCommon.GetSQLConnection())
            {
                sqlConn.Open();
                var sqlTrans = sqlConn.BeginTransaction();
                try
                {
                    //
                    //
                    //
                    ID_Parent = SaveObject(Oid_Model, TempCurrentObject, "Header", CurrentObject, Properties, PrimaryKey, TableName, IsNew, 1, null, null, sqlConn, sqlTrans);
                    saveChilds(TempCurrentObject, CurrentObject, Properties, sqlConn, sqlTrans, ID_Parent);
                    if (UploadedFiles != null) {
                        foreach (var fd in UploadedFiles) {
                            fd.ID_CurrentObject = ID_Parent;
                        };
                    };
                    //
                    //
                    //
                    if (PrimaryKey == "ID")
                    {
                        new SqlCommand("pModel_AfterSaved @ID_Model = '" + Oid_Model + "',@ID_CurrentObject = '" + ID_Parent + "',@IsNew = " + (IsNew ? "1" : "0") + "", sqlConn, sqlTrans).ExecuteNonQuery();
                    }
                    sqlTrans.Commit();

                    if (UploadedFiles != null) {
                        if (UploadedFiles.Count > 0)
                        {
                            var dets = UploadedFiles.Select(s => new tFileUpload()
                            {
                                Name = s.FileName,
                                FileName = s.FileName,
                                ID_CurrentObject = s.ID_CurrentObject,
                                ID_Model = Guid.Parse(s.Oid_Model),
                                Path = s.NewPath,
                            });
                            ctx.tFileUpload.AddRange(dets);
                            ctx.SaveChanges();
                        }
                    }
                    //
                    //
                    //
                    JObject p = JObject.FromObject(new
                    {
                        Params = new
                        {
                            ID = ID_Parent,
                            Oid = ID_Parent
                        }
                    });
                    var newLoadObject = (ID_Parent == null ? new { } : _GetCurrentObject(ID_Parent, null, Model, p));
                    if (TempCurrentObject != null)
                    {
                        if (AuditTrailTable.Rows.Count > 0)
                        {
                            using (var conn = JSCommon.GetSQLConnection())
                            {
                                conn.Open();
                                string ModelDisplayName = Model.Caption;
                                string DisplayName = Model.DisplayName;
                                string CurretUserName = this.CurrentUser.Name;
                                var sqlCmd = new SqlCommand("pAuditTrail", conn);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Structured,
                                    ParameterName = "@Details",
                                    Value = AuditTrailTable,
                                    TypeName = "typAuditTrail"
                                });

                                string ObjectName = null;
                                string Description = null;
                                var dtry = ((IDictionary<string, object>)newLoadObject);
                                if (DisplayName != null)
                                {
                                    if (dtry.Keys.Contains(DisplayName))
                                    {
                                        var value = dtry[DisplayName];
                                        if (value != null) ObjectName = value.ToString();
                                    };
                                }

                                if (ObjectName == null)
                                {
                                    if (newLoadObject.Name != null)
                                    {
                                        ObjectName = newLoadObject.Name;
                                    }
                                    else if (newLoadObject.Code != null)
                                    {
                                        ObjectName = newLoadObject.Code;
                                    }
                                    else
                                    {
                                        if (dtry.Keys.Contains("Oid"))
                                        {
                                            ObjectName = dtry["Oid"].ToString();
                                        }
                                        else if (dtry.Keys.Contains("ID"))
                                        {
                                            ObjectName = dtry["ID"].ToString();
                                        }
                                    }
                                }

                                if (IsNew)
                                {
                                    Description = CurretUserName + " has added " + ModelDisplayName + " (" + ObjectName + ")";
                                }
                                else
                                {
                                    Description = CurretUserName + " has modified " + ModelDisplayName + " (" + ObjectName + ")";
                                }

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@Name",
                                    Value = newLoadObject.Name
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@Description",
                                    Value = Description
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@ID_Model",
                                    Value = Oid_Model
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@ID_CurrentObject",
                                    Value = ID_Parent.Replace("'", "").ToUpper()
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Int,
                                    ParameterName = "@ID_AuditTrailType",
                                    Value = IsNew == true ? 1 : 2
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Int,
                                    ParameterName = "@ID_Session",
                                    Value = Int32.Parse(CurrentUser.ID_Session.ToString())
                                });

                                sqlCmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                    //
                    //
                    //
                    //r.Content = new StringContent(JsonConvert.SerializeObject(newLoadObject), Encoding.UTF8, "application/json");
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                }
                finally
                {
                    sqlConn.Close();
                }

            }
            return ID_Parent;
        }

        protected SaveObjectResult _Save(string Oid_Model, SaveObjectParam param, IFormFileCollection files = null)
        {
            SaveObjectResult saveObjResult = new SaveObjectResult();
            this.CurrentUser = new ExpandoObject();

            dynamic CurrentObject = JObject.Parse(param.CurrentObject);

            saveObjResult.ID_CurrentObject = CurrentObject.ID;

            if (param.CurrentUser == "undefined") param.CurrentUser = "";

            if (String.IsNullOrWhiteSpace(param.CurrentUser))
            {

                (this.CurrentUser as IDictionary<string, object>).Add("ID", 1);
                (this.CurrentUser as IDictionary<string, object>).Add("ID_Session", 1);
                (this.CurrentUser as IDictionary<string, object>).Add("Name", "System");
            }
            else
            {
                dynamic currentUser = JObject.Parse(param.CurrentUser);

                (this.CurrentUser as IDictionary<string, object>).Add("ID", currentUser["ID_User"]);
                (this.CurrentUser as IDictionary<string, object>).Add("ID_Session", currentUser["ID_UserSession"]);
                (this.CurrentUser as IDictionary<string, object>).Add("Name", "");
            }


            if (String.IsNullOrWhiteSpace(param.DeletedItems) != true && param.DeletedItems != "undefined")
            {
                this.DeletedItems = JObject.Parse(param.DeletedItems);
            }
            if (param.PreviousObject == "undefined") param.PreviousObject = null;
            if (String.IsNullOrWhiteSpace(param.PreviousObject) == false) TempCurrentObject = JObject.Parse(param.PreviousObject);
            if (TempCurrentObject != null)
            {
                AuditTrailTable = new DataTable();
                AuditTrailTable.Columns.Add("ModelProperty", typeof(string));
                AuditTrailTable.Columns.Add("PropertyName", typeof(string));
                AuditTrailTable.Columns.Add("OldValue", typeof(string));
                AuditTrailTable.Columns.Add("NewValue", typeof(string));
                AuditTrailTable.Columns.Add("ID_AuditTrailType", typeof(int));
                AuditTrailTable.Columns.Add("ID_PropertyType", typeof(int));
                AuditTrailTable.Columns.Add("ID_Model", typeof(Guid));
            };
            var Model = new DBCollection().GetDynamicCollections("SELECT *, ISNULL(Caption,Name) AS Caption FROM dbo._vModel WHERE Oid = '" + Oid_Model + "'")[0];
            var Properties = new DBCollection().GetDynamicCollections("SELECT * FROM dbo._vModelPropertiesCrud WHERE ID_Model = '" + Oid_Model + "'");
     
            bool ishasFiles = true;
            if (files == null) ishasFiles = false;
            if (ishasFiles)
            {

                if (files.Count == 0) ishasFiles = false;
            }

            if (ishasFiles)
            {
                UploadedFiles = JArray.Parse(param.UploadFileDetails).ToObject<List<UploadFileDetail>>();
                string webRootPath = env.WebRootPath;
                string contentRootPath = env.ContentRootPath;
                foreach (var f in files)
                {
                    var det = UploadedFiles.SingleOrDefault(d => d.FileId == f.FileName);
                    if (det.IsImage == true)
                    {
                        var img = Image.FromStream(f.OpenReadStream());
                        var fileName = det.FileName;
                        var extension = fileName.Substring(det.FileName.LastIndexOf("."));
                        var newFileName = fileName.Substring(0, det.FileName.LastIndexOf(".")) + $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}" + extension;
                        var path = webRootPath + @"\Content\Image\" + newFileName;
                        det.NewFileName = newFileName;
                        det.NewPath = path;
                        img.Save(path, img.RawFormat);
      
                        Image thumbNail = Utility.FixedSize(img, 80, 80);
                        thumbNail.Save(webRootPath + @"\Content\Thumbnail\" + newFileName, img.RawFormat);
                    }
                    else
                    {

                    }
                }
            }
            string PrimaryKey = Model.PrimaryKey;
            string TableName = Model.TableName;
            bool IsNew = (PrimaryKey == "ID" ? (CurrentObject.ID == -1 || CurrentObject.ID == null) : (CurrentObject.Oid == null));
            string ID_Parent = null;
            using (var sqlConn = JSCommon.GetSQLConnection())
            {
                sqlConn.Open();
                var sqlTrans = sqlConn.BeginTransaction();
                try
                {
                    ID_Parent = SaveObject(Oid_Model, TempCurrentObject, "Header", CurrentObject, Properties, PrimaryKey, TableName, IsNew, 1, null, null, sqlConn, sqlTrans);
                    saveObjResult.ID_CurrentObject = ID_Parent;

                    saveChilds(TempCurrentObject, CurrentObject, Properties, sqlConn, sqlTrans, ID_Parent);
                    if (UploadedFiles != null)
                    {
                        foreach (var fd in UploadedFiles)
                        {
                            fd.ID_CurrentObject = ID_Parent;
                        };
                    };

                    sqlTrans.Commit();

                    if (PrimaryKey == "ID")
                    {
                        new SqlCommand("pModel_AfterSaved @ID_Model = '" + Oid_Model + "',@ID_CurrentObject = '" + ID_Parent + "',@IsNew = " + (IsNew ? "1" : "0") + "", sqlConn, sqlTrans).ExecuteNonQuery();
                    }

                    try {

                        var dbAccess = new DBCollection();
                        var sql = "EXEC dbo.pGet/*ModelName*/  @ID = '/*ID*/', @ID_Session = '/*ID_Session*/'";
                        sql = sql.Replace("/*ModelName*/", TableName.Remove(0, 1));
                        sql = sql.Replace("/*ID*/", ID_Parent);
                        sql = sql.Replace("/*ID_Session*/", (string)CurrentUser.ID_Session);
                        saveObjResult.Record = dbAccess.GetDynamicObject(sql, true);
                    }
                    catch (Exception ex) {


                        saveObjResult.Message = ex.Message;
                    }

                    if (UploadedFiles != null)
                    {
                        if (UploadedFiles.Count > 0)
                        {
                            var dets = UploadedFiles.Select(s => new tFileUpload()
                            {
                                Name = s.FileName,
                                FileName = s.FileName,
                                ID_CurrentObject = s.ID_CurrentObject,
                                ID_Model = Guid.Parse(s.Oid_Model),
                                Path = s.NewPath,
                            });
                            ctx.tFileUpload.AddRange(dets);
                            ctx.SaveChanges();
                        }
                    }
      
                    JObject p = JObject.FromObject(new
                    {
                        Params = new
                        {
                            ID = ID_Parent,
                            Oid = ID_Parent
                        }
                    });
                    var newLoadObject = (ID_Parent == null ? new { } : _GetCurrentObject(ID_Parent, null, Model, p));
                    if (TempCurrentObject != null)
                    {
                        if (AuditTrailTable.Rows.Count > 0)
                        {
                            using (var conn = JSCommon.GetSQLConnection())
                            {
                                conn.Open();
                                string ModelDisplayName = Model.Caption;
                                string DisplayName = Model.DisplayName;
                                string CurretUserName = this.CurrentUser.Name;
                                var sqlCmd = new SqlCommand("pAuditTrail", conn);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Structured,
                                    ParameterName = "@Details",
                                    Value = AuditTrailTable,
                                    TypeName = "typAuditTrail"
                                });

                                string ObjectName = null;
                                string Description = null;
                                var dtry = ((IDictionary<string, object>)newLoadObject);
                                if (DisplayName != null)
                                {
                                    if (dtry.Keys.Contains(DisplayName))
                                    {
                                        var value = dtry[DisplayName];
                                        if (value != null) ObjectName = value.ToString();
                                    };
                                }

                                if (ObjectName == null)
                                {
                                    if (newLoadObject.Name != null)
                                    {
                                        ObjectName = newLoadObject.Name;
                                    }
                                    else if (newLoadObject.Code != null)
                                    {
                                        ObjectName = newLoadObject.Code;
                                    }
                                    else
                                    {
                                        if (dtry.Keys.Contains("Oid"))
                                        {
                                            ObjectName = dtry["Oid"].ToString();
                                        }
                                        else if (dtry.Keys.Contains("ID"))
                                        {
                                            ObjectName = dtry["ID"].ToString();
                                        }
                                    }
                                }

                                if (IsNew)
                                {
                                    Description = CurretUserName + " has added " + ModelDisplayName + " (" + ObjectName + ")";
                                }
                                else
                                {
                                    Description = CurretUserName + " has modified " + ModelDisplayName + " (" + ObjectName + ")";
                                }

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@Name",
                                    Value = newLoadObject.Name
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@Description",
                                    Value = Description
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@ID_Model",
                                    Value = Oid_Model
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.VarChar,
                                    ParameterName = "@ID_CurrentObject",
                                    Value = ID_Parent.Replace("'", "").ToUpper()
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Int,
                                    ParameterName = "@ID_AuditTrailType",
                                    Value = IsNew == true ? 1 : 2
                                });

                                sqlCmd.Parameters.Add(new SqlParameter()
                                {
                                    SqlDbType = SqlDbType.Int,
                                    ParameterName = "@ID_Session",
                                    Value = Int32.Parse(CurrentUser.ID_Session.ToString())
                                });

                                sqlCmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                  
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();

                    saveObjResult.Message = ex.Message;
                }
                finally
                {
                    sqlConn.Close();
                }
            }

            return saveObjResult;
        }

        private void saveChilds(dynamic AuditTrailObject, dynamic CurrentObject, List<dynamic> Properties, SqlConnection sqlConn, SqlTransaction sqlTrans, string ID_Parent)
        {
            var PropertyFields = Properties.Where(p => p.ID_PropertyType == 10).ToArray();
            if (PropertyFields.Length == 0) return;
            //if (((JObject)CurrentObject).Properties().cou)
            var properties = ((JObject)CurrentObject).Properties().Select(s => s.Name).ToList();
            foreach (dynamic f in PropertyFields)
            {
                if (f.ID_PropertyModel == null) continue;
                if (f.PropertyModel_Link == null) continue;
                if (properties.Contains(f.Name) == false) continue;
                //if (((IDictionary<string, object>)CurrentObject).Keys.Contains(f.Name)) continue;
                try
                {
                    if (((JValue)CurrentObject[f.Name]).Type == JTokenType.String) continue;
                }
                catch { }
                if (CurrentObject[f.Name] == null) continue;
                var pList = ((IEnumerable<dynamic>)CurrentObject[f.Name]).ToList();
                //if (pList.Count == 0) continue;
                string _PrimaryKey = f.PropertyModel_PrimaryKey;
                string _TableName = f.PropertyModel_TableName;
                string _ID_Model = f.ID_PropertyModel.ToString();
                var _Properties = new DBCollection().GetDynamicCollections("SELECT * FROM dbo._vModelPropertiesCrud WHERE ID_Model = '" + _ID_Model + "'");
                string _ParentKey = f.PropertyModel_Link.ToString();
                int _ParentKeyType = f.PropertyModel_Type;
                string[] Ids = new string[] { };
                //if (pList.Count > 0)
                //{
                    if (_PrimaryKey == "ID")
                    {
                        Ids = pList.Where(s => s.ID > 0).Select(s => (string)s.ID).ToArray();
                    }
                    else if (_PrimaryKey == "Oid")
                    {
                        Ids = pList.Where(s => s.Oid != null).Select(s => "'" + ((string)s.Oid) + "'").ToArray();
                    }
                    if (Ids.Length > 0)
                    {
                        var SQL = "DELETE FROM " + _TableName + " WHERE " + _ParentKey + " = " + ID_Parent + "  AND  " + _PrimaryKey + " NOT IN (" + String.Join(",", Ids) + ")";
                        new SqlCommand(SQL, sqlConn, sqlTrans).ExecuteNonQuery();
                    }
                    else
                    {
                        var SQL = "DELETE FROM " + _TableName + " WHERE " + _ParentKey + " = " + ID_Parent + ";";
                        new SqlCommand(SQL, sqlConn, sqlTrans).ExecuteNonQuery();
                    }
                //}
                //if (pList.Count == 0) return;

                foreach (var _currentObject in pList)
                {
                    dynamic tempAuditTrailObject = null;
                    bool _IsNew = (_PrimaryKey == "ID" ? (_currentObject.ID == null || _currentObject.ID < 0) : (_currentObject.Oid == null));

                    if (_IsNew == false)
                    {
                        if (AuditTrailObject != null)
                        {
                            if (AuditTrailObject[f.Name] != null)
                            {
                                if (_PrimaryKey == "ID")
                                {
                                    tempAuditTrailObject = ((IEnumerable<dynamic>)AuditTrailObject[f.Name]).ToList().Where(d => d.ID == _currentObject.ID).ToArray()[0];
                                }
                                else
                                {
                                    tempAuditTrailObject = ((IEnumerable<dynamic>)AuditTrailObject[f.Name]).ToList().Where(d => d.Oid == _currentObject.Oid).ToArray()[0];
                                }
                            }
                        }
                    }
                    string Key = SaveObject(_ID_Model, tempAuditTrailObject, f.Name.ToString(), _currentObject, _Properties, _PrimaryKey, _TableName, _IsNew, _ParentKeyType, _ParentKey, ID_Parent, sqlConn, sqlTrans);
                    //
                    //
                    //
                    saveChilds(tempAuditTrailObject, _currentObject, _Properties, sqlConn, sqlTrans, Key);
                    //
                    //
                    //
                };

                

                if (DeletedItems != null)
                {
                    if (DeletedItems.Properties().Select(s => s.Name).ToList().Contains(f.Name.ToString()))
                    {
                        JArray deleted = (JArray)DeletedItems[f.Name];
                        foreach (JObject d in deleted)
                        {
                            var fields = _Properties.Where(p => p.ID_PropertyType != 10).ToArray();
                            foreach (var _f in fields)
                            {
                                string PropertyName = d[_f.Name];
                                if (d.Properties().Select(p => p.Name).ToList().Contains(_f.Name.ToString()) == false) continue;
                                var newRow = AuditTrailTable.NewRow();
                                newRow["ModelProperty"] = f.Name.ToString();
                                newRow["PropertyName"] = _f.Name.ToString();
                                newRow["ID_AuditTrailType"] = 3;
                                newRow["ID_PropertyType"] = Int32.Parse(_f.ID_PropertyType.ToString());
                                newRow["OldValue"] = d[_f.Name].ToString();
                                newRow["NewValue"] = null;
                                newRow["ID_Model"] = _ID_Model;
                                AuditTrailTable.Rows.Add(newRow);
                            }
                        }
                        var ids = _PrimaryKey == "ID" ? String.Join(",", deleted.Select(o => o["ID"].ToString()).ToArray<string>()) : String.Join(",", deleted.Select(o => "'" + o["Oid"].ToString() + "'").ToArray<string>());
                        new SqlCommand("DELETE FROM " + _TableName + " WHERE " + _PrimaryKey + " IN (" + ids + ")", sqlConn, sqlTrans).ExecuteNonQuery();
                    }
                }

            }
        }

        private string SaveObject(string ID_Model, dynamic AuditTrailObject, string PropertyName, dynamic CurrentObject, List<dynamic> Properties, string PrimaryKey, string TableName, bool IsNew, int ID_Parent_Type, string ID_Parent_Key, string ID_Parent, SqlConnection sqlConn, SqlTransaction sqlTrans)
        {
            string ParentKey = null;
            List<KeyValuePair<string, object>> FieldValueKeys = SQL(ID_Model, AuditTrailObject, PropertyName, CurrentObject, TableName, PrimaryKey, Properties, ID_Parent_Key, IsNew);

            if (IsNew)
            {
                if (ID_Parent_Key != null && ID_Parent != null)
                {
                    FieldValueKeys.Add(new KeyValuePair<string, object>(ID_Parent_Key, (ID_Parent_Type == 8 ? "'" + ID_Parent + "'" : ID_Parent)));
                }

                string SQL = null;
                if (PrimaryKey == "Oid")
                {
                    ParentKey = Guid.NewGuid().ToString();
                    FieldValueKeys.Add(new KeyValuePair<string, object>("Oid", "'" + ParentKey + "'"));
                };
                SQL = "INSERT INTO " + TableName + "(" + String.Join(",", FieldValueKeys.Select(s => s.Key).ToArray()) + ") VALUES (" + String.Join(",", FieldValueKeys.Select(s => s.Value.ToString()).ToArray()) + ")";
                if (PrimaryKey == "ID")
                {
                    SQL = SQL + ";SELECT @@IDENTITY";
                    var sqlCmd = new SqlCommand(SQL, sqlConn, sqlTrans);
                    var Rs = sqlCmd.ExecuteReader();
                    Rs.Read();
                    ParentKey = Rs[0].ToString();
                    Rs.Close();
                }
                else
                {
                    new SqlCommand(SQL, sqlConn, sqlTrans).ExecuteNonQuery();
                }
            }
            else
            {
                ParentKey = PrimaryKey == "Oid" ? "'" + CurrentObject.Oid.ToString() + "'" : CurrentObject.ID.ToString();
                if (FieldValueKeys.Count == 0) return ParentKey;
                string SQL = "UPDATE " + TableName + " SET " + String.Join(",", FieldValueKeys.Select(s => s.Key + " = " + s.Value.ToString())) + " WHERE " + PrimaryKey + " = " + ParentKey;
                new SqlCommand(SQL, sqlConn, sqlTrans).ExecuteNonQuery();

            }
            return ParentKey;
        }

        private List<KeyValuePair<string, object>> SQL(string ID_Model, dynamic AuditTrailObject, string PropertyName, dynamic CurrentObject, string TableName, string PrimaryKey, List<dynamic> Properties, string exceptField, bool IsNew)
        {
            var Values = new List<KeyValuePair<string, object>>();
            var fields = Properties.Where(p => p.ID_PropertyType != 10 && p.Name != exceptField).ToArray();
            string CurrentField = null;
            try
            {
                foreach (dynamic f in fields)
                {
                    var c = (JObject)CurrentObject; //((IDictionary<string, object>)CurrentObject);
                    JObject _c = AuditTrailObject;
                    List<JProperty> properties = c.Properties().ToList();
                    var value = c[f.Name];//.ToString();
                    CurrentField = f.Name;
                    if (new string[] { "ID_CreatedBy", "ID_LastModifiedBy" }.Contains((string)f.Name))
                    {
                        if (CurrentUser != null)
                        {
                            if (IsNew == false)
                            {
                                if (f.Name == "ID_LastModifiedBy")
                                {
                                    Values.Add(new KeyValuePair<string, object>(f.Name, CurrentUser.ID.ToString()));
                                }
                            }
                            else
                            {
                                Values.Add(new KeyValuePair<string, object>(f.Name, CurrentUser.ID.ToString()));
                            }
                        }
                    }
                    else
                    {
                        if (properties.Select(p => p.Name).ToList().Contains(f.Name))
                        {

                            var fileDetails = UploadedFiles != null ? UploadedFiles.Where(s => s.DataField == f.Name.ToString()) : null;
                            if (fileDetails != null)
                            {
                                var files = fileDetails.ToList();
                                foreach (var fd in fileDetails) {
                                    fd.Oid_Model = ID_Model;
                                }
                                if (files.Count > 0)
                                {
                                    var fileName = String.Join("|", fileDetails.Select(s => s.NewFileName).ToList());
                                    Values.Add(new KeyValuePair<string, object>(f.Name, "'" + fileName + "'"));
                                    continue;
                                }
                            }

                            int ID_PropertyType = Int32.Parse(f.ID_PropertyType.ToString());


                            if (IsNew == false && AuditTrailTable != null)
                            {
                                if (_c != null)
                                {
                                    string firstValue = c[f.Name] != null ? (String.IsNullOrWhiteSpace(c[f.Name].Value.ToString()) ? "null" : c[f.Name].Value.ToString()) : "null";
                                    string secondValue = _c[f.Name] != null ? (String.IsNullOrWhiteSpace(_c[f.Name].Value.ToString()) ? "null" : _c[f.Name].Value.ToString()) : "null";
                                    if (firstValue != secondValue)
                                    {
                                        var newRow = AuditTrailTable.NewRow();
                                        newRow["ModelProperty"] = PropertyName;
                                        newRow["PropertyName"] = f.Name.ToString();
                                        newRow["ID_AuditTrailType"] = IsNew == true ? 1 : 2;
                                        newRow["ID_PropertyType"] = ID_PropertyType;
                                        newRow["OldValue"] = _c[f.Name] != null ? _c[f.Name].ToString() : DBNull.Value;
                                        newRow["NewValue"] = c[f.Name] != null ? c[f.Name].ToString() : DBNull.Value;
                                        newRow["ID_Model"] = ID_Model;
                                        AuditTrailTable.Rows.Add(newRow);
                                    }
                                }
                            }
                            else
                            {
                                if (AuditTrailTable != null)
                                {
                                    var newRow = AuditTrailTable.NewRow();
                                    newRow["ModelProperty"] = PropertyName;
                                    newRow["PropertyName"] = f.Name.ToString();
                                    newRow["ID_AuditTrailType"] = IsNew == true ? 1 : 2;
                                    newRow["ID_PropertyType"] = ID_PropertyType;
                                    newRow["OldValue"] = null;
                                    newRow["NewValue"] = c[f.Name] != null ? c[f.Name].ToString() : "NULL";
                                    newRow["ID_Model"] = ID_Model;
                                    AuditTrailTable.Rows.Add(newRow);
                                }
                            }

                            if (IsNew == false)
                            {
                                if (_c != null)
                                {
                                    if (c[f.Name] == _c[f.Name]) continue; //nothing changes continue
                                }
                            }

                            if (c[f.Name] == null)
                            {
                                Values.Add(new KeyValuePair<string, object>(f.Name, "NULL"));
                                continue;
                            }


                            switch (ID_PropertyType)
                            {
                                case 8:
                                case 1://String
                                    if (String.IsNullOrEmpty(((string)value)) != true)
                                    {
                                        string Value = ((string)value).Replace("'", "''");
                                        Values.Add(new KeyValuePair<string, object>(f.Name, "'" + Value + "'"));
                                    }
                                    else
                                    {
                                        Values.Add(new KeyValuePair<string, object>(f.Name, "NULL"));
                                    }
                                    break;
                                case 2://Int
                                case 3://Decimal
                                    if (((JValue)value).Type == JTokenType.String)
                                    {
                                        if (String.IsNullOrEmpty(((string)((JValue)value).Value)))
                                        {
                                            Values.Add(new KeyValuePair<string, object>(f.Name, "NULL"));
                                        }
                                        else
                                        {
                                            var numberValue = ((JValue)value).Value as string;
                                            if (ID_PropertyType == 2)
                                            {
                                                var _value = (int)Decimal.Parse(numberValue);
                                                Values.Add(new KeyValuePair<string, object>(f.Name, Int32.Parse(_value + "")));
                                            }
                                            else if (ID_PropertyType == 3)
                                            {
                                                Values.Add(new KeyValuePair<string, object>(f.Name, Decimal.Parse(numberValue)));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Values.Add(new KeyValuePair<string, object>(f.Name, value));
                                    }
                                    break;
                                case 4://Bit
                                    if (value == true)
                                    {
                                        Values.Add(new KeyValuePair<string, object>(f.Name, "1"));
                                    }
                                    else if (value == false)
                                    {
                                        Values.Add(new KeyValuePair<string, object>(f.Name, "0"));
                                    }
                                    break;
                                case 5://DateTime
                                case 6://Date
                                case 7://Time

                                    Values.Add(new KeyValuePair<string, object>(f.Name, "'" + value.ToString() + "'"));
                                    break;
                                    //case 8://Uniqueidentifier
                                    //    Values.Add()
                                    //    break;
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(CurrentField);
                throw;
            }
            return Values;
        }
        //
        //
        //
        private dynamic _GetCurrentObject(string ID_CurrentObject, string sql, dynamic Model, dynamic P, bool IsByKey = false)
        {
            dynamic CurrentObject = null;
            if (ID_CurrentObject != null)
            {
                ID_CurrentObject = ID_CurrentObject.Replace("'", "");
            }

            if (sql == null)
            {
                string Oid_Model = Model.Oid.ToString();
                string ModelName = Model.Name;
                string TableName = Model.TableName;
                string PrimaryKey = Model.PrimaryKey;
                string ViewSource = Model.ViewSource;
                var procedures = new DBCollection().GetDynamicCollections("SELECT Name FROM sys.procedures WHERE Name = 'pGet" + ModelName + "'");
                if (IsByKey == false)
                {
                    if (procedures != null && procedures.Count > 0)
                    {
                        string SQL = procedures[0].Name;
                        //r.Content = new StringContent(JsonConvert.SerializeObject(DBCollection.GetCurrentObject(null, SQL, ID_CurrentObject, P["Params"] == null ? null : P["Params"].ToString())), Encoding.UTF8, "application/json");


                        CurrentObject = DBCollection.GetCurrentObject(null, SQL, ID_CurrentObject, P["Params"] == null ? null : P["Params"].ToString());
                        //CurrentObject = new DBCollection().GetDynamicObject(SQL, false);
                    }
                    else
                    {
                        if (ID_CurrentObject == "-1")
                        {
                            IDictionary<string, object> newObject = new ExpandoObject();
                            var Properties = new DBCollection().GetDynamicCollections("SELECT Oid,Name,ID_PropertyType,DefaultValue FROM _tModel_Property WHERE ID_Model = '" + Oid_Model + "' AND isActive = 1 AND Name NOT IN ('ID_CreatedBy', 'ID_LastModifiedBy', 'DateCreated', 'DateModified')");
                            foreach (var p in Properties)
                            {
                                if (p.Name == "ID")
                                {
                                    newObject["ID"] = -1;
                                }
                                else
                                {
                                    newObject[p.Name] = null;
                                }
                            }
                            CurrentObject = newObject;
                        }
                        else
                        {
                            var List = new DBCollection().GetDynamicCollections("SELECT H.* FROM " + (ViewSource != null ? ViewSource : TableName) + " H WHERE " + PrimaryKey + " = " + (PrimaryKey == "Oid" ? "'" + ID_CurrentObject.Replace("'", "") + "'" : ID_CurrentObject));
                            //r.Content = new StringContent(JsonConvert.SerializeObject(List[0]), Encoding.UTF8, "application/json");
                            if (List == null) return null;
                            CurrentObject = List[0];
                        }
                    }
                    if (CurrentObject != null)
                    {
                        if (((IDictionary<string, object>)CurrentObject).Keys.Contains("ID"))
                        {
                            if (CurrentObject.ID == -1)
                            {
                                var DefaulValueProperties = new DBCollection().GetDynamicCollections("SELECT Oid,Name,ID_PropertyType,DefaultValue FROM _tModel_Property WHERE DefaultValue IS NOT NULL AND ID_Model = '" + Oid_Model + "' AND isActive = 1 AND Name NOT IN ('ID_CreatedBy', 'ID_LastModifiedBy', 'DateCreated', 'DateModified')");
                                if (DefaulValueProperties != null)
                                {
                                    foreach (var p in DefaulValueProperties)
                                    {
                                        if (p.DefaultValue != null)
                                        {
                                            if (p.ID_PropertyType != null)
                                            {
                                                int ID_Propertytype = p.ID_PropertyType;
                                                try
                                                {
                                                    var currentObject = ((IDictionary<string, object>)CurrentObject);
                                                    switch (ID_Propertytype)
                                                    {
                                                        case 1:// String
                                                            currentObject[p.Name] = p.DefaultValue;
                                                            break;
                                                        case 2:// Int
                                                            currentObject[p.Name] = Int32.Parse(p.DefaultValue.ToString());
                                                            break;
                                                        case 3:// Decimal
                                                            currentObject[p.Name] = Decimal.Parse(p.DefaultValue.ToString());
                                                            break;
                                                        case 4:// Bit
                                                            currentObject[p.Name] = Int32.Parse(p.DefaultValue.ToString()) == 1 ? true : false;
                                                            break;
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Write(e.Message);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (ID_CurrentObject != "0")
                    {
                        var List = new DBCollection().GetDynamicCollections("SELECT H.* FROM " + (ViewSource != null ? ViewSource : TableName) + " H WHERE " + PrimaryKey + " = " + (PrimaryKey == "Oid" ? "'" + ID_CurrentObject.Replace("'", "") + "'" : ID_CurrentObject));
                        //r.Content = new StringContent(JsonConvert.SerializeObject(List[0]), Encoding.UTF8, "application/json");
                        CurrentObject = List[0];
                    }
                }
            }
            else
            {
                sql = Utils.Decrypt(sql);
                if (sql.ToUpper().IndexOf(" WHERE ") > -1)
                {
                    sql = sql.Substring(0, sql.ToUpper().IndexOf(" WHERE "));
                }
                else if (sql.ToUpper().IndexOf(" ORDER BY ") > -1)
                {
                    sql = sql.Substring(0, sql.ToUpper().IndexOf(" ORDER BY "));
                }
                int _ID_CurrentObject = -1;
                bool isID = Int32.TryParse(ID_CurrentObject, out _ID_CurrentObject);
                sql = sql + " WHERE " + (isID ? " ID = " + _ID_CurrentObject : " Oid = '" + ID_CurrentObject + "'");
                var List = new DBCollection().GetDynamicCollections(sql);
                if (List.Count == 1) CurrentObject = List[0];
            }
            return CurrentObject;
        }
    }

    public class SaveObjectParam
    {
        public string CurrentObject { get; set; }
        public string PreviousObject { get; set; }
        public string DeletedItems { get; set; }
        public string UploadFileDetails { get; set; }
        public string CurrentUser { get; set; }
        public string Param { get; set; }
    }
    public class SaveObjectResult
    {
        public string ID_CurrentObject { get; set; }
        public string Message { get; set; }
        public ExpandoObject Record { get; set; }
    }

    public class UploadFileDetail {
        public string FileName { get; set; }
        public string DataField { get; set; }
        public string FileId { get; set; }
        public bool IsImage { get; set; }
        public string NewFileName { get; set; }
        public string NewPath { get; set; }
        public string Oid_Model { get; set; }
        public string ID_CurrentObject { get; set; }
    
    }
}
