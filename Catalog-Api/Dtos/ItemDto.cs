using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog_Api.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}
