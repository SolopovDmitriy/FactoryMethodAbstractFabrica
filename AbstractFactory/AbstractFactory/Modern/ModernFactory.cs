using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Modern
{
    class ModernFactory : ICreateProduct
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
