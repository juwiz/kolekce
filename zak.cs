using static Kolekce.Subject;



namespace Kolekce
{
    public class Student {
    private string firstName;
    private string lastName;
    private string studentClass;
    private Subject subjects;


    public Student(string f, string l, string c, Subject s){
        this.firstName = f;
        this.lastName = l;
        this.studentClass = c;
        this.subjects = s;
    }
    
    public void getFirstName(){
        Console.WriteLine($"{this.firstName}");
    }

    public void setFirstName(string name){
        //////////// do later: rewrite the txt file and name of the file
        this.firstName = name;
        Console.WriteLine("first name of student changed");
    }


    public void getLastName(){
        Console.WriteLine($"{this.firstName}");
    }


    public void setLastName(string name){
        //////////// do later: rewrite the txt file and name of the file
        this.lastName = name;
        Console.WriteLine("last name of student changed");
    }




    public void getClass(){
         Console.WriteLine($"{this.studentClass}");
    }
    public void setClass(string num){
        /////// do later: check if class exists
        ////// do later: change files directory
        this.studentClass = num;
        
    }

    public Subject getSubject(string name){

        Console.WriteLine( $"{name} \n{this.subjects.getMarks(name)}");

        return this.subjects;
    }

///////////////////////////////////////////////////////////////////

    public void addSubject(string name, string marks){
        //////////do later: change in file

        this.subjects.name_marks.Add(name, marks.Split(" "));

        Console.WriteLine("new subject added");

    }

    public void delSubject(string name){

        ////////////////do later: remove subject in txt
        this.subjects.name_marks.Remove(name);
        Console.WriteLine($"subject {name} deleted");
    }


}
}
