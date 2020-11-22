using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Classes
{
    class Representation : Type
    {
        public override TypeOrganization SetType()
        {
            return TypeOrganization.Representation;
        }
    }
}
