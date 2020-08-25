using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public ICollection<Child> Childs { get; set; }

    }
}
