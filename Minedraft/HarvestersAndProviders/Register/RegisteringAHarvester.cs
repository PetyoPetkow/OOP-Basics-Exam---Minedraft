//namespace Minedraft.HarvestersAndProviders
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Text;

//    using Minedraft.HarvestersAndProviders.Harvesters;

//    public class HarvesterCreation
//    {
//        public Harvester MakeTheHarvester(List<string> arguments, List<string>harvesters)
//        {
//            string type = arguments[0];
//            if (type == "Sonic")
//            {
//                FilingTheMachinesList(arguments, harvesters);
//                return new SonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4]));
//            }
//            else if (type == "Hammer")
//            {
//                FilingTheMachinesList(arguments, harvesters);
//                return new HammerHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]));
//            }
//            else
//            {
//                return null;
//            }
//        }
//        public static void FilingTheMachinesList(List<string> arguments, List<string> harvesters)
//        {

//            switch (arguments[0])
//            {
//                case "Sonic":
//                    string harvester = new string($"{arguments[0]} Harvester – {arguments[1]} Ore Output: {arguments[2]} Energy Requirement: {arguments[3]}");
//                    harvesters.Add(harvester);
//                    break;
//                case "Hammer":
//                    harvester = new string($"{arguments[0]} Harvester – {arguments[1]} Ore Outpt: {arguments[2]} Energy Requirement: {arguments[3]}");
//                    harvesters.Add(harvester);
//                    break;
//            }
//        }

//    }
//}
