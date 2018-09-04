using System;           
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySql.Data.MySqlClient;


namespace PACL.DomainModels.Models
{
    public class registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegId { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int MaxAttempt { get; set; }
        public int Attempt { get; set; }
        public char Lock { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string OldPassword { get; set; }
        public DateTime PasswordUpdatedOn { get; set; }
        public bool IsDelete { get; set; }

    }
}
