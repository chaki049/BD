//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Лекарство
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Лекарство()
        {
            this.Ассортимент_товара = new HashSet<Ассортимент_товара>();
            this.Лекарство1 = new HashSet<Лекарство>();
            this.Лекарство2 = new HashSet<Лекарство>();
            this.Статистика_поиска = new HashSet<Статистика_поиска>();
        }
    
        public int id_лекарство { get; set; }
        public string Название_лекарства { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ассортимент_товара> Ассортимент_товара { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Лекарство> Лекарство1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Лекарство> Лекарство2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Статистика_поиска> Статистика_поиска { get; set; }
    }
}
