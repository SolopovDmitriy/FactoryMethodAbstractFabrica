using System;
using System.Collections.Generic;

namespace FactoryMethodApp
{
    class Program
    {


        static void TestOverride()
        {
            Creator[] creators = { new ShipCreator(), new TruckCreator() };
            Creator shipCreator = new ShipCreator();
            creators[0].Print();
        }





        static void Main(string[] args)
        {
           
            /*Factory Method - порождающий паттерн который определяет общий интерфейс по созданию любых обьектов*/

            ShipCreator shipCreator = new ShipCreator();
            TruckCreator truckCreator = new TruckCreator();


            ITransport transport = shipCreator.CreateTransport(); // = new Ship();
            transport = truckCreator.CreateTransport(); // = new Truck();


            // my code-------------------------------------------------
            transport.AddParcel(new Parcel("Anna", "Maria", 1500, 150.0f, 125));
            transport.AddParcel(new Parcel("Anna2", "Maria2", 2500, 153.0f, 225));
            transport.AddParcel(new Parcel("Anna3", "Maria3", 3500, 155.0f, 325));
            // my code-------------------------------------------------
            transport.Deliver();


            List<ITransport> novaPochtaTrnsportList = new List<ITransport>();

            novaPochtaTrnsportList.Add(shipCreator.CreateTransport());
            novaPochtaTrnsportList.Add(truckCreator.CreateTransport());
            novaPochtaTrnsportList.Add(shipCreator.CreateTransport());


            /*Реализовать доставку нескольких единиц посылок одним транспортным средством*/



            // TestOverride();

        }
    }
}
