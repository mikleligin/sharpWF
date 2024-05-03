using System;
using System.Xml.Serialization;

namespace TestTask
{
    [XmlRoot("BOSMeth")]
    public class BOSMeth
    {
        [XmlAttribute("TemplateGUID")]
        public string TemplateGUID { get; set; }

        [XmlElement("Channels")]
        public сhannels Channels { get; set; }
    }

    public class сhannels
    {
        [XmlElement("Channel")]
        public List<channel> channels { get; set; } = new List<channel>();
        //public Channel[] Channel { get; set; }
    }

    public class channel
    {
        [XmlAttribute("UnicNumber")]
        public int UnicNumber { get; set; }

        [XmlAttribute("SignalFileName")]
        public string SignalFileName { get; set; }

        [XmlAttribute("Type")]
        public int Type { get; set; }

        [XmlAttribute("EffectiveFd")]
        public int EffectiveFd { get; set; }
    }
}