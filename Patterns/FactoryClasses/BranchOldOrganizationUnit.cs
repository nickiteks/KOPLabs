﻿using Patterns.Classes;
using Patterns.FabricClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryClasses
{
    public class BranchOldOrganizationUnit : UnitFactory
    {
        public override Novelty CreateNovelty()
        {
            return new Old();
        }

        public override Type CreateType()
        {
            return new Branch();
        }
    }
}
