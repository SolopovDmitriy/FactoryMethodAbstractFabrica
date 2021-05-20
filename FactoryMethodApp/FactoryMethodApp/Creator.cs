using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    abstract class Creator
    {
        public abstract ITransport CreateTransport(); 


        public virtual void Print()
        {
            Console.WriteLine("Print Creator ");
        }

    }
}
