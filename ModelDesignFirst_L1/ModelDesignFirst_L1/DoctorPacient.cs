//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelDesignFirst_L1
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoctorPacient
    {
        public int Doctors_Id { get; set; }
        public int Pacients_Id { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Pacient Pacient { get; set; }
    }
}
