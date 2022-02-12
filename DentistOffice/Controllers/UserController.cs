using DentistOffice.DataAccess;
using DentistOffice.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DentistOffice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> repository;

        public UserController(IRepository<User> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers() => this.repository.GetAll();

        [HttpGet]
        [Route("{userId}")]
        public User GetUserById(int userId) => this.repository.GetById(userId);
    }
}
