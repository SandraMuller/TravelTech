using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.Database;
using WebForm.Models;

namespace WebForm.BusinessLayer
{
    public class BLRegion
    {
        public List<Region> GetRegions()
        {
            FakeDatabase db = new FakeDatabase();
            return db.GetRegions();

        }
    }
}
