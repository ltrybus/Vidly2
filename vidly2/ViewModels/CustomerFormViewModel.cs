﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly2.Models;

namespace vidly2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customers Customers { get; set; }

    }
}