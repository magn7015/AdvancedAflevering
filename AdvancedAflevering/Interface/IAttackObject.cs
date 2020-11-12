using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering.Interface
{
    public interface IAttackObject : IWorldObject
    {
        string Name { get; set; }
        int Damage { get; set; }
        int AttackRange { get; set; }
    }
}
