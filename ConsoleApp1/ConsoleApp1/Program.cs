using Geocoding;
using Geocoding.Google;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace AIFSCRAPER
{
    public class Program
    {
        static void Main(string[] args)
        {

            string search = "victoria";
            string baseAddress = "https://www.aif.adfa.edu.au/";

            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load($"{baseAddress}search?type=search&name=&regNum=&place={search}&includeNOK=n&townOnly=n&start=0&pageSize=1000&totFound=1000");

            var listings = doc.DocumentNode.SelectNodes("//tr");

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Aidan\Desktop\aifScrap.json");
            file.AutoFlush = true;

            file.WriteLine("[");

            foreach (var item in listings.Where(l => l != listings.Last()))
            {
                string num = item.ChildNodes[1].InnerHtml;
                string name = item.ChildNodes[2].InnerText;
                string address = item.ChildNodes[3].InnerHtml;
                string battalion = item.ChildNodes[4].InnerText;


                IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyBPiIqz1gTyYxOQqRIm47zjLtpP3TknBRo" };

                try
                {
                    Console.WriteLine(num);
                    IEnumerable<Address> addresses = geocoder.Geocode(address);
                    string entry = "{\"name\": \"" + name + "\"," +
                    "\"coords\": \"[" + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude + "]\"},";
                    file.WriteLine(entry);
                }
                catch (Exception e)
                {
                    Console.WriteLine("[ERROR] - " + e.Message);
                }

                
                

            }
            file.WriteLine("]");
        }
    }

}
