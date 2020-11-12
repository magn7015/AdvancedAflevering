using AdvancedAflevering.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdvancedAflevering
{
    public class Character : ICharacter
    {
        public bool IsDead { get; }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Damage { get; set; }
        public int BaseDamage { get; set; }
        public Position Position { get; set; }

        public List<IAttackObject> AttackObjects { get; set; }
        public List<IDefenceObject> DefenceObjects { get; set; }


        public Character(string name, int hitpoints, int damage, Position position)
        {
            Name = name;
            HitPoints = hitpoints;
            Damage = damage;
            Position = position;
        }

        public virtual int Attack()
        {           
            foreach (IAttackObject attackobject in AttackObjects)
            {
                BaseDamage += attackobject.Damage - BaseDamage;
            }            
            return BaseDamage;
        }

        public virtual int ReceiveAttack(int damageTaken)
        {
            foreach (IDefenceObject defenceobject in DefenceObjects)
            {
                damageTaken -= defenceobject.NegateDamage;
            }
            if (HitPoints <= 0)
            {
               IsDead = true;
                Console.WriteLine(Name + "Has died");
            }
            return HitPoints -= damageTaken;
        }
    }
}
