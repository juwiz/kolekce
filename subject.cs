

namespace Kolekce
{
    public class Subject {

    

        public Dictionary <string, string[]>  name_marks = new Dictionary <string, string[]> ();


    public Subject(string n){

        ///// input check later needed, eliminate all the error inputs later tho enjoy that babe xd ///////////
        String [] a = n.Split("\n");

        for (int i = 0; i < a.Length; i+=2)
        {
            this.name_marks.Add(a[i], a[i+1].Split(" "));
        }


    }

    

   

    public void setMarks(string name){

        ////////////////////////valid input check
        ///check if subject exist
        //////////do later: change in file;
        Console.WriteLine($"current grades: {string.Join(" ", this.name_marks[name])}\ncopy current grades and then change, add or delete, them.");
        string? input = Console.ReadLine();

        if(input == null){
            input = " ";
        }

        this.name_marks[name] = input.Split(" ");
        
    }

    

    public String getMarks( string name){

        String a = string.Join(" ", this.name_marks[name]);


        return a;
    }

    
}
}

