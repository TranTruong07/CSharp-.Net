using Services;
using Repositories.Entities;
namespace UIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container<Student> listh = new Container<Student> ();
            listh.AddItem(new Student() { Id = "001", Name = "AN", Dob = "2003", GPA = 7.8 });
            listh.AddItem(new Student() { Id = "002", Name = "DDD", Dob = "2043", GPA = 8.8 });
            listh.AddItem(new Student() { Id = "003", Name = "FFF", Dob = "2063", GPA = 9.8 });
            listh.PrintAll();
        }
    }
}
