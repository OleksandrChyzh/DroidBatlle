using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidBatlle
{
    public class BattleMode
    {
        public static void OneOnOne(BaseDroid droid1, BaseDroid droid2)
        {
            Console.WriteLine($"Починається бій між {droid1.Name} та {droid2.Name}!");
            while (droid1.Health > 0 && droid2.Health > 0)
            {
                droid1.Attack(droid2);
                if (droid2.Health > 0)
                    droid2.Attack(droid1);
            }

            if (droid1.Health > 0)
                Console.WriteLine($"{droid1.Name} переміг!");
            else
                Console.WriteLine($"{droid2.Name} переміг!");
        }

        public static void TwoOnTwo(BaseDroid[] team1, BaseDroid[] team2)
        {
            Console.WriteLine("Режим 2 на 2 не реалізований поки що.");
        }
    }

}
