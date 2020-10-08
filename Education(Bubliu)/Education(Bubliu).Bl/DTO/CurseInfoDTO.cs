using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Bubliu_.Bl.DTO
{
    public class CurseInfoDTO : BaseDTO
    {
        public InfoUserDTO Author { get; set; }
        public string Description { get; set; }
        public string Book { get; set; }
    }
}
