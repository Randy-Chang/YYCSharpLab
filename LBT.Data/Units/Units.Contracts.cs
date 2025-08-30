using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Units
{
    public enum ESIUnit
    {
        Ampere = 0,     // Ampere
        Volt = 1,       // V
        Watt = 2,       // W
        DecibelMilliWatt = 3, // dBm
        Meter = 4,   // m
    }

    public enum ESIUnitOrder
    {
        Yotta = 24,
        Zetta = 21,
        Exa = 18,
        Peta = 15,
        Tera = 12,
        Giga = 9,
        Mega = 6,
        Kilo = 3,
        Hecto = 2,
        Deca = 1,
        None = 0,
        Deci = -1,
        Centi = -2,
        Milli = -3,
        Micro = -6,
        Nano = -9,
        Pico = -12,
        Femto = -15,
        Atto = -18,
        Zepto = -21,
        Yocto = -24,
    }
}
