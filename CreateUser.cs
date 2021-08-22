using System;

namespace MarketplacePOO
{
    public static class CreateUser
    {
        public static User New() 
        {
            User obj = new User();
            obj.Id = GetUserData.ReadInt("ID");
            obj.Name = GetUserData.ReadString("Nome");
            obj.UserName = GetUserData.ReadString("Apelido");
            obj.Password = GetUserData.ReadString("Password");
            obj.BirthDate = GetUserData.ReadDateTime("Data de Nascimento");
            
            return obj;
        }
    }
}