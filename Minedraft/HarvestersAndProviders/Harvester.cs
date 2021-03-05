namespace Minedraft.HarvestersAndProviders
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Harvester
    {
        private string id;
        private double oreOutput;
        private double energyRequirement;

        public Harvester(string id)
        {
            this.Id = id;
        }
        public Harvester(string id,double oreOutput,double energyRequirement)
        {
            this.Id = id;
            this.OreOutput = oreOutput;
            this.EnergyRequirement = energyRequirement;
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
                if (value < 0)
                {
                    throw new ArgumentException(message: "Energy requirement can't be a negative value!");
                }
                else if (value > 20000)
                {
                    throw new ArgumentException(message: "Energy requirement can't be greater than 20 000!");
                }

                this.energyRequirement= value;
            }
        }
    }
}
