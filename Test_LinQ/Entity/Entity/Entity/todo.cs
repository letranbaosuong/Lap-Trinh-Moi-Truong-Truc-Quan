//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class todo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public todo()
        {
            this.tasks = new HashSet<task>();
        }
    
        public int idTodo { get; set; }
        public string nameTodo { get; set; }
        public string descriptionTodo { get; set; }
        public Nullable<int> priorityTodo { get; set; }
        public Nullable<System.DateTime> dueDateTodo { get; set; }
        public Nullable<int> idUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<task> tasks { get; set; }
        public virtual user user { get; set; }
    }
}
