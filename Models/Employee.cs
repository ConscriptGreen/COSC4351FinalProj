namespace COSC4351
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("COSC4351.Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            EmployeeLogins = new HashSet<ELogin>();
            DManager = new HashSet<DManager>();
        }

        [Key]
        public long EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(15)]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(15)]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(50)]
        public string StreetAddress { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(5)]
        public string ZipCode { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        [Column(TypeName = "date")]
        public DateTime? DoB { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [Display(Name = "Job Title")]
        [StringLength(20)]
        public string JobTitle { get; set; }

        [Display(Name = "Department")]
        public long? DepartmentID { get; set; }

        [Display(Name = "Department")]
        public virtual Departments Departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELogin> EmployeeLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DManager> DManager { get; set; }
    }
}
