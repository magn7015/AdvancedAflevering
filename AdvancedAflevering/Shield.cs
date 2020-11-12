using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering
{
   public class Shield : IDefenceObject
    {
        public Position Position { get; set; }
        public string Name { get; set; }
        public int NegateDamage { get; set; }

        public Shield(Position position , string name, int negateamage)
        {
            Position = position;
            Name = name;
            NegateDamage = negateamage;
        }
      
    }
}
