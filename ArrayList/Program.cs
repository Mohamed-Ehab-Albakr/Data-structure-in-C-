using ArrayList;
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
            // testing interface impelementation 

            // direct impelementation of interface in class DFN 
            student s=new student();
            MyArrayList<student>studentList= new MyArrayList<student>(s);
            studentList.Add(new student { ssn = 66 });
            studentList.IndexOf(new student { ssn = 66 }); 
            //  in direct impelementation of intterface 
            MyArrayList<person> list_p2= new MyArrayList<person>(new PersonEquality());
            person p3 = new person(); p3.id = 10; p3.name = "ali";

            list_p2.Add(new person { id = 10, name = "ali" });
            list_p2.Add(new person { id = 10, name = "ali" });
            list_p2.Add(new person { id = 10, name = "ali" });
            list_p2.Add(new person { id = 10, name = "ali" });
            // 4 elements 

            list_p2.IndexOf(p3);
            list_p2.RemoveAt(1);
            list_p2.RemoveAt(2);














        }
    }
}
