


using System.Net.Http.Headers;

namespace Kolekce
{
    

    public class zakFunkce { //////// manipulating w student classes, adding deleting, changing ect.....

        otherFunctions of;
        public zakFunkce(){
            this.of = new otherFunctions();
        }

        public void addStudent(string firstName, string lastName, string classNum,  string[] subjects){

          var s = this.of.formatSubjectString(subjects);

            
            

            string txtContent = $"{firstName}\n{lastName}\n{classNum}\n{s}";
            ///////////do later: add new txt file

            

            Console.WriteLine("Student added to system");
        }


        public void delStudent(Student student){

            ////check if student exists
            /////////////////////do later: just delete the file bro
            Console.WriteLine("Student deleted");
        }

        public void changeFirstName(Student student){
            /////////////////do later: change file name
            var  s = Console.ReadLine();
            if(s == null){

                ///////trow error cus no name was writen
                return;
            }
            student.setFirstName(s);
        }

        public void changeLastName(Student student){
            /////////////////do later: change file name
            var  s = Console.ReadLine();
            if(s == null){

                ///////trow error cus no name was writen
                return;
            }
            student.setLastName(s);
        }















    }

    
}