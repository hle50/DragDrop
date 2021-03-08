using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragDrop.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Job { get; set; }
        public string Type { get; set; }
        public DateTime ArriveDateTime { get; set; }
    }
}
