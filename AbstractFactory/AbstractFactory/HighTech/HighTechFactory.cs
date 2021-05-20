using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.HighTech
{
    class HighTechFactory : ICreateProduct
    {
        public IChair CreateChair()
        {
            return new HighTechChair();
        }

        public ISofa CreateSofa()
        {
            return new HighTechSofa();
        }

        public ITable CreateTable()
        {
            return new HighTechTable();
        }
    }
}
