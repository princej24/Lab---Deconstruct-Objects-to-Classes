using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab___Deconstruct_Objects_to_Classes
{

    enum Watch { Omega , Tag_Heuer , casio}
    enum CaseMaterial { Carbon_Fiber , Ceramic , Titanium , Stainless_Steel }
    enum YearMade { pre2000s ,early1990s , late1980s }
    
    internal class Wristwatch
    {
        string _Brand;
        int _YearMade;
        int _Price;

        public string Brand { get => _Brand; set => _Brand = value; }
        public int YearMade { get => _YearMade; set => _YearMade = value; }
        public int Price { get => _Price; set => _Price = value; }
    }
}
