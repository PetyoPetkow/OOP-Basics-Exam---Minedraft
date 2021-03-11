//namespace Minedraft.HarvestersAndProviders
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Text;

//    using Minedraft.HarvestersAndProviders.Providers;

//    public class ProviderCreation
//    {
//        public static Provider MakeTheProvider(List<string> arguments)
//        {
//            string type = arguments[0];
//            if (type == "Solar")
//            {
//                return new SolarProvider(arguments[1], double.Parse(arguments[2]));
//            }
//            else if (type == "Pressure")
//            {
//                return new PressureProvider(arguments[1], double.Parse(arguments[2]));
//            }
//            else
//            {
//                return null;
//            }

//        }
//    }
//}
