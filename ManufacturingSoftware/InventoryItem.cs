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


        public InventoryItem(int idNumber, string name, string description, int quantityInStock, decimal pricePerUnit, string supplier)
        {
            IdNumber = idNumber;
            Name = name;
            Description = description;
            QuantityInStock = quantityInStock;
            PricePerUnit = pricePerUnit;
            Supplier = supplier;
        }
    }
}
