using UnityEngine;
internal static class 专且丝丄丙丗丈不丞
{
    // Fields
    private static System.Globalization.NumberFormatInfo 丗丒不丛丄与万丌丁;
    
    // Properties
    private static System.Globalization.NumberFormatInfo 与七丏丅万丙丐七丏 { get; }
    
    // Methods
    internal static int 丈丐且丐丆丑丂丄丘(int 东丏丕丗丕丞丁三丌, int 世万丈与丑专丝一丞)
    {
        世万丈与丑专丝一丞 = 世万丈与丑专丝一丞 + 1;
        return UnityEngine.Random.Range(min:  东丏丕丗丕丞丁三丌, max:  世万丈与丑专丝一丞);
    }
    internal static float 丈丐且丐丆丑丂丄丘(float 东丏丕丗丕丞丁三丌, float 世万丈与丑专丝一丞)
    {
        return UnityEngine.Random.Range(min:  东丏丕丗丕丞丁三丌, max:  世万丈与丑专丝一丞);
    }
    internal static bool 丆与丏丞丟丙丁丒不(int 万丁世丌丁丌丆万丟)
    {
        return (bool)((UnityEngine.Random.Range(min:  1, max:  101)) <= 万丁世丌丁丌丆万丟) ? 1 : 0;
    }
    internal static bool 丆与丏丞丟丙丁丒不(float 万丁世丌丁丌丆万丟, float 世万丈与丑专丝一丞 = 1)
    {
        return (bool)((UnityEngine.Random.Range(min:  0.0001f, max:  世万丈与丑专丝一丞)) <= 万丁世丌丁丌丆万丟) ? 1 : 0;
    }
    public static bool 丆丁万上丗三丑丐东(UnityEngine.Touch 丟下丙丆不东一与丅, UIRect 丁丄七万不专丅丗丝)
    {
        return 专且丝丄丙丗丈不丞.丙万丐丆丅三一万与(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, 丁丄七万不专丅丗丝:  丁丄七万不专丅丗丝);
    }
    public static bool 三业专丟丈业业丁丘(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UIRect 丁丄七万不专丅丗丝)
    {
        var val_8;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        val_8 = null;
        val_8 = null;
        if(val_1 == 0)
        {
                return false;
        }
        
        if(UICamera.currentCamera == 0)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_4 = val_1.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        UnityEngine.Vector3 val_5 = UICamera.currentCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        return 专且丝丄丙丗丈不丞.丙万丐丆丅三一万与(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, 丁丄七万不专丅丗丝:  丁丄七万不专丅丗丝);
    }
    internal static int 万七丝丐丒一丞三丞(int 三丛业丄丏丄丑与一)
    {
        System.TimeSpan val_1 = System.TimeSpan.FromHours(value:  (double)三丛业丄丏丄丑与一);
        return (int)(int)val_1._ticks.TotalSeconds;
    }
    internal static int 丐丄下丅七专东世七(int 东专专丗丄与丏丗专)
    {
        System.TimeSpan val_1 = System.TimeSpan.FromDays(value:  (double)东专专丗丄与丏丗专);
        return (int)(int)val_1._ticks.TotalSeconds;
    }
    public static UnityEngine.Vector2 丟东东丐丂丄丗丟下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_13;
        float val_14;
        float val_17;
        float val_18;
        var val_19;
        val_13 = 业丒丝丗与丐丛丟丏.z;
        val_14 = 业丒丝丗与丐丛丟丏.x;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_17 = val_1.x;
        val_18 = val_1.y;
        UnityEngine.Camera val_2 = UnityEngine.Camera.main;
        val_19 = null;
        val_19 = null;
        if(val_2 == 0)
        {
                return new UnityEngine.Vector2() {x = val_17, y = val_18};
        }
        
        if(UICamera.currentCamera == 0)
        {
                return new UnityEngine.Vector2() {x = val_17, y = val_18};
        }
        
        UnityEngine.Vector3 val_5 = val_2.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_14, y = 业丒丝丗与丐丛丟丏.y, z = val_13});
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        UnityEngine.Vector3 val_8 = UICamera.currentCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        val_13 = val_10.x;
        val_14 = val_10.z;
        UnityEngine.Vector3 val_11 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_13, y = val_10.y, z = val_14});
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_17 = val_12.x;
        val_18 = val_12.y;
        return new UnityEngine.Vector2() {x = val_17, y = val_18};
    }
    public static bool 丙万丐丆丅三一万与(UnityEngine.Vector2 业丒丝丗与丐丛丟丏, UIRect 丁丄七万不专丅丗丝)
    {
        var val_10;
        var val_11;
        val_10 = null;
        val_10 = null;
        if(丁丄七万不专丅丗丝 != 0)
        {
                if(UICamera.currentCamera != 0)
        {
            goto label_8;
        }
        
        }
        
        val_11 = 0;
        return (bool)val_11;
        label_8:
        UnityEngine.Vector3 val_3 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丁丄七万不专丅丗丝.rightAnchor, y = V11.16B, z = 丁丄七万不专丅丗丝.bottomAnchor});
        UnityEngine.Vector3 val_4 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丁丄七万不专丅丗丝.updateAnchors, y = V13.16B, z = 丁丄七万不专丅丗丝.丑丒丕上三丑丒专上});
        var val_5 = (业丒丝丗与丐丛丟丏.x >= val_3.x) ? 1 : 0;
        val_5 = val_5 & ((业丒丝丗与丐丛丟丏.x <= val_4.x) ? 1 : 0);
        val_5 = ((业丒丝丗与丐丛丟丏.y >= val_3.y) ? 1 : 0) & val_5;
        val_11 = ((业丒丝丗与丐丛丟丏.y <= val_4.y) ? 1 : 0) & val_5;
        return (bool)val_11;
    }
    public static void 丂丝三丏丞七万七东(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        var val_5;
        var val_25;
        PGCompany.七丑一上且三世丝三<K, V> val_1 = PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不();
        val_25 = 丈丄不七三万丄丁不.Count;
        List.Enumerator<T> val_3 = 丈丄不七三万丄丁不.GetEnumerator();
        label_23:
        if((584367664 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((val_1.ContainsKey(key:  val_6.业东丅东丌上丗丑不())) != true)
        {
                new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_6.业东丅东丌上丗丑不());
            val_1.set_Item(key:  val_6.业东丅东丌上丗丑不(), value:  new PGCompany.三东丏不丗世丅丌丄());
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_13 = val_1.Item[val_6.业东丅东丌上丗丑不()];
        val_13.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_6.丂丁丏一丙丛业且丌() + val_13.丂丁丏一丙丛业且丌());
        PGCompany.三东丏不丗世丅丌丄 val_18 = val_1.Item[val_6.业东丅东丌上丗丑不()];
        val_18.丅丁业不且上业丘且(丙业与丙丗丝不丈东:  val_6.丙丑丁专一专世万丕() + val_18.丙丑丁专一专世万丕());
        goto label_23;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        丈丄不七三万丄丁不.Clear();
        Dictionary.Enumerator<TKey, TValue> val_22 = val_1.GetEnumerator();
        label_48:
        if((584367624 & 1) == 0)
        {
            goto label_46;
        }
        
        ConfiguredValueTaskAwaiter val_23 = 0.GetAwaiter();
        丈丄不七三万丄丁不.Add(item:  val_23._value._obj);
        goto label_48;
        label_46:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.三东丏不丗世丅丌丄>.万世丅七一专丕丞不()) != null)
        {
                return;
        }
    
    }
    public static void 丂丝三丏丞七万七东(System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> 专丒业丛丞丝丕上一)
    {
        var val_5;
        var val_24;
        PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 val_26;
        PGCompany.七丑一上且三世丝三<K, V> val_1 = PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>.万世丅七一专丕丞不();
        val_24 = 专丒业丛丞丝丕上一.Count;
        List.Enumerator<T> val_3 = 专丒业丛丞丝丕上一.GetEnumerator();
        label_28:
        if((584555440 & 1) == 0)
        {
            goto label_6;
        }
        
        if((val_1.ContainsKey(key:  val_6.m_stringLength.业东丅东丌上丗丑不())) == false)
        {
            goto label_10;
        }
        
        PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 val_10 = val_1.Item[val_6.m_stringLength.业东丅东丌上丗丑不()];
        val_10.三东丏不丗世丅丌丄.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_6.m_stringLength.丂丁丏一丙丛业且丌() + val_10.三东丏不丗世丅丌丄.丂丁丏一丙丛业且丌());
        PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 val_15 = val_1.Item[val_6.m_stringLength.业东丅东丌上丗丑不()];
        val_15.三东丏不丗世丅丌丄.丅丁业不且上业丘且(丙业与丙丗丝不丈东:  val_6.m_stringLength.丙丑丁专一专世万丕() + val_15.三东丏不丗世丅丌丄.丙丑丁专一专世万丕());
        goto label_28;
        label_10:
        val_26 = val_5.丐丏七丌丕丗业且上().Clone();
        if((val_26 != null) && (null != null))
        {
                val_26 = 0;
        }
        
        val_1.set_Item(key:  val_6.m_stringLength.业东丅东丌上丗丑不(), value:  val_26);
        goto label_28;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        专丒业丛丞丝丕上一.Clear();
        Dictionary.Enumerator<TKey, TValue> val_21 = val_1.GetEnumerator();
        label_57:
        if((584555400 & 1) == 0)
        {
            goto label_55;
        }
        
        ConfiguredValueTaskAwaiter val_22 = 0.GetAwaiter();
        专丒业丛丞丝丕上一.Add(item:  val_22._value._obj);
        goto label_57;
        label_55:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((PGCompany.七丑一上且三世丝三<System.Int32, PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>.万世丅七一专丕丞不()) != null)
        {
                return;
        }
    
    }
    public static void 丝丐丝丛上丙丕丟一<T1, T2>(System.Collections.Generic.Dictionary<T1, T2> 万丝且丘不丑丝下丑, System.Collections.Generic.Dictionary<T1, T2> 下丈丌三且三丝丄与, bool 丘丁丙丐丆不丕丟丂 = False)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_6;
        var val_12;
        var val_13;
        var val_14;
        label_9:
        if((584728832 & 1) == 0)
        {
            goto label_2;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_4 = val_3.RemoteEndpoint;
        if(丘丁丙丐丆不丕丟丂 == false)
        {
            goto label_3;
        }
        
        int val_7 = val_6.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_3:
        int val_8 = val_6.丙东专丂世丈丏丁丂();
        if((万丝且丘不丑丝下丑 & 1) != 0)
        {
            goto label_9;
        }
        
        int val_9 = val_6.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_2:
        val_12 = 0;
        val_13 = 0;
        val_3 = __RuntimeMethodHiddenParam + 48 + 64;
        val_2 = val_1;
        val_1 = val_3;
        if((__RuntimeMethodHiddenParam + 48 + 64 + 286) == 0)
        {
            goto label_24;
        }
        
        var val_11 = __RuntimeMethodHiddenParam + 48 + 64 + 176;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_23:
        if(((__RuntimeMethodHiddenParam + 48 + 64 + 176 + 8) + -8) == null)
        {
            goto label_22;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (__RuntimeMethodHiddenParam + 48 + 64 + 286))
        {
            goto label_23;
        }
        
        goto label_24;
        label_22:
        val_14 = ((__RuntimeMethodHiddenParam + 48 + 64) + (((__RuntimeMethodHiddenParam + 48 + 64 + 176 + 8)) << 4)) + 296;
        label_24:
        val_3.Dispose();
        if( != 1)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    public static void 丝丐丝丛上丙丕丟一<T>(PGCompany.丒且丌丑丆上一丘丆<T> 万丝且丘不丑丝下丑, PGCompany.丒且丌丑丆上一丘丆<T> 下丈丌三且三丝丄与, bool 丘丁丙丐丆不丕丟丂 = False)
    {
        var val_8;
        var val_10;
        var val_11;
        label_20:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_8 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(下丈丌三且三丝丄与.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_8 = __RuntimeMethodHiddenParam + 48 + 8;
        if(丘丁丙丐丆不丕丟丂 == false)
        {
            goto label_14;
        }
        
        string val_4 = 下丈丌三且三丝丄与.丐丏七丌丕丗业且上();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_14:
        string val_5 = 下丈丌三且三丝丄与.丐丏七丌丕丗业且上();
        if((万丝且丘不丑丝下丑 & 1) != 0)
        {
            goto label_20;
        }
        
        string val_6 = 下丈丌三且三丝丄与.丐丏七丌丕丗业且上();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_7:
        val_10 = 0;
        val_11 = 0;
        if(下丈丌三且三丝丄与 == null)
        {
            
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            下丈丌三且三丝丄与.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void 丝丐丝丛上丙丕丟一<T>(PGCompany.且丟一七万东丁三上<T> 万丝且丘不丑丝下丑, PGCompany.且丟一七万东丁三上<T> 下丈丌三且三丝丄与, bool 丘丁丙丐丆不丕丟丂 = False)
    {
        var val_8;
        var val_10;
        var val_11;
        label_20:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_8 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(下丈丌三且三丝丄与.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_8 = __RuntimeMethodHiddenParam + 48 + 8;
        if(丘丁丙丐丆不丕丟丂 == false)
        {
            goto label_14;
        }
        
        int val_4 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_14:
        int val_5 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if((万丝且丘不丑丝下丑 & 1) != 0)
        {
            goto label_20;
        }
        
        int val_6 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_7:
        val_10 = 0;
        val_11 = 0;
        if(下丈丌三且三丝丄与 == null)
        {
            
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            下丈丌三且三丝丄与.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void 丝丐丝丛上丙丕丟一<T>(PGCompany.且丟一七万东丁三上<PGCompany.丒且丌丑丆上一丘丆<T>> 万丝且丘不丑丝下丑, PGCompany.且丟一七万东丁三上<PGCompany.丒且丌丑丆上一丘丆<T>> 下丈丌三且三丝丄与, bool 丘丁丙丐丆不丕丟丂 = False)
    {
        var val_8;
        var val_10;
        var val_11;
        label_20:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_8 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        if(下丈丌三且三丝丄与.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_8 = __RuntimeMethodHiddenParam + 48 + 8;
        if(丘丁丙丐丆不丕丟丂 == false)
        {
            goto label_14;
        }
        
        int val_4 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_14:
        int val_5 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if((万丝且丘不丑丝下丑 & 1) != 0)
        {
            goto label_20;
        }
        
        int val_6 = 下丈丌三且三丝丄与.丙东专丂世丈丏丁丂();
        if(万丝且丘不丑丝下丑 != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_7:
        val_10 = 0;
        val_11 = 0;
        if(下丈丌三且三丝丄与 == null)
        {
            
        }
        else
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            下丈丌三且三丝丄与.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static System.Collections.Generic.List<int> 丛丌下万七丞丝丝丞(System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丑丝丟丕丒不万万万)
    {
        var val_3;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(丑丝丟丕丒不万万万 == null)
        {
                return val_1;
        }
        
        List.Enumerator<T> val_2 = 丑丝丟丕丒不万万万.GetEnumerator();
        label_4:
        if((585295792 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        val_1.Add(item:  585295776);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public static bool 世上一不丄丂丐不丕(System.Enum 三专丌丕下与一七与, System.Enum 下专丁下与下丘丏不)
    {
        return (bool)(下专丁下与下丘丏不 != 三专丌丕下与一七与) ? 1 : 0;
    }
    public static bool 丞东万一七丌丆丌三(System.Enum 业丄七丙丛上专专丕)
    {
        return (bool)(业丄七丙丛上专专丕 == 0) ? 1 : 0;
    }
    internal static System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 专东世东一丏与一丗(System.Collections.Generic.List<int> 专三东丞丆丒下七丑)
    {
        System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> val_4;
        System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> val_2 = null;
        val_4 = val_2;
        val_2 = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        .东且丁丆丛丁丏丘且 = val_4;
        if(专三东丞丆丒下七丑 == null)
        {
                return val_4;
        }
        
        专三东丞丆丒下七丑.ForEach(action:  new System.Action<System.Int32>(object:  new 专且丝丄丙丗丈不丞.业丂七丏丟丕丌丂世(), method:  System.Void 专且丝丄丙丗丈不丞.业丂七丏丟丕丌丂世::丒丆丁丞业上丆丈丄(int 与丟丘丁业丄丙丛下)));
        val_4 = (专且丝丄丙丗丈不丞.业丂七丏丟丕丌丂世)[1152921539552296048].东且丁丆丛丁丏丘且;
        return val_4;
    }
    internal static void 上丁上三东丕丝丛丙(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丅丆一丕丛与丁丂丛, ref System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丄丄丆不丂丗丛丙专)
    {
        var val_3 = 1152921539552440736;
        if(丅丆一丕丛与丁丂丛 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丅丆一丕丛与丁丂丛.GetEnumerator();
        label_6:
        if((585807208 & 1) == 0)
        {
            goto label_2;
        }
        
        if((0.丐丏七丌丕丗业且上() == null) || (val_2.m_stringLength == 0))
        {
            goto label_6;
        }
        
        丄丄丆不丂丗丛丙专.Add(item:  val_2.m_stringLength);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上丁上三东丕丝丛丙(System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丅丆一丕丛与丁丂丛)
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        if(丅丆一丕丛与丁丂丛 == null)
        {
                return val_1;
        }
        
        List.Enumerator<T> val_2 = 丅丆一丕丛与丁丂丛.GetEnumerator();
        label_6:
        if((585943704 & 1) == 0)
        {
            goto label_2;
        }
        
        if((0.丐丏七丌丕丗业且上() == null) || (val_3.m_stringLength == 0))
        {
            goto label_6;
        }
        
        val_1.Add(item:  val_3.m_stringLength);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal static void 丞丝一三丟东丛东且(System.Collections.Generic.List<UIRect> 丐丗一业丒丐七丗且)
    {
        if(丐丗一业丒丐七丗且 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丐丗一业丒丐七丗且.GetEnumerator();
        label_7:
        if((586076200 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.ResetAndUpdateAnchors();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static void 三业丒丑丂三丕上丛(System.Collections.Generic.List<PanelAnchor> 丝丕与丙丁丗七丑东)
    {
        if(丝丕与丙丁丗七丑东 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = 丝丕与丙丁丗七丑东.GetEnumerator();
        label_7:
        if((586208680 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.Apply();
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private static System.Globalization.NumberFormatInfo 丗丘东丂丕丗丟丕丏()
    {
        System.Globalization.NumberFormatInfo val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(专且丝丄丙丗丈不丞.丗丒不丛丄与万丌丁 == null)
        {
                System.Globalization.NumberFormatInfo val_1 = new System.Globalization.NumberFormatInfo();
            val_4 = null;
            val_4 = null;
            专且丝丄丙丗丈不丞.丗丒不丛丄与万丌丁 = val_1;
            val_1.NumberGroupSeparator = " ";
            val_2 = 专且丝丄丙丗丈不丞.丗丒不丛丄与万丌丁;
            val_1.NumberDecimalSeparator = ",";
            val_3 = null;
        }
        
        val_3 = null;
        return (System.Globalization.NumberFormatInfo)专且丝丄丙丗丈不丞.丗丒不丛丄与万丌丁;
    }
    internal static string 丌丄丟东丂下业丕东(float 丑丅世丐丒丏丐三丅)
    {
        var val_4 = null;
        if(System.Math.Abs(丑丅世丐丒丏丐三丅) >= 0)
        {
                return (string)丑丅世丐丒丏丐三丅.ToString(format:  "0,0", provider:  专且丝丄丙丗丈不丞.丗丘东丂丕丗丟丕丏());
        }
        
        string val_1 = 丑丅世丐丒丏丐三丅.ToString();
        return (string)丑丅世丐丒丏丐三丅.ToString(format:  "0,0", provider:  专且丝丄丙丗丈不丞.丗丘东丂丕丗丟丕丏());
    }
    private static 专且丝丄丙丗丈不丞()
    {
    
    }

}
