using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace News.API.Model
{
    [XmlRoot(ElementName = "rss"), Serializable]
    public class Rss
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "channel")]
        public RssChannel Channel { get; set; }
    }
}

