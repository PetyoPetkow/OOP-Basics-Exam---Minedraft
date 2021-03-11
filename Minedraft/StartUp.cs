namespace Minedraft
{
    using System;
    using System.Collections.Generic;

    using HarvestersAndProviders.Harvesters;
    using HarvestersAndProviders.Providers;

    public class StartUp
    {
        static void Main()
        {
            string mode = "Full";
            List<SonicHarvester> sonics = new List<SonicHarvester>();
            List<HammerHarvester> hammers = new List<HammerHarvester>();

            List<SolarProvider> solars = new List<SolarProvider>();
            List<PressureProvider> pressures = new List<PressureProvider>();

            List<string> machines = new List<string>();

            double summedEnergyOutput = 0;
            double summedOreOutput = 0;

            var input = Console.ReadLine().Split();

            while (input[0].ToLower() != "shutdown")
            {

                switch (input[0])
                {
                    case "RegisterHarvester":
                        Console.WriteLine(RegisterHarvester(input, sonics, hammers, machines));
                        break;

                    case "RegisterProvider":
                        Console.WriteLine(RegisterProvider(input, solars, pressures, machines));
                        break;

                    case "Day":
                        Console.WriteLine("==============================================================");
                        Console.WriteLine(Day(solars, pressures, hammers, sonics, ref summedEnergyOutput, ref summedOreOutput, mode));
                        Console.WriteLine("==============================================================");
                        break;

                    case "Check":
                        Console.WriteLine(Check(sonics, hammers, solars, pressures, input));
                        break;

                    case "Mode":
                        Console.WriteLine(Mode(input, mode));
                        break;

                }
                input = Console.ReadLine().Split();
            }

            Console.WriteLine();
            Console.WriteLine(summedEnergyOutput);
            Console.WriteLine(summedOreOutput);

        }
        static string RegisterHarvester(string[] arguments, List<SonicHarvester> sonics, List<HammerHarvester> hammers, List<string> machines)
        {
            string type = arguments[1];
            string id = arguments[2];
            double oreOutput = double.Parse(arguments[3]);
            double energyRequirement = double.Parse(arguments[4]);

            if (type == "Sonic")
            {
                int sonicFactor = int.Parse(arguments[5]);
                SonicHarvester sonic = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                sonics.Add(sonic);
                machines.Add($"{sonic.Id} {sonic.OreOutput} {sonic.EnergyRequirement} {sonic.SonicFactor}");
            }
            else if (type == "Hammer")
            {
                HammerHarvester hammer = new HammerHarvester(id, oreOutput, energyRequirement);
                hammers.Add(hammer);
                machines.Add($"{hammer.Id} {hammer.OreOutput} {hammer.EnergyRequirement}");
            }
            return $"Successfully registered {arguments[1]} Harvester {arguments[2]}";
        }

        static string RegisterProvider(string[] arguments, List<SolarProvider> solars, List<PressureProvider> pressures, List<string> machines)
        {
            string type = arguments[1];
            string id = arguments[2];
            double energyOutput = double.Parse(arguments[3]);

            if (type == "Solar")
            {
                SolarProvider solar = new SolarProvider(id, energyOutput);
                solars.Add(solar);
                machines.Add($"{solar.Id} {solar.EnergyOutput}");
            }
            else if (type == "Pressure")
            {
                PressureProvider pressure = new PressureProvider(id, energyOutput);
                pressures.Add(pressure);
                machines.Add($"{pressure.Id} {pressure.EnergyOutput}");
            }
            return $"Successfully registered {arguments[1]} Provider {arguments[2]}";
        }

        static string Check(List<SonicHarvester> sonics, List<HammerHarvester> hammers, List<SolarProvider> solars, List<PressureProvider> pressures, string[] input)
        {
            foreach (var hammer in hammers)
            {
                if (input[1] == hammer.Id)
                {
                    return hammer.ToString();
                }
            }
            foreach (var hammer in sonics)
            {
                if (input[1] == hammer.Id)
                {
                    return hammer.ToString();
                }
            }
            foreach (var hammer in pressures)
            {
                if (input[1] == hammer.Id)
                {
                    return hammer.ToString();
                }
            }
            foreach (var hammer in solars)
            {
                if (input[1] == hammer.Id)
                {
                    return hammer.ToString();
                }
            }
            return null;
        }

        static string Day(List<SolarProvider> solars, List<PressureProvider> pressures, List<HammerHarvester> hammers, List<SonicHarvester> sonics, ref double summedEnergyOutput, ref double summedOreOutput, string mode)
        {
            double energyReq = 0;
            double oreMinedForTheDay = 0;
            double energyProvidedForTheDay = 0;
            foreach (var item in solars)
            {
                summedEnergyOutput += item.EnergyOutput;
                energyProvidedForTheDay += item.EnergyOutput;
            }
            foreach (var item in pressures)
            {
                summedEnergyOutput += item.EnergyOutput;
                energyProvidedForTheDay += item.EnergyOutput;
            }

            if (mode == "Full")
            {
                foreach (var item in sonics)
                {
                    energyReq += item.EnergyRequirement;
                }
                foreach (var item in hammers)
                {
                    energyReq += item.EnergyRequirement;
                }

                if (summedEnergyOutput >= energyReq)
                {
                    foreach (var item in sonics)
                    {
                        summedOreOutput += oreMinedForTheDay = item.OreOutput;
                        summedEnergyOutput -= item.EnergyRequirement;
                    }
                    foreach (var item in hammers)
                    {
                        summedOreOutput += oreMinedForTheDay = item.OreOutput;
                        summedEnergyOutput -= item.EnergyRequirement;
                    }
                }
            }
            else if (mode == "Half")
            {
                foreach (var item in sonics)
                {
                    energyReq += item.EnergyRequirement * 0.6;
                }
                foreach (var item in hammers)
                {
                    energyReq += item.EnergyRequirement * 0.6;
                }

                if (summedEnergyOutput >= energyReq)
                {
                    foreach (var item in sonics)
                    {
                        summedOreOutput += oreMinedForTheDay = item.OreOutput * 0.5;
                        summedEnergyOutput -= item.EnergyRequirement * 0.6;
                    }
                    foreach (var item in hammers)
                    {
                        summedOreOutput += oreMinedForTheDay = item.OreOutput * 0.5;
                        summedEnergyOutput -= item.EnergyRequirement * 0.6;
                    }
                }
            }
            else if (mode == "Energy")
            { }

            return $"Ore mined for the day : {oreMinedForTheDay}\n" + $"Energy provided for the day : {energyProvidedForTheDay}";

        }

        static string Mode(string[] input, string mode)
        {
            if (input[1] == "Half")
            {
                mode = "Half";
            }
            else if (input[1] == "Full")
            {
                mode = "Full";
            }
            else if (input[1] == "Energy")
            {
                mode = "Energy";
            }
            return $"Mode has been set to {mode}.";
        }
    }
}