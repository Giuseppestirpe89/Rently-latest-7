using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Rently.Models;
using Rently.ViewModels;

namespace Rently.Controllers
{
    public class CustomersController : Controller
    {
        //declaring the name of the db
        private ApplicationDbContext _context;

        //constructor
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //dispose the context object by overriding the dispose method method
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //close the tab to admin only by give the role name       
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        //form to save new customer
        public ActionResult Save(Customer customer)
        {
            //check for valiation
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }
            //addig customer to memeory fisrt and then with SaveChanges will save to Db
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            //after saving the page will be redirected to the index of customers
            return RedirectToAction("Index", "Customers");
        }

        //if the login is admin show the index page otherwise show the read only for the guest
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("Index");

            return View("ReadOnlyList"); ;
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Details(int id)
        {
            //we get the customerm the db with labda function
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            //we get the customer from the db with the lambda exp
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            //if the customer is not in the db return 404 error
            if (customer == null)
                return HttpNotFound();

            //if exist return to the form customer form and we edit the customer
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}