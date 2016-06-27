using System.Configuration;

namespace SystemConfiguration.TeamConfiguration.OffensiveRosterConfiguration
{
    /// <summary>
    /// Defines a new type that inherits from <see cref="ConfigurationElement"/>
    /// that can be used as node inside of a <see cref="ConfigurationSection"/>.
    /// This element contains a number of required and optional attributes that
    /// correspond to a football team quarterback roster.
    /// </summary>
    public class QuarterbackPositions : ConfigurationElement
    {
        /// <summary>
        /// A string attribute providing an identifier for build
        /// transforms.
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Quarterback position.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="QuarterbackPositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("Starter", IsRequired = true)]
        public string Starter
        {
            get { return (string)base["Starter"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting SecondString position on the Quarterback roster.
        /// <para />
        /// This attribute is not required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to false. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="QuarterbackPositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("SecondString", IsRequired = false)]
        public string SecondString
        {
            get { return (string)base["SecondString"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting ThirdString position on the Quarterback roster.
        /// <para />
        /// This attribute is not required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to false. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="QuarterbackPositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("ThirdString", IsRequired = false)]
        public string ThirdString
        {
            get { return (string)base["ThirdString"]; }
        }
    }
}
