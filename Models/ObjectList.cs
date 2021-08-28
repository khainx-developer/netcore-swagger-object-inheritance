using System.Collections.Generic;

namespace NetcoreSwaggerObjectInheritance.Models
{
    public class ObjectList<T>
    {
        public int Total { get; set; }
        public List<T> Items { get; set; }
    }
}