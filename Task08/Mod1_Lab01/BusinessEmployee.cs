using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab02
{
    class BusinessEmployee : Employee
    {
        public double bonusBudet = 1000;

        public BusinessEmployee(String name) : base(name, 50000)
        {

        }

        public override string employeeStatus()
        {
            return ToString() + "with a buget of " + this.bonusBudet;
        }
    }
}