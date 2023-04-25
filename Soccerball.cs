using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab___Deconstruct_Objects_to_Classes
{
    enum BrandType { Adidas, Nike, Puma };
    enum SizeOfBall { Size1 , Size2, Size3, Size4, Size5 };
    internal class Soccerball
    {

        string _BrandType;
        int _YearMade;
        int _SizeOfBall;

        public string BrandType { get => _BrandType; set => _BrandType = value; }
        public int YearMade { get => _YearMade; set => _YearMade = value; }
        public int SizeOfBall { get => _SizeOfBall; set => _SizeOfBall = value; }

        public Soccerball( string brandType, int yearMade, int sizeOfBall)
        {
           
            BrandType = brandType;
            YearMade = yearMade;
            SizeOfBall = sizeOfBall;
        }

    }
}
