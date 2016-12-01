using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace YamlConfigurationProvider
{
    public class YamlConfigurationProvider : FileConfigurationProvider
    {
        public YamlConfigurationProvider(YamlConfigurationSource source) : base(source) { }

        public override void Load(Stream stream)
        {
            

            //Data = parser.Parse(stream);
        }
    }
}
