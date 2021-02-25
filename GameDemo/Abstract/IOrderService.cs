using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
   public  interface IOrderService
   {
        void OrderAdd(Order order,User user,Game game);
        void OrderUpdate(Order order, User user, Game game);
        void OrderDelete(Order order, User user, Game game);
   }
}
