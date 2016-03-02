using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TrafficSystem
    {
        public IState _state;

        public TrafficSystem()
        {
            _state=new RedState();
        }

        public void Start()
        {
            _state.ChangeState(this);
        }
    }
}
