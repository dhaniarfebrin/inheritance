namespace LatihanInheritance
{
    public class Program
    {
        public static void Main() {
            Person person = new Person("Mike", 29);
            // person.Name = "Mike";
            // person.Age = 299;
            person.GetNameAndAge();

            Teacher tch = new Teacher("Thomas", 22, "209148", "Math");
            // tch.Name = "Thomas";
            // tch.Age = 22;
            // tch.TeacherId = "809328";
            // tch.Subject = "Math";
            tch.GetNameAndAge();

            Student std = new Student("Sara", 19, "901341", "augag@gmail.com");
            // std.Name = "Sara";
            // std.Age = 19;
            // std.StudentId = "29035092";
            // std.Email = "asogh@gmail.com";
            std.GetNameAndAge();
        }
    }
}