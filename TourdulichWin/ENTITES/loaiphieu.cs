//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTITES
{
    using System;
    using System.Collections.Generic;
    
    public partial class loaiphieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loaiphieu()
        {
            this.phieuthanhtoans = new HashSet<phieuthanhtoan>();
        }
    
        public int id { get; set; }
        public string tenloaiphieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieuthanhtoan> phieuthanhtoans { get; set; }
    }
}
