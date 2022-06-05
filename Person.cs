using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventt
{
    internal class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;
        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 10)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                //var arg = new EventArgs();
                DoWork?.Invoke(this, null);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
