using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //simple interation over List i.e why I used IEnumerable
        {
            var Users = await _context.AppUsers.ToListAsync();
            return Users;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id) //simple interation over List i.e why I used IEnumerable
        {
            return await _context.AppUsers.FindAsync(id);
            
        }
    }
}
