namespace LatihanInheritance
{
    public class Program
    {
        public static void Main() {
            Person person = new Person();
            person.Name = "Mike";
            person.Age = 299;
            person.GetNameAndAge();

            Teacher tch = new Teacher();
            tch.Name = "Thomas";
            tch.Age = 22;
            tch.TeacherId = "809328";
            tch.Subject = "Math";
            tch.GetNameAndAge();

            Student std = new Student();
            std.Name = "Sara";
            std.Age = 19;
            std.StudentId = "29035092";
            std.Email = "asogh@gmail.com";
            std.GetNameAndAge();
        }
    }
}