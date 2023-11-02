using System;


namespace do_an.Model
{
    class TempProduct
    {
        private string _id;
        private string _name;
        private string _image;
        private string _catalog;
        private string _supplier;
        private string _amount;
        private string _price;
        private string _status;
        private DateTime _createDate;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Image { get => _image; set => _image = value; }
        public string Catalog { get => _catalog; set => _catalog = value; }
        public string Supplier { get => _supplier; set => _supplier = value; }
        public string Amount { get => _amount; set => _amount = value; }
        public string Price { get => _price; set => _price = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
    }
}
