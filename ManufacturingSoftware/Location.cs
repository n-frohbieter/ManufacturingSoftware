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

        public void ChangeAisle(string aisle)
        {       
            Aisle = aisle;
        }

        public void ChangeBay(string bay)
        {
            Bay = bay;
        }

        public void ChangeShelf(string shelf)
        {
            Shelf = shelf;
        }

        public bool IsValidAisle(string aisle)
        {
            return string.IsNullOrWhiteSpace(aisle);
        }

        public bool IsValidBay(string bay)
        {
            return string.IsNullOrWhiteSpace(bay);
        }

        public bool IsValidShelf(string shelf)
        {
            return string.IsNullOrWhiteSpace(shelf);
        }

        public bool IsValidLocation(string aisle, string bay, string shelf)
        {
            return IsValidAisle(aisle) && IsValidBay(bay) && IsValidShelf(shelf);
        }
    }
}
