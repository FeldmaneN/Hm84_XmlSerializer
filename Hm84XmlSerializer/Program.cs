using System.Text;
using System;
using System.Xml.Linq;

namespace Hm84XmlSerializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Note myNote = new Note();

            myNote.To = "Tove";
            myNote.From = "Jani";
            myNote.Heading = "Reminder";
            myNote.Body = "Don't forget me this weekend!";

            XmlHelper.Save(myNote);

            var loadedNote = XmlHelper.Load();
        }
    }
}