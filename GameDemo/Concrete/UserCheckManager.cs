using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class UserCheckManager : IUserCheckService
    {
        public bool ChechkIfRealUser(User user)
        {
            return true;
        }
    }
}
