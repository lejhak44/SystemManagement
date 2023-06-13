using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JSLibrary
{
    public class Utility {

        public static string setSecondaryColor(string Hex) {
            return SetColorBrightness(Hex, 0.80f);
        }

        public static string SetColorBrightness(string Hex, float A) {
            Color color = ColorTranslator.FromHtml(Hex);
            return HexConverter(ChangeColorBrightness(color, A));
        }

        public static Color ChangeColorBrightness(Color color, float correctionFactor) {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0) {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            } else {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        private static String HexConverter(System.Drawing.Color c) {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public static Image FixedSize(Image imgPhoto, int Width, int Height) {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW) {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            } else {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        public static object sendTextMessage(string Number, string Message, string ApiCode, string ApiPassword)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", Number);
                parameter.Add("2", Message);
                parameter.Add("3", ApiCode);
                parameter.Add("passwd", ApiPassword);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;
        }

        public static object sendVetCloudSMSAPITextMessage(string vetCloudID)
        {
            object functionReturnValue = null;
            dynamic obj;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://textblast.vetcloudsystem.one/api/status.php";
                parameter.Add("UniqueID", vetCloudID);
                dynamic rpb = client.UploadValues(url, "POST", parameter);

                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
                obj = JsonConvert.DeserializeObject<dynamic>(functionReturnValue.ToString());
            }

            return obj;
        }

        public static void saveStringToTextFile(string filename, string value) {

            try
            {
                if (File.Exists(filename))
                {
                    using (StreamWriter writer = new StreamWriter(filename, append: true))
                    {
                        writer.WriteLine(value);
                        writer.Close();
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filename, append: true))
                    {
                        writer.WriteLine(value);
                        writer.Close();
                    }
                }

            }
            catch (Exception ex) { 
            
            
            }

        }
    }


    public static class DataTableExtensions
    {
        public static List<dynamic> ToDynamic(this DataTable dt)
        {
            var dynamicDt = new List<dynamic>();
            foreach (DataRow row in dt.Rows)
            {
                dynamic dyn = new ExpandoObject();
                dynamicDt.Add(dyn);
                foreach (DataColumn column in dt.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    if (row[column] == DBNull.Value || row[column] == null) {
                        dic[column.ColumnName] = null;
                    } else {
                        dic[column.ColumnName] = row[column];
                    } 
                }
            }
            return dynamicDt;
        }

    }
}
