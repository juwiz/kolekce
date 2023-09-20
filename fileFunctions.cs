namespace Kolekce

{
 public class FileFunctions {

    public  FileFunctions(){

    }
    ///add file
    ///find file
    
    ///read file and return string
    ///add folder
    ///list names of files
    ///go throu whole school and list every student
    public string[] getFilePaths(string s){
        
        var a = Directory.GetFiles(s, "*.txt",SearchOption.AllDirectories);
        Console.WriteLine();
        return a;
    }
    ///search bro
 }   
}