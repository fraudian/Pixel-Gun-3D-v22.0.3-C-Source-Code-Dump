using UnityEngine;
internal sealed class VeteranChestBanner : GameEventOpenChestBase
{
    // Fields
    private System.Collections.Generic.List<VeteranChestBanner.StateSpec> _stateSpecs;
    private UnityEngine.GameObject _chestOpenTweener;
    private float _startSpinDelay;
    private UnityEngine.GameObject _progressBarObject;
    private UnityEngine.AudioClip _mainStateActiveClip;
    private UnityEngine.AudioClip _infoStateActiveClip;
    private static bool <丑与丁丆七七丂业万>k__BackingField;
    private VeteranChestBanner.丗与七丅丒丘丗丅丈 丗下丘世三七一专丕;
    private UnityEngine.Coroutine 且丛丐与丞上丌不丒;
    
    // Properties
    internal static bool 丕世丁丈丞丙上专丄 { get; set; }
    
    // Methods
    internal static bool 丕三三丐一一丟丘丂()
    {
        return (bool)VeteranChestBanner.<丑与丁丆七七丂业万>k__BackingField;
    }
    private static void 业丛且丟丏一丁丑丝(bool 丙业与丙丗丝不丈东)
    {
        VeteranChestBanner.<丑与丁丆七七丂业万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 东不丙三与丟丈东丘(Rilisoft.BankBannersHolder 七万上丐一丈丏丏专)
    {
        int val_3 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().且七丘丝且世丅上丏();
        if(七万上丐一丈丏丏专 != 0)
        {
                Rilisoft.GameEventOpenChestBase.下与丞三丅丛丄七丕(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 丐东业丕丕丂丗丅丙:  val_3, 世丁丌万丏丟丗世三:  6, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
        }
        
        Rilisoft.GameEventOpenChestBase.下与丞三丅丛丄七丕(丐东业丕丕丂丗丅丙:  val_3, 世丁丌万丏丟丗世三:  6);
    }
    public override void Show()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().且七丘丝且世丅上丏();
        if(Rilisoft.GameEventOpenChestBase.丅丟丒下丕丄丆丁业 <= 0)
        {
                UnityEngine.Debug.LogError(message:  "unknown chest");
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._chestOpenTweener, 丏业丟一东丂东丘丛:  false);
        val_5 = null;
        val_5 = null;
        Rilisoft.AbstractGameEventView.丕一不丅丗专七丗与 = false;
        Rilisoft.AbstractGameEventView.丁丒丌不专丙上丂下 = new System.Action<Rilisoft.GameEventItem>(object:  this, method:  System.Void VeteranChestBanner::丁丒丌不专丙上丂下(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七));
        this.Show();
    }
    public override void Hide()
    {
        null = null;
        Rilisoft.AbstractGameEventView.丕一不丅丗专七丗与 = true;
        Rilisoft.AbstractGameEventView.丁丒丌不专丙上丂下 = 0;
        this.Hide();
    }
    private void 丁丒丌不专丙上丂下(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七)
    {
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        PGCompany.丁七丛丑丄丄丂东世.丞上一丈丘丞三丞三(丙丈下丕丑专上丕丛:  下丅丙一丂丗丅丝七, 丆丏七丟不丒与七专:  this.transform);
    }
    protected override void 丘上丐世丆丑且丞丒()
    {
        丗与七丅丒丘丗丅丈 val_8;
        this.丘上丐世丆丑且丞丒();
        bool val_2 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().下丆一丄丅丙与丟丙();
        PGCompany.VeteranChest.丐丂丄丗业业丘下丕 val_3 = PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世();
        if(val_3 == null)
        {
            goto label_1;
        }
        
        if(val_2 == false)
        {
            goto label_2;
        }
        
        label_6:
        if(val_3.丄丛丒业丙万丅丏丌() == false)
        {
            goto label_3;
        }
        
        var val_7 = ((PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丐下专丑丕一丁丛东() & true) != 0) ? (1 + 1) : 1;
        goto label_7;
        label_1:
        if(val_2 == true)
        {
            goto label_6;
        }
        
        label_2:
        val_3.业丏丅丟丟丕丑下三();
        val_8 = 3;
        goto label_7;
        label_3:
        val_8 = 4;
        label_7:
        this.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  val_8);
    }
    protected override void 业不下业与下丛一丂()
    {
    
    }
    protected override void 丌丟丆不丄专丐不丂(bool 万丄丟丅丌万丛七三)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  90);
        this.丌丟丆不丄专丐不丂(万丄丟丅丌万丛七三:  万丄丟丅丌万丛七三);
        PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().七丏丞东丂丈不七丝(世丁丙世丄一万丆三:  9);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        VeteranChestBanner.<丑与丁丆七七丂业万>k__BackingField = true;
    }
    protected override void OnDisable()
    {
        this.且丛丐与丞上丌不丒 = 0;
        VeteranChestBanner.<丑与丁丆七七丂业万>k__BackingField = false;
        this.OnDisable();
    }
    private System.Collections.IEnumerator 丌丁丘丕专丞上丅且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VeteranChestBanner.丑不丟丅丕业且上丑();
    }
    private void 一业丝且丘丁专丆丕()
    {
        if(this.且丛丐与丞上丌不丒 != null)
        {
                return;
        }
        
        this.且丛丐与丞上丌不丒 = this.StartCoroutine(routine:  this.丌丁丘丕专丞上丅且());
    }
    private void 丗丄且丌下世上丈与(VeteranChestBanner.丗与七丅丒丘丗丅丈 与丆丌丂丟丛丘丑且)
    {
        var val_4;
        var val_13;
        VeteranChestBanner val_20;
        var val_21;
        UnityEngine.Object val_22;
        System.Func<TSource, System.Boolean> val_23;
        var val_24;
        var val_25;
        var val_26;
        .与丆丌丂丟丛丘丑且 = 与丆丌丂丟丛丘丑且;
        List.Enumerator<T> val_2 = this._stateSpecs.GetEnumerator();
        val_20 = 1152921519068956112;
        val_21 = 0;
        val_22 = 0;
        var val_19 = 0;
        label_20:
        if((592364560 & 1) == 0)
        {
            goto label_3;
        }
        
        val_23 = val_4.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<UnityEngine.GameObject>(丑东与丅丐丅丂丞业:  X24)) == true)
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_7 = val_23.GetEnumerator();
        label_12:
        if((592364528 & 1) == 0)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_12;
        label_9:
        val_19 = val_19 + 1;
        mem2[0] = 106;
        val_24 = val_22;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_19 == 1) || ((1152921539558949792 + ((0 + 1)) << 2) != 106))
        {
            goto label_17;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ (val_19 >> 31);
        val_19 = val_19 + val_20;
        goto label_20;
        label_17:
        if( == 0)
        {
            goto label_20;
        }
        
        goto label_20;
        label_3:
        val_25 = val_19 + 1;
        val_26 = 131;
        goto label_21;
        label_7:
        val_25 = val_19 + 1;
        val_26 = 284;
        label_21:
        mem2[0] = 284;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_19 == 1)
        {
            goto label_30;
        }
        
        if((1152921539558949792 + ((0 + 1)) << 2) == 284)
        {
                return;
        }
        
        if((1152921539558949792 + ((0 + 1)) << 2) != 131)
        {
            goto label_30;
        }
        
        var val_21 = 0;
        val_21 = val_21 ^ (val_19 >> 31);
        val_25 = val_19 + val_21;
        goto label_32;
        label_30:
        if( != 0)
        {
                val_22 = 0;
        }
        
        label_32:
        System.Func<StateSpec, System.Boolean> val_9 = null;
        val_23 = val_9;
        val_9 = new System.Func<StateSpec, System.Boolean>(object:  new VeteranChestBanner.丄丆丌丌丕丈丆丆业(), method:  System.Boolean VeteranChestBanner.丄丆丌丌丕丈丆丆业::上下不一东丂丟丐丌(VeteranChestBanner.StateSpec 丏丛与丅丛丌万专丌));
        if(((System.Linq.Enumerable.FirstOrDefault<StateSpec>(source:  this._stateSpecs, predicate:  val_9)) == null) || (val_10.EnabledObjects == null))
        {
            goto label_56;
        }
        
        List.Enumerator<T> val_11 = val_10.EnabledObjects.GetEnumerator();
        label_38:
        if((592364528 & 1) == 0)
        {
            goto label_35;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  true);
        goto label_38;
        label_35:
        val_19 = val_19 + 1;
        mem2[0] = 222;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_19 == 1)
        {
            goto label_42;
        }
        
        if(( == 0) || ((1152921539558949792 + (((0 + 1) + 1)) << 2) == 222))
        {
            goto label_56;
        }
        
        label_55:
        label_56:
        val_20 = this;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_22 = mem[(VeteranChestBanner.丄丆丌丌丕丈丆丆业)[1152921539558998128].与丆丌丂丟丛丘丑且 == 0x3 ? 1152921539558962472 : 1152921539558962464];
            val_22 = ((VeteranChestBanner.丄丆丌丌丕丈丆丆业)[1152921539558998128].与丆丌丂丟丛丘丑且 == 3) ? 1152921539558962472 : 1152921539558962464;
            if(val_22 != 0)
        {
                UnityEngine.AudioSource val_18 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_22);
        }
        
        }
        
        mem[1152921539558962480] = (VeteranChestBanner.丄丆丌丌丕丈丆丆业)[1152921539558998128].与丆丌丂丟丛丘丑且;
        return;
        label_42:
        if( != 0)
        {
            goto label_55;
        }
        
        goto label_56;
    }
    private void 上丘一世丑一丌丙与()
    {
        丗与七丅丒丘丗丅丈 val_6;
        if(PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丄丛丒业丙万丅丏丌() != false)
        {
                var val_5 = ((PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丐下专丑丕一丁丛东() & true) != 0) ? (1 + 1) : 1;
        }
        else
        {
                val_6 = 4;
        }
        
        this.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  val_6);
    }
    public void U_Spin()
    {
        this.一业丝且丘丁专丆丕();
    }
    public void U_Back()
    {
        goto typeof(VeteranChestBanner).__il2cppRuntimeField_218;
    }
    public override void Back()
    {
        if(PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丐下专丑丕一丁丛东() == true)
        {
                return;
        }
        
        if(this.且丛丐与丞上丌不丒 != null)
        {
                return;
        }
        
        if(this.丑丕下丕丕丟且丕丘() != false)
        {
                return;
        }
        
        if(this.丗下丘世三七一专丕 == 3)
        {
                this.上丘一世丑一丌丙与();
            return;
        }
        
        this.Back();
    }
    public void U_ToMainState()
    {
        this.上丘一世丑一丌丙与();
    }
    public void U_ToInfoState()
    {
        if(this.且丛丐与丞上丌不丒 != null)
        {
                return;
        }
        
        this.丗丄且丌下世上丈与(与丆丌丂丟丛丘丑且:  3);
    }
    public VeteranChestBanner()
    {
        this._startSpinDelay = 1.5f;
    }

}
