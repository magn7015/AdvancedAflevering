using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering.Interface
{
   public interface IDefenceObject : IWorldObject
    {
        string Name { get; set; }
        int NegateDamage { get; set; }
    }
}
