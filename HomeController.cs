using System;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using MaSV_LTW.Models;
namespace MaSV_LTW.Areas.Admin.Controllers {
 [MaSV_LTW.Areas.Admin.Filters.AdminOnly] public class HomeController : Controller { private readonly MyStoreContext db=new MyStoreContext();public ActionResult Index(){ViewBag.CategoryCount=db.Categories.Count();ViewBag.ProductCount=db.Products.Count();ViewBag.CustomerCount=db.Customers.Count();ViewBag.OrderCount=db.Orders.Count();return View();}protected override void Dispose(bool d){if(d)db.Dispose();base.Dispose(d);} } }