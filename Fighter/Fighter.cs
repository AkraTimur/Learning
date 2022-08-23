using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter
{
    internal class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
//https://www.codewars.com/kata/577bd8d4ae2807c64b00045b/train/csharp