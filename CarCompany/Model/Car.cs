//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCompany.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Buys = new HashSet<Buy>();
        }
    
        public int ID { get; set; }
        public int BrandID { get; set; }
        public int ModelID { get; set; }
        public int ColorID { get; set; }
        public long CarPrice { get; set; }
        public string CarProductionYear { get; set; }
        public int ForeignGalleryID { get; set; }
        public int InternalGalleryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy> Buys { get; set; }
        public virtual CarBrand CarBrand { get; set; }
        public virtual CarColor CarColor { get; set; }
        public virtual CarModel CarModel { get; set; }
        public virtual ForeignGallery ForeignGallery { get; set; }
        public virtual InternalGallery InternalGallery { get; set; }
    }
}
