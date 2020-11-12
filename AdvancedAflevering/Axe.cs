using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering
{
    public class Axe : IAttackObject
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int AttackRange { get; set; }
        public Position Position { get; set; }
        public Axe(string name, int damage, int attackrange, Position position)
        {           
            Name = name;
            Damage = damage;
            AttackRange = attackrange;
            Position = position;
        }

        
    }
}
