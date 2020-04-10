using System;

namespace HW10P._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface IPlayable
        {
            public void Play() {
                System.Console.WriteLine("I'm playing");
            }
            public void Pause(){
                System.Console.WriteLine("I have paused");
            }
            public void Stop(){
                System.Console.WriteLine("I have stopped");
            }
        }
        interface IRecordable
        {
            public void Record() {
                System.Console.WriteLine("I'm recording");
            }
            public void Pause(){
                System.Console.WriteLine("I have paused");
            }
            public void Stop(){
                System.Console.WriteLine("I have stopped");
            }
        }
    }
}
