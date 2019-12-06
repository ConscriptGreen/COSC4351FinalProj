namespace COSC4351
{
    using System;
    using System.Data;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class COSC4351Context : DbContext
    {
        public COSC4351Context()
            : base("name=COSC4351Context")
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<ELogin> ELogin { get; set; }
        public virtual DbSet<DManager> DManager{ get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<COSC4351Context>(null);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Sex)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeLogins)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

        }
    }
}
