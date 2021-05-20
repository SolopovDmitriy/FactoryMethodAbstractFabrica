using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    class TruckCreator : Creator
    {
        public override ITransport CreateTransport()
        {
            return new Truck { LiftingCapacity = 2000 }; ;
        }
    }
}
