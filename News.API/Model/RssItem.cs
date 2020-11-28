﻿using System;
using System.Xml.Serialization;

namespace News.API.Model
{
    [XmlType(TypeName = "item"), Serializable]
    public class RssItem
    {
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }

        [XmlElement(ElementName = "category")]
        public string Category { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "author")]
        public string Author { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public string PublicationDate { get; set; }
    }
}
