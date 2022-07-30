namespace DesignPatterns.ProxyPattern;

public class ProxyProgram
{
    public static void Run()
    {
        Console.WriteLine("Proxy Pattern");
        TestProxyPattern();
    }

    private static void TestProxyPattern()
    {
        var youTubeProxy = new CachedYouTube(new YouTubeService());

        var videos = youTubeProxy.ListVideos();
        Console.WriteLine(videos);
        
        var videoInfo = youTubeProxy.GetVideoInfo(3);
        Console.WriteLine(videoInfo);

        videos = youTubeProxy.ListVideos();
        Console.WriteLine(videos);
    }
}
