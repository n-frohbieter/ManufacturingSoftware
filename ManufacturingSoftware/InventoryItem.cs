using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingSoftware
{
    public class InventoryItem
    {
        public int IdNumber { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int QuantityInStock { get; private set; }
        public decimal PricePerUnit { get; private set; }
        public string Supplier { get; private set; }
        public Location Location { get; private set; }


        public InventoryItem(int idNumber, string name, string description, int quantityInStock,
            decimal pricePerUnit, string supplier, Location location)
        {
            IdNumber = idNumber;
            Name = name;
            Description = description;
            QuantityInStock = quantityInStock;
            PricePerUnit = pricePerUnit;
            Supplier = supplier;
            Location = location;
        }

        public bool IncreaseStock(int amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            QuantityInStock += amount;
            return true;
        }

        public bool DecreaseStock(int amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (amount > QuantityInStock)
            {
                return false;
            }

            QuantityInStock -= amount;
            return true;
        }

        public bool UpdatePricePerUnit(decimal cost)
        {
            if (cost <= 0)
            {
                return false;
            }

            PricePerUnit = cost;
            return true;
        }

        public bool ChangeSupplier(string supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier))
            {
                return false;
            }

            Supplier = supplier;
            return true;
        }

        public bool ChangeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            Name = name;
            return true;
        }

        public bool ChangeDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                return false;
            }

            Description = description;
            return true;
        }

       
        public bool ChangeLocation(string aisle, string bay, string shelf)
        {
            if (!Location.IsValidLocation(aisle, bay, shelf))
            {
                return false;
            }

            Location.ChangeAisle(aisle);
            Location.ChangeBay(bay);
            Location.ChangeShelf(shelf);
            return true;
        }

        public decimal GetItemValue()
        {
            return PricePerUnit * QuantityInStock;
        }
    }
}
