using System;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.Add(new User { UserId = 1, DateBirth = new DateTime(2001, 10, 21),
            FirstName="Sude",LastName="Karanlık", NationalityId="138975" });
            Console.ReadLine();

        }
    }
}
