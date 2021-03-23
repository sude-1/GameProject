using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Sayın:" + " " + user.FirstName + " " + user.LastName + " " + "kaydınız başarıyla oluşturuldu.");
        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Sayın:" + " " + user.FirstName + " " + user.LastName + " " + "kaydınız silindi.");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Sayın:" + " " + user.FirstName + " " + user.LastName + " " + "kaydınız başarıyla güncelleştirildi.");
        }
    }
}
