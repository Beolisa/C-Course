using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM3
{
    internal class Queen : Bee
    {
        public Queen() : base("Queen")
        {
            AssignBee("Nectar Collector");
            AssignBee("Honey Manufacturer");
            AssignBee("Egg Care");
        }

        public const float EGGS_PER_SHIFT = 0.45f;
        public const float HONEY_PER_UNASSIGNED_WORKER = 0.5f;

        private Bee[] workers = new Bee[0];
        private float eggs = 0;
        private float unassignedWorkers = 3;

        public string StatusReport
        {
            get; private set;
        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
            }
            UpdateStatusReport();
        }

        public override float CostPerShift
        {
            get
            {
                return 2.15f;
            }
        }
        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach (Bee worker in workers)
            {
                worker.WorkTheNextShift();
            }

            HoneyVault.ConsumeHoney(HONEY_PER_UNASSIGNED_WORKER * unassignedWorkers);
            UpdateStatusReport();
        }

        private void AddWorker(Bee worker)
        {
            if (unassignedWorkers >= 1)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;   // Add worker to the end of the array
            }
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Vault report: {HoneyVault.StatusReport}\n" +
                $"Egg count: {eggs:0.0}\n" +
                $"Unassigned workers: {unassignedWorkers}\n" +
                $"{WorkerStatus("Nectar Collector")}:\n" +
                $"{WorkerStatus("Honey Manufacturer")}:\n" +
                $"{WorkerStatus("Egg Care")}:\n" +
                $"TOTAL WORKERS: {workers.Length}";
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach (Bee w in workers)
            {
                if (w.Job == job)
                {
                    count++;
                }
            }
            string s = "s";

            if (count == 1)
            {
                s = "";
            }
            return $"{count} {job} bee{s}";
        }
    }
}
