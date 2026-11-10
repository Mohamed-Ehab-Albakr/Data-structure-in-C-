using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStructures
{
    public  class MyArrayList<T>
    {
        #region feilds
        // phase 1 --> Basic operations 
        T[] Items;
        int CurrentIndex;
        int Count { set; get; }
        const int Capacity = 4;
        #endregion
        // default constractour <Size not passed as para > "default array size --> 4 "
        #region constractour
        public MyArrayList()
        {
            Items = new T[Capacity];
            Count = 0;
            CurrentIndex = 0;
        }
        public
            MyArrayList(int init_size)
        {
            Items = new T[init_size];
            Count = 0;
            CurrentIndex = 0;
        }
        #endregion
        // Indexers creation
        #region indexer
        public T this[int index]
        {
            // assign a vlaue "must be in the valid range of indexes "
            set
            {
                if (index >= 0 && index < Count)
                {
                    Items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            //  return the value at specific index "must be in the valid range "
            get
            {
                if (index >= 0 && index < Count)
                {
                    return Items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }


        }

        #endregion
        // 







    }
}
