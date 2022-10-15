﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV5
{
    class Product:IShipable
    {
        private double price;
        private string description;
        private double weight; //in kilos?
        public Product(string description, double price,double weight)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return this.price; } }

        public double Weight { get { return this.weight;} }
        public string Description(int depth = 0)
        {
            return 
                (new string(' ', depth) + this.description +" "+ this.price+ " kn " + this.weight+ "grams");
        }
    }
}
