using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using To_Kankan_Some_Xinwen.news;

namespace To_Kankan_Some_Xinwen.binds
{
    class News
    {

        public static RenminwangNews[] GetRenminwangNews(string type, string page)
        {
            string data = "type="+type+"&page="+page;  //要上传到网页系统里的数据（字段名=数值 ，用&符号连接起来）
            byte[] bytesToPost = System.Text.Encoding.Default.GetBytes(data); //转换为bytes数据

            string responseResult = String.Empty;
            HttpWebRequest req = (HttpWebRequest)
            HttpWebRequest.Create("http://localhost:8080/renminwang");   //创建一个有效的httprequest请求，地址和端口和指定路径必须要和网页系统工程师确认正确，不然一直通讯不成功
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded;charset=gb2312";
            req.ContentLength = bytesToPost.Length;

            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bytesToPost, 0, bytesToPost.Length);     //把要上传网页系统的数据通过post发送
            }
            HttpWebResponse httpWebResponse = (HttpWebResponse)req.GetResponse();

            RenminwangNews[] result;

            if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.OK)
            {
                StreamReader sr;
                using (sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    responseResult = sr.ReadToEnd();  //网页系统的json格式的返回值，在responseResult里，具体内容就是网页系统负责工程师跟你协议号的返回值协议内容
                    result = JsonConvert.DeserializeObject<RenminwangNews[]>(responseResult);
                }
                sr.Close();
            }
            else
            {
                return null;
            }
            httpWebResponse.Close();
            return result;
        }
    }
}
