using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets
{
    public class Catalog
    {
        private string _product;
        private string _category;
        private double _price;
        private bool _hasdiscount;
        public string Product 
        {
            get
            {
                return _product;
            }
        }
        public string Category 
        {
            get
            {
                return _category;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public bool HasDiscount
        {
            get
            {
                return _hasdiscount;
            }
        }

        public Catalog(string product, string category, int price)
        {
            _product = product;
            _category = category;
            _price = price;
            _hasdiscount = false;
        }

        public void Categories(string categories)
        {
            var categoriesAvailable = categories;
            if (categoriesAvailable == "beverages" || categoriesAvailable == "grocery" || categoriesAvailable == "hygiene")
                _category = categoriesAvailable;
            else
                Console.Write($"Category not available. ");
        }
        public void Discount()
        {
            _hasdiscount = true;
        }
        public void NoDiscount()
        {
            _hasdiscount = false;
        }


    }

}
