using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering
{
    public class ShieldReinforcementDecorator : IDefenceObject
    {
        private readonly IDefenceObject _defenceObject;
        public ShieldReinforcementDecorator(IDefenceObject defenceObject)
        {
            _defenceObject = defenceObject;
        }

        public string Name
        {
            get { return _defenceObject.Name; }
            set { _defenceObject.Name = Name; }
        }

        public int NegateDamage
        {
            get { return _defenceObject.NegateDamage * 2; }
            set { _defenceObject.NegateDamage = NegateDamage; }
        }      
        
        public Position Position
        {
            get { return _defenceObject.Position; }
            set { _defenceObject.Position = Position; }
        }


    }

    }
}
