using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Order
    {
        private int _id;
        private DateTime _date;
        private string _items;
        private int _count;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Items 
        {
            get { return _items; }
            set { _items = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public Order(int id, DateTime date, string items, int count)
        {
            this._id = id;
            this._date = date;
            this._items = items;
            this._count = count;
        }
        public Order()
        {

        }
        public void addItems()
        {

        }
    }
}
