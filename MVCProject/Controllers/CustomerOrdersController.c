using System.Collections.Generic;
using System.Web.Mvc;
using YourNamespace.Models;  // Use the appropriate namespace for Models and ViewModels
using YourNamespace.ViewModels;

public class CustomerOrdersController : Controller
{
    public ActionResult Index()
    {
        // Create an example customer
        var customer = new Customer
        {
            Id = 1,
            FirstName = "Burak",
            LastName = "Yılmaz",
            Email = "burak@example.com"
        };

        // Create example orders
        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 15000m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Keyboard", Price = 500m, Quantity = 2 },
            new Order { Id = 3, ProductName = "Mouse", Price = 250m, Quantity = 1 }
        };

        // Create the ViewModel
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        // Pass the model to the view
        return View(viewModel);
    }
}
