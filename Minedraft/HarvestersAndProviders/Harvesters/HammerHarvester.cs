namespace Minedraft.HarvestersAndProviders.Harvesters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HammerHarvester:Harvester
    {
        public HammerHarvester(string id, double oreOutput, double energyRequirement)
            : base(id,oreOutput,energyRequirement)
        {
            base.OreOutput = oreOutput+(2*oreOutput);
            base.EnergyRequirement = 2*energyRequirement;
        }
        public override string ToString()
        {
            return $"Hammer Harvester - {Id}\n" + $"Ore Output: {OreOutput} ";
        }
    }
}
