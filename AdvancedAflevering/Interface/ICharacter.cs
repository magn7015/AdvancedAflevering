using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering.Interface
{
    public interface ICharacter : IWorldObject
    {
        bool IsDead { get; }
        string Name { get; set; }
        int Damage { get; set; }
        int HitPoints { get; set; }

        List<IAttackObject> AttackObjects
        {
            get;
            set;
        }
        List<IDefenceObject> DefenceObjects
        {
            get; 
            set; 
        }



    }
}
