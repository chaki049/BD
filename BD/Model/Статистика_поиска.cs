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
    
    public partial class Статистика_поиска
    {
        public int id_лекарство { get; set; }
        public int Месяц { get; set; }
        public int Запросов { get; set; }
    
        public virtual Лекарство Лекарство { get; set; }
    }
}
