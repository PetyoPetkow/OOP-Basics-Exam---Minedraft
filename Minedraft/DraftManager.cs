namespace Minedraft
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Minedraft.HarvestersAndProviders.Harvesters;

    public class DraftManager
    {
        static string RegisterHarvester(List<string> arguments)
        {
            return $"Successfully registered {arguments[1]} Harvester {arguments[2]}";
        }
        //string RegisterProvider(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //public static string Day()
        //{
        //    return "a day has passed";
        //}
        //string Mode(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string Check(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string ShutDown()
        //{
        //TODO: Add some logic here …
        //}

        //public static void RegisterHarvester(List<string> arguments)
        //{
        //    string[] arg=arguments.ToArray();

        //    if (arg[0] == "Sonic")
        //    {
        //        SonicHarvester a = new SonicHarvester(arg[1].ToString(), double.Parse(arg[2]), double.Parse(arg[3]), int.Parse(arg[4]));
        //        Console.WriteLine($"Successfully registered Sonic Harvester {arg[1]}");
        //    }
        //    else if (arg[0]=="Hammer")
        //    {
        //        HammerHarvester a = new HammerHarvester(arg[1].ToString(), double.Parse(arg[2]), double.Parse(arg[3]));
        //        Console.WriteLine($"Successfully registered Sonic Harvester {arg[1]}");
        //    }
        //}
        //string RegisterProvider(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string Day()
        //{
        //    //TODO: Add some logic here …
        //}
        //string Mode(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string Check(List<string> arguments)
        //{
        //    //TODO: Add some logic here …
        //}
        //string ShutDown()
        //{
        //    //TODO: Add some logic here …
        //}

    }
}
