using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Web;
using System.Xml;
using System.Reflection;
using System.ComponentModel;
using System.IO;
using System.Collections;
using System.Data;
namespace ERP.Web
{
    public class Public
    {
        /// <summary>
        /// 获得网页标题
        /// </summary>
        /// <param name="url"></param>
        /// <param name="charSet"></param>
        /// <returns></returns>
        public static string GetHtml(string url, string charSet)
        {
            try
            {
                //url是要访问的网站地址，charSet是目标网页的编码，如果传入的是null或者""，那就自动分析网页的编码
                WebClient myWebClient = new WebClient(); //创建WebClient实例myWebClient
                // 需要注意的：
                //有的网页可能下不下来，有种种原因比如需要cookie,编码问题等等
                //这是就要具体问题具体分析比如在头部加入cookie
                // webclient.Headers.Add("Cookie", cookie);
                //这样可能需要一些重载方法。根据需要写就可以了

                //获取或设置用于对向 Internet 资源的请求进行身份验证的网络凭据。
                myWebClient.Credentials = CredentialCache.DefaultCredentials;
                //如果服务器要验证用户名,密码
                //NetworkCredential mycred = new NetworkCredential(struser, strpassword);
                //myWebClient.Credentials = mycred;
                //从资源下载数据并返回字节数组。（加@是因为网址中间有"/"符号）
                byte[] myDataBuffer = myWebClient.DownloadData(url);
                string strWebData = Encoding.Default.GetString(myDataBuffer);

                //获取网页字符编码描述信息
                Match charSetMatch = Regex.Match(strWebData, "<meta([^<]*)charset=([^<]*)\"", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                string webCharSet = charSetMatch.Groups[2].Value;
                if (charSet == null || charSet == "")
                    charSet = webCharSet;

                if (charSet != null && charSet != "" && Encoding.GetEncoding(charSet) != Encoding.Default)
                    strWebData = Encoding.GetEncoding(charSet).GetString(myDataBuffer);

                Match TitleMatch = Regex.Match(strWebData, "<title>(.*?)</title>", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                string title = TitleMatch.Groups[1].Value;
                return title;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 根目录
        /// </summary>
        public static string rootDir
        {
            get
            {
                string root = HttpContext.Current.Request.ApplicationPath;
                if (root == "/") root = string.Empty;
                return root;
            }
        }
        /// <summary>
        /// 读取配置文件，从本地文件读取
        /// </summary>
        /// <param name="target">节点</param>
        /// <param name="Path">配置文件的路径</param>
        /// <param name="isText">是否显示为text</param>
        /// <returns></returns>
        public static string GetXMLValue(string target, string Path, bool isText = false)
        {
            try
            {
                string XmlPath = HttpContext.Current.Server.MapPath(Path);
                System.Xml.XmlDocument xdoc = new XmlDocument();
                xdoc.Load(XmlPath);
                XmlElement root = xdoc.DocumentElement;
                XmlNode node = root.SelectSingleNode(target);
                if (node != null)
                {
                    return isText ? node.InnerText : node.InnerXml;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch { return string.Empty; }
        }

        /// <summary>
        /// 读取配置文件，从远程文件读取
        /// </summary>
        /// <param name="target">节点</param>
        /// <param name="Path">配置文件的绝对路径</param>
        /// <param name="isText">是否显示为text</param>
        /// <returns></returns>
        public static string GetXMLValueRpath(string target, string Path, bool isText = false)
        {
            try
            {
                string XmlPath = Path;
                System.Xml.XmlDocument xdoc = new XmlDocument();
                xdoc.Load(XmlPath);
                XmlElement root = xdoc.DocumentElement;
                XmlNode node = root.SelectSingleNode(target);
                if (node != null)
                {
                    return isText ? node.InnerText : node.InnerXml;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch { return string.Empty; }
        }
        /// <summary>
        /// 从xml字符中读取
        /// </summary>
        /// <param name="target">节点</param>
        /// <param name="xmlStr">XML字符</param>
        /// <param name="isText">是否显示为text</param>
        /// <returns></returns>
        public static string GetXMLValueFromXmlStr(string target, string xmlStr, bool isText = false)
        {
            try
            {
                System.Xml.XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(xmlStr);
                XmlElement root = xdoc.DocumentElement;
                XmlNode node = root.SelectSingleNode(target);
                if (node != null)
                {
                    return isText ? node.InnerText : node.InnerXml;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch { return string.Empty; }
        }
        /// <summary>
        /// 获取XML节点的值
        /// </summary>
        /// <param name="Xpath">节点 根节点ROOT不写</param>
        /// <param name="XMLPath">XML文件路径 </param>
        /// <returns>单个值</returns>
        public static string GetXmlDate(string Xpath, string XMLPath)
        {
            try
            {
                Xpath = "ROOT/" + Xpath;
                if (!File.Exists(XMLPath))
                {
                    return "";
                }

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(XMLPath);

                XmlNode FoundNode;

                FoundNode = (XmlNode)xmldoc.SelectSingleNode("descendant::" + Xpath);

                if (FoundNode == null)
                {
                    return "no";
                }
                else
                {
                    return FoundNode.InnerText;
                }
            }
            catch
            {
                return "error";
            }
        }


        //public static string GetUserSupplier() {
        //    QCUserToSupplierBLL userspbll = new QCUserToSupplierBLL();
        //    var splist = userspbll.GetModelList(" and userid='" + WebHelper.GetCurrentUser().UserId + "'");
        //    string str = "";
        //    foreach (var item in splist)
        //    {
        //        str += "'" + item.supplierid + "',";
        //    }
        //    str = str.TrimEnd(',');
        //    return str;
        //}

        //public static string GetUserCustomer()
        //{
        //    QCUserToCustmerBLL usercsbll = new QCUserToCustmerBLL();
        //    var cslist = usercsbll.GetModelList(" and userid='" + WebHelper.GetCurrentUser().UserId + "'");
        //    string str = "";
        //    foreach (var item in cslist)
        //    {
        //        str += "'" + item.custmerid + "',";
        //    }
        //    str = str.TrimEnd(',');
        //    return str;
        //}

        /// <summary>
        /// 获取枚举描述
        /// </summary>
        /// <param name="e">枚举值</param>
        /// <returns></returns>
        public static string GetEnumDesc(Enum e)
        {
            try
            {
                FieldInfo EnumInfo = e.GetType().GetField(e.ToString());
                DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])EnumInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (EnumAttributes.Length > 0)
                {
                    return EnumAttributes[0].Description;
                }
                return e.ToString();
            }
            catch
            {

                return string.Empty;
            }
        }

        public static List<dynamic> GetEnumTypeList<T>()
        {
            List<dynamic> list = new List<dynamic>();
            foreach (var i in Enum.GetValues(typeof(T)))
            {
                Hashtable ht = new Hashtable();
                ht.Add("value", GetEnumDesc((Enum)Enum.Parse(typeof(T), i.ToString())));
                ht.Add("text", GetEnumDesc((Enum)Enum.Parse(typeof(T), i.ToString())));
                list.Add(ht);
            }
            return list;
        }

        /// <summary>
        /// 获取客户端真实Ip
        /// </summary>
        /// <returns></returns>
        public static string GetClientIP()
        {
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            return result;
        }
        /// <summary>
        /// 获取当前系统的域名、IP
        /// </summary>
        /// <returns></returns>
        public static string GetCurrectDomain()
        {
            Uri currectUri = HttpContext.Current.Request.Url;
            StringBuilder hostName = new StringBuilder(currectUri.Scheme + "://");
            hostName.Append(currectUri.Host);
            if (currectUri.Port != 80)
            {
                hostName.Append(":" + currectUri.Port);
            }
            return hostName.ToString();
        }
        /// <summary>
        /// 判断某个uri.host是否为域名
        /// 判断条件：域名应为xx.xxx.xx这样的，不允许IP地址、带端口、虚拟目录
        /// </summary>
        /// <param name="uriHost">uri host主机</param>
        /// <returns></returns>
        public static bool IsUriDomain(string uriHost)
        {
            if (uriHost.IndexOf(':') > -1 || uriHost.IndexOf('/') > -1 || uriHost.IndexOf('\\') > -1)
            {
                return false;
            }
            //判断是否为IP
            System.Net.IPAddress ip;
            if (System.Net.IPAddress.TryParse(uriHost, out ip))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 按照给定路径自动创建存储文件夹
        /// </summary>
        /// <param name="pathbase">给定存储相对路径</param>
        public static void CreateFolder(string pathbase)
        {
            string uploadpath = HttpContext.Current.Server.MapPath(pathbase);//获取文件上传路径
            if (!Directory.Exists(uploadpath))
            {
                Directory.CreateDirectory(uploadpath);
            }
        }

        /// <summary>
        /// 遍历指定文件夹所有文件
        /// </summary>
        /// <param name="list">所有子目录及文件</param>
        /// <param name="path">指定根目录</param>
        /// <param name="apath">指定根目录绝对路径</param>
        /// <param name="dir">指定模板目录</param>
        /// <param name="IsAll">是否包含所有（子目录、文件）true 包含，false 包含目录</param>
        public static void CreateTree(List<Hashtable> list, string path, string apath, string dir, bool IsAll)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo theFolder = new DirectoryInfo(path);
                DirectoryInfo[] dirInfo = theFolder.GetDirectories();
                //遍历文件夹
                if (dirInfo.Length > 0)//存在子目录
                {

                    foreach (DirectoryInfo NextFolder in dirInfo)
                    {
                        DirectoryInfo theFolder1 = new DirectoryInfo(path + "\\" + NextFolder.Name + "\\");
                        DirectoryInfo[] dirInfo1 = theFolder1.GetDirectories();
                        if (dirInfo1.Length > 0)
                        {
                            CreateTree(list, path + "\\" + NextFolder.Name + "\\", apath, dir, IsAll);//递归添加
                        }
                        Hashtable ht = new Hashtable();
                        ht.Add("name", NextFolder.Name);
                        ht.Add("fullname", NextFolder.FullName);
                        if (IsAll)
                        {
                            ht.Add("rpath", NextFolder.FullName.Replace(apath, ""));//相对路径//
                        }
                        else
                        {
                            ht.Add("rpath", dir + "\\" + NextFolder.FullName.Replace(apath, ""));//相对路径//
                        }
                        ht.Add("parent", NextFolder.Parent.Name);
                        ht.Add("id", NextFolder.Name);
                        ht.Add("pId", NextFolder.Parent.Name);
                        if (IsAll)
                        {
                            FileInfo[] fileInfo = NextFolder.GetFiles();
                            if (fileInfo.Length > 0)
                            {
                                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                                {
                                    Hashtable hb = new Hashtable();
                                    hb.Add("name", NextFile.Name);
                                    hb.Add("fullname", NextFile.FullName);//绝对路径
                                    string rpath = NextFile.FullName.Replace(apath, "");//
                                    hb.Add("rpath", rpath);//相对路径
                                    hb.Add("parent", NextFolder.Name);
                                    hb.Add("id", NextFile.Name);
                                    hb.Add("pId", NextFolder.Name);
                                    list.Add(hb);
                                }
                            }
                        }
                        list.Add(ht);
                    }
                }
            }
        }
        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="srcPath">文件夹目录</param>
        /// <param name="isDeleteRoot">是否删除跟目录</param>
        public static void DelectDir(string srcPath, bool isDeleteRoot = true)
        {
            try
            {
                if (Directory.Exists(srcPath))
                {
                    DirectoryInfo dir = new DirectoryInfo(srcPath);
                    FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                    foreach (FileSystemInfo i in fileinfo)
                    {
                        //删除子目录
                        if (i is DirectoryInfo)            //判断是否文件夹
                        {
                            DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                            subdir.Delete(true);          //删除子目录和文件
                        }
                        else
                        {
                            File.Delete(i.FullName);      //删除指定文件
                        }
                    }
                    if (isDeleteRoot)
                    {
                        Directory.Delete(srcPath);
                    }
                }
            }
            catch
            {
            }
        }
        public static string GetProperties<T>(T t)
        {
            string tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}_{1}__", name, value);
                }
                else
                {
                    tStr += GetProperties(value);
                }
            }
            return tStr;
        }
        /// <summary>
        /// 反射实现两个类的对象之间相同属性的值的复制
        /// 适用于没有新建实体之间
        /// </summary>
        /// <typeparam name="D">返回的实体</typeparam>
        /// <typeparam name="S">数据源实体</typeparam>
        /// <param name="d">返回的实体</param>
        /// <param name="s">数据源实体</param>
        /// <returns></returns>
        public static D MapperToModel<D, S>(D d, S s)
        {
            try
            {
                var Types = s.GetType();//获得类型  
                var Typed = typeof(D);
                foreach (PropertyInfo sp in Types.GetProperties())//获得类型的属性字段  
                {
                    foreach (PropertyInfo dp in Typed.GetProperties())
                    {
                        if (dp.Name == sp.Name && dp.PropertyType == sp.PropertyType && dp.Name != "Error" && dp.Name != "Item")//判断属性名是否相同  
                        {
                            dp.SetValue(d, sp.GetValue(s, null), null);//获得s对象属性的值复制给d对象的属性  
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return d;
        }

    }
}
