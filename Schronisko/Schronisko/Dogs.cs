//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Schronisko
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dogs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dogs()
        {
            this.Events = new HashSet<Events>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> year_of_birth { get; set; }
        public string photo_path { get; set; }
        public string description { get; set; }
        public Nullable<int> id_race { get; set; }
    
        public virtual Races Races { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events> Events { get; set; }
    }
}
