// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekce
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] m2 = {1, 3, 2, 3};
    

    int[] m = {1, 4, 4, 4};
    Subject s = new Subject("cj\n" + string.Join(" ", m2) + "\n"  + "aj\n" + string.Join(" ", m) );

    Student yukito = new Student("Yukito", "Zakiry", "2", s);

    
    yukito.getSubject("cj");
    yukito.getSubject("aj") ;
    yukito.getSubject("aj").setMarks("aj");
    yukito.getSubject("aj");


    


        }
    }
}