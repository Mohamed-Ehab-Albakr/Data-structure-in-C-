using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayList
{
    public  class ArrayList<T>
    {
        // phase 1 --> Basic operations 
        T[] Items;
        int CurrentIndex;
        public int Count { set; get; }
         const int Capacity = 4;
        // default constractour <Size not passed as para > "default array size --> 4 "
        public ArrayList()
        {
            Items= new T[Capacity];
            Count = 0;
            CurrentIndex = 0;
        }
        public ArrayList(int init_size)
        {
            Items = new T[init_size];
            Count = 0;
            CurrentIndex = 0;
        }


    }
}
