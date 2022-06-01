using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwagAssignment1
{
    public class OrderedItems
    {
        [PrimaryKey,AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string TshirtSizes { get; set; }

        public string TShirtColor { get; set; }

        public string ShippingAddress { get; set; }

        public int DateofOrder { get; set; }

        public bool Done { get; set; }

        



    }

}
