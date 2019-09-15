using System;
using MoneyTemplate.Models;
using MoneyTemplate.Models.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;
using Type = MoneyTemplate.Models.ViewModel.Type;

namespace MoneyTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookKeeping _accountBook = new BookKeeping(new List<Account>());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Money()
        {
            return View();
        }

        [HttpPost]
        public void RecordAccount(Account account)
        {
            _accountBook.Add(account);
        }

        [ChildActionOnly]
        public ActionResult ShowAccountBookDetail()
        {
            return View(_accountBook.GetBookList());
        }
    }
}