using System;

namespace HW10P._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        interface IPlayable
        {
            public void Play();
            public void Pause();
            public void Stop();
        }
        interface IRecordable
        {
            public void Record();
            public void Pause();
            public void Stop();
        }
        class Actions: IPlayable, IRecordable{
            public void Record() {
                System.Console.WriteLine("I'm recording");
            }
            public void Pause(){
                System.Console.WriteLine("I have paused");
            }
            public void Stop(){
                System.Console.WriteLine("I have stopped");
            }
            public void Play() {
                System.Console.WriteLine("I'm playing");
            }

        }
    }
}
