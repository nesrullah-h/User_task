using System;
using User;
namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Username = "Nicat";
            user1.Password = "Hecinecesenficuu";
            user1.Age = -5;
            user1.GetInfo();
            //Console.WriteLine();
            
            
        }
    }
}
