using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADPPoc.Model
{
    internal class AudioPlayerdapter:IAudioPlayer
    {
        private LocalAudioPlayer _localPlayer;
        private StreamingServicePlayer _streamingPlayer;

        public AudioPlayerdapter(LocalAudioPlayer localPlayer, StreamingServicePlayer streamingPlayer)
        {
            _localPlayer = localPlayer;
            _streamingPlayer = streamingPlayer;
        }

        public void Play(string track)
        {
            if (track.Contains(".mp3"))
            {
                _localPlayer.PlayLocalAudio(track);
            }
            else
            {
                _streamingPlayer.PlayStreamingService(track);
            }
        }
    }
}

