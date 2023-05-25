using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSlot6_CollectionsGenerics
{
    class SortedDictionaryGenericDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> custDict = new Dictionary<int, Customer>();
            custDict[99] = new Customer(99, "H", "P");
            custDict[77] = new Customer(77, "B", "G");
            custDict[55] = new Customer(55, "B", "S");
            custDict[88] = new Customer(88, "B", "P");

            Dictionary<int, Customer>.ValueCollection unsortedValues;
            unsortedValues = custDict.Values;
            foreach (Customer cust in unsortedValues)
                Console.Out.WriteLine("Customer Name: {0}", cust.Name);

            SortedDictionary<int, Customer> sortedDict;
            sortedDict = new SortedDictionary<int, Customer>(custDict);

            SortedDictionary<int, Customer>.ValueCollection sortedValues;
            sortedValues = sortedDict.Values;
            foreach (Customer cust in sortedValues)
            {
                Console.Out.WriteLine("Customer->{0}", cust.Name);
            }

            sortedDict.Remove(88);

            sortedValues = sortedDict.Values;
            foreach (Customer cust in sortedValues)
            {
                Console.Out.WriteLine("Customer->{0}", cust.Name);
            }
        }
    }
    public class Customer : System.IComparable
    {
        private int _id;
        private string _name;
        private string _rating;
        private static SortOrder _order;

        public enum SortOrder
        {
            Ascending = 0,
            Descending = 1
        }
        public Customer(int id, string name) : this(id, name, "Other")
        {
        }
        public Customer(int id, string name, string rating)
        {
            this._id = id;
            this._name = name;
            this._rating = rating;
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }
        public static SortOrder Order
        {
            get { return _order; }
            set { _order = value; }
        }
        public override bool Equals(Object obj)
        {
            bool retVal = false;
            if (obj != null)
            {
                Customer custObj = (Customer)obj;
                if ((custObj.Id == this.Id) &&
                    (custObj.Name.Equals(this.Name) &&
                    (custObj.Rating.Equals(this.Rating))))
                    retVal = true;
            }
            return retVal;
        }
        public override string ToString()
        {
            return this._id + ": " + this._name;
        }

        public int CompareTo(Object obj)
        {
            switch (_order)
            {
                case SortOrder.Ascending:
                    return this.Name.CompareTo(((Customer)obj).Name);
                case SortOrder.Descending:
                    return (((Customer)obj).Name).CompareTo(this.Name);
                default:
                    return this.Name.CompareTo(((Customer)obj).Name);
            }
        }
        int IComparable.CompareTo(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
