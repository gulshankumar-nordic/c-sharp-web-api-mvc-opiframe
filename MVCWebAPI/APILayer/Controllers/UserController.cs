using ModelLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APILayer.Controllers
{
   
    public class UserController : ApiController
    {
        List<User> users;
        public UserController()
        {
            users = new List<User>();
            users.Add(new User { ID = 1, Name = "Test user 1", Address = "church street", City = "Helsinki", ContactNumber = 23223, email = "test@test.com", password = "12345" });
            users.Add(new User { ID = 2, Name = "Test user 2", Address = "church street", City = "Helsinki", ContactNumber = 23223, email = "test@test.com", password = "12345" });

        }

        public IEnumerable<User> Get()
        {
            return users;
        }

        public User Get(int id)
        {
            return users.FirstOrDefault<User>(x => x.ID.Equals(id));
        }
        
    }
}

/*
 * 
 * 
 * int ID, string Name, string Address 
   string City, long ContactNumber
   string email, string password

 */
