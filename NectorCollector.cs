using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    class NectorCollector : Bee
    {
        public NectorCollector() : base("Nector Collector")
        {
        }

        public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;
        public override float CostPerShift
        {
            get
            {
                return 1.95f;
            }
        }

        protected override void DoJob()
        {
            Console.WriteLine($"{Job}: Nector Collector...");
            HoneyVault.CollecNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
