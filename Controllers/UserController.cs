using Microsoft.AspNetCore.Mvc;
using mvccemx.Data;
using mvccemx.Models;
using System.Data;

namespace mvccemx.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var dt = DbHelper.GetUsers();
            var users = new List<UserModel>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new UserModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Username = row["Username"].ToString(),
                    EmployeeId = Convert.ToInt32(row["EmployeeId"]),
                    EmployeeName = row["EmployeeName"].ToString(),
                    IsActive = Convert.ToBoolean(row["IsActive"])
                });
            }
            return View(users);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                DbHelper.AddUser(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
