using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WAVPlayer
{
    public class Player
    {
        private Dictionary<string, System.Media.SoundPlayer> dict = new Dictionary<string, SoundPlayer>();
        public static Player Instance = new Player();
        public void Add(string soundName, string wavFileName)
        {
            dict[soundName] = new System.Media.SoundPlayer(wavFileName);
            dict[soundName].Load();
        }
        public void Remove(string soundName)
        {
            dict.Remove(soundName);
        }

        public Dictionary<string, System.Media.SoundPlayer> GetDictionary()
        {
            return dict;
        }

        public void Play(string soundName)
        {
            dict[soundName].PlaySync();
        }

        public void Stop(string soundName)
        {
            dict[soundName].Stop();
        }
    }
}
