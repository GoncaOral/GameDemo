using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
   public  class UserManager:BaseUserManager
   {
        private IUserCheckService _userCheckService;
        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public override void UserAdd(User user)
        {
            if (_userCheckService.ChechkIfRealUser(user))
            {
                base.UserAdd(user);
            }
            else
            {
                throw new Exception("Not a valid User");
            }
           
        }

        public override void UserDelete(User user)
        {
            base.UserDelete(user);
        }

        public override void UserUpdate(User user)
        {
            base.UserUpdate(user);
        }
    }
}
