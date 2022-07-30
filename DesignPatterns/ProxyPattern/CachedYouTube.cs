namespace DesignPatterns.ProxyPattern;

public class CachedYouTube : IYouTubeLib
{
    private IYouTubeLib _youTubeService;
    private string _listCache, _videoCache;
    
    public CachedYouTube(IYouTubeLib service)
    {
        _youTubeService = service;
    }

    public string ListVideos()
    {
        if (_listCache == null)
            _listCache = _youTubeService.ListVideos();

        return _listCache;
    }

    public string GetVideoInfo(int id)
    {
        if (_videoCache == null)
            _videoCache = _youTubeService.GetVideoInfo(id);

        return _videoCache;
    }
}
