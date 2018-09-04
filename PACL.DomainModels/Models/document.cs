using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PACL.DomainModels.Models
{
    public class document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocId { get; set; }
        public int RegId { get; set; }
        public string DocumentTitle { get; set; }
        public DateTime UploadOn { get; set; }
        public string DocumentNewTitle { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDelete { get; set; }


        [ForeignKey("RegId")]
        public virtual registration Registration { get; set; }
    }
}
