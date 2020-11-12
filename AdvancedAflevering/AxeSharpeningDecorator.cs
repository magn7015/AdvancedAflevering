using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedAflevering
{
    class AxeSharpeningDecorator : IAttackObject
    {
        private readonly IAttackObject _attackObject;

        public int Damage
        {
            get { return _attackObject.Damage * 2; }
            set { _attackObject.Damage = Damage; }
        }
        public string Name
        {
            get { return _attackObject.Name; }
            set { _attackObject.Name = Name; }
        }
        public Position Position
        {
            get { return _attackObject.Position; }
            set { _attackObject.Position = Position; }
        }
        public int AttackRange
        {
            get { return _attackObject.AttackRange; }
            set { _attackObject.AttackRange = AttackRange; }
        }



    }
}
