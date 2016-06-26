using System.Configuration;

namespace SystemConfiguration.TeamConfiguration.OffensiveRosterConfiguration
{
    /// <summary>
    /// Defines a new type that inherits from <see cref="ConfigurationSection"/>
    /// that can be used in XML configuration files.
    /// </summary>
    public class Offense : ConfigurationSection
    {
        /// <summary>
        /// A <see cref="OffensiveLinePositions"/> deriving from 
        /// <see cref="ConfigurationElement"/> that is required
        /// by <see cref="Offense"/>.
        /// <para />
        /// Note: This element is not automatically checked by the 
        /// <see cref="ConfigurationManager"/>. Instead, validation
        /// is performed in the <see cref="FootballTeam.Init()"/> method
        /// based on <see cref="ConfigurationProperty.IsRequired"/>
        /// for this element.
        /// </summary>
        [ConfigurationProperty("OffensiveLine", IsRequired = true)]
        public OffensiveLinePositions OL
        {
            get { return (OffensiveLinePositions)base["OffensiveLine"]; }
        }

        /// <summary>
        /// A <see cref="QuarterbackPositions"/> deriving from 
        /// <see cref="ConfigurationElement"/> that is required
        /// by <see cref="Offense"/>.
        /// <para />
        /// Note: This element is not automatically checked by the 
        /// <see cref="ConfigurationManager"/>. Instead, validation
        /// is performed in the <see cref="FootballTeam.Init()"/> method
        /// based on <see cref="ConfigurationProperty.IsRequired"/>
        /// for this element.
        /// </summary>
        [ConfigurationProperty("Quarterbacks", IsRequired = true)]
        public QuarterbackPositions Qb
        {
            get { return (QuarterbackPositions)base["Quarterbacks"]; }
        }
    }
}
