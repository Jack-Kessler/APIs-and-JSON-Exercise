using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static string KanyeQuoteGenerator()
        {
            var client = new HttpClient();

            string kanyeURL = "https://api.kanye.rest";

            var kanyeJSONResponse = client.GetStringAsync(kanyeURL).Result;

            string kanyeActualQuote = JObject.Parse(kanyeJSONResponse).GetValue("quote").ToString();

            return kanyeActualQuote;
        }

        public static string RonQuoteGenerator()
        {
            var client = new HttpClient();

            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronJSONResponse = client.GetStringAsync(ronURL).Result;

            string ronActualQuote = JArray.Parse(ronJSONResponse).ToString().Replace('[',' ').Replace(']',' ').Trim();

            return ronActualQuote;
        }

    }
}
