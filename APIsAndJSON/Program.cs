namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    string kanyeQuote = RonVSKanyeAPI.KanyeQuoteGenerator();
            //    string ronQuote = RonVSKanyeAPI.RonQuoteGenerator();
            //    Console.WriteLine($"Kanye: \"{kanyeQuote}\"\nRon: {ronQuote}\n\n");
            //    Console.WriteLine("====================================\n");
            //}

            OpenWeatherMapAPI.FindCurrentWeather();
        }
    }
}
