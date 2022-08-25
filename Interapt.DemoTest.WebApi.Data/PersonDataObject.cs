using Interapt.DemoTest.BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interapt.DemoTest.WebApi.Data
{
    public class PersonDataObject : IPersonDataObject
    {
        private PersonContext _context;

        public PersonDataObject(PersonContext context)
        {
            _context = context;
        }

    }
}
