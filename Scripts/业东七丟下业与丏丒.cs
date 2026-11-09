using UnityEngine;
private sealed class 丅且东丙业丏丛东丛.业东七丟下业与丏丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丅且东丙业丏丛东丛 丝且与丝丒丟万丁专;
    public bool 丕丈丅丐丙丈丒不丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅且东丙业丏丛东丛.业东七丟下业与丏丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_56;
        PGCompany.丘与丈世不丕丕丅丑 val_57;
        int val_58;
        var val_60;
        Rilisoft.PlayerPaymentType val_61;
        Rilisoft.PlayerPaymentType val_62;
        Rilisoft.PlayerPaymentType val_63;
        var val_64;
        var val_65;
        var val_66;
        int val_67;
        int val_68;
        IntPtr val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
            goto label_11;
        }
        
        val_57 = 1152921505476546560;
        if(Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世() == null)
        {
            goto label_11;
        }
        
        val_57 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        if(val_3.丘与丈世不丕丕丅丑 == null)
        {
            goto label_11;
        }
        
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_6 = this.丝且与丝丒丟万丁专.丄丒丌丄且丝丅丛丛.Values.GetEnumerator();
        label_18:
        if((1344678752 & 1) == 0)
        {
            goto label_15;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        new System.Collections.Generic.List<System.Int32>().Add(item:  val_9.m_stringLength);
        goto label_18;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_43;
        }
        
        val_58 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_58;
        label_11:
        val_58 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_58;
        return (bool)val_58;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专.丄丒丌丄且丝丅丛丛.Clear();
        string val_11 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  91);
        val_56 = public PGCompany.丘与丈世不丕丕丅丑 DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<PGCompany.丘与丈世不丕丕丅丑>(string 丞丕丒专一下丙业上);
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_57 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_39;
        }
        
        val_60 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.丌七万三丗丅丐丘丗 = val_57;
        if(val_57 != null)
        {
            goto label_40;
        }
        
        goto label_43;
        label_39:
        val_60 = 96;
        mem[96] = val_57;
        val_57 = mem[96];
        if(val_57 == 0)
        {
            goto label_43;
        }
        
        label_40:
        if((val_12 + 24) == 0)
        {
            goto label_43;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_44;
        }
        
        this.丝且与丝丒丟万丁专.万丗专丆与丆丂业丐(丁丛丂专丛且丙七万:  val_12 + 24);
        goto label_45;
        label_43:
        val_58 = 0;
        return (bool)val_58;
        label_44:
        0.万丗专丆与丆丂业丐(丁丛丂专丛且丙七万:  val_12 + 24);
        label_45:
        this.丝且与丝丒丟万丁专.下丆东丄丄丗丆丏丗(丁丛丂专丛且丙七万:  val_12 + 24);
        System.DateTime val_15 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丙丅丅业丟丁世丁丗());
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_61 = this.丝且与丝丒丟万丁专.丞丌一丈世丟丅不丝();
        }
        else
        {
                val_61 = 0.丞丌一丈世丟丅不丝();
        }
        
        this.丝且与丝丒丟万丁专.丌万丏七与丒丂丑专 = val_61;
        System.Collections.Generic.Dictionary<System.Int32, 世上丏丘丏丛丙万世> val_18 = new System.Collections.Generic.Dictionary<System.Int32, 世上丏丘丏丛丙万世>();
        List.Enumerator<T> val_20 = this.丝且与丝丒丟万丁专.七三丞万万一丞万万().GetEnumerator();
        label_80:
        label_72:
        if((1344678720 & 1) == 0)
        {
            goto label_57;
        }
        
        世上丏丘丏丛丙万世 val_22 = this.丝且与丝丒丟万丁专.丏且丁丈万丁下专专(丐丛不东三下丕东丗:  val_12 + 24, 丞丅上丏丂且下丅与:  val_8.丙东专丂世丈丏丁丂());
        if(((val_22 == null) || ((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_15.dateData}, t2:  new System.DateTime() {dateData = val_22.DateStart})) == true)) || ((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_15.dateData}, t2:  new System.DateTime() {dateData = val_22.DateEnd})) == true))
        {
            goto label_72;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_62 = this.丝且与丝丒丟万丁专.丌万丏七与丒丂丑专;
        }
        else
        {
                val_62 = this.丝且与丝丒丟万丁专.丌万丏七与丒丂丑专;
        }
        
        if(((this.丝且与丝丒丟万丁专.丄丏七丕与业上丆丒(丐丛不东三下丕东丗:  val_22, 七丈七丂与丈丙业丕:  val_62)) == false) || ((this.丝且与丝丒丟万丁专.丈丏丅上丁丐丄丁且(丐丛不东三下丕东丗:  val_22)) == false))
        {
            goto label_72;
        }
        
        val_18.set_Item(key:  val_22.Multiplier, value:  val_22);
        int val_30 = UnityEngine.Mathf.Min(a:  2147483647, b:  (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_22.DateEnd})) - PixelTime.丙丅丅业丟丁世丁丗());
        goto label_80;
        label_57:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_31 = val_12 + 24.GetEnumerator();
        label_125:
        label_116:
        if((1344678688 & 1) == 0)
        {
            goto label_101;
        }
        
        string val_32 = val_8.丐丏七丌丕丗业且上();
        if(val_32 == null)
        {
            goto label_116;
        }
        
        string val_33 = val_32 + 56;
        if((val_18.ContainsKey(key:  val_33)) != false)
        {
                if((public System.Boolean System.Collections.Generic.Dictionary<System.Int32, 世上丏丘丏丛丙万世>::ContainsKey(System.Int32 key)) == 0)
        {
            goto label_116;
        }
        
        }
        
        if(((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_15.dateData}, t2:  new System.DateTime() {dateData = val_33})) == false) || ((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_15.dateData}, t2:  new System.DateTime() {dateData = val_33})) == false))
        {
            goto label_116;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_63 = this.丝且与丝丒丟万丁专.丌万丏七与丒丂丑专;
        }
        else
        {
                val_63 = this.丝且与丝丒丟万丁专.丌万丏七与丒丂丑专;
        }
        
        if(((this.丝且与丝丒丟万丁专.丄丏七丕与业上丆丒(丐丛不东三下丕东丗:  val_32, 七丈七丂与丈丙业丕:  val_63)) == false) || ((this.丝且与丝丒丟万丁专.丈丏丅上丁丐丄丁且(丐丛不东三下丕东丗:  val_32)) == false))
        {
            goto label_116;
        }
        
        val_18.set_Item(key:  val_33, value:  val_32);
        int val_42 = UnityEngine.Mathf.Min(a:  2147483647, b:  (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_33})) - PixelTime.丙丅丅业丟丁世丁丗());
        this.丝且与丝丒丟万丁专.丗上东不业丛专丝丈(丞丅上丏丂且下丅与:  val_32.m_stringLength);
        goto label_125;
        label_101:
        val_64 = 1344678592;
        val_65 = 0;
        val_66 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || ( != 714))
        {
            goto label_143;
        }
        
        val_65 = 0;
        if(val_18 != null)
        {
            goto label_147;
        }
        
        goto label_145;
        label_143:
        if( != 0)
        {
                val_66 = 0;
        }
        
        if(val_18 != null)
        {
            goto label_147;
        }
        
        label_145:
        label_147:
        System.Collections.Generic.List<TSource> val_44 = System.Linq.Enumerable.ToList<System.Int32>(source:  val_18.Keys);
        if(val_44 != null)
        {
                val_44.Sort();
        }
        else
        {
                0.Sort();
        }
        
        val_67 = val_44.Count - 1;
        goto label_150;
        label_156:
        if(val_44 != null)
        {
                val_68 = val_44.Item[val_67];
        }
        else
        {
                val_68 = 0.Item[val_67];
        }
        
        this.丝且与丝丒丟万丁专.丄丒丌丄且丝丅丛丛.set_Item(key:  val_68, value:  val_18.Item[val_44.Item[val_67]]);
        val_67 = val_67 - 1;
        label_150:
        if((val_67 & 2147483648) == 0)
        {
            goto label_156;
        }
        
        this.丝且与丝丒丟万丁专.东丑七且丈七丐下丅();
        System.Action val_50 = null;
        val_69 = System.Void 丅且东丙业丏丛东丛::与东一不丗业丗一丝();
        val_50 = new System.Action(object:  this.丝且与丝丒丟万丁专, method:  val_69);
        UnityEngine.Coroutine val_51 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  2.147484E+09f, 丌专业且丛丏丞丝且:  val_50);
        val_70 = val_66;
        if(this.丝且与丝丒丟万丁专.丑不业丗丂丁丁三丒 == true)
        {
            goto label_162;
        }
        
        this.丝且与丝丒丟万丁专.丑不业丗丂丁丁三丒 = true;
        if(this.丝且与丝丒丟万丁专.丈丝丄丟且丏不丆专 == null)
        {
            goto label_162;
        }
        
        List.Enumerator<T> val_52 = this.丝且与丝丒丟万丁专.丈丝丄丟且丏不丆专.GetEnumerator();
        label_167:
        if((1344678664 & 1) == 0)
        {
            goto label_165;
        }
        
        this.丝且与丝丒丟万丁专.丁东丙丈丂东三丑下(丘专丈与三专丈丈专:  0.丐丏七丌丕丗业且上());
        goto label_167;
        label_165:
        val_71 = 1344678592;
        val_72 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_171;
        }
        
        if(( == 0) || ( == 912))
        {
            goto label_183;
        }
        
        label_182:
        val_69 = 0;
        label_183:
        this.丝且与丝丒丟万丁专.丈丝丄丟且丏不丆专.丂且不业丂专丛丆东();
        label_162:
        if(this.丕丈丅丐丙丈丒不丕 != false)
        {
                val_73 = null;
            val_73 = null;
            if(丅且东丙业丏丛东丛.丘丂业丘丟下丙丌丑 != 0)
        {
                丅且东丙业丏丛东丛.丘丂业丘丟下丙丌丑.Invoke();
        }
        
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_58;
        label_171:
        if( != 0)
        {
            goto label_182;
        }
        
        goto label_183;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
