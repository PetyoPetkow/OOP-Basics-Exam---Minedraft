namespace Minedraft.HarvestersAndProviders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Harvester
    {
       
        private double oreOutput;
        private double energyRequirement;

        protected Harvester(string id)
        {
            this.Id = id;
        }
        protected Harvester(string id,double oreOutput,double energyRequirement)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public string Id { get; set; }
        
        public double OreOutput
        {
            get
            {
                return this.oreOutput;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Ore output can't be a negative value!");
                }

                this.oreOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get
            {
                return this.energyRequirement;
            }
            set
            {
                if (value < 0 || value>20000)
                {
                    throw new ArgumentException (message: "Energy requirement can't be a negative value or greater than 20 000!");
                }

                this.energyRequirement= value;
            }
        }
    }
}
