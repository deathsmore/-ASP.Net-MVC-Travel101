using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Travel101_MVC.Data
{
    public class TravelContext:DbContext
    {
        public TravelContext() : base("name=TravelConnection")
        {

        }
    }
}