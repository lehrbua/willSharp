using willSharp;

namespace ConsoleTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            willOptions options = new willOptions()
            {
                KeyWord = "ibm",
                Rows = 30,
                PayLivery = true,
                PriceFrom = 0,
                PriceTo = 10,
            };

            options.AddCondition(willOptions.Condition.Used);
            willQuery query = new willQuery(options);
            willJson result = await query.Query();

            Console.WriteLine(result.props.pageProps.searchResult.rowsFound);
            foreach (Advertsummary advert in result.props.pageProps.searchResult.advertSummaryList.advertSummary)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Beschreibung: {advert.description}");
                Console.WriteLine($"Status: {advert.advertStatus.description}");
                foreach (willSharp.Attribute attribute in advert.attributes.attribute)
                {
                    if (attribute.values.Count() > 0) Console.WriteLine($"{attribute.name}: {attribute.values[0]}");
                }

            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
