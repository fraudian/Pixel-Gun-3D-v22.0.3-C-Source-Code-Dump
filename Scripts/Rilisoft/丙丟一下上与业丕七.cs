using UnityEngine;

namespace Rilisoft
{
    internal static class 丙丟一下上与业丕七
    {
        // Methods
        internal static bool 专一丏丆丁与丄丒万(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不, out object 东且丁丆丛丁丏丘且)
        {
            string val_4;
            if(万丝且丘不丑丝下丑 == null)
            {
                goto label_1;
            }
            
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_2;
            }
            
            return 万丝且丘不丑丝下丑.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  object val_1 = 东且丁丆丛丁丏丘且);
            label_1:
            val_4 = "dictionary";
            goto label_3;
            label_2:
            val_4 = "key";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        internal static object 七世丙丂东东丌专丕(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            string val_6;
            object val_1 = 0;
            if(万丝且丘不丑丝下丑 == null)
            {
                goto label_1;
            }
            
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_2;
            }
            
            return (object)((万丝且丘不丑丝下丑.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1)) != true) ? (val_1) : 0;
            label_1:
            val_6 = "dictionary";
            goto label_3;
            label_2:
            val_6 = "key";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_6);
        }
        internal static bool 万下万与丘丌世丘上(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不, out System.Collections.Generic.List<object> 东且丁丆丛丁丏丘且)
        {
            string val_5;
            if(万丝且丘不丑丝下丑 == null)
            {
                goto label_1;
            }
            
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_2;
            }
            
            bool val_2 = 万丝且丘不丑丝下丑.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  0);
            东且丁丆丛丁丏丘且 = 0;
            return false;
            label_1:
            val_5 = "dictionary";
            goto label_8;
            label_2:
            val_5 = "key";
            label_8:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        internal static bool 丘世七且丑不业丄丙(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不, out bool 东且丁丆丛丁丏丘且)
        {
            object val_10;
            bool val_11;
            object val_1 = 0;
            val_10 = val_1;
            if((val_10 != 0) && ((Rilisoft.丙丟一下上与业丕七.专一丏丆丁与丄丒万(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  val_1)) != false))
            {
                    val_11 = 1;
                东且丁丆丛丁丏丘且 = System.Convert.ToBoolean(value:  val_10);
                return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Boolean>(东且丁丆丛丁丏丘且: out  val_11 = true);
            }
            
            return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Boolean>(东且丁丆丛丁丏丘且: out  val_11);
        }
        internal static System.Nullable<bool> 丂丄丗丁丂且一丟丙(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            var val_3;
            if((Rilisoft.丙丟一下上与业丕七.丘世七且丑不业丄丙(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  false)) != false)
            {
                    val_3 = 0;
                return (System.Nullable<System.Boolean>)val_3;
            }
            
            val_3 = 0;
            return (System.Nullable<System.Boolean>)val_3;
        }
        internal static bool 万专丟世三东丆丆业(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不, out int 东且丁丆丛丁丏丘且)
        {
            object val_8;
            int val_9;
            object val_1 = 0;
            val_8 = val_1;
            if((val_8 != 0) && ((Rilisoft.丙丟一下上与业丕七.专一丏丆丁与丄丒万(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  val_1)) != false))
            {
                    东且丁丆丛丁丏丘且 = System.Convert.ToInt32(value:  val_8);
                val_9 = 1;
                return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Int32>(东且丁丆丛丁丏丘且: out  val_9 = 1152921542234594112);
            }
            
            return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Int32>(东且丁丆丛丁丏丘且: out  val_9);
        }
        internal static System.Nullable<int> 且丞丂七与丗丛下丁(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            var val_3;
            if((Rilisoft.丙丟一下上与业丕七.万专丟世三东丆丆业(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  0)) != false)
            {
                    val_3 = 0;
                return (System.Nullable<System.Int32>)val_3;
            }
            
            val_3 = 0;
            return (System.Nullable<System.Int32>)val_3;
        }
        internal static bool 丒丟且丏丌东丙丘专(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不, out double 东且丁丆丛丁丏丘且)
        {
            object val_9;
            double val_10;
            object val_1 = 0;
            val_9 = val_1;
            if((val_9 != 0) && ((Rilisoft.丙丟一下上与业丕七.专一丏丆丁与丄丒万(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  val_1)) != false))
            {
                    val_10 = 1;
                东且丁丆丛丁丏丘且 = System.Convert.ToDouble(value:  val_9);
                return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Double>(东且丁丆丛丁丏丘且: out  val_10 = 1.28824051720794E-231);
            }
            
            return (bool)Rilisoft.丙丟一下上与业丕七.丐丟丈丘业丁不丁丙<System.Double>(东且丁丆丛丁丏丘且: out  val_10);
        }
        internal static System.Nullable<double> 丐丞且不丁丅丁丙丟(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            string val_3 = 下上丐丆丝丟丝丒不;
            if((Rilisoft.丙丟一下上与业丕七.丒丟且丏丌东丙丘专(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  val_3 = 下上丐丆丝丟丝丒不, 东且丁丆丛丁丏丘且: out  double val_1 = 1.28824051723323E-231)) == false)
            {
                    return 0;
            }
            
            val_3 = public System.Void System.Nullable<System.Double>::.ctor(System.Double value);
            return 0;
        }
        internal static string 丒丙丝丆丄丆丄且专(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑, string 下上丐丆丝丟丝丒不)
        {
            object val_1 = Rilisoft.丙丟一下上与业丕七.七世丙丂东东丌专丕(万丝且丘不丑丝下丑:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            if(val_1 == null)
            {
                    return (string)(null == null) ? (val_1) : 0;
            }
            
            return (string)(null == null) ? (val_1) : 0;
        }
        private static bool 丐丟丈丘业丁不丁丙<T>(out T 东且丁丆丛丁丏丘且)
        {
            东且丁丆丛丁丏丘且 = false;
            return false;
        }
    
    }

}
