﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
    [XmlType("Creator")]
    public class ExportCreatorsDto
    {
        [XmlAttribute("BoardgamesCount")]
        public string BoardgamesCount { get; set; }

        [XmlElement("CreatorName")]
        public string CreatorName { get; set; }

        [XmlArray("Boardgames")]
        public ExportBoardgamesDto[] Boardgames { get; set; }
    }
}
