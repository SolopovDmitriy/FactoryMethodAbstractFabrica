﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    class ShipCreator : Creator
    {
        public override ITransport CreateTransport()
        {
            return new Ship { LiftingCapacity = 4000 };
        }

        public override void Print() // new - запускает родительскую версию метода  
                                     // override - запускает свою версию метода
        {
            Console.WriteLine("Print ShipCreator ");
        }

    }
}
