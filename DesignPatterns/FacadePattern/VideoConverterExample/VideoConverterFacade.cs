using DesignPatterns.FacadePattern.VideoConverterExample.VideoLibrary;

namespace DesignPatterns.FacadePattern.VideoConverterExample;

public class VideoConverterFacade
{
    public VideoFile ConvertVideo(string filename, string format)
    {
        var videoFile = new VideoFile(filename);
        var sourceCodec = new CodecFactory().Extract(videoFile);

        ICompressionCodec destinationCodec;
        if (format == "mp4")
            destinationCodec = new MPEG4CompressionCodec();
        else
            destinationCodec = new OggCompressionCodec();

        var bitRateReader = new BitRateReader();
        var buffer = bitRateReader.Read(videoFile, sourceCodec);
        var videoData = bitRateReader.Convert(buffer, destinationCodec);

        var result = new AudioMixer().Fit(videoData);
        return new VideoFile(result);
    }
}