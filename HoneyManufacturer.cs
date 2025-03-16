using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    internal class HoneyManufacturer : Bee
    {
        public HoneyManufacturer() : base("Honey Manufacturer")
        {
        }
        public const float NECTAR_COLLECTED_PER_SHIFT = 33.15f;
        public override float CostPerShift
        {
            get
            {
                return 1.95f;
            }
        }

        protected override void DoJob()
        {
            //HoneyVault.StoreNectar(NECTAR_COLLECTED_PER_SHIFT);
        }
    }
}
