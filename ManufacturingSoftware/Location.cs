using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingSoftware
{
    public class Location
    {
        public string Aisle { get; private set; }
        public string Bay { get; private set; }
        public string Shelf { get; private set; }

        public Location(string aisle, string bay, string shelf)
        {
            Aisle = aisle;
            Bay = bay;
            Shelf = shelf;
        }
    }
}
