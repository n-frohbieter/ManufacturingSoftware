using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingSoftware
{
    public class InventoryManager
    {
        Dictionary<int, InventoryItem> itemsInInventory = new Dictionary<int, InventoryItem>();

        public void AddNewItemToInventory(int id, string name, string description, int quantityInStock, 
            decimal pricePerUnit, string supplier, Location location)
        {
            InventoryItem newInventoryItem = new InventoryItem(id, name, description, quantityInStock, 
                pricePerUnit, supplier, location);
            itemsInInventory.Add(id, newInventoryItem);
        }
        
    }

}
