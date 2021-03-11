namespace Minedraft.HarvestersAndProviders.Harvesters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SonicHarvester:Harvester
    {
        private int sonicFactor;

        public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
            : base(id, oreOutput, energyRequirement)
        {
            this.SonicFactor = sonicFactor;
            this.EnergyRequirement = energyRequirement/this.sonicFactor;
        }

        public int SonicFactor 
        {
            get
            {
                return this.sonicFactor;
            }
            set
            {
                if (value<0 || value>10)
                {
                    throw new ArgumentException (message: "Sonic factor must be a value between 1 and 10!");
                }
                else
                {
                    this.sonicFactor = value;
                }
            }

        }
        public override string ToString()
        {
            return $"Sonic Harvester - {Id} \n" + $"Ore Output: {OreOutput} ";
        }
    }
}
