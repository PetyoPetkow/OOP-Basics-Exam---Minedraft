namespace Minedraft.HarvestersAndProviders.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SolarProvider:Provider
    {
        public SolarProvider(string id, double energyOutput)
            :base(id,energyOutput)
        {

        }
        public override string ToString()
        {
            return $"Solar Provider - {Id} \n" + $"Energy Output: {EnergyOutput} ";
        }

    }
}
