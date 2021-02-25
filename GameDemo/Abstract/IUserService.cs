using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IUserService
    {
        void UserAdd(User user);
        void UserUpdate(User user);
        void UserDelete(User user);
    }
}
