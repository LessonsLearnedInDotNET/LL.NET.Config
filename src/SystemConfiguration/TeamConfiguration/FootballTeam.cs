using System;
using System.Configuration;
using SystemConfiguration.TeamConfiguration.OffensiveRosterConfiguration;

namespace SystemConfiguration.TeamConfiguration
{
    /// <summary>
    /// Singleton class that provides abstraction for the custom <see cref="Offense"/> 
    /// <see cref="ConfigurationSection"/>. If any required configuration is missing
    /// from the configuration file, an exception will be thrown the first time
    /// <see cref="OffensiveRoster"/> is accessed when <see cref="Init()"/> is executed.
    /// </summary>
    public static class FootballTeam
    {
        private static Offense _config;

        /// <summary>
        /// Performs initialization of custom configuration section and validates
        /// any required derived <see cref="ConfigurationElement"/>s have been populated.
        /// </summary>
        private static void Init()
        {
            _config = (Offense)ConfigurationManager.GetSection("Offense");
            if (_config == null)
                throw new ApplicationException("No OffenseConfig section in config");

            // IsRequired field doesn't work on ConfigurationElements, http://stackoverflow.com/a/2492170
            foreach (PropertyInformation propertyInformation in _config.ElementInformation.Properties)
            {
                var complexProperty = propertyInformation.Value as ConfigurationElement;
                if (complexProperty == null)
                    continue;
                if (propertyInformation.IsRequired && !complexProperty.ElementInformation.IsPresent)
                    throw new ApplicationException(string.Format("ConfigProperty: [{0}] is required but not present", propertyInformation.Name));
            }
        }

        /// <summary>
        /// Singleton parameter that initializes configuration on first access.
        /// </summary>
        public static Offense OffensiveRoster
        {
            get
            {
                if (_config == null)
                {
                    Init();
                }
                return _config;
            }
        }
    }
}
