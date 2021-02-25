using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Order :IEntity
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int CampaignId { get; set; }
    }
}
