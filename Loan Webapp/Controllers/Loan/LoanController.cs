using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loan_Webapp.Models;

namespace Loan_Webapp.Controllers
{
    public class LoanController : Controller
    {

        public IActionResult Loan1p()
        {
            return View();
        }


        public IActionResult Calculate()
        {

                int n1 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["loan"].ToString()));
                int n2 = Math.Abs(Convert.ToInt32(HttpContext.Request.Form["numyr"].ToString()));
                double n3 = Math.Abs(Convert.ToDouble(HttpContext.Request.Form["interest"].ToString()));
                string hm = Request.Form["hometype"];
                string bnk = Request.Form["bnktype"]; 

                double itr = n3 / 100;
                double itrate = itr / 12;
                double ipone = 1 + itrate;
                double numberofmonths = n2 * 12;
                double pow_ab = Math.Pow(ipone, numberofmonths);
                double onedivab = 1 / pow_ab;
                double oneminus = 1 - onedivab;
                double Rdivr = oneminus / itrate;
                double ResultLoan = n1 / Rdivr;


                ViewBag.CalculationResult = string.Format("{0:n}", ResultLoan);
                ViewBag.numofmonth = numberofmonths.ToString();
                ViewBag.numofyrs = n2.ToString();
                ViewBag.loancustomer = string.Format("{0:n0}", n1);
                ViewBag.loancustomerin =  n1;
                ViewBag.hometype = hm;
                ViewBag.bnktype = bnk;
                ViewBag.interest = n3;




            return View("Loan1p");
        }



        public IActionResult KeepLoan()
        {
            string loan = Request.Form["Loancusresult"];
            string bnk = Request.Form["bankresult"];
            string hm = Request.Form["tyhmresult"];
            string nmofmonth = Request.Form["nmfmonresult"];
            string yrs = Request.Form["yrsresult"];

            ViewBag.numofyrs = yrs;
            ViewBag.numofmonth = nmofmonth;
            ViewBag.hometype = hm;
            ViewBag.bnktype = bnk;
            ViewBag.loancustomer = loan;

            return View("Information");
        }

        public IActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Information(Loan In)
        {

            if (ModelState.IsValid)
            {

                return View("Report", In);
            }

            string loan = Request.Form["LoanCustomer"];
            string bnk = Request.Form["BankCustomer"];
            string hm = Request.Form["TypeHomeCustomer"];
            string nmofmonth = Request.Form["Numofmonths"];
            string yrs = Request.Form["Numofyear"];

            ViewBag.numofyrs = yrs;
            ViewBag.numofmonth = nmofmonth;
            ViewBag.hometype = hm;
            ViewBag.bnktype = bnk;
            ViewBag.loancustomer = loan;


            return View(In);
        }

        public IActionResult Complete()
        {
            return View();
        }


    }
}
