using UnityEngine;
private sealed class ClanWarUIRewardsAnimator.三且且世丁丄丂丑丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanWarUIRewardsAnimator 丝且与丝丒丟万丁专;
    public System.Collections.Generic.Dictionary<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 上业丟世三与七七三;
    private PGCompany.ClanWarUIRewardsAnimator.三丅丞丒丕丅专一丅 丄丌丂东丘丗一万且;
    public bool 且丑丞与七丂且万万;
    private int 丕丌丐丅一与上丙丘;
    private float 丈丟东丑丝一丒不丟;
    private UnityEngine.WaitForSeconds 业一丌且丅下业丕丏;
    private float 丁下丐不丏专专一三;
    private System.Collections.Generic.Dictionary.Enumerator<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 丑丅丞不不丏上丄丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarUIRewardsAnimator.三且且世丁丄丂丑丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_12;
        var val_24;
        var val_30;
        var val_31;
        Dictionary.Enumerator<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> val_32;
        var val_44;
        var val_70;
        PGCompany.ClanWarUIRewardsAnimator val_71;
        ClanWarUIRewardsAnimator.三丅丞丒丕丅专一丅 val_72;
        System.Action val_73;
        var val_74;
        System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>>, System.Int32> val_76;
        var val_80;
        Dictionary.Enumerator<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        string val_88;
        ParticleAtraktor val_89;
        var val_90;
        UnityEngine.GameObject val_91;
        ParticleAtraktor val_92;
        var val_94;
        val_71 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_221;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_69 = this.丝且与丝丒丟万丁专._emitDelay;
        val_69 = this.丁下丐不丏专专一三 + val_69;
        this.丁下丐不丏专专一三 = val_69;
        label_150:
        val_72 = this.丄丌丂东丘丗一万且;
        if(this.丄丌丂东丘丗一万且.丝丅世万一丁七丄丝 < this.丕丌丐丅一与上丙丘)
        {
                if(this.丁下丐不丏专专一三 < 0)
        {
            goto label_7;
        }
        
        }
        
        if(this.且丑丞与七丂且万万 == false)
        {
            goto label_221;
        }
        
        val_73 = this.丝且与丝丒丟万丁专.丐七丘丟世丐东丛丅;
        if(val_73 == null)
        {
                return (bool)val_73;
        }
        
        val_73.Invoke();
        goto label_221;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        new ClanWarUIRewardsAnimator.三丅丞丒丕丅专一丅() = new System.Object();
        this.丄丌丂东丘丗一万且 = new ClanWarUIRewardsAnimator.三丅丞丒丕丅专一丅();
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this.丄丌丂东丘丗一万且.丝丅世万一丁七丄丝 = 0;
        val_74 = null;
        val_74 = null;
        val_76 = ClanWarUIRewardsAnimator.<>c.<>9__17_0;
        if(val_76 == null)
        {
                val_76 = null;
            val_76 = new System.Func<System.Collections.Generic.KeyValuePair<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>>, System.Int32>(object:  ClanWarUIRewardsAnimator.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanWarUIRewardsAnimator.<>c::丒丁丘丈丕不丐业丐(System.Collections.Generic.KeyValuePair<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>> 三丟东丕丄丄下下丑));
            ClanWarUIRewardsAnimator.<>c.<>9__17_0 = val_76;
        }
        
        this.丕丌丐丅一与上丙丘 = System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<DiscreteVector2, System.Collections.Generic.List<Rilisoft.OfferItem>>>(source:  this.上业丟世三与七七三, selector:  null);
        float val_70 = this.丝且与丝丒丟万丁专._emitDelay;
        val_70 = val_70 * (float)this.上业丟世三与七七三.Count;
        val_70 = val_70 + 1f;
        this.丈丟东丑丝一丒不丟 = val_70;
        this.丄丌丂东丘丗一万且.万丈丞上丌丏丞丗丐 = ClanWarUI.丑七不且上丗丁一世().世丙世丄丗七下下世().丒丙世东丒业且且东().丏三世七东丒万丕丅();
        Dictionary.Enumerator<TKey, TValue> val_9 = this.上业丟世三与七七三.GetEnumerator();
        label_50:
        if(((-1890896304) & 1) == 0)
        {
            goto label_27;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_12.GetAwaiter();
        if(((ClanWarMap.丑七不且上丗丁一世().丟与丅东丁丗丆专一().ContainsKey(key:  new DiscreteVector2() {_x = val_13._value._obj.丐丏七丌丕丗业且上(), _y = val_13._value._obj.丐丏七丌丕丗业且上()})) == false) || (val_13._value._obj == 0))
        {
            goto label_50;
        }
        
        不上丌世万丁丝丏丆 val_21 = ClanWarMap.丑七不且上丗丁一世().丟与丅东丁丗丆专一().Item[new DiscreteVector2() {_x = val_13._value._obj.丐丏七丌丕丗业且上(), _y = val_13._value._obj.丐丏七丌丕丗业且上()}];
        List.Enumerator<T> val_22 = val_13._value._obj.GetEnumerator();
        goto label_37;
        label_40:
        string val_25 = val_24.丐丏七丌丕丗业且上();
        if(val_25.Type == 1220)
        {
                this.丄丌丂东丘丗一万且.万丈丞上丌丏丞丗丐 = val_25.Count + this.丄丌丂东丘丗一万且.万丈丞上丌丏丞丗丐;
            val_70 = ;
        }
        
        label_37:
        if(((-1890896352) & 1) != 0)
        {
            goto label_40;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 == 1) || (372 != 372))
        {
            goto label_47;
        }
        
        goto label_50;
        label_47:
        if(val_24 == 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_2:
        val_80;
        val_81 = this.丑丅丞不不丏上丄丅;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_51;
        label_7:
        val_73 = 1;
        this.丗丏丅丕丆世丁专丟 = 2;
        this.丒上七丌业七丟与丐 = this.业一丌且丅下业丕丏;
        return (bool)val_73;
        label_27:
        var val_71 = 0;
        val_82 = 0;
        val_83 = 1152921536823340480;
        val_84 = 0;
        val_71 = val_71 + 1;
        mem2[0] = 400;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_73 = val_71;
        if((val_73 != 1) && ((1152921554255557920 + ((0 + 1)) << 2) == 400))
        {
                var val_72 = 0;
            val_72 = val_72 ^ (val_73 >> 31);
            val_73 = val_73 + val_72;
        }
        else
        {
                if( != 0)
        {
                val_82 = 0;
            val_84 = 0;
        }
        else
        {
                val_82 = 0;
        }
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_29 = this.上业丟世三与七七三.GetEnumerator();
        val_80;
        val_81 = this.丑丅丞不不丏上丄丅;
        mem[1152921554255570504] = val_30;
        mem[1152921554255570488] = val_31;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丑丅丞不不丏上丄丅 = val_32;
        label_51:
        label_91:
        if((val_81 & 1) == 0)
        {
            goto label_87;
        }
        
        ConfiguredValueTaskAwaiter val_33 = val_81.GetAwaiter();
        if(((ClanWarMap.丑七不且上丗丁一世().丟与丅东丁丗丆专一().ContainsKey(key:  new DiscreteVector2() {_x = val_33._value._obj.丐丏七丌丕丗业且上(), _y = val_33._value._obj.丐丏七丌丕丗业且上()})) == false) || (val_33._value._obj == 0))
        {
            goto label_91;
        }
        
        List.Enumerator<T> val_42 = val_33._value._obj.GetEnumerator();
        label_148:
        if(((-1890896352) & 1) == 0)
        {
            goto label_95;
        }
        
        new ClanWarUIRewardsAnimator.丐丟三丐丈丙且且专() = new System.Object();
        .东丟且丗且三专丙丁 = this.丄丌丂东丘丗一万且;
        .下丅丙一丂丗丅丝七 = val_44.丐丏七丌丕丗业且上();
        new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() = new System.Object();
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
                val_85 = new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上();
            .丕丅丏丁丅东且七丌 = new ClanWarUIRewardsAnimator.丐丟三丐丈丙且且专();
            val_86 = 1152921554255749872;
            mem[1152921554255749864] = 0;
        }
        else
        {
                mem[32] = new ClanWarUIRewardsAnimator.丐丟三丐丈丙且且专();
            mem[24] = 0;
            val_86 = 24;
            val_85 = 32;
        }
        
        Rilisoft.OfferItemType val_48 = .下丅丙一丂丗丅丝七.Type;
        if(val_48 == 1200)
        {
            goto label_101;
        }
        
        if(val_48 != 1220)
        {
            goto label_115;
        }
        
        ClanWarUI val_49 = ClanWarUI.丑七不且上丗丁一世();
        if(val_49 == null)
        {
            goto label_107;
        }
        
        ClanWarRatingListUI val_51 = (val_49 == 0) ? 0 : (val_49).世丙世丄丗七下下世();
        if(val_51 == null)
        {
            goto label_107;
        }
        
        ClanWarRatingUI val_53 = (val_51 == 0) ? 0 : (val_51).丒丙世东丒业且且东();
        if(val_53 == null)
        {
            goto label_109;
        }
        
        val_87 = (val_53 == 0) ? 0 : (val_53).transform;
        goto label_111;
        label_101:
        if((System.String.op_Equality(a:  .下丅丙一丂丗丅丝七.Id, b:  "ClanSilver")) == false)
        {
            goto label_115;
        }
        
        val_87 = mem[this.丝且与丝丒丟万丁专 + 88];
        val_87 = this.丝且与丝丒丟万丁专 + 88;
        val_88 = "cw-tribute-reward-silver";
        goto label_118;
        label_115:
        val_87 = 0;
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
            goto label_124;
        }
        
        goto label_120;
        label_107:
        val_87 = 0;
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
            goto label_123;
        }
        
        goto label_122;
        label_109:
        val_87 = 0;
        label_111:
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
            goto label_123;
        }
        
        label_122:
        label_123:
        val_88 = "cw-tribute-reward-shields";
        label_118:
        mem[24] = val_88;
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
            goto label_124;
        }
        
        label_120:
        label_124:
        val_89 = val_71.七丒东丒上丂丘丁上(丞丅上丏丂且下丅与:  mem[24]);
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
                val_90 = new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上();
            .丐丘业丂丙丞三不七 = val_89;
        }
        else
        {
                mem[16] = val_89;
            val_89 = mem[16];
            val_90 = 16;
        }
        
        new System.Action() = new System.Action(object:  new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上(), method:  System.Void ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上::上三丗丌丕丆丂不丛());
        val_89.丛丐丐丄七上七丝与(丙业与丙丗丝不丈东:  new System.Action());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_90.transform.parent, 丏业丟一东丂东丘丛:  true);
        PGCompany.UI.BindedUI val_62 = mem[16].GetComponent<PGCompany.UI.BindedUI>();
        PGCompany.ClanWarTile val_63 = ClanWarMap.丑七不且上丗丁一世().丟与丅东丁丗丆专一().Item[new DiscreteVector2() {_x = val_33._value._obj.丐丏七丌丕丗业且上(), _y = val_33._value._obj.丐丏七丌丕丗业且上()}].丑丕丞三三世丑丅丝();
        if(val_63 != null)
        {
                val_91 = (val_63 == 0) ? 0 : (val_63).gameObject;
        }
        else
        {
                val_91 = 0;
        }
        
        val_62.Target = val_91;
        mem2[0] = val_87;
        if(new ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上() != null)
        {
                val_92 = mem[16];
        }
        else
        {
                val_92 = mem[16];
        }
        
        val_92.GiveReward(丌丒丝东丌下丕丁丅:  .下丅丙一丂丗丅丝七.Count);
        goto label_148;
        label_87:
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专 + 96);
        this.业一丌且丅下业丕丏 = new UnityEngine.WaitForSeconds();
        this.丁下丐不丏专专一三 = 0f;
        goto label_150;
        label_95:
        var val_74 = val_73;
        val_72 = val_82;
        val_94 = ;
        val_74 = val_74 + 1;
        mem2[0] = 908;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_74 == 1)
        {
            goto label_200;
        }
        
        if( == 0)
        {
            goto label_204;
        }
        
        if((val_80 + ((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1)) << 2) != 908)
        {
            goto label_202;
        }
        
        goto label_204;
        label_200:
        if( == 0)
        {
            goto label_204;
        }
        
        label_202:
        label_204:
        new UnityEngine.WaitForSeconds() = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专 + 96);
        val_73 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds();
        this.丗丏丅丕丆世丁专丟 = val_73;
        return (bool)val_73;
        label_221:
        val_73 = 0;
        return (bool)val_73;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.丑丅丞不不丏上丄丅);
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
