namespace TallinnaRakenduslikKolledz.Models
{
    public class DelinquentsBase
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public enum Violaton
      {
         Smoking,Gooning,Sleeping,Drugs,Alcohol
      }
        public bool? isTeacherOrStudent { get; set; }

        public string ViolationDescription { get; set; }
    }
}
