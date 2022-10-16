using System.Data;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Hm84XmlSerializer
{
    internal class XmlHelper
    {
        internal static void Save(Note note)
        {
            XmlSerializer serlzr = new XmlSerializer(typeof(Note));
            using(var writer = new FileStream(@"singlenote.xml", FileMode.Create))
            {
                serlzr.Serialize(writer, note);
            }            
        }
        internal static Note Load()
        {
            XmlSerializer deserlzr = new XmlSerializer(typeof(Note));

            using (var reader = new StreamReader(@"singlenote.xml"))
            {
                var note = deserlzr.Deserialize(reader);
                return (Note)note;
            }
        }
    }
}
