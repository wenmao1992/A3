using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public String[] hotel(string zip){

            String url = "https://maps.googleapis.com/maps/api/place/textsearch/xml?query=hotel+in+"+zip+
                "&key=AIzaSyBYBcV73rNAli4bauQJaUl8gjqmFPDYH2I" ;

            Uri ur = new Uri(url);
            WebClient proxy = new WebClient();

            string xmlpage = "";
            string[] ele = new string[10];

            try
            {
                byte[] xml = proxy.DownloadData(ur);
                xmlpage = System.Text.UTF8Encoding.UTF8.GetString(xml);

            }
            catch (Exception e)
            {
                 Console.WriteLine(e.ToString());
                 
            }

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlpage);
            XmlNodeList eList1 = doc.GetElementsByTagName("name");
            XmlNodeList eList2 = doc.GetElementsByTagName("formatted_address");

            for (int i = 0; i < 10; i++)
            {
                ele[i] += "         Hotel: " + eList1[i].InnerXml + "\n Address: " + eList2[i].InnerXml;
            }

                return ele;

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
