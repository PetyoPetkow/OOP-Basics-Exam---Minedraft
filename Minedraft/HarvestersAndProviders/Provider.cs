namespace Minedraft.HarvestersAndProviders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Provider
    {
        private string id;
        private double energyOutput;

        public Provider(string id,double energyOutput)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public double EnergyOutput 
        {
            get
            {
                return this.energyOutput;
            }
            set
            {
                if (value<1 || value>10000)
                {
                    throw new ArgumentException(message: "Energy output is not in the valid range of values!");
                }
                this.energyOutput = value;
            }
        }

    }
}
