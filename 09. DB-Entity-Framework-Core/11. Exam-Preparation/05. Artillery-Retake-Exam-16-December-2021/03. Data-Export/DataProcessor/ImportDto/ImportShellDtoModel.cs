﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto
{
    [XmlType("Shell")]
    public class ImportShellDtoModel
    {
        [Required]
        [Range(2, 1680)]
        [XmlElement("ShellWeight")]
        public double ShellWeight { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        [XmlElement("Caliber")]
        public string Caliber { get; set; }
    }
}
