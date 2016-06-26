using System.Configuration;

namespace SystemConfiguration.TeamConfiguration.OffensiveRosterConfiguration
{
    /// <summary>
    /// Defines a new type that inherits from <see cref="ConfigurationElement"/>
    /// that can be used as node inside of <see cref="ConfigurationSection"/>.
    /// This type contains a number of required and optional attributes that
    /// correspond to a football team offensive line.
    /// </summary>
    public class OffensiveLinePositions : ConfigurationElement
    {
        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Left Tackle position on the Offensive Line.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("LeftTackle", IsRequired = true)]
        public string LeftTackle
        {
            get { return (string)base["LeftTackle"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Left Guard position on the Offensive Line.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("LeftGuard", IsRequired = true)]
        public string LeftGuard
        {
            get { return (string)base["LeftGuard"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Center position on the Offensive Line.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("Center", IsRequired = true)]
        public string Center
        {
            get { return (string)base["Center"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Right Guard position on the Offensive Line.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("RightGuard", IsRequired = true)]
        public string RightGuard
        {
            get { return (string)base["RightGuard"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Right Tackle position on the Offensive Line.
        /// <para />
        /// This attribute is required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to true. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("RightTackle", IsRequired = true)]
        public string RightTackle
        {
            get { return (string)base["RightTackle"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Reserve1 position on the Offensive Line.
        /// <para />
        /// This attribute is not required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to false. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("Reserve1", IsRequired = false)]
        public string Reserve1
        {
            get { return (string)base["Reserve1"]; }
        }

        /// <summary>
        /// A string attribute representing the player assigned to play
        /// starting Reserve2 position on the Offensive Line.
        /// <para />
        /// This attribute is not required because
        /// <see cref="ConfigurationProperty.IsRequired"/> is set
        /// to false. This is automatically verified by the
        /// <see cref="ConfigurationManager"/> when <see cref="OffensiveLinePositions"/>
        /// is being deserialized from XML configuration.
        /// </summary>
        [ConfigurationProperty("Reserve2", IsRequired = false)]
        public string Reserve2
        {
            get { return (string)base["Reserve2"]; }
        }
    }
}
