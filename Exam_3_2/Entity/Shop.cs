using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_3_2.Entity
{
    public class Shop
    {
        public int Id { get; set; }
        public virtual ICollection<Goods> Goods { get; set; }
    }
}
