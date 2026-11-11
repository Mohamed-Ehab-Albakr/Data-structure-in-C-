using System.Collections;

namespace CustomDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // impelementation test and debug 
           MyArrayList<int> List=new MyArrayList<int>();// default capacity "4"
            List.Add(10);// o(1)
            List.Add(20);
            List.Add(30);
            List.Add(40);
            // creating a new arrat "resizing " 
            List.Add(50);// o(n)
            // remove at position 
            List.RemoveAt(3);



        }
    }
}
