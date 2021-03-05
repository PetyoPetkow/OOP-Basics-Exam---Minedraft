namespace Minedraft
{
    using System;

    using HarvestersAndProviders;
    using HarvestersAndProviders.Harvesters;
    using HarvestersAndProviders.Providers;

    public class StartUp
    {
        static void Main()
        {
            HammerHarvester har = new HammerHarvester("asd", -1, 10.2);
            Console.WriteLine(har.OreOutput.ToString());
            Console.WriteLine(har.EnergyRequirement.ToString());

            SonicHarvester son = new SonicHarvester("aa", 2.2, 10.2, 2);
            Console.WriteLine(son.EnergyRequirement.ToString());
        }
    }
}
