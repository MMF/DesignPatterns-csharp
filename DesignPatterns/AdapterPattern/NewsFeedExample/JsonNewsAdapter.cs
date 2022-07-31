namespace DesignPatterns.AdapterPattern.NewsFeedExample;

public class JsonNewsAdapter : IXmlNewsFeedProvider
{
    private IJsonNewsProvider _jsonNewsProvider;

    public JsonNewsAdapter(IJsonNewsProvider provider)
    {
        _jsonNewsProvider = provider;
    }
    
    public string GetXmlNewsFeed()
    {
        var jsonData = _jsonNewsProvider.GetJsonNewsFeed();
        return _convertJsonToXML(jsonData);
    }

    private string _convertJsonToXML(string jsonContext)
    {
        return $"[XML] {jsonContext}";
    }
}
