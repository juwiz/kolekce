

namespace Kolekce
{   
    public class otherFunctions {
        public otherFunctions(){

        }


        public string formatSubjectString(string[] subjects){
            var s = $"{subjects[0]}\n";
           for (int i = 1; i < subjects.Length; i++)
           {
             if(int.TryParse( subjects[i], out int a)){
                s =s + $"{subjects[i]} ";
            }
            else{
                s = s + $"\n{subjects[i]}\n";
            }
           }
            return s;
        }
    }
    
}