﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    class NectarCollector : Bee
    {
        public NectarCollector() : base("Nectar Collector")
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
            HoneyVault.CollecNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
