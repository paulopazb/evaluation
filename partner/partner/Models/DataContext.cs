﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace partner.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }
    }
}