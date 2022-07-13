using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkUpConstruction.Models
{
    public class BlogTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
