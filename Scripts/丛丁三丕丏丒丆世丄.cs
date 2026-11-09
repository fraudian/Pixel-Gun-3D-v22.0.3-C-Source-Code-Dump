using UnityEngine;
public class 丛丁三丕丏丒丆世丄
{
    // Fields
    internal System.Collections.Generic.List<ModulePointWithProbability> BaseConfig;
    
    // Methods
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七(int 东丂万丌丑上丝丅丝, int 专丗不丏下丑万丞一)
    {
        int val_6;
        System.Collections.Generic.List<ModulePointWithProbability> val_27;
        Rilisoft.OfferItemType val_28;
        var val_29;
        int val_30;
        float val_27 = (float)东丂万丌丑上丝丅丝;
        val_27 = val_27 / (float)专丗不丏下丑万丞一;
        System.Collections.Generic.List<ModulePointWithProbability> val_2 = new System.Collections.Generic.List<ModulePointWithProbability>();
        System.Collections.Generic.List<ModulePointWithProbability> val_3 = new System.Collections.Generic.List<ModulePointWithProbability>();
        List.Enumerator<T> val_4 = this.BaseConfig.GetEnumerator();
        label_11:
        if(((-605437712) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        int val_8 = this.上与丕一东丞丂丄世(丈丄不七三万丄丁不:  public ModulePointWithProbability List.Enumerator<ModulePointWithProbability>::get_Current(), 丌丒丝东丌下丕丁丅:  0);
        if(val_8 >= (UnityEngine.Mathf.CeilToInt(f:  val_27)))
        {
            goto label_6;
        }
        
        if(val_8 < 1)
        {
            goto label_11;
        }
        
        val_3.Add(item:  val_7);
        goto label_11;
        label_6:
        val_2.Add(item:  val_7);
        goto label_11;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_27 = this.丑丂丞丑东丅下丗不(丌丒丝东丌下丕丁丅:  专丗不丏下丑万丞一, 上世丏丁世丟世丆业:  val_2);
        if(val_27.Count < 专丗不丏下丑万丞一)
        {
                val_27.AddRange(collection:  this.丑丂丞丑东丅下丗不(丌丒丝东丌下丕丁丅:  专丗不丏下丑万丞一 - val_27.Count, 上世丏丁世丟世丆业:  val_3));
        }
        
        val_28 = this.丆不且一丕丟七丁丙(东丁丆丞三下丏三丞:  val_27, 丝丛上丞七上丂丏丏:  东丂万丌丑上丝丅丝);
        System.Collections.Generic.List<Rilisoft.OfferItem> val_15 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        Dictionary.Enumerator<TKey, TValue> val_16 = val_28.GetEnumerator();
        val_29 = 0;
        goto label_24;
        label_32:
        if((-605437672) >= 1)
        {
                PGCompany.丙万丙下三下丄丌丄 val_20 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  val_6.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂());
            val_28 = val_20.不业丙丒丂丞下丆丙();
            val_27 = val_20.业上丙丞丐丄丆丅七();
            new Rilisoft.OfferItem() = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  val_28, 丞一丁业丄一一业且:  val_27, 丂丕丂丏专丂丄丕且:  -605437672);
            val_15.Add(item:  new Rilisoft.OfferItem());
        }
        
        label_24:
        if(((-605437744) & 1) != 0)
        {
            goto label_32;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_30 = 东丂万丌丑上丝丅丝;
        if((-605437672) >= )
        {
                return val_15;
        }
        
        double val_28 = (double) - 1152921538361147672;
        val_28 = 丐东不丅丂丂丅丙不.丁丌且万且丄丄丐世() * val_28;
        Rilisoft.OfferItem val_26 = null;
        val_30 = val_26;
        val_26 = new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  242, 丞一丁业丄一一业且:  "", 丂丕丂丏专丂丄丕且:  null);
        val_15.Add(item:  val_26);
        return val_15;
    }
    private ModulePointWithProbability 业丟丂丅丆丛丕丅丆(System.Collections.Generic.List<ModulePointWithProbability> 上世丏丁世丟世丆业)
    {
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        List.Enumerator<T> val_1 = 上世丏丁世丟世丆业.GetEnumerator();
        val_7 = 1152921538361082528;
        val_8 = 0f;
        goto label_2;
        label_4:
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_8 = val_8 + val_2.m_stringLength;
        label_2:
        if(((-605247832) & 1) != 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_8 > 0f)
        {
                float val_7 = 0f;
            val_8 = UnityEngine.Random.Range(min:  0f, max:  val_8);
            val_9 = 0;
            if(val_8 > 0f)
        {
                do
        {
            val_9 = 1;
            val_7 = 上世丏丁世丟世丆业.Item[1];
            val_7 = val_7 + val_4.probability;
        }
        while(val_7 < 0);
        
        }
        
            if(val_9 < 上世丏丁世丟世丆业.Count)
        {
                ModulePointWithProbability val_6 = 上世丏丁世丟世丆业.Item[1];
            return (ModulePointWithProbability)val_10;
        }
        
        }
        
        val_10 = 0;
        return (ModulePointWithProbability)val_10;
    }
    private System.Collections.Generic.Dictionary<int, int> 丆不且一丕丟七丁丙(System.Collections.Generic.List<ModulePointWithProbability> 东丁丆丞三下丏三丞, int 丝丛上丞七上丂丏丏)
    {
        var val_4;
        var val_24;
        ModulePointWithProbability val_25;
        int val_26;
        var val_27;
        val_24 = 丝丛上丞七上丂丏丏;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        List.Enumerator<T> val_2 = 东丁丆丞三下丏三丞.GetEnumerator();
        goto label_2;
        label_10:
        val_25 = val_4.丐丏七丌丕丗业且上();
        int val_6 = X24.业东丅东丌上丗丑不();
        val_1.set_Item(key:  val_6, value:  1);
        val_26 = val_6.业东丅东丌上丗丑不();
        if((this.上与丕一东丞丂丄世(丈丄不七三万丄丁不:  val_6, 丌丒丝东丌下丕丁丅:  val_1.Item[val_26])) <= 0)
        {
                bool val_10 = 东丁丆丞三下丏三丞.Remove(item:  val_25);
        }
        
        val_24 = val_24 - 1;
        label_2:
        if(((-605086720) & 1) != 0)
        {
            goto label_10;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        goto label_11;
        label_37:
        val_25 = val_4.业丟丂丅丆丛丕丅丆(上世丏丁世丟世丆业:  东丁丆丞三下丏三丞);
        if((val_1.ContainsKey(key:  val_11.itemParams.业东丅东丌上丗丑不())) != true)
        {
                val_1.set_Item(key:  val_11.itemParams.业东丅东丌上丗丑不(), value:  0);
        }
        
        int val_15 = val_11.itemParams.业东丅东丌上丗丑不();
        if(val_1 != null)
        {
                val_27 = val_1.Item[val_15];
        }
        else
        {
                val_27 = val_1.Item[val_15];
        }
        
        val_1.set_Item(key:  val_15, value:  val_27 + 1);
        val_26 = val_11.itemParams.业东丅东丌上丗丑不();
        if((this.上与丕一东丞丂丄世(丈丄不七三万丄丁不:  val_11.itemParams, 丌丒丝东丌下丕丁丅:  val_1.Item[val_26])) <= 0)
        {
                bool val_22 = 东丁丆丞三下丏三丞.Remove(item:  val_25);
        }
        
        val_24 = val_24 - 1;
        label_11:
        if(val_24 < 1)
        {
                return val_1;
        }
        
        if(东丁丆丞三下丏三丞.Count > 0)
        {
            goto label_37;
        }
        
        return val_1;
    }
    private System.Collections.Generic.List<ModulePointWithProbability> 丑丂丞丑东丅下丗不(int 丌丒丝东丌下丕丁丅, System.Collections.Generic.List<ModulePointWithProbability> 上世丏丁世丟世丆业)
    {
        int val_7 = 丌丒丝东丌下丕丁丅;
        System.Collections.Generic.List<ModulePointWithProbability> val_1 = new System.Collections.Generic.List<ModulePointWithProbability>();
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<ModulePointWithProbability>(source:  上世丏丁世丟世丆业);
        if(val_7 < 1)
        {
                return val_1;
        }
        
        int val_3 = val_7 + 1;
        do
        {
            int val_4 = val_2.Count;
            if(val_4 <= 0)
        {
                return val_1;
        }
        
            val_7 = val_4.业丟丂丅丆丛丕丅丆(上世丏丁世丟世丆业:  val_2);
            val_1.Add(item:  val_7);
            bool val_6 = val_2.Remove(item:  val_7);
            val_3 = val_3 - 1;
        }
        while(val_3 >= 2);
        
        return val_1;
    }
    private int 上与丕一东丞丂丄世(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, int 丌丒丝东丌下丕丁丅 = 0)
    {
        PGCompany.丝丟丅丏丟丞不丌七 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丝丟丅丏丟丞不丌七>(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
        if(val_3 == null)
        {
                return 0;
        }
        
        if(val_3 == null)
        {
                return 0;
        }
        
        PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() = (null == null) ? (val_3) : 0;
        if(null == null)
        {
                return UnityEngine.Mathf.Max(a:  (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() - 丌丒丝东丌下丕丁丅) - (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().业上丈丄丁丂丕丏丕(丈丄不七三万丄丁不:  丈丄不七三万丄丁不)), b:  0);
        }
        
        return 0;
    }
    private int 业上丈丄丁丂丕丏丕(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        PGCompany.丝丟丅丏丟丞不丌七 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丝丟丅丏丟丞不丌七>(丈丄不七三万丄丁不:  丈丄不七三万丄丁不, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if(val_2 == null)
        {
                return (int)val_2.丂丁丏一丙丛业且丌();
        }
        
        return (int)val_2.丂丁丏一丙丛业且丌();
    }
    public 丛丁三丕丏丒丆世丄()
    {
        this.BaseConfig = new System.Collections.Generic.List<ModulePointWithProbability>();
    }

}
