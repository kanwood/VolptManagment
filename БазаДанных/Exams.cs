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
    
    public partial class Exams
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exams()
        {
            this.ResultExams = new HashSet<ResultExams>();
        }
    
        public int idExams { get; set; }
        public string nameE { get; set; }
        public string surnameE { get; set; }
        public string patronymicE { get; set; }
        public string schoolsubject { get; set; }
        public Nullable<System.DateTime> dateE { get; set; }
        public Nullable<int> idExamsOrg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultExams> ResultExams { get; set; }
    }
}
