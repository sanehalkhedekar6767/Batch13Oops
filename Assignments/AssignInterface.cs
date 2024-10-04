using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal interface Iplayable
    {
        public void Play();
    }
    class VideoPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }
    class MusicPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    public class AssignInterface
    {
        static void Main()
        {
            Iplayable video = new VideoPlayer();
            video.Play();
            Iplayable music = new MusicPlayer();
            music.Play();
        }
    }

}
