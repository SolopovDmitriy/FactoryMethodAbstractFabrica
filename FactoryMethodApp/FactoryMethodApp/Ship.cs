using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    class Ship : Vehicle, ITransport
    {
        // my code-------------------------------------------------
        public void Deliver()
        {
            Console.WriteLine("Deliver by Ship: ");
            foreach (Parcel parcel in Parcels)
            {
                Console.WriteLine($"Deliver from {parcel.Sender} to {parcel.Recipient}");
            }
            Parcels.Clear();
        }
    }
}
