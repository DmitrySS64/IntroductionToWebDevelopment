//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LW_1.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classes()
        {
            this.Students = new HashSet<Students>();
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int class_id { get; set; }
        public string name { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public Nullable<int> id_specialization { get; set; }
    
        public virtual Teachers Teachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Students> Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual TypeSpecialization TypeSpecialization { get; set; }
    }
}
