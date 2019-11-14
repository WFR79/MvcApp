using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MVCApp.Models;
using MVCApp.ViewModels;

namespace MVCApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer

        public ActionResult New()
        {

            var memberSHipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                MembershipTypes = memberSHipTypes
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult Edit(int id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();


            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        public ViewResult Index()
        {
            using (var _context = new ApplicationDbContext())
            {
                var customers = _context.Customers.
                    Include(customer => customer.MembershipType).ToList();
                return View(customers);
            }
            
            
        }


        public ActionResult Details(int Id)
        {
            var customers = _context.Customers.SingleOrDefault(c => c.Id == Id);
            return View(customers);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            int response = _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

    }
}