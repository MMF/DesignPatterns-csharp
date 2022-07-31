namespace DesignPatterns.AdapterPattern.NewsFeedExample;

public interface IXmlNewsFeedProvider
{
    string GetXmlNewsFeed();
}


public class AlJazeeraNewsFeed : IXmlNewsFeedProvider
{
    public string GetXmlNewsFeed()
    {
        return "XML news feed from AlJazeera";
    }
}
