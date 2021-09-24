using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loan_Webapp.Models;
using System.ComponentModel.DataAnnotations;

namespace Loan_Webapp.Models
{
    public class AnnotationsCal
    {
        [Key]

        [Required(ErrorMessage = "กรุณาป้อนจำนวนเงิน")]
        [StringLength(9, MinimumLength = 6, ErrorMessage = "กรุณาป้อนจำนวนเงินอย่างน้อย 6 หลัก เเละ ไม่เกิน 9 หลัก")]
        public string Inputmoney { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนระยะเวลา")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "กรุณาป้อนระยะเวลาให้ถูกต้อง")]
        public string Inputyrs { get; set; }
    }
}
