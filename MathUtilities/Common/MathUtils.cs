using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.Common
{
    public static partial class MathUtils
    {
        /// <summary>
        /// 從指定的清單中，根據 selector 所對應的數值，找出最接近 target 的項目索引。
        /// </summary>
        /// <typeparam name="T">清單中元素的型別。</typeparam>
        /// <param name="list">要搜尋的清單。</param>
        /// <param name="target">目標項目，用來比較 selector 所選擇的值。</param>
        /// <param name="selector">從 T 類型中提取數值的函式，通常為某個數值屬性。</param>
        /// <returns>與目標最接近的項目在清單中的索引。</returns>
        /// <exception cref="ArgumentException">當清單為 null 或空時拋出。</exception>
        /// <example>
        /// 以下為使用範例：
        /// <code>
        /// class Point
        /// {
        ///     public double X { get; set; }
        /// }
        /// 
        /// var points = new List&lt;Point&gt;
        /// {
        ///     new Point { X = 1.2 },
        ///     new Point { X = 3.4 },
        ///     new Point { X = 2.5 }
        /// };
        /// 
        /// var target = new Point { X = 3.0 };
        /// int index = MathUtils.FindClosestIndex(points, target, p => p.X);
        /// // index 應為 2，因為 2.5 最接近 3.0
        /// </code>
        /// </example>
        public static int FindClosestIndex<T>(IList<T> list, T target, Func<T, double> selector)
        {
            if (list == null || list.Count == 0)
                throw new ArgumentException("列表不能為空");

            int closestIndex = 0;
            double smallestDifference = double.MaxValue;

            double targetValue = selector(target);

            for (int i = 0; i < list.Count; i++)
            {
                double value = selector(list[i]);
                double difference = Math.Abs(value - targetValue);
                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    closestIndex = i;
                }
            }

            return closestIndex;
        }
    }

    public static partial class MathUtils
    {
        public static double FindLeftPoint(double target, int indexMax, List<double> xData, List<double> yData)
        {
            for (int i = indexMax; i >= 0; i--)
            {
                if (yData[i] <= target) return xData[i];
            }
            return xData[0];
        }

        public static double FindRightPoint(double target, int indexMax, List<double> xData, List<double> yData)
        {
            for (int i = indexMax; i < yData.Count; i++)
            {
                if (yData[i] <= target) return xData[i];
            }
            return xData[xData.Count - 1];
        }
    }
}
