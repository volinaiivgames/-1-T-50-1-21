using System;
using System.Collections.Generic;
using System.Text;

namespace practic4
{
    class Pages
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Pages(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            Date = date;
        }
    }
}
