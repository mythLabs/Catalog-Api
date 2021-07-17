using Catalog_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog_Api.Repository
{
    public class InMemItemsRepository : IItemsRepository
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

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(x => x.Id == item.Id);
            items[index] = item;
        }
    }
}
