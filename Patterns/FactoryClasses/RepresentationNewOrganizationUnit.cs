using Patterns.Classes;
using Patterns.FabricClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryClasses
{
    public class RepresentationNewOrganizationUnit : UnitFactory
    {
        public override Novelty CreateNovelty()
        {
            return new New();
        }

        public override Type CreateType()
        {
            return new Representation();
        }
    }
}
