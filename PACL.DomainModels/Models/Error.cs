using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PACL.DomainModels.Models
{
    public class error
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ErrorId { get; set; }
        public string ErrorName { get; set; }
        public int RegId { get; set; }
        public string UserIP { get; set; }
        public DateTime ErrorDate { get; set; }


        [ForeignKey("RegId")]
        public virtual registration Registration { get; set; }
    }
}
