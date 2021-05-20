using System.Collections.Generic;

namespace FactoryMethodApp
{
    public interface ITransport
    {


        List<Parcel> Parcels { get; set; }  

        void AddParcel(Parcel parcel);

        void Deliver();
    }
}