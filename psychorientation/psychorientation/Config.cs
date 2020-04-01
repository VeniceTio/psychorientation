using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace psychorientation
{
    class Config
    {
        private static Config instance;

        public double coeffEffortOral;
        public double coeffCompetenceOral;

        public double coeffCompetenceEcrit;
        public double coeffEffortEcrit;

        public static Config getInstance()
        {
            if (Config.instance == null)
            {

                Config.instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
                Console.WriteLine(Config.instance.coeffEffortOral);
                return Config.instance;
            }
            else
            {
                return Config.instance;
            }
        }

        public double getCoeffEffortOral()
        {
            return this.coeffEffortOral;
        }

        public double getCoeffCompetenceOral()
        {
            return this.coeffCompetenceOral;
        }

        public double getCoeffCompetenceEcrit()
        {
            return this.coeffCompetenceOral;
        }

        public double getCoeffEffortEcrit()
        {
            return this.coeffEffortEcrit;
        }
    }
}
