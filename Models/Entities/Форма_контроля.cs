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
    
    public partial class Форма_контроля
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Форма_контроля()
        {
            this.Дисциплина_в_семестре = new HashSet<Дисциплина_в_семестре>();
        }
    
        public int Код_формы_контроля { get; set; }
        public string Наименование { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Дисциплина_в_семестре> Дисциплина_в_семестре { get; set; }
    }
}
