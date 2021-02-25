using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game: IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int SalesPrice { get; set; }
    }
}
