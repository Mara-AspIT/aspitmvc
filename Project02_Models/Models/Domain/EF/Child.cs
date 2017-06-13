namespace Project02_Models.Models.Domain.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Child")]
    public partial class Child
    {
        public int ChildId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
