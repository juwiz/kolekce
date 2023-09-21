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
/// print out marks of one subject///listmark
/// end program///end

/// help, print out commands that can be used in the given moment///help or -h
/// if input is "command" -h, then print out specifics about the command
/// 
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Kolekce
{
    public class Commands {
        FileFunctions f = new FileFunctions();
        public Commands (){
             
        }

        public void search(string[] s){
            
            string[] sArr = new string[s.Length];
            for (int i = 1; i < s.Length; i++)
            {
                sArr [i - 1] = s[i];
           }
            
           var rArr = this.viewall();
           Console.Clear();
            var a = string.Join(" ", sArr);
            
           foreach (var i in rArr)
           {
            if(i.Contains(a)){
                Console.WriteLine(i);
            }
           }
        }
        public void filter(string[] s){

            if(s.Length != 2){
                return;
            }
            var sArr = f.getFilePaths($"school/{s[1]}");
            string[] tArr;
            //string []rArr = {};
            foreach (var i in sArr)
            {
                string text = File.ReadAllText(i);
                tArr = text.Split("\n");
               // rArr = rArr.Append($"{tArr[0]} {tArr[1]}").ToArray();
                
                Console.WriteLine($"{tArr[0]} {tArr[1]}");
            }
            //return rArr;
            
        }
        public void addstudent(string[] s){
            
            OtherFunctions of = new OtherFunctions();
            if (s.Length < 3) {
                return;
            }
            var marks = s.Skip(3).ToArray();
            var name = s[0];
            var last_name = s[1];
            var class_num = s[2];

            var file = File.CreateText(Path.Join("school", class_num, string.Format("{0}_{1}.txt",name.ToLower(), last_name.ToLower())));
            file.WriteLine(name);
            file.WriteLine(last_name);
            file.WriteLine(of.formatSubjectString(marks));
            file.Flush();
        }
        public void delstudent(string[] s){
            ///do later: write whenhn input is incorect
            if (s.Length != 2) {
                return;
            }
            foreach (var dir in Directory.EnumerateDirectories("school")) {
                Console.WriteLine(Path.Join("school", dir, string.Format("{0}_{1}.txt", s[0].ToLower(), s[1].ToLower())));
                try {
                    File.Delete(Path.Join(dir, string.Format("{0}_{1}.txt", s[0].ToLower(), s[1].ToLower())));
                } catch {}
            }
        }
        public void setfirstname(string[] s){
            
        }
        public void setlastname(string[] s){
            
        }
        public string[] viewall(){
            Console.Clear();
            
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
        public Student setactive(string[] s){
            if (s.Length != 4)
            {
                return null;
            }

            if(Directory.Exists($"school/{s[3]}")){

                string[] lines = File.ReadAllLines(Path.Join("school", s[3], string.Format("{0}_{1}.txt", s[1].ToLower(), s[2].ToLower())));
                string[] sArr = new string[s.Length - 3];
                 for (int i = 3; i < s.Length; i++)
                 {
                     sArr [i - 3] = s[i];
                     Console.WriteLine(s[i]);
                 }
            


                Subject subject = new Subject(sArr);
                Student student = new Student(lines[0], lines[1], lines[2], subject);
                return student;
            }
            return null;
        }

        public void addclass(string [] s){
            if(s.Length != 2 && !int.TryParse(s[1], out var a)){
                return;
            }
            string dir = $"school/{s[1]}";
            if (!Directory.Exists(dir))
            {
                 Directory.CreateDirectory(dir);
            }
        }
       
        
        public void addsubject(Student st, string[] s){
            string[] sArr = new string[s.Length - 2];
            if (int.TryParse(s[1], out var a))
            {
              return;

            }
            for (int i = 2; i < s.Length; i++)
            {
                if (int.TryParse(s[i], out var b))
                {
                    sArr[i - 2] = s[i];
                }
                
            }
            st.getSubject().name_marks.Add(s[1], sArr);
        }
        public void delsubject(string[] s){
            
        }
        public void setmarks(string[] s){
            
        }
        public void listsubject(Student s){
            
            foreach (var i in s.getSubject().name_marks)
            {
                Console.WriteLine($"{i.Key}: {string.Join(" ", i.Value)}");
            }
            
        }
        public void listmarks(string[] s){
            
        }
        public void help(string[] s){
            
        }

    }
    
}