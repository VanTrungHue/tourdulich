﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class tinhthanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tinhthanh()
        {
            this.diadiems = new HashSet<diadiem>();
        }
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Mã tỉnh thành")]
        public string matt { get; set; }
        [System.ComponentModel.DisplayName("Tên tỉnh thành")]
        public string tentt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [Browsable(false)]
        public virtual ICollection<diadiem> diadiems { get; set; }
    }
}
