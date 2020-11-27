using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace News.API.Model
{
    [XmlType(TypeName = "channel"), Serializable]
    public class RssChannel
    {
        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "item", Type = typeof(RssItem))]
        public List<RssItem> Items { get; set; }
    }
}
