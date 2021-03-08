namespace Minedraft
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using HarvestersAndProviders;
    using HarvestersAndProviders.Harvesters;
    using HarvestersAndProviders.Providers;
    
    


    public class StartUp
    {
        static void Main()
        {
            List<SonicHarvester> sonics = new List<SonicHarvester>();
            List<HammerHarvester> hammers = new List<HammerHarvester>();
            List<SolarProvider> solars = new List<SolarProvider>();
            List<PressureProvider> pressures = new List<PressureProvider>();
            double summedEnergyOutput = 0;
            double summedOreOutput = 0;

            var input = Console.ReadLine().Split();

            while (input[0].ToLower()!="shutdown")
            {
                
                if (input[0]=="RegisterHarvester")
                {
                    string type = input[1];
                    string id = input[2];
                    double oreOutput= double.Parse(input[3]);
                    double energyRequirement = double.Parse(input[4]);

                    if (type=="Sonic")
                    {
                        int sonicFactor = int.Parse(input[5]);
                        SonicHarvester sonic = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                        Console.WriteLine(RegisterHarvester(input.ToList()));
                        sonics.Add(sonic);
                    }
                    else if (type == "Hammer")
                    {
                        HammerHarvester hammer = new HammerHarvester(id, oreOutput, energyRequirement);
                        Console.WriteLine(RegisterHarvester(input.ToList()));
                        hammers.Add(hammer);
                    }
                }

                if (input[0] == "RegisterProvider")
                {
                    string type = input[1];
                    string id = input[2];
                    double energyOutput = double.Parse(input[3]);

                    if (type == "Solar")
                    {
                        SolarProvider solar = new SolarProvider(id, energyOutput);
                        Console.WriteLine(RegisterProvider(input.ToList()));
                        solars.Add(solar);
                    }
                    else if (type == "Pressure")
                    {
                        PressureProvider pressure = new PressureProvider(id, energyOutput);
                        Console.WriteLine(RegisterProvider(input.ToList()));
                        pressures.Add(pressure);
                    }
                }

                if (input[0]=="Day")
                {
                    double energyReq = 0;

                    foreach (var item in sonics)
                    {
                        energyReq += item.EnergyRequirement;
                    }
                    foreach (var item in hammers)
                    {
                        energyReq += item.EnergyRequirement;
                    }

                    foreach (var item in solars)
                    {
                        summedEnergyOutput += item.EnergyOutput;
                    }
                    foreach (var item in pressures)
                    {
                        summedEnergyOutput += item.EnergyOutput;
                    }

                    if (summedEnergyOutput >= energyReq)
                    {
                        foreach (var item in sonics)
                        {
                            summedOreOutput += item.OreOutput;
                            summedEnergyOutput -= item.EnergyRequirement;
                        }
                        foreach (var item in hammers)
                        {
                            summedOreOutput += item.OreOutput;
                            summedEnergyOutput -= item.EnergyRequirement;
                        }
                    }
                    
                    
                    Console.WriteLine("A hay has passed");
                }

                

                //if (input[0]=="Check")
                //{
                //    string identity = Console.ReadLine();
                //    string currentId = hammers
                //        where id = identity
                //        select id;

                //    foreach (var item in hammers
                //         where id==identity)
                //    {

                //    }
                //    Console.WriteLine(hammers.);
                //}


                //if (input[0]=="")
                //{

                //}







                input = Console.ReadLine().Split();
                
            }

            foreach (var item in solars)
            {
                Console.WriteLine($"{item.Id} {item.EnergyOutput}");
            }
            foreach (var item in pressures)
            {
                Console.WriteLine($"{item.Id}, {item.EnergyOutput}");
            }
            foreach (var item in sonics)
            {
                Console.WriteLine($"{item.Id}, {item.OreOutput}");
            }
            foreach (var item in hammers)
            {
                Console.WriteLine($"{item.Id}, {item.OreOutput}");
            }

            Console.WriteLine();
            Console.WriteLine(summedEnergyOutput);
            Console.WriteLine(summedOreOutput);

            //HammerHarvester har = new HammerHarvester("asd", 2, 10.2);
            //Console.WriteLine(har.OreOutput.ToString());
            //Console.WriteLine(har.EnergyRequirement.ToString());

            //SonicHarvester son = new SonicHarvester("aa", 2.2, 10.2, 2);
            //Console.WriteLine(son.EnergyRequirement.ToString());
        }
        static string RegisterHarvester(List<string> arguments)
        {
            return $"Successfully registered {arguments[1]} Harvester {arguments[2]}";
        }
        static string RegisterProvider(List<string> arguments)
        {
            return $"Successfully registered {arguments[1]} Provider {arguments[2]}";
        }
        static string Day()
        {
            return "A day has passed.";
        }
    }
}
