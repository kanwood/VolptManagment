//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolptManagment.БазаДанных
{
    using System;
    using System.Collections.Generic;
    
    public partial class RatingsReceived
    {
        public int idRatingReceived { get; set; }
        public Nullable<int> idUser { get; set; }
        public string nameRR { get; set; }
        public string surnameRR { get; set; }
        public string patronymicRR { get; set; }
        public string nameSpecRR { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
