using System;

namespace MarketplacePOO
{
    public class Client : User
    {
        public Address DeliveryAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}