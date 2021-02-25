using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserManager userManager = new UserManager(new MernisServiceAdapter());
            userManager.UserAdd(new User 
            { 
                Id=1,
                NationalityId=54004384536,
                FirstName="GONCA",
                LastName="ORAL",
                DateOfBirth= new DateTime (1994,11,01),
                UserType = "Gamer"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign
            {
                CampaignId = 1,
                CampaignName = "Kişiye Özel Kampanya"
            }, new User
            {
                FirstName = "Gonca"
            });

            GameManager gameManager = new GameManager();
            gameManager.GameAdd(new Game { GameId = 1, GameName = "Pubg" });

            OrderManager orderManager = new OrderManager();
            orderManager.OrderAdd(new Order
            {
                OrderNumber = 100
            }, new User
            {
                FirstName = "Gonca"
            }, new Game
            {
                GameName = "Pubg"
            });

            Console.ReadLine();
        }
    }
}
