namespace Project02_Models.Models.Domain.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersonModel : DbContext
    {
        public PersonModel()
            : base("name=PersonModel")
        {
        }

        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .HasMany(e => e.People)
                .WithMany(e => e.Languages)
                .Map(m => m.ToTable("LanguagePersons"));

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Children)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);
        }
    }
}
