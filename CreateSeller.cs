namespace MarketplacePOO
{
    public static class CreateSeller
    {
        public static Seller New() 
        {
            Seller obj = new Seller();
            obj.Id = GetUserData.ReadInt("ID");
            obj.Name = GetUserData.ReadString("Nome");
            obj.UserName = GetUserData.ReadString("Apelido");
            obj.Password = GetUserData.ReadString("Password");
            obj.BirthDate = GetUserData.ReadDateTime("Data de Nascimento");
            obj.Address = CreateAddress.New("Endereço");
            
            return obj;
        }
    }
}