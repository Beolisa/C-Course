using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERION_RATIO = 0.19f;
        public const float LOW_LEVEL_WARNING = 10f;
        private static float honey = 25f;
        private static float nectar = 100f;

        public static void CollecNectar(float amount)
        {
            nectar += amount;
        }

        public static void ConvertNectarToHoney(float amount)
        {
            if (nectar >= amount)
            {
                nectar -= amount;
                honey += amount * NECTAR_CONVERION_RATIO;
            }
        }

        public static bool ConsumeHoney(float amount)
        {
            //Every work shift honey will be consumed by the amount of bees you have
            return false;
        }

        public static string StatusReport
        {
            get
            {
                string status = $"{honey: 0.0} units of honey\n" + $"{nectar: 0.0} units of nectar\n";
                string warning = "";

                if (honey < LOW_LEVEL_WARNING)
                {
                    warning += "\nLOW HONEY - ADD A MANUFACTURER\n";
                }
                if (nectar < LOW_LEVEL_WARNING)
                {
                    warning += "\nLOW NECTAR - ADD A NECTAR COLLECTOR\n";
                }

                return status + warning;
            }
        }
    }
}
