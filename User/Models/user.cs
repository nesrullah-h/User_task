using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class User
    {
        private string username;
        private string password;
        private int age ;
        public string Username { get;set; }
        public string Password { get;set; }
        public int Age 
        { 
            get 
            {
                return age;
            } 
            set 
            {
                if (value > 0)
                    age = value;

                else
                    Console.WriteLine("yas menfi olmaz");
            }
        }      
        public User()
        {

        }
        public User(string username, string password, int age)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Username}\n{Password}\n{Age}");
        }


    }
}
