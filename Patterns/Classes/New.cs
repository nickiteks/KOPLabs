using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Classes
{
    class New : Novelty
    {
        public override NoveltyUnit SetNovelty()
        {
            return NoveltyUnit.New;
        }
    }
}
