using System; //a namespace in .Net framework, where we have our basic utility classes and primitive types there

//Not used but described
using System.Collections.Generic;  //used to work with lists collections and so on
using System.Linq; //used to work with data
using System.Text; //used to work with texts and coding and stuff like that
using System.Threading.Tasks; //used to build multi threaded applications

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) //when you run the application, CLR executes the code inside the main method
                                        //void means this method does not return any value, it just contains some code
                                        //the parameter inside of Main() is the input to the method. In this case its args which is of type string array
        {
            Console.WriteLine("Hello World");
        }
    }
}