namespace LottoBuddy.Database
{
    using Model;
    using System.Data.Entity;

    public class LottoBuddyContext : DbContext
    {
        public LottoBuddyContext()
            : base("LottoBuddyConnectionString")
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
