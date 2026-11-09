using UnityEngine;
private sealed class BPSeasonEnd.丑世丂丆丟丛丐丏丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BPSeasonEnd 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BPSeasonEnd.丑世丂丆丟丛丐丏丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        var val_39;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_74;
        var val_77;
        var val_78;
        UILabel val_80;
        string val_81;
        var val_82;
        var val_83;
        var val_84;
        System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_86;
        var val_87;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_67 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_67;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.世不丁丌业专且与丗 = val_2;
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_20:
        System.Collections.Generic.List<Rilisoft.OfferItem> val_3 = null;
        val_68 = val_3;
        val_3 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        val_69 = this.丝且与丝丒丟万丁专 + 192.丑万丘丈业丁丟丏七();
        if(val_69 == null)
        {
            goto label_8;
        }
        
        var val_69 = 0;
        val_69 = val_69 + 1;
        val_70 = val_68;
        goto label_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._rewardsWrap.IsInitialized != false)
        {
                this.丝且与丝丒丟万丁专._rewardsWrap.ResetCells();
        }
        
        if(this.丝且与丝丒丟万丁专._possibleRewardsWrap.IsInitialized != false)
        {
                this.丝且与丝丒丟万丁专._possibleRewardsWrap.ResetCells();
        }
        
        this.丝且与丝丒丟万丁专.三丟七丑世丆且且万 = false;
        label_201:
        val_67 = 0;
        this.丝且与丝丒丟万丁专.下丈不丄七不丐丅丒 = 0;
        return (bool)val_67;
        label_4:
        mem[192] = val_2;
        if(mem[192] != 0)
        {
            goto label_20;
        }
        
        label_5:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_201;
        }
        
        goto label_201;
        label_12:
        System.Collections.Generic.IEnumerator<T> val_8 = val_69.GetEnumerator();
        label_41:
        var val_70 = 0;
        val_70 = val_70 + 1;
        if(val_8.MoveNext() == false)
        {
            goto label_28;
        }
        
        var val_71 = 0;
        val_71 = val_71 + 1;
        T val_12 = val_8.Current;
        if((val_12.Item == null) || (val_12.Item.Type == 1100))
        {
            goto label_41;
        }
        
        val_3.Add(item:  val_12.Item);
        goto label_41;
        label_28:
        val_74 = 0;
        val_69 = 0;
        val_68 = ;
        if(val_8 == null)
        {
            
        }
        else
        {
                var val_72 = 0;
            val_72 = val_72 + 1;
            val_8.Dispose();
        }
        
        if(( == 1) || (170 != 170))
        {
            goto label_57;
        }
        
        label_8:
        val_74 = 0;
        goto label_59;
        label_57:
        if( != false)
        {
                val_69 = 0;
        }
        
        label_59:
        val_77 = ;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_19 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
        if(val_19 == null)
        {
            goto label_89;
        }
        
        List.Enumerator<T> val_20 = val_19.GetEnumerator();
        label_78:
        if(((-286558304) & 1) == 0)
        {
            goto label_64;
        }
        
        string val_23 = val_22.丐丏七丌丕丗业且上();
        if(0 == 0)
        {
            goto label_78;
        }
        
        List.Enumerator<T> val_24 = 0.GetEnumerator();
        label_70:
        if(((-286558336) & 1) == 0)
        {
            goto label_67;
        }
        
        string val_25 = val_22.丐丏七丌丕丗业且上();
        if(val_25 == null)
        {
            goto label_70;
        }
        
        val_3.Add(item:  val_25);
        goto label_70;
        label_67:
        var val_73 = val_77;
        val_73 = val_73 + 1;
        mem2[0] = 277;
        val_78 = val_69;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_75 = val_73;
        if((val_75 == 1) || ((1152921560154863424 + ((val_77 + 1)) << 2) != 277))
        {
            goto label_75;
        }
        
        var val_74 = 0;
        val_74 = val_74 ^ (val_75 >> 31);
        val_75 = val_75 + val_74;
        goto label_78;
        label_75:
        if( == 0)
        {
            goto label_78;
        }
        
        goto label_78;
        label_64:
        val_77 = val_77 + 1;
        mem2[0] = 302;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_77 == 1) || ((1152921560154863424 + ((val_77 + 1)) << 2) != 302))
        {
            goto label_86;
        }
        
        var val_76 = 0;
        val_76 = val_76 ^ (val_77 >> 31);
        val_77 = val_77 + val_76;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_90;
        }
        
        goto label_88;
        label_86:
        if( != 0)
        {
                val_69 = 0;
        }
        
        label_89:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_90;
        }
        
        label_88:
        label_90:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.丝且与丝丒丟万丁专._levelLabels, 丕丗丘丑丛与丑业丒:  this.丝且与丝丒丟万丁专 + 192.业丈丅丂且丁与丄丂().ToString());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buyPremButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buyLevelButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintLabelBig.gameObject, 丏业丟一东丂东丘丛:  false);
        if((this.丝且与丝丒丟万丁专 + 192.专丟专一丒且丘与丌()) == 0)
        {
            goto label_98;
        }
        
        if((this.丝且与丝丒丟万丁专 + 192.丐丞上丒七丞丁丙丕()) == false)
        {
            goto label_100;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintLabelBig.gameObject, 丏业丟一东丂东丘丛:  true);
        val_80 = this.丝且与丝丒丟万丁专._hintLabelBig;
        val_81 = "Key_6601";
        goto label_112;
        label_98:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buyPremButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintLabel.gameObject, 丏业丟一东丂东丘丛:  true);
        val_80 = this.丝且与丝丒丟万丁专._hintLabel;
        val_81 = "Key_6179";
        goto label_112;
        label_100:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buyLevelButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._hintLabelBig.gameObject, 丏业丟一东丂东丘丛:  true);
        val_80 = this.丝且与丝丒丟万丁专._hintLabelBig;
        val_81 = "Key_6604";
        label_112:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_80, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_81));
        this.丝且与丝丒丟万丁专.丂丑丆丏丝丈丂东丙 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
        List.Enumerator<T> val_37 = val_3.GetEnumerator();
        label_125:
        if(((-286558336) & 1) == 0)
        {
            goto label_119;
        }
        
        string val_40 = val_39.丐丏七丌丕丗业且上();
        if(((val_40 == null) || (val_40.Type == 1100)) || (val_40.Type == 1090))
        {
            goto label_125;
        }
        
        new PGCompany.BattlePass.BPReward() = new PGCompany.BattlePass.BPReward(上丌丆丁丟上下专丁:  0, 丏世丞丅丁丄丁万丑:  1, 下丅丙一丂丗丅丝七:  val_40, 专丞不万丄业下丞三:  false);
        this.丝且与丝丒丟万丁专.丂丑丆丏丝丈丂东丙.Add(item:  new PGCompany.BattlePass.BPReward());
        goto label_125;
        label_119:
        val_82 = val_77 + 1;
        mem2[0] = 711;
        val_83 = 1152921505284374528;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_134;
        }
        
        if(( == 0) || ((1152921560154863424 + ((val_77 + 1)) << 2) == 711))
        {
            goto label_147;
        }
        
        label_146:
        label_147:
        val_84 = null;
        val_84 = null;
        val_86 = BPSeasonEnd.<>c.<>9__42_1;
        if(val_86 == null)
        {
                System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_47 = null;
            val_86 = val_47;
            val_47 = new System.Func<PGCompany.BattlePass.BPReward, System.Int32>(object:  BPSeasonEnd.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BPSeasonEnd.<>c::一不丂丝丝与丅东丑(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
            BPSeasonEnd.<>c.<>9__42_1 = val_86;
        }
        
        System.Collections.Generic.List<TSource> val_49 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.BattlePass.BPReward, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  this.丝且与丝丒丟万丁专 + 192.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  false), predicate:  new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  this.丝且与丝丒丟万丁专, method:  System.Boolean PGCompany.BattlePass.BPSeasonEnd::七专丛丅业丈七下丒(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛))), keySelector:  val_47));
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_144;
        }
        
        val_87 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.丏丞丄丙丙丟丌七一 = val_49;
        mem2[0] = PGCompany.BattlePass.上丕丁专三丗丝万丆.丒不丂一丑丘丄业丁(上业丟世三与七七三:  val_49);
        goto label_145;
        label_134:
        if( != 0)
        {
            goto label_146;
        }
        
        goto label_147;
        label_144:
        val_87 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.丏丞丄丙丙丟丌七一 = val_49;
        mem2[0] = PGCompany.BattlePass.上丕丁专三丗丝万丆.丒不丂一丑丘丄业丁(上业丟世三与七七三:  this.丝且与丝丒丟万丁专 + 208);
        label_145:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._freeShield, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._freeShieldNoRewards, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._paidShield, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._paidShieldNoRewards, 丏业丟一东丂东丘丛:  false);
        int val_53 = this.丝且与丝丒丟万丁专.丂丑丆丏丝丈丂东丙.Count;
        if((this.丝且与丝丒丟万丁专 + 192.专丟专一丒且丘与丌()) != 100)
        {
            goto label_152;
        }
        
        if(val_53 == 0)
        {
                if((this.丝且与丝丒丟万丁专 + 208.Count) == 0)
        {
            goto label_155;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.丂丑丆丏丝丈丂东丙.Count == 0)
        {
            goto label_157;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._paidShield, 丏业丟一东丂东丘丛:  true);
        if((this.丝且与丝丒丟万丁专 + 208.Count) != 0)
        {
            goto label_174;
        }
        
        if(this.丝且与丝丒丟万丁专._topBlockContainer != null)
        {
            goto label_211;
        }
        
        label_212:
        label_211:
        UnityEngine.Transform val_57 = this.丝且与丝丒丟万丁专._topBlockContainer.transform;
        val_57.SetParent(p:  this.丝且与丝丒丟万丁专._rewardsNoPossiblePosition);
        UnityEngine.Vector3 val_58 = UnityEngine.Vector3.zero;
        val_57.localPosition = new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z};
        goto label_174;
        label_152:
        if(val_53 == 0)
        {
            goto label_168;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._freeShield, 丏业丟一东丂东丘丛:  true);
        goto label_174;
        label_168:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._freeShieldNoRewards, 丏业丟一东丂东丘丛:  true);
        goto label_174;
        label_157:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._paidShieldNoRewards, 丏业丟一东丂东丘丛:  true);
        if((this.丝且与丝丒丟万丁专 + 208.Count) == 0)
        {
            goto label_178;
        }
        
        label_174:
        if((this.丝且与丝丒丟万丁专 + 208.Count) >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._possibleRewardsContainer, 丏业丟一东丂东丘丛:  true);
        }
        
        label_210:
        if(this.丝且与丝丒丟万丁专.丂丑丆丏丝丈丂东丙.Count >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._rewardsContainer, 丏业丟一东丂东丘丛:  true);
            this.丝且与丝丒丟万丁专._rewardsWrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BPSeasonEnd::一世丞不下丝专丑丝()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丛丕丄丄世七丘丐丏(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)));
            this.丝且与丝丒丟万丁专._rewardsWrap.UpdateVisibleCells();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._rewardsContainer, 丏业丟一东丂东丘丛:  false);
        }
        
        if((this.丝且与丝丒丟万丁专 + 208.Count) >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._possibleRewardsContainer, 丏业丟一东丂东丘丛:  true);
            this.丝且与丝丒丟万丁专._possibleRewardsWrap.Initialize(下丛一丂不丕东万丐:  new System.Func<System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 PGCompany.BattlePass.BPSeasonEnd::一世丁上丌三三专丄()), 丆丄丟东专与且丂业:  new System.Action<UnityEngine.GameObject, System.Int32>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::一业丆下丞丘七三世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)));
            this.丝且与丝丒丟万丁专._possibleRewardsWrap.UpdateVisibleCells();
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._possibleRewardsContainer, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丝且与丝丒丟万丁专.三丟七丑世丆且且万 == false)
        {
            goto label_201;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_67;
        label_155:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._paidShieldNoRewards, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Transform val_67 = this.丝且与丝丒丟万丁专._paidShieldNoRewards.transform;
        val_67.SetParent(p:  this.丝且与丝丒丟万丁专._rewardsNoPossiblePosition);
        UnityEngine.Vector3 val_68 = UnityEngine.Vector3.zero;
        val_67.localPosition = new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z};
        goto label_210;
        label_178:
        if(this.丝且与丝丒丟万丁专._paidShieldNoRewards != null)
        {
            goto label_211;
        }
        
        goto label_212;
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
