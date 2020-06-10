using System;

namespace Exam_3_2.Model
{
    public class GoodsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public DateTimeOffset ExpiredDate { get; set; }
        public DateTimeOffset CreationDate { get; set; }
        public int price { get; set; }
        public int priceOfSell { get; set; }
        public int ShopID { get; set; }
    }
}
