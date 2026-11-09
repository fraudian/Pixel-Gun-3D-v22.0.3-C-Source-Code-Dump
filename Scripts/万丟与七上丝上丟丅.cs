using UnityEngine;
internal sealed class 万丟与七上丝上丟丅
{
    // Fields
    internal static readonly string 丏上丗且不丝丒丙丆;
    internal static readonly string 丘世丛丕丙丐且丅丑;
    
    // Methods
    internal System.Collections.Generic.Dictionary<string, object> 丈万上丙丝丂丑丄丂(Progress.不东丌丈专丞丅三丆.专业一丟东上丙丙丘 专丞丙一丟专丞与丗)
    {
        string val_12;
        var val_15;
        var val_16;
        var val_18;
        val_12 = 专丞丙一丟专丞与丗;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_12.丛丈东丞一且七丆丆().Count == 0)
        {
                return val_1;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>> val_6 = val_12.丛丈东丞一且七丆丆().GetEnumerator();
        label_18:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_4.set_Item(key:  val_6.Current.丙东专丂世丈丏丁丂().ToString(), value:  -51017640);
        goto label_18;
        label_11:
        val_15 = 0;
        val_16 = 0;
        if(val_6 == null)
        {
            
        }
        else
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_6.Dispose();
        }
        
        val_18 = null;
        val_18 = null;
        val_12 = 万丟与七上丝上丟丅.丘世丛丕丙丐且丅丑;
        val_1.set_Item(key:  val_12, value:  val_4);
        return val_1;
    }
    internal Progress.不东丌丈专丞丅三丆.专业一丟东上丙丙丘 三丆丁丙与万丑丕丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_5;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        不东丌丈专丞丅三丆.专业一丟东上丙丙丘 val_1 = new 不东丌丈专丞丅三丆.专业一丟东上丙丙丘();
        val_17 = null;
        val_17 = null;
        val_18 = 万丟与七上丝上丟丅.丘世丛丕丙丐且丅丑;
        if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  val_18)) == false)
        {
                return (专业一丟东上丙丙丘)val_1;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = 一丐丗丁丞丆丅丟丄.Item[万丟与七上丝上丟丅.丘世丛丕丙丐且丅丑];
        if(val_20 != null)
        {
                val_20 = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_8 = val_20.GetEnumerator();
        label_20:
        if(((-50848288) & 1) == 0)
        {
            goto label_14;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_5.GetAwaiter();
        val_1.丒丒丆丅业不下丞丄(万丕丘丒丛丑一业专:  System.Convert.ToInt32(value:  val_11._value._obj.丐丏七丌丕丗业且上(), provider:  System.Globalization.CultureInfo.InvariantCulture), 专世专丟丝丌与丘上:  System.Convert.ToInt32(value:  val_11._value._obj, provider:  System.Globalization.CultureInfo.InvariantCulture));
        goto label_20;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (专业一丟东上丙丙丘)val_1;
    }
    public 万丟与七上丝上丟丅()
    {
    
    }
    private static 万丟与七上丝上丟丅()
    {
        万丟与七上丝上丟丅.丏上丗且不丝丒丙丆 = "t";
        万丟与七上丝上丟丅.丘世丛丕丙丐且丅丑 = "r";
    }

}
