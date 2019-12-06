using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace COSC4351.ViewModels
{
    public class EmployeeVM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeVM()
        {
            EmployeeLogins = new HashSet<ELogin>();
            DManager = new HashSet<DManager>();
        }

        [Key]
        public long EmployeeID { get; set; }

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string MiddleName { get; set; }

        [StringLength(15)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string StreetAddress { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(5)]
        public string ZipCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DoB { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(20)]
        public string JobTitle { get; set; }

        public long? DepartmentID { get; set; }

        public virtual Departments Departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELogin> EmployeeLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELogin> DManager { get; set; }

        [Key]
        [StringLength(40)]
        public string LoginEmail { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

    }
}