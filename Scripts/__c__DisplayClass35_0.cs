using UnityEngine;
private sealed class HTTPCacheService.<>c__DisplayClass35_0
{
    // Fields
    public BestHTTP.Caching.HTTPCacheMaintananceParams maintananceParam;
    
    // Methods
    public HTTPCacheService.<>c__DisplayClass35_0()
    {
    
    }
    internal void <BeginMaintainence>b__0(object param)
    {
        var val_10;
        var val_29;
        var val_37;
        var val_39;
        var val_40;
        var val_43;
        System.Collections.Generic.List<BestHTTP.Caching.HTTPCacheFileInfo> val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_50;
        val_37 = 1152921505561370624;
        System.Collections.Generic.Dictionary<System.Uri, BestHTTP.Caching.HTTPCacheFileInfo> val_1 = BestHTTP.Caching.HTTPCacheService.Library;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  val_1, lockTaken: ref  val_2);
        System.DateTime val_3 = System.DateTime.UtcNow;
        System.DateTime val_4 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = val_3.dateData}, t:  new System.TimeSpan() {_ticks = this.maintananceParam.<DeleteOlder>k__BackingField});
        System.Collections.Generic.List<BestHTTP.Caching.HTTPCacheFileInfo> val_5 = new System.Collections.Generic.List<BestHTTP.Caching.HTTPCacheFileInfo>();
        Dictionary.Enumerator<TKey, TValue> val_7 = BestHTTP.Caching.HTTPCacheService.Library.GetEnumerator();
        label_18:
        if((2012719024 & 1) == 0)
        {
            goto label_9;
        }
        
        ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
        System.DateTime val_12 = val_11._value._obj.LastAccess;
        if(((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_12.dateData}, t2:  new System.DateTime() {dateData = val_4.dateData})) == false) || ((BestHTTP.Caching.HTTPCacheService.DeleteEntity(uri:  val_11._value._obj.丐丏七丌丕丗业且上(), removeFromLibrary:  false)) == false))
        {
            goto label_18;
        }
        
        null.Add(item:  val_11._value._obj);
        goto label_18;
        label_9:
        val_39 = 0;
        val_40 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (140 == 140))
        {
                val_39 = 0;
        }
        else
        {
                if( != 0)
        {
                val_40 = 0;
        }
        
        }
        
        val_44 = 0;
        goto label_38;
        label_48:
        bool val_19 = BestHTTP.Caching.HTTPCacheService.Library.Remove(key:  null.Item[0].Uri);
        bool val_22 = BestHTTP.Caching.HTTPCacheService.UsedIndexes.Remove(key:  null.Item[0].MappedNameIDX);
        val_37 = 1152921505561370624;
        val_44 = 1;
        label_38:
        if(val_44 < null.Count)
        {
            goto label_48;
        }
        
        val_45 = 140;
        null.Clear();
        val_46 = BestHTTP.Caching.HTTPCacheService.GetCacheSize();
        if(val_46 <= (this.maintananceParam.<MaxCacheSize>k__BackingField))
        {
            goto label_53;
        }
        
        val_47 = null;
        val_47 = null;
        val_44 = null;
        val_44 = new System.Collections.Generic.List<BestHTTP.Caching.HTTPCacheFileInfo>(capacity:  BestHTTP.Caching.HTTPCacheService.library.Count);
        Dictionary.Enumerator<TKey, TValue> val_27 = BestHTTP.Caching.HTTPCacheService.library.GetEnumerator();
        label_60:
        if((2012719024 & 1) == 0)
        {
            goto label_58;
        }
        
        ConfiguredValueTaskAwaiter val_31 = val_29.GetAwaiter();
        null.Add(item:  val_31._value._obj);
        goto label_60;
        label_53:
        val_48 = val_40;
        goto label_61;
        label_58:
        val_39 = 0 + 1;
        mem2[0] = 319;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_39 == 1) || ((val_45 + ((0 + 1)) << 2) != 319))
        {
            goto label_74;
        }
        
        var val_37 = 0;
        val_37 = val_37 ^ (val_39 >> 31);
        val_39 = val_39 + val_37;
        if(val_44 != null)
        {
            goto label_78;
        }
        
        goto label_76;
        label_74:
        if( != 0)
        {
                val_40 = 0;
        }
        
        if(val_44 != null)
        {
            goto label_78;
        }
        
        label_76:
        label_78:
        null.Sort();
        val_48 = val_40;
        goto label_91;
        label_103:
        if(0 >= null.Count)
        {
            goto label_81;
        }
        
        BestHTTP.Caching.HTTPCacheFileInfo val_33 = null.Item[0];
        bool val_36 = BestHTTP.Caching.HTTPCacheService.DeleteEntity(uri:  val_33.Uri, removeFromLibrary:  true);
        val_39 = val_39 + 1;
        val_46 = val_46 - (long)val_33.BodyLength;
        val_45 = 140;
        mem2[0] = 381;
        if((val_39 != 1) && ((val_45 + (((0 + 1) + 1)) << 2) == 381))
        {
                var val_38 = 0;
            val_38 = val_38 ^ (val_39 >> 31);
            val_39 = val_39 + val_38;
            val_48 = val_48;
        }
        else
        {
                val_40 = 0;
            val_48 = 0;
            if(val_48 != 0)
        {
                val_40 = 0;
            val_48 = 0;
        }
        
        }
        
        label_91:
        if(val_46 >= (this.maintananceParam.<MaxCacheSize>k__BackingField))
        {
            goto label_103;
        }
        
        label_81:
        val_37 = 1152921505561370624;
        label_61:
        val_50 = val_1;
        val_43 = val_39 + 1;
        mem2[0] = 431;
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  null);
        }
        
        if(val_39 == 1)
        {
            goto label_122;
        }
        
        if( == 0)
        {
            goto label_128;
        }
        
        if((val_45 + (((0 + 1) + 1)) << 2) != 431)
        {
            goto label_124;
        }
        
        goto label_128;
        label_122:
        if( == 0)
        {
            goto label_126;
        }
        
        label_124:
        val_40 = 0;
        val_48 = 0;
        goto label_128;
        label_126:
        val_40 = 0;
        val_43 = 0;
        label_128:
        BestHTTP.Caching.HTTPCacheService.SaveLibrary();
        BestHTTP.Caching.HTTPCacheService.InMaintainenceThread = false;
        if(val_43 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(1179403647 == 431)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }

}
