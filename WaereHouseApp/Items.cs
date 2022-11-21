using System;
namespace WaereHouseApp
{
    public class Items
    {
        private string _sku;
        private string _name;
        private int _quantity;
        private string _company;
        private string _location;

        public Items(string sku, string name, int quantity, string company, string location)
        {
            _sku = sku;
            _name = name;
            _quantity = quantity;
            _company = company;
            _location = location;
        }
    }
}

