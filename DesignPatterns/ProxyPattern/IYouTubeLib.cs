namespace DesignPatterns.ProxyPattern;

public interface IYouTubeLib
{
    string ListVideos();
    string GetVideoInfo(int id);
}