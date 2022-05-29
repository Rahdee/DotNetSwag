using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SwagAssignment1
{
    public class PersonClass1
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Size { get; set; }

        public string TshirtColour { get; set; }

        public bool DateofOrder { get; set; }

        public string ShippingAdress { get; set; }

    }
}
