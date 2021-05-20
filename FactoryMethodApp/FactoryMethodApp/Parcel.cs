using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodApp
{
    public class Parcel
    {
        public int Weight { get; set; }

        public float Volume { get; set; }

        public float DeclaredPrice { get; set; }

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public Parcel()
        {
            Weight = default;
            Volume = default;
            DeclaredPrice = default;
            Sender = default;
            Recipient = default;
        }
        public Parcel(string sender, string recipient, float decPrice, float volume, int weight)
        {
            Weight = weight;
            Volume = volume;
            DeclaredPrice = decPrice;
            Sender = sender;
            Recipient = recipient;
        }
        public override string ToString()
        {
            return $"Sender: {Sender}; Recipient: {Recipient}; ";
        }
    }
}
