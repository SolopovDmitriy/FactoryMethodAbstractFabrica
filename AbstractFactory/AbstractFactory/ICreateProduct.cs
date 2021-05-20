using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface ICreateProduct
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
}
