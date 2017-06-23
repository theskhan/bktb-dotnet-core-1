using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using my_web.Services;

namespace my_web.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        public UsersController(INotification notification) {
            notification.Notify("Hello Users");
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = new List<User>();

            for (int i = 0; i < 50; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Name = "Name " + i.ToString(),
                    Address = "Address " + i.ToString()
                });
            }
            return users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
