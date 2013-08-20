using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace PDCX.CSharp
{
    public static class Config
    {
        private static char[] _delimiter = new char[] { '|' };
        private static string _NETePayHostList;
        private static string _GIFTePayHostList;
        private static string _MerchantIDList;
        private static string _SecureDeviceList;
        private static string _PadTypeList;

        public static string NETePayHostList
        {
            get { return _NETePayHostList; }
        }

        public static string GIFTePayHostList
        {
            get { return _GIFTePayHostList; }
        }

        public static List<string> MerchantIDList
        {
            get { return _MerchantIDList.Split(_delimiter).ToList(); }
        } 

        public static List<string> SecureDeviceList
        {
            get { return _SecureDeviceList.Split(_delimiter).ToList(); }
        }

        public static List<string> PadTypeList
        {
            get { return _PadTypeList.Split(_delimiter).ToList(); }
        }

        static Config()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            _NETePayHostList = appSettings["NETePayHostList"];
            _GIFTePayHostList = appSettings["GIFTePayHostList"];
            _MerchantIDList = appSettings["MerchantIDList"];
            _SecureDeviceList = appSettings["SecureDeviceList"];
            _PadTypeList = appSettings["PadTypeList"];            
        }
    }
}
