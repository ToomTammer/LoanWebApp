using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Loan_Webapp.Models;

namespace Loan_Webapp.Models
{
    public class Loan
    {
        [Key]
        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ใช้")]
        public String NameUser { get; set; }

        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์ให้ครบ 10 ตัว")]
        public String NumberUser { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนที่อยู่ปัจจุบัน")]
        public String Address { get; set; }

        public string LoanCustomer { get; set; }


        public string Numofyear { get; set; }

        public string TypeHomeCustomer { get; set; }

        public string Payofmonths { get; set; }

        public string Numofmonths { get; set; }


        public string BankCustomer { get; set; }


    }
}
