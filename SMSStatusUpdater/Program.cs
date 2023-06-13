using JSLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading;

namespace SMSStatusUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic appSettings = getAppSettings();

            DateTime dateStart = DateTime.Now;
            DateTime dateEnd;

            Console.WriteLine("Vet Cloud SMS Sender Service run as of {0}", DateTime.Now.ToString("MM/dd/yyyy ddd hh:mm tt"));

            try
            {

                sendSMS(appSettings);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            dateEnd = DateTime.Now;

            System.TimeSpan diff2 = dateEnd - dateStart;

            Console.WriteLine("Done.. Duration - {0}", diff2.ToString("hh\\:mm\\:ss"));
            Thread.Sleep(5000);
        }

        public static void sendSMS(dynamic appSettings)
        {

            string currentExecutable = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            string connectonString = appSettings["SystemManagementConnectionString"];
            string apiCode = appSettings["ITexMoAPICode"];
            string apiPassword = appSettings["ITexMoAPIPassword"];
            string sendSOAPPlanStoredProcedure = appSettings[currentExecutable];
            var SMSRecordStoredProcedures = appSettings["SMSRecordStoredProcedures"];

            List<int> soapPlan = new List<int>();
            List<dynamic> records = new List<dynamic>();

            var dbAccess = new DBCollection(DBCollection.GetReplacedConnectionString(connectonString));

            foreach (string storedProc in SMSRecordStoredProcedures)
            {

                var DetailView = dbAccess.GetDynamicObject(storedProc, true);

                List<dynamic> _records = DetailView.Records as List<dynamic>;

                records.AddRange(_records);
            }

            if (records != null)
            {
                foreach (var d in records)
                {
                    dynamic result;
                    string status = "";
                    string date_sent = "";
                    string datesent = "";
                    string message = "";

                    try
                    {

                        result = Utility.sendVetCloudSMSAPITextMessage(d.UniqueID);

                        status = result.status;

                        date_sent = result.date_sent;
                        datesent = result.date_sent;

                        if (status is null)
                        {
                            status = "1";
                        }

                        if (date_sent is null)
                        {
                            date_sent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {

                            date_sent = date_sent.Replace("T", "");
                        }
                    }
                    catch (Exception ex)
                    {
                        status = "-1";
                        message = ex.Message + $"UniqueID :{ d.UniqueID }";
                        date_sent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    }

                    string sql = $"EXEC dbo.pNoteSOAPPlanAsSend @UniqueID = '{d.UniqueID}', @iTextMo_Status = {status}, @DateSent = '{date_sent}'";

                    Console.WriteLine($"@DateSent = {d.Name_Company}, ID_Reference = {d.ID_Reference}, DateSending {d.DateSending}, DateSent = {datesent}, Number = {d.ContactNumber_Client}, @iTextMo_Status = {status}, ErrorMessage: {message}");

                    var _result = new DBCollection(connectonString).GetDynamicObject(sql, true);
                }
            }
        }

        public static Dictionary<String, Object> Dyn2Dict(dynamic dynObj)
        {
            var dictionary = new Dictionary<string, object>();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(dynObj))
            {
                object obj = propertyDescriptor.GetValue(dynObj);
                dictionary.Add(propertyDescriptor.Name, obj);
            }
            return dictionary;
        }

        public static dynamic getAppSettings()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();

            StreamReader r = new StreamReader(@$"{currentDirectory}/appsettings.json");
            string jsonString = r.ReadToEnd();
            dynamic _tempObject = JsonConvert.DeserializeObject<dynamic>(jsonString);
            r.Close();

            return _tempObject;
        }
    }
}
