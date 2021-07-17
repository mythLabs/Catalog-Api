using Catalog_Api.Entities;
using System;
using System.Collections.Generic;

namespace Catalog_Api.Repository
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}