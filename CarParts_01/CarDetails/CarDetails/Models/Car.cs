//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarDetails.Models
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
