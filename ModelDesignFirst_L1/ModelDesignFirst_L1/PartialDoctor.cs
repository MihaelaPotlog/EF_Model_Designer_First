﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Doctor
    {
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Specialty;
        }
    }
}
