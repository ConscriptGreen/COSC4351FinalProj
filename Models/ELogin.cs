namespace COSC4351
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("COSC4351.ELogin")]
    public partial class ELogin
    {
        [Key]
        [StringLength(40)]
        public string LoginEmail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public long? EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}