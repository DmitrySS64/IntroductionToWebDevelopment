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
    
    public partial class Equipments
    {
        public int equipment_id { get; set; }
        public string name { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> classroom_id { get; set; }
    
        public virtual Classrooms Classrooms { get; set; }
    }
}
