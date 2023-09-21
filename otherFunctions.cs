

namespace Kolekce
{   
    public class OtherFunctions {
        public OtherFunctions(){

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