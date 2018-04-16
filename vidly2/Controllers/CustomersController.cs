
using System.Linq;
using System.Web.Mvc;
using vidly2.Models;
using vidly2.ViewModels;
using System.Data.Entity;

namespace vidly2.Controllers
{
    

    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(i => i.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        public ActionResult New ()
        {
            var membershipType = _context.MembershipType.ToList();

            var viewModel = new CustomerFormViewModel
            {
                MembershipType = membershipType
            };
            return View("CustomerForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customers customers)
        {
            if (!ModelState.IsValid)
            {

                var viewModel = new CustomerFormViewModel
                {
                    Customers = customers,
                    MembershipType = _context.MembershipType.ToList()
                };
                return View("CustomerForm", viewModel);
            }

            if(customers.Id == 0)
                _context.Customers.Add(customers);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customers.Id);
                customerInDb.Name = customers.Name;
                customerInDb.DOB = customers.DOB;
                customerInDb.MembershipTypeId = customers.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customers.IsSubscribedToNewsletter;
                // NFG TryUpdateModel(customerInDb);  
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(i => i.Id == id);
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customers = customer,
                MembershipType = _context.MembershipType.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}