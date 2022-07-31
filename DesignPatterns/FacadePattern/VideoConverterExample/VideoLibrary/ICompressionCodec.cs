namespace DesignPatterns.FacadePattern.VideoConverterExample.VideoLibrary;

public interface ICompressionCodec
{
    string Encode(VideoFile file);
    string Decode(VideoFile file);
}
