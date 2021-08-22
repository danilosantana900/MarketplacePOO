namespace MarketplacePOO
{
    public static class CreateClient
    {
        public static Client New() 
        {
            Client obj = new Client();
            obj.Id = GetUserData.ReadInt("ID");
            obj.Name = GetUserData.ReadString("Nome");
            obj.UserName = GetUserData.ReadString("Apelido");
            obj.Password = GetUserData.ReadString("Password");
            obj.BirthDate = GetUserData.ReadDateTime("Data de Nascimento");
            obj.DeliveryAddress = CreateAddress.New("Endereço de Entrega");
            obj.BillingAddress = CreateAddress.New("Endereço de Cobrança");
            
            return obj;
        }
    }
}