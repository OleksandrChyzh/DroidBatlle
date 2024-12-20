using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidBatlle
{
    public class HealthStealerDroid : AttackerDroid
    {
        public HealthStealerDroid(string name, int health, int attackPower)
            : base(name)
        {
        }

        public override void Attack(BaseDroid enemy)
        {
            if (enemy == null || enemy.Health <= 0)
            {
                Console.WriteLine($"{Name} не може атакувати!");
                return;
            }

            int stolenHealth = Math.Min(AttackPower, enemy.Health);
            enemy.Health -= stolenHealth;
            Health += stolenHealth;

            Console.WriteLine($"{Name} краде {stolenHealth} здоров'я у {enemy.Name}. Його здоров'я тепер: {Health}, а {enemy.Name} має: {enemy.Health}.");
        }
    }

}