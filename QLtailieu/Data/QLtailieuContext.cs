using Microsoft.EntityFrameworkCore;
using QLtailieu.Models;

namespace QLtailieu.Data
{
    public class QLtailieuContext : DbContext
    {
        public QLtailieuContext (DbContextOptions<QLtailieuContext> options)
            : base(options)
        {
        }

        public DbSet<Tailieu> Tailieus { get; set; }
        public DbSet<TaileuNguoidung> TaileuNguoidungs { get; set; }
        public DbSet<Nguoidung> Nguoidungs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>().ToTable("Nguoidung");
            modelBuilder.Entity<TaileuNguoidung>().ToTable("TaileuNguoidung");
            modelBuilder.Entity<Tailieu>().ToTable("Tailieu");
        }
    }
}
