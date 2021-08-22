using System;

namespace MarketplacePOO
{
    public static class GetUserData
    {
        public static int ReadInt(string field)
        {
            Console.Write($"Informe {field}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static String ReadString(string field)
        {
            Console.Write($"Informe {field}: ");
            return Console.ReadLine();
        }             
        
        public static DateTime ReadDateTime(string field)
        {
            Console.Write($"Informe {field}: ");
            return Convert.ToDateTime(Console.ReadLine());
        }        
    }
}