using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Classes
{
    class Branch : Type
    {
        public override TypeOrganization SetType()
        {
            return TypeOrganization.Branch;
        }
    }
}
