using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolledz.Models
{
    public enum Violation
    {
        Smoking, Gooning, Sleeping, Drugs, Alcohol
    }
    public class Delinquent
    {
        [Key]
      public int ID { get; set; }
        public string FirstName { get; set; }
      public string LastName { get; set; }
        public Violation Violation { get; set; }
        public bool? isTeacherOrStudent { get; set; }

        public string ViolationDescription { get; set; }
    }
}
