using System;
using System.Collections.Generic;
using System.ComponentModel;
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
         int Capacity = 4;
        #endregion
        // default constractour <Size not passed as para > "default array size --> 4 "
        #region constractour
        public MyArrayList()
        {
            Items = new T[Capacity];
            Count = 0;
            CurrentIndex = -1;
        }
        public
            MyArrayList(int init_size)
        {
            if(init_size >0)
            {
                Capacity = init_size;
                Items = new T[Capacity];
                Count = 0;
                CurrentIndex = -1;

            }
            else
            {
                throw new ArgumentException();
            }
            
        }
        public MyArrayList(MyArrayList<T> m )
        {
            Items =m.Items ;
            CurrentIndex = m.CurrentIndex;
            Count = m.Count;
            Capacity = (m.Capacity);
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
        //Methods

        //Adds a new element to the list
        //If the array is full, it automatically resizes by doubling its capacity
        //copies the old elements into the new array, and then adds the new item
        public void Add(T element)
        {
            Count++;
            CurrentIndex++;
            if (Count > Capacity) {
                // Resizing the array create a  new array withv double size in the same object 
                MyArrayList<T> temp = new MyArrayList<T>(this);
                Capacity *= 2;
                Items=new T[Capacity];


                for (int i = 0; i < (int)(Capacity) / 2; i++) {
                    Items[i] = temp.Items[i];
                }
                // add the element in the created array \
                Items[CurrentIndex] = element;


                


            }
            else {
                Items[CurrentIndex] = element;

            }
                

        }
    }

}

