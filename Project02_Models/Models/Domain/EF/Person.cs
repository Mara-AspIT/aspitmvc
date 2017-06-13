namespace Project02_Models.Models.Domain.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Children = new HashSet<Child>();
            Languages = new HashSet<Language>();
        }

        public int PersonId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Height { get; set; }

        public bool IsHealthy { get; set; }

        public int CountryId { get; set; }

        public int? PetId { get; set; }

        public int Gender { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Child> Children { get; set; }

        public virtual Country Country { get; set; }

        public virtual Pet Pet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Language> Languages { get; set; }
    }
}
