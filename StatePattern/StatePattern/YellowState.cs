using System;

namespace StatePattern
{
    public class YellowState : IState
    {
        public string Name
        {
            get { return "Yellow"; }
        }

        public void ChangeState(TrafficSystem ts)
        {
            Console.WriteLine("Yellow State");
            ts._state=new RedState();
            
        }
    }
}