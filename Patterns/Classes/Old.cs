using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Classes
{
    class Old : Novelty
    {
        public override NoveltyUnit SetNovelty()
        {
            return NoveltyUnit.Old;
        }
    }
}
