﻿namespace Blazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
        public List<SelectKeyValue> Properties { get; set; }
        public bool Show { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
