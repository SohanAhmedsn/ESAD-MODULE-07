//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInformation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Car_Parts = new HashSet<Car_Parts>();
        }
    
        public int CarId { get; set; }
        public string Model { get; set; }
        public System.DateTime Make { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public Nullable<bool> Availabel { get; set; }
        public string Picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car_Parts> Car_Parts { get; set; }
    }
}

//namespace Ev_07.Models
//{
//    using System;
//    using System.Collections.Generic;

//    public partial class Candidate
//    {
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
//        public Candidate()
//        {
//            this.Qualifications = new HashSet<Qualification>();
//        }

//        public int CandidateId { get; set; }
//        public string CandidateName { get; set; }
//        public System.DateTime BirthDate { get; set; }
//        public string AppliedFor { get; set; }
//        public decimal ExpectedSalary { get; set; }
//        public Nullable<bool> WorkFromHome { get; set; }
//        public string Picture { get; set; }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<Qualification> Qualifications { get; set; }
//    }
//}
