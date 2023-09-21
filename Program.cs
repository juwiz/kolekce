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
          
           
            string? input;
            string[] iArr;
            Student? active = null;
            
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
                              c.search(iArr);
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
                              active = c.setactive(iArr);
                             break;   
                        case"deactive":
                              active = null;
                             break;
                        case"getactive":
                              Console.WriteLine("no student is selected");
                              
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
                              c.addsubject(active, iArr);
                             break;
                        case"delsubject":
                             break;   
                        case"listsubject":
                              c.listsubject(active);
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
                              active = null;
                             break;
                        case"getactive":
                              Console.WriteLine($"{active.getFirstName()} { active.getLastName()}");
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
               

        


    


        }
    }
}