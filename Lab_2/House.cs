using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Lab_2
{
    [Serializable]
    public class House
    {
        [XmlElement(ElementName = "Length_of_House")]
        public string Length_of_House;
        [XmlElement(ElementName = "Number_of_Rooms")]
        public string Number_of_Rooms;
        [XmlElement(ElementName = "Year")]
        public string Year;
        [XmlElement(ElementName = "Material")]
        public List<string> Material;
        [XmlElement(ElementName = "Flat")]
        public string Flat;
        [XmlElement(ElementName = "rooms")]
        public List<string> rooms;
        public House()
        {

        }
        public House(string Length_of_House, string Number_of_Rooms,string Year, List<string> material, string Flat, List<string> list)
        {
            this.Length_of_House = Length_of_House;
            this.Number_of_Rooms = Number_of_Rooms;
            this.Year = Year;
            this.Material = material;
            this.Flat = Flat;
            this.rooms = list; 
        }
    }
}
