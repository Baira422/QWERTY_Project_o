//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QWERTY_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class FirstDiagnostic
    {
        public int idDiagnostic { get; set; }
        public int device { get; set; }
        public string description { get; set; }
    
        public virtual Device Device1 { get; set; }
    }
}
