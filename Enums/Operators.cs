using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Enums
{
    public  enum Operators : int
    {
        None = 0,

        [Display(Name = "+")]
        Plus = 1,
        [Display(Name = "-")]
        Minus = 2,
        [Display(Name = "*")]
        Multiple = 3,
        [Display(Name = "/")]
        Divide = 4,
    };

    
}
