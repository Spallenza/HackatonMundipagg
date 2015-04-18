using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hackaton.Core.Utility {
    public sealed class ConfigurationUtility : IConfigurationUtility {
        public string ConnectionString {
            get { return ConfigurationManager.ConnectionStrings["HackatonConnection"].ConnectionString; }
            
        }
    }
}
