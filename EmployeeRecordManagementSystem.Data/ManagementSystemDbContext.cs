namespace EmployeeRecordManagementSystem.Data
{
    using Model.Entities;
    using Microsoft.EntityFrameworkCore;

    public class ManagementSystemDbContext : DbContext
    {
        public ManagementSystemDbContext(DbContextOptions<ManagementSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.JobTitle)
                .WithMany(jt => jt.Employees)
                .HasForeignKey(e => e.JobTitleId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Employee>().
                HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(m => m.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Comments)
                .HasForeignKey(c => c.EmployeeId);

            modelBuilder.Entity<Department>().HasData(
                new Department() { Id=1, Name= "Administration", IsActive=true},
                new Department() { Id=2, Name= "Human Resources", IsActive=true},
                new Department() { Id=3, Name= "IT", IsActive=true},
                new Department() { Id=4, Name= "Executive", IsActive=true}
                );

            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle() { Id=1, Name= "Head of Administration", IsActive=true },
                new JobTitle() { Id=2, Name= "VP of Administration", IsActive=true },
                new JobTitle() { Id=3, Name= "Administrative Director", IsActive=true },
                new JobTitle() { Id=4, Name= "Data Analyst", IsActive=true },
                new JobTitle() { Id=5, Name= "System Administrator", IsActive=true },
                new JobTitle() { Id=6, Name= "QA Tester", IsActive=true },
                new JobTitle() { Id=7, Name="Full Stack Web Developer", IsActive=true },
                new JobTitle() { Id=8, Name="Front-end Web Developer", IsActive=true },
                new JobTitle() { Id=9, Name= "CPO", IsActive=true },
                new JobTitle() { Id=10, Name= "HR Director", IsActive=true },
                new JobTitle() { Id=11, Name= "Executive director", IsActive=true },
                new JobTitle() { Id=12, Name= "Chief financial officer", IsActive=true }
                );
        }
    }
}
