using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PACL.DomainModels.Models
{
    public class user
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RegId { get; set; }
        public string Name { get; set; }
        public bool IsNameChange { get; set; }
        public string ChangeName { get; set; }
        public string Aadhaar { get; set; }
        public string PAN { get; set; }
        public bool LandAlloted { get; set; }
        public bool IsNominee { get; set; }
        public string NomineeName { get; set; }
        public string Relation { get; set; }
        public string IFSC { get; set; }
        public string BankAndBranch { get; set; }
        public string AccountNo { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        [ForeignKey("RegId")]
        public virtual registration Registration { get; set; }

    }
}
