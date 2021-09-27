using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskRest.Models;

namespace ObligatoriskRest.Manager
{
    public class ItemsManager
    {
        private static int _nextId = 1;
        private static readonly List<Item> Data = new List<Item>
        {
            new Item {Id = _nextId++, Name = "Jeg hedder Mads", Quantity = 12, ItemQuality = 5},
            new Item {Id=_nextId++, Name = "Jeg er 24 år", Quantity = 22, ItemQuality = 9},
            new Item {Id = _nextId++, Name = "Jeg går på Zealand", Quantity = 2, ItemQuality = 3},
            new Item {Id=_nextId++, Name = "som ligger i Roskilde", Quantity = 32, ItemQuality = 4}
        };

        public List<Item> GetAll()
        {
            return new List<Item>(Data);
        }

        public Item GetById(int id)
        {
            return Data.Find(Item => Item.Id == id);
        }

        public Item Add(Item newItem)
        {
            newItem.Id = _nextId++;
            Data.Add(newItem);
            return newItem;
        }

        public Item Delete(int id)
        {
            Item Item = Data.Find(Item1 => Item1.Id == id);
            if (Item == null) return null;
            Data.Remove(Item);
            return Item;
        }

        public Item Update(int id, Item updates)
        {
            Item Item = Data.Find(Item1 => Item1.Id == id);
            if (Item == null) return null;
            Item.Name = updates.Name;
            Item.ItemQuality = updates.ItemQuality;
            Item.Quantity = updates.Quantity;
            return Item;
        }
    }
}
