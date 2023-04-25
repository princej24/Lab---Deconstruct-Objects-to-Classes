using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Deconstruct_Objects_to_Classes
{
    enum Beats { Beats_Studio, Beats_solo }
    enum driverSize{ driver_30mm, driver_40mm, driver_50mm, driver_55mm, driver_60mm }
    
    enum FrequencyResponse {Hz20_kHz20 ,Hz5_kHz35 ,Hz10_kHz40 , Hz15_kHz25 , Hz20_kHz40 }

    internal class Headphones
    {
        int _FrequencyResponse;
        int _driverSize;
        string _Beats;
        string _year;
       // int _Specs;

        public int FrequencyResponse { get => _FrequencyResponse; set => _FrequencyResponse = value; }
        public int DriverSize { get => _driverSize; set => _driverSize = value; }
        public string Beats { get => _Beats; set => _Beats = value; }
        public string Year { get => _year; set => _year = value; }
      //  public int Specs { get => _Specs; set => _Specs = value; }
    }
}
