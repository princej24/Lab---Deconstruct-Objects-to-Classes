using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{

    enum sunglassesHut { Coach, RayBan, Armani, Burberry }
    enum version { Prescriptionglasses , sunglasses, Fashionglasses}
    enum LensWidth { Narrow_42_48mm, Average_49_54mm, Wide_55mm_and_up }
    enum LensHeight {Short_25_28mm ,Average_29_36mm, Tall_37mm_and_up}
    
    internal class Sunglasses
    {
        string _Brand;
        string _ColorFrames;
        int _LensWidth;
        int _LensHeight;

        public string Brand { get => _Brand; set => _Brand = value; }
        public string ColorFrames { get => _ColorFrames; set => _ColorFrames = value; }
        public int LensWidth { get => _LensWidth; set => _LensWidth = value; }
        public int LensHeight { get => _LensHeight; set => _LensHeight = value; }
    }
}
