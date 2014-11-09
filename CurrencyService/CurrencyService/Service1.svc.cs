using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;

namespace CurrencyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string currency( string currency2)
        {
            string url = "http://www.floatrates.com/daily/USD.xml";

            Uri ur = new Uri(url);
            WebClient proxy = new WebClient();

            string xmlpage = "";
            string result = "Please enter an vaild currency";

            try
            {
                byte[] xml = proxy.DownloadData(ur);
                xmlpage = System.Text.UTF8Encoding.UTF8.GetString(xml);

            }
            catch (Exception e)
            {
                return e.ToString();
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlpage);
            XmlNodeList eList1 = doc.GetElementsByTagName("title");

            for (int i = 0; i < 79; i++)
            {
                if (eList1[i].InnerText.Contains(currency2))
                {
                    result = "\n" + eList1[i].InnerText;
                    
                }
            }
            return result;
    }
        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
