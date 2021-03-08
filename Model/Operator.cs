using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragDrop.Model
{
    public class Operator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string[] Products { get; set; }
        public int Open { get; set; }
        public int Capicity { get; set; }
    }
}
