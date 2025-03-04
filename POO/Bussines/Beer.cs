﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Bussines
{
    public class Beer : Drink , ISalable
    {

        private const string Category = "Cerveza";

        private decimal _alcohol;
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal Alcohol
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }

        public string SAlcohol
        {
            get
            {
                return _alcohol.ToString();
            }
        }

        public Beer(string name, decimal price, decimal alcohol, int quantity)
            : base(quantity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }

        public virtual string GetInfo()
        {
            return "Nombre: " + Name + ", Precio: $ " + Price + ", Alcohol: " + Alcohol;
        }

        public string GetInfo(string message)
        {
            return message + " " + GetInfo();
        }

        public string GetInfo(int number)
        {
            return number + ".- " + GetInfo();
        }

        public override string GetCategory()
        {
            return Category;
        }

        public decimal GetPrice()
             => Price;

    }
}
