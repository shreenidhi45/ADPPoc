using ADPPoc.Model;

namespace ADPPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalAudioPlayer localPlayer = new LocalAudioPlayer();
            StreamingServicePlayer streamingPlayer = new StreamingServicePlayer();

            IAudioPlayer audioPlayer = new AudioPlayerdapter(localPlayer, streamingPlayer);

            audioPlayer.Play("local_track.mp3");
            audioPlayer.Play("streaming_track");
        }
    }
}