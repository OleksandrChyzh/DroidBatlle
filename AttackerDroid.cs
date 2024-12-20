using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidBatlle
{
    public class AttackerDroid : BaseDroid
    {
        public AttackerDroid(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 30;
            Defense = 10;
        }

        public override void Attack(BaseDroid target)
        {
            Console.WriteLine($"{Name} атакує {target.Name}");
            target.Defend(AttackPower);
        }

        public override void Defend(int damage)
        {
            int reducedDamage = damage - Defense;
            reducedDamage = Math.Max(reducedDamage, 0);
            Health -= reducedDamage;
            Console.WriteLine($"{Name} отримує {reducedDamage} шкоди. Здоров'я: {Health}");
        }
    }

}
