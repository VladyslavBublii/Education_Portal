using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_.Core.Entities
{
    public class Users : BaseEntities
    {
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }

    }
}
