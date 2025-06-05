using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionUtilities
{
    public class DictionaryHelper
    {
        #region Normal Fundtion
        /// <summary>
        /// 當Dictionary的Key為Enum，且Value為List時可使用。
        /// 
        /// 使用範例：
        /// Dictionary<MyEnum, List<int>> myDict;
        /// InitDictionary(out myDict, () => new List<int>());
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="target"></param>
        /// <param name="defaultValueFactory"></param>
        public static void InitDictionary<TKey, TValue>(ref Dictionary<TKey, TValue> target,
                                                            Func<TValue> defaultValueFactory)
        {
            target = new Dictionary<TKey, TValue>();

            TKey[] enumValues = (TKey[])Enum.GetValues(typeof(TKey));

            foreach (TKey enumValue in enumValues)
            {
                // 使用 factory 方法來創建每個 TValue 的新實例
                target.Add(enumValue, defaultValueFactory());
            }
        }

        /// <summary>
        /// 當Dictionary的Key為Enum，且Value為Dictionary時可使用。
        /// 
        /// 使用範例：
        /// Dictionary<MyEnum, Dictionary<string, int>> myDict;
        /// InitDictionary(out myDict, () => new Dictionary<string, int>());
        /// 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TSubKey"></typeparam>
        /// <typeparam name="TSubValue"></typeparam>
        /// <param name="target"></param>
        /// <param name="defaultValueFactory"></param>
        public static void InitDictionary<TKey, TSubKey, TSubValue>(out Dictionary<TKey, Dictionary<TSubKey, TSubValue>> target,
                                                                        Func<Dictionary<TSubKey, TSubValue>> defaultValueFactory)
        {
            target = new Dictionary<TKey, Dictionary<TSubKey, TSubValue>>();

            TKey[] enumValues = (TKey[])Enum.GetValues(typeof(TKey));

            foreach (TKey enumValue in enumValues)
            {
                // 每次呼叫 defaultValueFactory() 來生成新的字典實例
                target.Add(enumValue, defaultValueFactory());
            }
        }

        /// <summary>
        /// 當Dictionary的Key為Enum，且Value為任一實值型別時可使用。
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="target"></param>
        public static void InitDictionary<TKey, TValue>(out Dictionary<TKey, TValue> target)
        {
            target = new Dictionary<TKey, TValue>();

            string[] enumNames = Enum.GetNames(typeof(TKey));

            foreach (string element in enumNames)
            {
                TKey enumValue = (TKey)Enum.Parse(typeof(TKey), element);

                target.Add(enumValue, default(TValue));
            }
        }

        public static Dictionary<TKey, TValue> InitDictionary<TKey, TValue>()
        {
            Dictionary<TKey, TValue> target = new Dictionary<TKey, TValue>();

            string[] enumNames = Enum.GetNames(typeof(TKey));

            foreach (string element in enumNames)
            {
                TKey enumValue = (TKey)Enum.Parse(typeof(TKey), element);

                target.Add(enumValue, default(TValue));
            }

            return target;
        }

        public static Dictionary<TKey, TValue> InitDictionary2<TKey, TValue>() where TKey : Enum
        {
            Dictionary<TKey, TValue> target = new Dictionary<TKey, TValue>();

            foreach (TKey enumValue in Enum.GetValues(typeof(TKey)))
            {
                // 為 TValue 嘗試初始化
                TValue value = typeof(TValue).IsValueType || typeof(TValue).GetConstructor(Type.EmptyTypes) != null
                    ? Activator.CreateInstance<TValue>()
                    : default;

                target.Add(enumValue, value);
            }

            return target;
        }
        #endregion
    }
}
