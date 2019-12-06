namespace COSC4351
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("COSC4351.DManager")]
    public partial class DManager
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DepartmentID { get; set; }

        public virtual Departments Departments { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
