using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventt
{
    internal class Program
    {
        //public delegate void ValueDelegate(int i);
        //public delegate void MyDelegate();
        //по сути одно и то же
        //public event MyDelegate Event;
        //public event Action Eventt;

        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Pavel"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("6/5/2022 10:33:11pm"));
            person.TakeTime(DateTime.Parse("6/6/2022 3:33:11am"));
            Console.ReadLine();
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if(sender is Person)
            Console.WriteLine($"{((Person)sender).Name} is working.");
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Man went to bed.");
        }
    }
}
