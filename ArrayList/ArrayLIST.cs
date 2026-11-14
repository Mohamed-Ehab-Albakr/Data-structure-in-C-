using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        private  IEqualityComparer<T> comparer;

        #endregion
        // default constractour <Size not passed as para > "default array size --> 4 "
        #region constractour
        public MyArrayList()
        {
            Items = new T[Capacity];
            Count = 0;
            CurrentIndex = -1;
            comparer = EqualityComparer<T>.Default;
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
                comparer = EqualityComparer<T>.Default;

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
        public MyArrayList(IEqualityComparer<T> compare)// interface  refrence as para 
        {
            Items = new T[Capacity];
            Count = 0;
            CurrentIndex = -1;

            comparer = compare ?? EqualityComparer<T>.Default;
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
        // ------------------------------------------ ADD METHOD-----------------------------------------------------------

        // add o(1) the adedd element is not the last element in the array
        // o(n) if it is the last element "beacause the loop iterate on the size of array n "

        //Adds --> check if index valid ,check if the adding is available in the current array  ,add new element to the list
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
        // -------------------------------------REMOVE METHOD-----------------------------------------------------------
        // check if the index in the valid range 
        // shift arrat items in the left 
        // remove the  last element o(1) , the first element o(n) "loop shifts all elements"
        // remove from middle o(n)
        public void RemoveAt(int index ) 
        {
            if (index >= 0 && index < Count)
            {
              
              // shift all elements <LEFT SHIFT>
                for (int i =index;i<Count-1 ;i++)
                {
                    Items[i] = Items[i + 1];
                }
                Items[CurrentIndex] = default(T);

                Count--;
                CurrentIndex--;
                
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
            
       
        }

        // length method 
        public int Length()
        {
            return Count;
        }
        // -------------------------------indexOf method ------------------------------------------
       

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (comparer.Equals(Items[i], item))
                {
                    // Equlas() impelemented according to the  object or class type 
                    return i;
                }
            }

            return -1;
          }
        // ------------------------------- remove  method ------------------------------------------
        // you pass an item then if the item found in the list it remove it if not throw an exception 
        public void  Remove(T item)
        {

            int index_of_item = IndexOf(item);
            if (index_of_item == -1)// if the item havent foung in the list 
            {
                throw new KeyNotFoundException();
            }
            else
            {
                RemoveAt(index_of_item);
            }

        }
        // ----------------------------------add range method-------------------------------------------------
        public void AddRange(T[] elements)
        {
            int new_size = elements.Length + Count;
            if (new_size> Capacity)
            {
                // resizing the array 
                while (new_size> Capacity)
                {
                    Capacity *= 2;
                }
                T[] temp = Items;
                Items=new T[Capacity];
                for (int i =0;i< Count; i++)
                {
                    Items[i] = temp[i];
                }
                int j = 0;
                for (int i=CurrentIndex+1;i<new_size; i++)
                {
                   
                    Items[i]=elements[j];
                    j++;
                    CurrentIndex++;
                 
                }



            }
            else
            {
                
                int j = 0;
                for (int i = CurrentIndex+1; i <new_size ; i++)
                {

                    Items[i] = elements[j];
                    j++;
                    CurrentIndex++;
               
                }

            }
            Count = new_size;

        }



    }

}

