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
    
    public partial class task
    {
        public int idTask { get; set; }
        public string nameTask { get; set; }
        public Nullable<bool> isFinishedTask { get; set; }
        public Nullable<System.DateTime> timeReminder { get; set; }
        public Nullable<int> idTodo { get; set; }
    
        public virtual todo todo { get; set; }
    }
}
