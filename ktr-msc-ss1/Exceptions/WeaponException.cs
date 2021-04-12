using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    public class WeaponException : Exception
    {
        public WeaponException(string msg) : base(msg) { }
    }
}
