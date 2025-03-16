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
        private int unassignedWorkers = 0;

        public void AssignBee(string job)
        {
            if (unassignedWorkers > 0)
            {
                Console.WriteLine($"Queen Assigning bee to job: {job}");
                unassignedWorkers--;
                UpdateStatusReport();
            }
            else
            {
                Console.WriteLine("No unassigned workers available.");
            }
        }

        public string StatusReport
        {
            get; private set;
            //{
            //    string report = "Vault report:\n";
            //    report += $"Eggs: {eggs:F2}\n";
            //    report += $"Unassigned workers: {unassignedWorkers:F2}\n";
            //    report += $"Workers:\n";
            //    foreach (Bee worker in workers)
            //    {
            //        report += $"  {worker.Job}: {worker.Status}\n";
            //    }
            //    return report;
            //}
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
            //HoneyVault.CollecNectar(EGGS_PER_SHIFT);
        }

        private void AddWorker(Bee worker)
        {
            //workers.Add(worker);
        }

        public void CareForEggs(float eggsToConvert)
        {

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
