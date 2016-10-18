namespace TeamProject1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameContextAzure : DbContext
    {
        public GameContextAzure()
            : base("name=GameConnectionAzure")
        {
        }

        public virtual DbSet<GameTable> GameTable { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameTable>()
                .Property(e => e.WEEK_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<GameTable>()
                .Property(e => e.TEAM_1_ID)
                .IsFixedLength();

            modelBuilder.Entity<GameTable>()
                .Property(e => e.TEAM_2_ID)
                .IsFixedLength();

            modelBuilder.Entity<GameTable>()
                .Property(e => e.TEAM_1_Score)
                .IsFixedLength();

            modelBuilder.Entity<GameTable>()
                .Property(e => e.TEAM_2_Score)
                .IsFixedLength();

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
