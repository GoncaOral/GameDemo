using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Eklendi.");
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Silindi.");
        }

        public void GameUpdate(Game game)
        {
            Console.WriteLine("Oyun Güncellendi.");
        }
    }
}
