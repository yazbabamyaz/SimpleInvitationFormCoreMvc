namespace Exam1.Models
{
    public class DemoDb
    {
        private readonly static List<Invitation> invitations = new();

        public static IEnumerable<Invitation> Invitations => invitations;

        public static void Save(Invitation value)
        {
            invitations.Add(value);
        }        

    }
}
