using System;

namespace StatePattern
{
    public class GreenState : IState
    {
        public string Name
        {
            get { return "Green"; }
        }

        public void ChangeState(TrafficSystem ts)
        {
            Console.WriteLine("Green State");
            ts._state = new YellowState();
        }
    }
}