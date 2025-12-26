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

        public bool ChangeAisle(string aisle)
        {
            if (string.IsNullOrWhiteSpace(aisle))
            {
                return false;
            }

            Aisle = aisle;
            return true;
        }

        public bool ChangeBay(string bay)
        {
            if (string.IsNullOrWhiteSpace(bay))
            {
                return false;
            }

            Bay = bay;
            return true;
        }

        public bool ChangeShelf(string shelf)
        {
            if (string.IsNullOrWhiteSpace(shelf))
            {
                return false;
            }

            Shelf = shelf;
            return true;
        }
    }
}
