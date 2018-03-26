using System.Net;
using GeekBurger.StoreCatalog.Core.Interfaces;

namespace GeekBurger.StoreCatalog.Core
{
    public class StoreCatalogCore : IStoreCatalogCore
    {
        public bool StatusServers()
        {
            try
            {
                var client = new WebClient();
                string resultUrl1 = client.DownloadString("http://www.youtube.com.br/");
                string resultUrl2 = client.DownloadString("http://www.uol.com.br/");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
