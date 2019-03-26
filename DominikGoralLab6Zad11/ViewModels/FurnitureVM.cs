using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DominikGoralLab6Zad11.ViewModels
{
    public class FurnitureVM
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }

        public FurnitureVM(string name, string manufacturer, string type, int price, string photo)
        {
            Name = name;
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Photo = photo;
        }
    }
}