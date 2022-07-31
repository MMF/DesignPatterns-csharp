namespace DesignPatterns.AdapterPattern.NewsFeedExample;

public class NewsReaderClient
{
    public static void Run()
    {
        var aljazeera = new AlJazeeraNewsFeed();
        ShowNews(aljazeera);

        var foxNews = new FoxNewsFeed();
        //ShowNews(foxNews);
        
        var newsAdapter = new JsonNewsAdapter(foxNews);
        ShowNews(newsAdapter);
    }

    public static void ShowNews(IXmlNewsFeedProvider provider)
    {
        Console.WriteLine(provider.GetXmlNewsFeed());
    }
}
