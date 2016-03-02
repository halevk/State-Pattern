using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class RedState :IState
    {
        public void ChangeState(TrafficSystem ts)
        {
            Console.WriteLine("Red State");
            ts._state = new GreenState();
        }

        public string Name
        {
            get { return "Red"; }
        }
    }
}
