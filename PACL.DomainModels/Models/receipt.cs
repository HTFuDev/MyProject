using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PACL.DomainModels.Models
{
    public class receipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecpId { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public double ReceiptAmount { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedOn { get; set; }
        public string UploadedBy { get; set; }
        public double TotalClaimedAmount { get; set; }
        public double TotalAmountApproved { get; set; }
        public bool IsDelete { get; set; }
        public int Status { get; set; }
        public int RegId { get; set; }
        public string NewFileName { get; set; }
    }
}
