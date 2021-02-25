using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void UserAdd(User user)
        {
            Console.WriteLine(user.FirstName + " İsimli Kullanıcı Eklendi.");
        }

        public virtual void UserDelete(User user)
        {
            Console.WriteLine(user.FirstName + " İsimli Kullanıcı Silindi.");
        }

        public virtual void UserUpdate(User user)
        {
            Console.WriteLine("Kullanıcı Güncellendi.");
        }
    }
}
