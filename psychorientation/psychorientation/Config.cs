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

        public static Config GetInstance()
        {
            if (Config.instance == null)
            {

                Config.instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
                return Config.instance;
            }
            else
            {
                return Config.instance;
            }
        }

        public double GetCoeffEffortOral()
        {
            return this.coeffEffortOral;
        }

        public double GetCoeffCompetenceOral()
        {
            return this.coeffCompetenceOral;
        }

        public double GetCoeffCompetenceEcrit()
        {
            return this.coeffCompetenceEcrit;
        }

        public double GetCoeffEffortEcrit()
        {
            return this.coeffEffortEcrit;
        }
    }
}
