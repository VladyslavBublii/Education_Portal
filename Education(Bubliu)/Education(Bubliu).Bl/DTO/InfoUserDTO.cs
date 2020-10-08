using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_.Bl.DTO
{
    public class InfoUserDTO : BaseDTO
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Sex { get; set; }
    }
}
