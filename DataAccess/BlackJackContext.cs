using Microsoft.EntityFrameworkCore;
using System;

namespace blackjack.DataAccess {

	public partial class BlackJackContext : DbContext {
		
		public DbSet<PlayLog> PlayLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(Constants.SqlConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PlayLog>()
                        .Property(e => e.SessionID)
                        .IsUnicode(false);
        }

	}
}
