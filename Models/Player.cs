//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hdSection.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Player
    {
        [Required]
        public int PlayerID { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Account_Name { get; set; }
        public string Comments { get; set; }
        [Required]
        public int GameNo { get; set; }
    

        public virtual Game Game { get; set; }
    }
}
