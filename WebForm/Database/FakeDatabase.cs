using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForm.Models;

namespace WebForm.Database
{
    class FakeDatabase
    {
        public List<Location> GetLocations()
        {
            var list = new List<Location>() {
                new Location() { Name = "Upper Hutt", Value = "UpperHutt", Description = "Somewhere upper to here.", Region="Wellington"},
                new Location() { Name = "Lower Hutt", Value = "LowerHutt", Description = "Somewhere lower to here.", Region="Wellington"},
                new Location() { Name = "Paruma", Value = "Paruma", Description = "Madithupith", Region="Auckland"},
                new Location() { Name = "Pukekuoae", Value = "Pukekuoae", Description = "Puke ko hi", Region="Auckland"}               
            };
            return list;
        }

        public List<Region> GetRegions()
        {
            var list = new List<Region>() {
                new Region() {regionName = "Wellington", regionValue = "Wellington" },
                new Region() {regionName = "Auckland", regionValue = "Auckland"}
            };
            return list;
        }
    }
}
