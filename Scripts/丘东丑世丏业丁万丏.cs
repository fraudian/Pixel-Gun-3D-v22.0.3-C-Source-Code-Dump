using UnityEngine;
private sealed class 且丐丝七丅一丟丕丈.丘东丑世丏业丁万丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.Marathon.且丐丝七丅一丟丕丈 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且丐丝七丅一丟丕丈.丘东丑世丏业丁万丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        PGCompany.Marathon.且丐丝七丅一丟丕丈 val_52;
        System.Comparison<T> val_53;
        int val_54;
        var val_56;
        PGCompany.DataObjects.丟业专丘七丐丗且丌 val_57;
        var val_58;
        var val_59;
        var val_61;
        var val_62;
        var val_63;
        IntPtr val_64;
        var val_65;
        PGCompany.东丑丒丗一丞下丙丙<T> val_66;
        var val_67;
        var val_68;
        var val_69;
        int val_70;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_54;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_52 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝业丁丌丘东丏世与() == false)
        {
            goto label_4;
        }
        
        PGCompany.Marathon.一丐丁丐丈丑丑且不 val_2 = new PGCompany.Marathon.一丐丁丐丈丑丑且不();
        if(val_52 == null)
        {
            goto label_5;
        }
        
        val_53 = val_52;
        this.丝且与丝丒丟万丁专.丒丈丈丗丝丐丛丛丕 = 0;
        mem2[0] = val_2;
        goto label_6;
        label_4:
        val_54 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_54;
        return (bool)val_54;
        label_5:
        mem[24] = val_2;
        val_53 = 40;
        mem[40] = 0;
        label_6:
        if(val_52.丏丁专丂上且丗丘丈() == false)
        {
            goto label_54;
        }
        
        PGCompany.Marathon.业丏丏丏丞且丘下与 val_4 = 0.业丑丁丆丕丆丂丅万();
        if(val_4.Initialized <= 0)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄世丕东一丕丏业丒();
        }
        
        var val_51 = 0;
        val_51 = val_51 + 1;
        val_56 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_8, typeof(public PGCompany.DataObjects.丟业专丘七丐丗且丌 DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<PGCompany.DataObjects.丟业专丘七丐丗且丌>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
        val_57 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_52 == null)
        {
            goto label_23;
        }
        
        val_58 = val_52;
        this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 = val_57;
        if(val_57 == null)
        {
            goto label_24;
        }
        
        label_51:
        if(val_52 == null)
        {
                val_59 = mem[this.丝且与丝丒丟万丁专 + 16];
            val_59 = this.丝且与丝丒丟万丁专 + 16;
            if(val_59 == 0)
        {
            goto label_60;
        }
        
        }
        
        if(((this.丝且与丝丒丟万丁专 + 16 + 24) == 0) || ((System.Linq.Enumerable.Any<丙丕丈一一丝丑七丈>(source:  this.丝且与丝丒丟万丁专 + 16 + 24)) == false))
        {
            goto label_30;
        }
        
        List.Enumerator<T> val_12 = this.丝且与丝丒丟万丁专 + 16 + 24.GetEnumerator();
        val_61 = PGCompany.东丑丒丗一丞下丙丙<丈下与且下万丛丅与>.万世丅七一专丕丞不();
        label_46:
        if(((-821803616) & 1) == 0)
        {
            goto label_37;
        }
        
        string val_15 = val_14.丐丏七丌丕丗业且上();
        丈下与且下万丛丅与 val_16 = val_52.业丌丗丒丐东与万丐(与丄不丌一世东丁丙:  val_15);
        if(val_16 == null)
        {
            goto label_39;
        }
        
        val_61.Add(item:  val_16);
        goto label_46;
        label_39:
        if(val_15 != null)
        {
                string val_17 = val_15.m_stringLength.ToString();
        }
        else
        {
                val_62 = 0;
        }
        
        UnityEngine.Debug.LogError(message:  "initialization marathon fail: create reward for slot "("initialization marathon fail: create reward for slot ") + (val_62 == 0) ? "null" : (val_62)((val_62 == 0) ? "null" : (val_62)) + " fail");
        goto label_46;
        label_30:
        UnityEngine.Debug.LogError(message:  "initialization marathon fail: broken config, slots nullable or empty");
        val_54 = 0;
        mem2[0] = 0;
        return (bool)val_54;
        label_23:
        val_58 = 16;
        mem[16] = val_57;
        if(mem[16] != 0)
        {
            goto label_51;
        }
        
        label_24:
        UnityEngine.Debug.LogError(message:  "initialization marathon fail: nullable config object");
        goto label_54;
        label_37:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_62;
        label_60:
        if((PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  107)) != 1)
        {
            goto label_146;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1179403647 != 0)
        {
                val_56 = 0;
        }
        
        label_62:
        PGCompany.东丑丒丗一丞下丙丙<T> val_20 = PGCompany.东丑丒丗一丞下丙丙<丈下与且下万丛丅与>.万世丅七一专丕丞不();
        List.Enumerator<T> val_21 = val_59.GetEnumerator();
        label_78:
        if(((-821803648) & 1) == 0)
        {
            goto label_67;
        }
        
        new 且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝() = new System.Object();
        .且丘丏丁丑与丙与丁 = val_14.丐丏七丌丕丗业且上();
        System.Func<丈下与且下万丛丅与, System.Boolean> val_24 = new System.Func<丈下与且下万丛丅与, System.Boolean>(object:  new 且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝(), method:  System.Boolean 且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝::丏丄丒万丟丐丝丄丁(丈下与且下万丛丅与 七丏丄丅丌业与且丙));
        丈下与且下万丛丅与 val_25 = System.Linq.Enumerable.FirstOrDefault<丈下与且下万丛丅与>(source:  this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下, predicate:  null);
        if(val_25 == null)
        {
            goto label_70;
        }
        
        if((PGCompany.Marathon.业上丅上丘丄丟丙丘.丂丆世世丕丅丕丅上(丛三七丟丗与专丙丂:  val_25, 三丂丑丁丞丞丅东三:  (且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝)[1152921559619715584].且丘丏丁丑与丙与丁)) == true)
        {
            goto label_78;
        }
        
        bool val_27 = this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Remove(item:  val_25);
        this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Add(item:  (且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝)[1152921559619715584].且丘丏丁丑与丙与丁);
        val_20.Add(item:  (且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝)[1152921559619715584].且丘丏丁丑与丙与丁);
        goto label_78;
        label_70:
        this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Add(item:  (且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝)[1152921559619715584].且丘丏丁丑与丙与丁);
        val_20.Add(item:  (且丐丝七丅一丟丕丈.三丕业丁丗东丂七丝)[1152921559619715584].且丘丏丁丑与丙与丁);
        goto label_78;
        label_67:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_63 = 0;
        goto label_94;
        label_101:
        .丈丘丙东丒丕丂丗东 = this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Item[0];
        if((System.Linq.Enumerable.FirstOrDefault<丈下与且下万丛丅与>(source:  X26, predicate:  new System.Func<丈下与且下万丛丅与, System.Boolean>(object:  new 且丐丝七丅一丟丕丈.丄丗不丝不丄丅丄专(), method:  System.Boolean 且丐丝七丅一丟丕丈.丄丗不丝不丄丅丄专::三丕丞丄丌不三丄专(丈下与且下万丛丅与 七丏丄丅丌业与且丙)))) == null)
        {
                bool val_32 = this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Remove(item:  (且丐丝七丅一丟丕丈.丄丗不丝不丄丅丄专)[1152921559619768832].丈丘丙东丒丕丂丗东);
        }
        
        val_63 = 1;
        label_94:
        if(val_63 < this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Count)
        {
            goto label_101;
        }
        
        System.Comparison<丈下与且下万丛丅与> val_34 = null;
        val_53 = val_34;
        val_34 = new System.Comparison<丈下与且下万丛丅与>(object:  0, method:  static System.Int32 PGCompany.Marathon.且丐丝七丅一丟丕丈::丄世丑专七下上世一(丈下与且下万丛丅与 丛三七丟丗与专丙丂, 丈下与且下万丛丅与 三丂丑丁丞丞丅东三));
        val_64 = public System.Void System.Collections.Generic.List<丈下与且下万丛丅与>::Sort(System.Comparison<T> comparison);
        this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.Sort(comparison:  val_34);
        List.Enumerator<T> val_35 = this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下.GetEnumerator();
        goto label_116;
        label_119:
        string val_36 = val_14.丐丏七丌丕丗业且上();
        val_53 = val_36.与不丞丑七丘丁丂丛();
        val_64 = 0;
        if((val_53.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "current")) != false)
        {
                if(val_52 != null)
        {
                mem[40] = val_36;
        }
        else
        {
                mem[40] = val_36;
        }
        
            if(this.丝且与丝丒丟万丁专.丂七下世丟丞丆下丞 != null)
        {
                CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丝且与丝丒丟万丁专.丂七下世丟丞丆下丞);
            this.丝且与丝丒丟万丁专.丂七下世丟丞丆下丞 = 0;
        }
        
            int val_41 = mem[40].上丟丄与丁三丌丘专() - PixelTime.丝丗专上三不丄丑丑();
            if(val_41 >= 1)
        {
                val_64 = System.Void PGCompany.Marathon.且丐丝七丅一丟丕丈::上专丄丑专丑丘业丌();
            new System.Action() = new System.Action(object:  val_52, method:  val_64);
            this.丝且与丝丒丟万丁专.丂七下世丟丞丆下丞 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  (float)val_41, 丌专业且丛丏丞丝且:  new System.Action());
        }
        
        }
        
        label_116:
        val_65 = X26;
        if(((-821803648) & 1) != 0)
        {
            goto label_119;
        }
        
        val_66 = val_20;
        val_67 = 1152921559617044112;
        val_68 = 0;
        val_69 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (824 != 824))
        {
            goto label_132;
        }
        
        val_68 = 0;
        if(val_52 != null)
        {
            goto label_136;
        }
        
        goto label_134;
        label_132:
        if( != 0)
        {
                val_64 = 0;
            val_69 = 0;
        }
        
        if(val_52 != null)
        {
            goto label_136;
        }
        
        label_134:
        label_136:
        if((System.Linq.Enumerable.Any<丈下与且下万丛丅与>(source:  this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下)) != false)
        {
                val_53 = System.Linq.Enumerable.Last<丈下与且下万丛丅与>(source:  this.丝且与丝丒丟万丁专.三丒丕丙丅一与丙下);
            val_70 = val_53;
            int val_46 = val_70.三万七与东丄业丐丙();
        }
        else
        {
                val_70 = 0;
        }
        
        this.丝且与丝丒丟万丁专.一丛丘丛丝不丐丛丏 = val_70;
        List.Enumerator<T> val_47 = GetEnumerator();
        label_143:
        if(((-821803648) & 1) == 0)
        {
            goto label_141;
        }
        
        val_14.丐丏七丌丕丗业且上().专不丗丈丒丄三三丙();
        goto label_143;
        label_141:
        val_58 = 0 + 1;
        mem2[0] = 910;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_58 == 1)
        {
            goto label_147;
        }
        
        if(( == 0) || ((1152921559619618112 + ((0 + 1)) << 2) == 910))
        {
            goto label_155;
        }
        
        label_154:
        val_64 = 0;
        label_155:
        PGCompany.东丑丒丗一丞下丙丙<T> val_49 = PGCompany.东丑丒丗一丞下丙丙<丈下与且下万丛丅与>.万世丅七一专丕丞不();
        val_52 = PGCompany.东丑丒丗一丞下丙丙<丈下与且下万丛丅与>.万世丅七一专丕丞不();
        label_54:
        val_54 = 0;
        return (bool)val_54;
        label_147:
        if( != 0)
        {
            goto label_154;
        }
        
        goto label_155;
        label_146:
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
