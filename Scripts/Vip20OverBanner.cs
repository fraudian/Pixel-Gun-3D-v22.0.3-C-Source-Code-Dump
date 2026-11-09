using UnityEngine;
internal sealed class Vip20OverBanner : BannerWindowWithBack
{
    // Fields
    private static System.Action 业丙丘丈七不下下丐;
    internal UnityEngine.GameObject state_ToStore;
    internal UnityEngine.GameObject state_Timer;
    internal PGCompany.TimerUI timerUi;
    private WidgetLayout promoLayout;
    private MiniPoolMonoBehaviour promoViewPool;
    private System.Collections.Generic.List<MainStorePromotionView> 专丕业丌且一丕世丁;
    
    // Methods
    internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  Vip20OverBanner.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  Vip20OverBanner.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Vip20OverBanner::丝一丅丆三东丂丞七()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Vip20OverBanner::丝一丅丆三东丂丞七()));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Vip20OverBanner::丝一丅丆三东丂丞七()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Vip20OverBanner::丝一丅丆三东丂丞七()));
    }
    public override void Show()
    {
        this.Show();
        this.丝一丅丆三东丂丞七();
        PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().上丞丝丂丝不丅丐一();
        if(Vip20OverBanner.业丙丘丈七不下下丐 == null)
        {
                return;
        }
        
        Vip20OverBanner.业丙丘丈七不下下丐.Invoke();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_ToStore, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Timer, 丏业丟一东丂东丘丛:  false);
        PGCompany.VIP20.丗一丄且与一丕丙丝 val_1 = PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世();
        if(val_1.三世丌丈丒丌七东万 == null)
        {
            goto label_11;
        }
        
        PGCompany.VIP20.丗一丄且与一丕丙丝 val_2 = PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世();
        if(val_2.三世丌丈丒丌七东万.Count < 1)
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_ToStore, 丏业丟一东丂东丘丛:  true);
        goto label_14;
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Timer, 丏业丟一东丂东丘丛:  true);
        this.timerUi.一丛丄七一且东三七();
        this.timerUi.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_10549");
        1152921505284374528 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10549");
        this.timerUi.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  1152921505284374528);
        label_14:
        this.丟丝与三丘七且丞丛();
    }
    public void U_ToStorePressed()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  "vip20", 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    private void 丟丝与三丘七且丞丛()
    {
        var val_3;
        var val_19;
        System.Comparison<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_21;
        var val_22;
        PGCompany.东丑丒丗一丞下丙丙<T> val_23;
        List.Enumerator<T> val_1 = this.专丕业丌且一丕世丁.GetEnumerator();
        label_4:
        if((598966960 & 1) == 0)
        {
            goto label_2;
        }
        
        this.promoViewPool.Return(万且万且丑丗且丌丆:  val_3.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.专丕业丌且一丕世丁.Clear();
        this.promoLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.promoViewPool.example, 丏业丟一东丂东丘丛:  false);
        TagSystem.三与下丘七丘丌丏丄 val_5 = new TagSystem.三与下丘七丘丌丏丄();
        bool val_6 = val_5.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.vip20");
        PGCompany.东丑丒丗一丞下丙丙<T> val_9 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(七丄丆丘丒与丐丘丅: ref  val_9, 三不丟丈丐丟丏专丁:  val_5, 丁丏且丝丞丙万丗与:  3);
        val_19 = null;
        val_19 = null;
        val_21 = Vip20OverBanner.<>c.<>9__15_0;
        if(val_21 == null)
        {
            goto label_21;
        }
        
        label_46:
        val_22 = public System.Void System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>::Sort(System.Comparison<T> comparison);
        val_9.Sort(comparison:  val_21);
        if(val_9.Count >= 2)
        {
            goto label_24;
        }
        
        val_23 = val_9;
        if(val_23 != 0)
        {
            goto label_34;
        }
        
        goto label_26;
        label_24:
        val_23 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        val_23.Add(item:  val_9.Item[1]);
        val_21 = val_9.Item[0];
        val_22 = public System.Void System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>::Add(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 item);
        val_23.Add(item:  val_21);
        if(val_23 != null)
        {
            goto label_34;
        }
        
        label_26:
        label_34:
        List.Enumerator<T> val_14 = val_23.GetEnumerator();
        label_42:
        if((598966928 & 1) == 0)
        {
            goto label_35;
        }
        
        string val_15 = val_3.丐丏七丌丕丗业且上();
        MainStorePromotionView val_16 = this.promoViewPool.Get<MainStorePromotionView>();
        this.promoLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_16);
        this.专丕业丌且一丕世丁.Add(item:  val_16);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_16, 丏业丟一东丂东丘丛:  true);
        goto label_42;
        label_21:
        Vip20OverBanner.<>c.<>9__15_0 = new System.Comparison<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(object:  Vip20OverBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 Vip20OverBanner.<>c::下下丛上一丞丂业丅(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 三丟东丕丄丄下下丑, PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丒丒丄丁且丄丆丂丌));
        if(val_9 != 0)
        {
            goto label_46;
        }
        
        goto label_46;
        label_35:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.promoLayout.Reposition();
        if((PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不()) != null)
        {
                return;
        }
    
    }
    public Vip20OverBanner()
    {
        this.专丕业丌且一丕世丁 = new System.Collections.Generic.List<MainStorePromotionView>();
    }

}
