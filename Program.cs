// See https://aka.ms/new-console-template for more information




namespace Kolekce
{
    class Program
    {
        static void Main(string[] args)
        {
          
            zakFunkce zf = new zakFunkce();
            Commands c = new Commands();

          
          
       
          
          //////////////////////////////////////////////////
          
           int[] m2 = {1, 3, 2, 3};
           
    

            int[] m = {1, 4, 4, 4};
            Subject s = new Subject("cj\n" + string.Join(" ", m2) + "\n"  + "aj\n" + string.Join(" ", m) );

            Student yukito = new Student("Yukito", "Zakiry", "2", s);


            zf.addStudent("Yukito", "Zakiry", "2", "aj 1 2 3 2 cj 2 5 2 ne 4 2 5 3".Split(" "));

            yukito.listAllSubjects();

          c.viewall();

            string? input;
            string[] iArr;
            Student? active = null;
            /*
            while (true)
            {

                input = Console.ReadLine();
                

               if (input != null)
               {
                 iArr = input.Split(" ");
                 if (active == null)
                 {
                     //search, filter, viewall, del add student help, active deactive and getactive student, add class
                     switch (iArr[0])
                     {
                         case"search":
                             break;
                        case"filter":
                             break;   
                        case"viewall":
                             break;
                        case"addstudent":
                             break;   
                        case"addclass":
                             break;

                        case"delstudent":
                             break;
                        case"setactive":
                             break;   
                        case"deactive":
                             break;
                        case"getactive":
                             break;   
                        case"help" or "-h":
                             break; 

                         default:
                         Console.WriteLine("This command can't be used here, type help or -h for available commands");
                         break;
                     }
                 }
                 else
                 {
                    /// get active, deactive, help ,add del list subject, set list marks, change first or last name
                     switch (iArr[0])
                     {
                         case"addsubject":
                             break;
                        case"delsubject":
                             break;   
                        case"listsubject":
                             break;
                        case"setmarks":
                             break;   

                        case"listmarks":
                             break;
                        case"changefirstname":
                             break;  
                        case"changelastname":
                             break;   
                        case"setclass":
                             break;
                        case"deactive":
                             break;
                        case"getactive":
                             break;   
                        case"help" or "-h":
                             break; 

                         default:
                         Console.WriteLine("This command can't be used here, type help or -h for available commands");
                         break;
                     }
                 }
               }
               else
               {
                Console.WriteLine("You need to write command, to list useable commands type help or -h");
               }

                

                
            }
               */

        


    


        }
    }
}