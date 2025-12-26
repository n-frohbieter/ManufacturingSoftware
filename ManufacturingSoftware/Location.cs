using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingSoftware
{
    public class Location
    {
        public string Ailse { get; private set; }
        public string Bay { get; private set; }
        public string Shelf { get; private set; }

        public Location(string ailse, string bay, string shelf)
        {
            Ailse = ailse;
            Bay = bay;
            Shelf = shelf;
        }
    }
}
