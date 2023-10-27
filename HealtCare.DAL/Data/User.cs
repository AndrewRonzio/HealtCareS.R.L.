using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HealtCare.DAL.Data
{
    public class User : IdentityUser
    {       
        public string Surname { get; set; }
    }
}
