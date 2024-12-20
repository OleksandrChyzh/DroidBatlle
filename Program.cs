using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidBatlle
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDroid attacker = new AttackerDroid("Attacker 1");
            BaseDroid defender = new DefenderDroid("Defender 1");

            BattleMode.OneOnOne(attacker, defender);
        }
    }

}
