using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Class
{
    class Common
    {
        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-22
        /// description : 프로그램 실행경로를 리턴한다.
        /// </summary>
        public static string getLocalPath()
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            string localPath = "";
            
            foreach(var item in currentPath.Split("\\"))
            {
                localPath += item + @"\";
            }

            return localPath;
        }

        /// <summary>
        /// author : yuminhio
        /// date   : 2024-01-22
        /// description : DB연결정보를 담은 Xml파일 경로를 구한다.
        /// </summary>
        public static string getXmlLocalPath()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(getLocalPath());
            sb.Append(ConfigurationManager.AppSettings["DBConnectionXml"]);

            return sb.ToString();
        }
    }
}
