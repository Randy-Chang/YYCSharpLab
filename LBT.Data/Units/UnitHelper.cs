using LBT.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Units
{
    /// <summary>
    /// 提供 SI 單位相關的工具方法，包含單位字串、數值轉換與格式化。
    /// </summary>
    public class UnitHelper
    {
        /// <summary>
        /// 取得單位的字串符號（含倍數前綴）。
        /// <para>例如：Ampere + Milli → "mA"，Volt + Kilo → "kV"</para>
        /// <para>對於 dBm，忽略 <paramref name="order"/>，直接回傳 "dBm"</para>
        /// </summary>
        /// <param name="unit">基本單位</param>
        /// <param name="order">SI 倍數（前綴）</param>
        /// <returns>對應的單位字串符號</returns>
        /// <exception cref="ArgumentOutOfRangeException">傳入未知的單位或倍數時拋出</exception>
        public static string GetUnitSymbol(ESIUnit unit, ESIUnitOrder order)
        {
            string orderSymbol;
            switch (order)
            {
                case ESIUnitOrder.Yotta: orderSymbol = "Y"; break;
                case ESIUnitOrder.Zetta: orderSymbol = "Z"; break;
                case ESIUnitOrder.Exa: orderSymbol = "E"; break;
                case ESIUnitOrder.Peta: orderSymbol = "P"; break;
                case ESIUnitOrder.Tera: orderSymbol = "T"; break;
                case ESIUnitOrder.Giga: orderSymbol = "G"; break;
                case ESIUnitOrder.Mega: orderSymbol = "M"; break;
                case ESIUnitOrder.Kilo: orderSymbol = "k"; break;
                case ESIUnitOrder.Hecto: orderSymbol = "h"; break;
                case ESIUnitOrder.Deca: orderSymbol = "da"; break;
                case ESIUnitOrder.None: orderSymbol = ""; break;
                case ESIUnitOrder.Deci: orderSymbol = "d"; break;
                case ESIUnitOrder.Centi: orderSymbol = "c"; break;
                case ESIUnitOrder.Milli: orderSymbol = "m"; break;
                case ESIUnitOrder.Micro: orderSymbol = "µ"; break;
                case ESIUnitOrder.Nano: orderSymbol = "n"; break;
                case ESIUnitOrder.Pico: orderSymbol = "p"; break;
                case ESIUnitOrder.Femto: orderSymbol = "f"; break;
                case ESIUnitOrder.Atto: orderSymbol = "a"; break;
                case ESIUnitOrder.Zepto: orderSymbol = "z"; break;
                case ESIUnitOrder.Yocto: orderSymbol = "y"; break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(order), $"Not expected order value: {order}");
            }

            string unitSymbol;
            switch (unit)
            {
                case ESIUnit.Ampere: unitSymbol = "A"; break;
                case ESIUnit.Volt: unitSymbol = "V"; break;
                case ESIUnit.Watt: unitSymbol = "W"; break;
                case ESIUnit.DecibelMilliWatt: unitSymbol = "dBm"; break;
                case ESIUnit.Meter: unitSymbol = "m"; break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), $"Not expected unit value: {unit}");
            }

            return orderSymbol + unitSymbol;
        }

        /// <summary>
        /// 將數值轉換為 SI 基本單位值（去除倍數前綴）。
        /// <para>例如：5 mA → 0.005 A，3 kV → 3000 V</para>
        /// <para>dBm 為對數單位，不做轉換，直接回傳原值。</para>
        /// </summary>
        /// <param name="value">原始數值</param>
        /// <param name="unit">基本單位</param>
        /// <param name="order">SI 倍數（前綴）</param>
        /// <returns>以基本單位表示的數值</returns>
        public static double ConvertToBaseValue(double value, ESIUnit unit, ESIUnitOrder order)
        {
            if (double.IsNaN(value) || double.IsInfinity(value)) return value;
            if (unit == ESIUnit.DecibelMilliWatt) return value; // 不做線性換算
            return value * Math.Pow(10, (int)order);
        }

        /// <summary>
        /// 將 SI 基本單位值轉換為指定的倍數單位值。
        /// <para>例如：0.005 A → 5 mA，3000 V → 3 kV</para>
        /// <para>dBm 為對數單位，不做轉換，直接回傳原值。</para>
        /// </summary>
        /// <param name="baseValue">以 SI 基本單位表示的數值</param>
        /// <param name="unit">基本單位</param>
        /// <param name="order">SI 倍數（前綴）</param>
        /// <returns>以指定單位與倍數表示的數值</returns>
        public static double ConvertFromBaseValue(double baseValue, ESIUnit unit, ESIUnitOrder order)
        {
            if (double.IsNaN(baseValue) || double.IsInfinity(baseValue)) return baseValue;
            if (unit == ESIUnit.DecibelMilliWatt) return baseValue; // 同上
            return baseValue / Math.Pow(10, (int)order);
        }

        /// <summary>
        /// 將數值格式化為帶單位的字串。
        /// <para>例如：0.0123 A, Milli → "12.3 mA"</para>
        /// <para>dBm 為對數單位，不做倍數轉換，直接顯示 "dBm"</para>
        /// </summary>
        /// <param name="value">數值</param>
        /// <param name="unit">基本單位</param>
        /// <param name="order">SI 倍數（前綴）</param>
        /// <param name="decimals">小數位數（預設 3 位）</param>
        /// <returns>格式化後的字串，例如 "12.3 mA"</returns>
        public static string Format(double value, ESIUnit unit, ESIUnitOrder order, int decimals = 3)
        {
            var symbol = GetUnitSymbol(unit, order);
            return Math.Round(value, decimals).ToString(CultureInfo.InvariantCulture) + " " + symbol;
        }
    }
}
