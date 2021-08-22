using System;

namespace MarketplacePOO
{
    public static class CreateAddress
    {
        public static Address New(string descriptionAdress)
        {
            Console.WriteLine($"Informe {descriptionAdress}: ");
            Address address = new Address();
            address.StreetOrAvenue = GetUserData.ReadString("Rua/Avenida");
            address.SecondAddress = GetUserData.ReadString("Complemento");
            address.Number = GetUserData.ReadInt("Número");
            address.ZipCode = GetUserData.ReadString("CEP");
            address.City = GetUserData.ReadString("Cidade");
            address.State = GetUserData.ReadString("Estado");
            address.Country = GetUserData.ReadString("País");

            return address;
        }
    }
}