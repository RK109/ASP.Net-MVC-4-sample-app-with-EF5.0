//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Titles.DAL.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        public Participant()
        {
            this.TitleParticipants = new HashSet<TitleParticipant>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParticipantType { get; set; }
    
        public virtual ICollection<TitleParticipant> TitleParticipants { get; set; }
    }
}
