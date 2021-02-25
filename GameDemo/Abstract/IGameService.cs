using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        void GameAdd(Game game);
        void GameUpdate(Game game);
        void GameDelete(Game game);
    }
}
