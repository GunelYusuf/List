using System;
namespace Indexer
{
    public class MyList<T>
    {
        public int Number { get; set; }
        public string Name { get; set; }
        private T[] _customers;

        public MyList(int number=10)
        {
            _customers = new T[number];
        }

        #region IndexOf
        public T this[int index]
        {
            get
            {
                try
                {
                    return _customers[index];
                }
                catch (Exception)
                {
                    return _customers[0];
                }

            }
            set
            {
                try
                {
                    _customers[index] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Out of Range");
                }
            }
        }

        #endregion
        #region Count
        public int Count
        {
            get
            {
                int count = 0;
                foreach (var item in _customers)
                {
                    count++;
                    Console.WriteLine(item);
                }
                return count;
            }
        }
        #endregion
        #region Add
        public void Add(T customer)
        {
            T[] arr = new T[_customers.Length + 1];
            int count = 0;
            foreach (var item in _customers)
            {
                arr[count] = item;
                count++;
            }
            arr[count] = customer;
            Console.WriteLine(arr[count]);
        }
        #endregion
        #region AddRange
        public void AddRange(T[] customer)
        {
            T[] arr = new T[customer.Length + _customers.Length];
            int count = 0;
            foreach (var item in _customers)
            {
                arr[count] = item;
                count++;
            }
            foreach (var item in customer)
            {
                arr[count] = item;
                count++;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        public void Clear()
        {
            T[] arr = new T[_customers.Length + 1];
            int count = 0;
            foreach (var item in _customers)
            {
                arr[count] = item;
            }
            Console.WriteLine(arr[count]);
        }


        
        



        




    }
}
