using UnityEngine;
private sealed class AdaptiveAutoAimController.专丐与下丘丗丑丄专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.AdaptiveAutoAimController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AdaptiveAutoAimController.专丐与下丘丗丑丄专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_16;
        PGCompany.下三三丈与丁丈丒丛 val_25;
        System.Collections.Generic.IEnumerable<TSource> val_26;
        System.Collections.Generic.IEnumerable<TSource> val_27;
        var val_36;
        var val_41;
        var val_49;
        var val_57;
        var val_62;
        var val_68;
        var val_77;
        PGCompany.AdaptiveAutoAimController val_88;
        var val_89;
        double val_90;
        var val_91;
        int val_92;
        var val_93;
        var val_94;
        var val_95;
        System.Func<丆丑丑丞三世丁不丂, System.Int32> val_97;
        var val_98;
        System.Func<不三丂丁东丏丛丅业, System.Decimal> val_100;
        System.Collections.Generic.List<TSource> val_101;
        var val_102;
        var val_103;
        var val_105;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_89 = 1152921505243639808;
        val_88 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
            goto label_4;
        }
        
        if((this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 == null) || (PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世().丄丙丙丑丝专世上丌() == false))
        {
            goto label_8;
        }
        
        val_88.世丝丐七丕世丈丒丌();
        System.DateTime val_4 = System.DateTime.UtcNow;
        val_90 = (double)-(System.Math.Max(val1:  1, val2:  this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.MaxPayStepTime));
        System.DateTime val_7 = val_4.dateData.AddSeconds(value:  val_90);
        System.Collections.Generic.Dictionary<System.DateTime, System.Decimal> val_9 = PGCompany.丗丝万丏世丛丈丏丕.丑七不且上丗丁一世().一丑丛上一丏丟丛丕(世丘一东世丛丕丑七:  new System.DateTime() {dateData = val_7.dateData}, 丈丝世且万世丈丌万:  new System.DateTime() {dateData = val_4.dateData});
        if(val_9 == null)
        {
            goto label_17;
        }
        
        val_91 = val_9.Count;
        goto label_18;
        label_4:
        val_92 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_92;
        return (bool)val_92;
        label_17:
        val_91 = 0.Count;
        label_18:
        if(val_9.Count >= 1)
        {
                System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal> val_14 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.DateTime, System.Decimal>>(source:  val_9);
            val_90 = 0f;
            float val_20 = UnityEngine.Mathf.Max(a:  val_90, b:  (float)PixelTime.丝丗专上三不丄丑丑() - (专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {dateData = val_16.丐丏七丌丕丗业且上()})));
        }
        
        float val_21 = val_88.七丒丗业丆丏业业丕();
        val_88.且丞丑丂丟丗丐丗下(丙业与丙丗丝不丈东:  0);
        val_88.丗丙且丒丌丐业不丂(丙业与丙丗丝不丈东:  0);
        List.Enumerator<T> val_22 = this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.Properties.GetEnumerator();
        val_93 = 1152921556177580032;
        val_94 = 1152921556177581056;
        goto label_30;
        label_90:
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_24 = val_16.RemoteEndpoint;
        this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.set_Item(key:  val_25, value:  0f);
        val_95 = null;
        val_95 = null;
        val_97 = AdaptiveAutoAimController.<>c.<>9__30_0;
        if(val_97 == null)
        {
                val_97 = null;
            val_97 = new System.Func<丆丑丑丞三世丁不丂, System.Int32>(object:  AdaptiveAutoAimController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AdaptiveAutoAimController.<>c::丆丒丌丗丝世七丘丒(PGCompany.AdaptiveAutoAimConfig.丆丑丑丞三世丁不丂 三丟东丕丄丄下下丑));
            AdaptiveAutoAimController.<>c.<>9__30_0 = val_97;
        }
        
        System.Collections.Generic.List<TSource> val_30 = System.Linq.Enumerable.ToList<丆丑丑丞三世丁不丂>(source:  System.Linq.Enumerable.OrderBy<丆丑丑丞三世丁不丂, System.Int32>(source:  val_26, keySelector:  null));
        val_98 = null;
        val_98 = null;
        val_100 = AdaptiveAutoAimController.<>c.<>9__30_1;
        if(val_100 == null)
        {
                val_100 = null;
            val_100 = new System.Func<不三丂丁东丏丛丅业, System.Decimal>(object:  AdaptiveAutoAimController.<>c.__il2cppRuntimeField_static_fields, method:  System.Decimal AdaptiveAutoAimController.<>c::业丅丏东业专丏丝专(PGCompany.AdaptiveAutoAimConfig.不三丂丁东丏丛丅业 三丟东丕丄丄下下丑));
            AdaptiveAutoAimController.<>c.<>9__30_1 = val_100;
        }
        
        val_101 = System.Linq.Enumerable.ToList<不三丂丁东丏丛丅业>(source:  System.Linq.Enumerable.OrderBy<不三丂丁东丏丛丅业, System.Decimal>(source:  val_27, keySelector:  null));
        val_102 = 1152921556177635264;
        if(val_91 < 1)
        {
            goto label_43;
        }
        
        val_103 = 0;
        goto label_44;
        label_60:
        if(val_103 == 0)
        {
            goto label_45;
        }
        
        if(val_91 < 1)
        {
            goto label_52;
        }
        
        丆丑丑丞三世丁不丂 val_34 = val_30.Item[-1];
        if(val_36.丅丕丁与丆丆丑丆丝() >= 0)
        {
            goto label_52;
        }
        
        丆丑丑丞三世丁不丂 val_39 = val_30.Item[0];
        int val_43 = val_41.丅丕丁与丆丆丑丆丝();
        goto label_50;
        label_45:
        丆丑丑丞三世丁不丂 val_44 = val_30.Item[0];
        label_50:
        if(0 <= val_16.丅丕丁与丆丆丑丆丝())
        {
                丆丑丑丞三世丁不丂 val_47 = val_30.Item[0];
            decimal val_51 = val_49.丅丕丁与丆丆丑丆丝();
            float val_52 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_51.flags, hi = val_51.hi, lo = val_51.lo, mid = val_51.mid});
            val_52 = this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.Item[val_25] + val_52;
            this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.set_Item(key:  val_25, value:  val_52);
            val_88.且丞丑丂丟丗丐丗下(丙业与丙丗丝不丈东:  1);
            val_91 = val_91;
            val_93 = val_93;
            val_94 = val_94;
            val_102 = 1152921556177635264;
        }
        
        label_52:
        val_101 = val_101;
        val_103 = 1;
        label_44:
        int val_53 = val_30.Count;
        if(val_103 < val_53)
        {
            goto label_60;
        }
        
        label_43:
        val_89 = 0;
        goto label_61;
        label_89:
        if(val_89 == 0)
        {
            goto label_62;
        }
        
        if(val_103 < val_53)
        {
            goto label_67;
        }
        
        不三丂丁东丏丛丅业 val_54 = val_101.Item[-1];
        decimal val_58 = val_57.丅丕丁与丆丆丑丆丝();
        val_101 = val_101;
        if((System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_58.flags, hi = val_58.hi, lo = val_58.lo, mid = val_58.mid})) >= 0)
        {
            goto label_67;
        }
        
        不三丂丁东丏丛丅业 val_60 = val_101.Item[0];
        decimal val_64 = val_62.丅丕丁与丆丆丑丆丝();
        float val_65 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_64.flags, hi = val_64.hi, lo = val_64.lo, mid = val_64.mid});
        goto label_71;
        label_62:
        不三丂丁东丏丛丅业 val_66 = val_101.Item[0];
        decimal val_70 = val_68.丅丕丁与丆丆丑丆丝();
        label_71:
        val_101 = val_101;
        if(val_21 <= (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_70.flags, hi = val_70.hi, lo = val_70.lo, mid = val_70.mid})))
        {
            goto label_75;
        }
        
        label_67:
        if(val_89 != (val_101.Count - 1))
        {
            goto label_81;
        }
        
        不三丂丁东丏丛丅业 val_74 = val_101.Item[0];
        decimal val_78 = val_77.丅丕丁与丆丆丑丆丝();
        val_101 = val_101;
        if(val_21 <= (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_78.flags, hi = val_78.hi, lo = val_78.lo, mid = val_78.mid})))
        {
            goto label_81;
        }
        
        label_75:
        不三丂丁东丏丛丅业 val_81 = val_101.Item[0];
        float val_85 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 31258928, hi = 268435468});
        val_85 = this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.Item[val_25] + val_85;
        this.丝且与丝丒丟万丁专.世丂丁且丁丂丐与丁.set_Item(key:  val_25, value:  val_85);
        val_88.丗丙且丒丌丐业不丂(丙业与丙丗丝不丈东:  1);
        val_101 = val_101;
        label_81:
        val_89 = 1;
        label_61:
        if(val_89 < val_101.Count)
        {
            goto label_89;
        }
        
        label_30:
        if((31259024 & 1) != 0)
        {
            goto label_90;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_88 = 1152921505647845376;
        val_105 = null;
        val_105 = null;
        val_92 = PGCompany.AdaptiveAutoAimController.丂丛丗丏丟丁三万不;
        if(val_92 == null)
        {
                return (bool)val_92;
        }
        
        val_92.Invoke();
        label_8:
        val_92 = 0;
        return (bool)val_92;
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
