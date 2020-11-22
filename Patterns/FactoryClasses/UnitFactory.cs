using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FabricClasses
{
    public abstract class UnitFactory
    {
        public abstract Type CreateType();
        public abstract Novelty CreateNovelty();
    }
}
