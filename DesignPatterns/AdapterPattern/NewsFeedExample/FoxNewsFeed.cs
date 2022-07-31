namespace DesignPatterns.AdapterPattern.NewsFeedExample;

public interface IJsonNewsProvider
{
    string GetJsonNewsFeed();
}

public class FoxNewsFeed : IJsonNewsProvider
{
    public string GetJsonNewsFeed()
    {
        return "JSON news feed from Fox News.";
    }
}