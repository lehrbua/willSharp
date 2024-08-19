using System.Text.Json;
using System;
using System.Reflection;
using System.Web;

namespace willSharp
{
    public class willQuery
    {
        private const string marketplaceUrl = "https://www.willhaben.at/iad/kaufen-und-verkaufen/marktplatz";
        private const string userUrl = "https://www.willhaben.at/iad/kaufen-und-verkaufen/verkaeuferprofil/";
        public willOptions Options {  get;  private set; }
        public willQuery(willOptions options)
        {
            Options = options;
        }

        public async Task<willJson> Query()
        {
            using HttpClient client = new HttpClient();
            string uri = OptionsToUri(marketplaceUrl);
            Console.WriteLine(@"https://www.willhaben.at/iad/kaufen-und-verkaufen/marktplatz?isNavigation=true&isISRL=true&srcType=vertical-search-box&keyword=ibm");
            Console.WriteLine(uri);
            using HttpResponseMessage response = await client.GetAsync(OptionsToUri(marketplaceUrl));
            response.Headers.Add("Accept", "application/json");
            response.EnsureSuccessStatusCode();

            string resp = await response.Content.ReadAsStringAsync();



            string searchPattern = "<script id=\"__NEXT_DATA__\" type=\"application/json\">";
            int start = resp.IndexOf(searchPattern);
            start += searchPattern.Length;
            string json = resp.Substring(start, resp.Length - start);
            json = json.Replace("</script></body></html>","");

            willJson wj =  JsonSerializer.Deserialize<willJson>(json);
            return wj;
        }

        private string OptionsToUri(string url)
        {
            UriBuilder builder = new UriBuilder(url);
            builder.Port = -1;
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["rows"] = Options.Rows.ToString();
            query["keyword"] = Options.KeyWord;
            query["paylivery"] = Options.PayLivery.ToString();
            query["PRICE_FROM"] = Options.PriceFrom.ToString();
            query["PRICE_TO"] = Options.PriceTo.ToString();

            if (Options.Conditions.Count > 0)
            {
                foreach (int attribute in Options.Conditions)
                {
                    query["treeAttributes"] = attribute.ToString();
                }
            }

            builder.Query = query.ToString();
            return builder.ToString();
        }
    }
}
