//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NERABOTA.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Work
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Work()
        {
            this.Rabotadatel = new HashSet<Rabotadatel>();
        }
    
        public int id_work { get; set; }
        public int salary { get; set; }
        public int id_city { get; set; }
        public int id_metro { get; set; }
        public string name_work { get; set; }
        public string exp_work { get; set; }
    
        public virtual City City { get; set; }
        public virtual Metro Metro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rabotadatel> Rabotadatel { get; set; }
    }
}
