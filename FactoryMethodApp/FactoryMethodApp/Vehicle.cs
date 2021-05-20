using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace FactoryMethodApp
{
    abstract class Vehicle
    { // my code-------------------------------------------------
        public List<Parcel> Parcels { get; set; }
        public int LiftingCapacity { get; set; }

        public void AddParcel(Parcel parcel)
        {
            int sum = Parcels.Sum(p => p.Weight);
            if(sum + parcel.Weight <= LiftingCapacity)
            {
                Parcels.Add(parcel);
            }
            else
            {
                Console.WriteLine("Error. Vehicle doesn't have enough LiftingCapacity");
            }           
        }

        public Vehicle()
        {
            Parcels = new List<Parcel>();
        }

    }
}
