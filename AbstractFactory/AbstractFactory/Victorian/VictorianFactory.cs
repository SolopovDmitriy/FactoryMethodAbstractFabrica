using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Victorian
{
    class VictorianFactory : ICreateProduct
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
