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

            // passing comoparison logic 
            person p1=new person();
            MyArrayList<person> personList = new MyArrayList<person>(p1);
            personList.Add(new person {id=10 ,name="ali" });
            person p3=new person();p3.id=10;p3.name = "ali";
            personList.IndexOf(p3);
            personList.Add(new person { id = 142, name = "mohamed" });
            student s=new student();
            MyArrayList<student>studentList= new MyArrayList<student>(s);
            studentList.Add(new student { ssn = 66 });
            studentList.IndexOf(new student { ssn = 66 });












        }
    }
}
