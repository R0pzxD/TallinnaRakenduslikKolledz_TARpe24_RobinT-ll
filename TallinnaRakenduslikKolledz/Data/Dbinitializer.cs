using TallinnaRakenduslikKolledz.Models;

namespace TallinnaRakenduslikKolledz.Data
{
    public class Dbinitializer
    {
        public static void Initializer(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if(context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student
                {
                    FirstName = "George",
                    LastName = "Teemus",
                    EnrollmentDate = DateTime.Now,
                }
            };
        }
    }
}
