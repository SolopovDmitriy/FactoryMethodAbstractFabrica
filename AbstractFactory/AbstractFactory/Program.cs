using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IProduct> clientOrderOneStyle = new List<IProduct>();

            ICreateProduct factory;
            
            
            factory = new Victorian.VictorianFactory();
            clientOrderOneStyle.Add(factory.CreateChair());
            clientOrderOneStyle.Add(factory.CreateSofa());
            clientOrderOneStyle.Add(factory.CreateTable());

            foreach (var item in clientOrderOneStyle)
            {
                Console.WriteLine(item);
            }
            List<IProduct> clientOrderManyStyles = new List<IProduct>();

            clientOrderManyStyles.Add(new Victorian.VictorianFactory().CreateChair());
            clientOrderManyStyles.Add(new Modern.ModernFactory().CreateSofa());
            clientOrderManyStyles.Add(new HighTech.HighTechFactory().CreateTable());

            foreach (var item in clientOrderManyStyles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
