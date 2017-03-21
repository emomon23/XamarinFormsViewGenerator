using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsCustomViews.MockData
{
    public class FishSpecies
    {
        public string Name { get; set; }
        public string Icon { get; set; }

        public static List<FishSpecies> GetFishList()
        {
            return new List<FishSpecies>()
            {
                new FishSpecies() {Name = "Crappie", Icon = "crappie.png" },
                new FishSpecies() {Name = "fish", Icon = "fish.png" },
                new FishSpecies() {Name = "Large Mouth", Icon = "largemouth.png" },
                new FishSpecies() {Name = "Pike", Icon = "pike.png" },
                new FishSpecies() {Name = "Smallmouth", Icon = "smallmouth.png" },
                new FishSpecies() {Name = "Sunfish", Icon = "sunfish.png" },
                new FishSpecies() {Name = "Walleye", Icon = "walleye.png" },
            };
        }
    }
}
