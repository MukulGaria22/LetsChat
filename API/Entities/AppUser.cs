using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } //Primary key for AppUser EF take it as Primary Key
        public string UserName { get; set; }

    }
}
