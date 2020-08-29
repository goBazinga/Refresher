using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace RefresherConsole
{    

    public class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {

            XDocument doc = XDocument.Parse(xml);
            var folders = doc.Descendants("folder");

            var query = from f in folders
                        where f.Attribute("name").Value.StartsWith(startingLetter.ToString())
                        select f.Attribute("name").Value;

            return query;


            //throw new NotImplementedException("Waiting to be implemented.");
        }

        
    }
}
