using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserManager : BaseUserManager
    {
        private IUserCheckService _userCheckService;

        public UserManager()
        {
        }

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public override void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
            {
                base.Add(user);
            }
            else
            {
                throw new Exception("Bilgilerinizi lütfen kontrol ediniz!!!");
            }
        }
        public override void Delete(User user)
        {
            base.Delete(user);
        }
        public override void Update(User user)
        {
            base.Update(user);
        }
    }
}
