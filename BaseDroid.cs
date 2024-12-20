using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidBatlle
{
    public abstract class BaseDroid
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public abstract void Attack(BaseDroid target);
        public abstract void Defend(int damage);
    }

}
