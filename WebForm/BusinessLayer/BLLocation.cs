using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.Database;
using WebForm.Models;

namespace WebForm.BusinessLayer
{
    public class BLLocation
    {
        public List<Location> GetLocations(string regionValue)
        {
            FakeDatabase db = new FakeDatabase();
            var list = db.GetLocations();
            return list.Where(w => w.Region == regionValue).ToList();
        }
    }
}
