using System;

namespace HW10P._2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("I'm walking.What should I do?");
            Actions me = new Actions();
            do{
            System.Console.WriteLine("1.Play\n2.Pause\n3.Stop\n4.Record");
            switch(Console.ReadLine()){
                case "1": me.Play(); break;
                case "2": me.Pause(); break;
                case "3": me.Stop(); break;
                case "4": me.Record(); break;
                default: System.Console.WriteLine("Your choice not exist"); break;
            }
            System.Console.WriteLine("Enter some key to continue and q to exit");
            }while(Console.ReadLine() != "q");
            System.Console.WriteLine("Bye");
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
