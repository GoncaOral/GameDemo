using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class OrderManager : IOrderService
    {
        public void OrderAdd(Order order,User user, Game game)
        {
            Console.WriteLine(order.OrderNumber + " Numaralı Sipariş" + ": " + user.FirstName + " İsimli Kullanıcı " + game.GameName + " Adlı Oyundan Sipariş Oluşturdu.");
        }
        public void OrderDelete(Order order, User user, Game game)
        {
            Console.WriteLine(order.OrderNumber + " Numaralı Sipariş" + ": " + user.FirstName + " İsimli Kullanıcı " + game.GameName + " Adlı Oyunu Sipariş Listesinden Kaldırdı.");
        }
        public void OrderUpdate(Order order, User user, Game game)
        {
            Console.WriteLine(order.OrderNumber + " Numaralı Sipariş"+ ": " + user.FirstName + " İsimli Kullanıcı Siparişini Güncelledi..");
        }
    }
}
