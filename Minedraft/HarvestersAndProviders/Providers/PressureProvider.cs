namespace Minedraft.HarvestersAndProviders.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PressureProvider:Provider
    {
        public PressureProvider(string id,double energyOutput)
            :base(id,energyOutput)
        {
            base.EnergyOutput = energyOutput + (energyOutput / 2);
        }
        //public static void OutputEnergy(pressure)
        //{
        //    double energy = 0;
        //    energy += OutputEnergy;
        //}
    }
}
