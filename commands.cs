/// search the students who's name include searched string ///search
/// filter student by class, show just students from one class /// filter
/// add new Student ///addstudent
/// delete student from database ///delstudent
/// change students first name ///setfirstname
/// change students last name///setlastname
/// change students class///setclass
/// add new class to system///addclass
/// set active student, var that stores which student u can alter with (addSubject, addMarks ect.)///setactive
/// clear active student -> no student is active so no one can be altered///deactive
/// write out name and class of student thats active///getactive
/// view list of all students that go to the school w/o filter ///viewall
/// add new subject to student///addsubject
/// delete subject thats not needed///delsubject
/// change marks of chosen subject///setmarks
/// print out list of subjects that student studies///listsubject
/// print out marks of one subject///listmarks
/// end program///end

/// help, print out commands that can be used in the given moment///help or -h
/// if input is "command" -h, then print out specifics about the command
/// 
using System.Linq;

namespace Kolekce
{
    public class Commands {
        FileFunctions f = new FileFunctions();
        public Commands (){
             
        }

        public void search(string[] s){
            if (s.Length == 2)
            {
                
            }
            else{

            }
           var rArr = this.viewall();

           foreach (var i in rArr)
           {
            
           }
        }
        public void filter(string[] s){
            
        }
        public void addstudent(string[] s){
            ///struktura komandu jestli se lisi tak vratit
            /// command firstname lastname class subject marks subject marks (that can repeat there till all the subjects are added)
            /// example: addstudent bob tin 2 aj 2 2 2 2 cj 3 2 1
            ///vytvor txt filu ve stejnem formatu jako jsou ostatni v slozce school a prirad do spravne tridy

            
        }
        public void delstudent(string[] s){
            /// command firstname lastname
            /// najit a odstanit filu
        }
        public void setfirstname(string[] s){
            
        }
        public void setlastname(string[] s){
            
        }
        public string[] viewall(){
            
            var sArr = f.getFilePaths("school");
            string[] tArr;
            string []rArr = {};
            foreach (var i in sArr)
            {
                string text = File.ReadAllText(i);
                tArr = text.Split("\n");
                rArr = rArr.Append($"{tArr[0]} {tArr[1]}").ToArray();
                
                Console.WriteLine($"{tArr[0]} {tArr[1]}");
            }
            return rArr;
        }
        public void setclass(string[] s){
            
        }
        public void setactive(string[] s){
            
        }
        public void deactive(string[] s){
            
        }
        public void getactive(string[] s){
            
        }
        public void addsubject(string[] s){
            
        }
        public void delsubject(string[] s){
            
        }
        public void setmarks(string[] s){
            
        }
        public void listsubject(string[] s){
            
        }
        public void listmarks(string[] s){
            
        }
        public void help(string[] s){
            
        }

    }
    
}