using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Number2StringService
{

    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string Number2Words(string number)
        {
            string[] replace = { "none ", "none", " ABC ", "DEF", "GHI", "JKL", "MNO", "PRS", "TUV", "WXYZ" };
            string[] num = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (int i = 0; i < 10; i++)
            {
                number = number.Replace(num[i], replace[i]);
            }

            return number;
        }
    }

 
}
