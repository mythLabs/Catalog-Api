﻿using Catalog_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog_Api.Repository
{
    public class InMemItemsRepositiry
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Brake Shoe", Price = 105, CreatedDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Fi system", Price = 1050, CreatedDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Clutch Plates", Price = 600, CreatedDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Engine Oil", Price = 1500, CreatedDate = DateTime.UtcNow }
        };  

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
