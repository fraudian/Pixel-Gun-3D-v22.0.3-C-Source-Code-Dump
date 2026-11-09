using UnityEngine;
public class WeaponSkinsShopUI : SelectableButtonController
{
    // Fields
    private 丟上下丞世丞不不丁 丂丅丒一上丑丞丟丙;
    private ShopItemSkinView 丙丅丂丟丝世不三丂;
    private bool selectOnShow;
    private System.Collections.Generic.List<UILabel> weaponNameLabels;
    private System.Collections.Generic.List<UILabel> skinNameLabels;
    private ShopWeaponSkinView weaponSkinViewExample;
    private ShopArmorSkinView armorSkinViewExample;
    public UnityEngine.GameObject buySkinButton;
    public UnityEngine.GameObject equipSkinButton;
    private UnityEngine.GameObject equipSkinDisabledButton;
    public UnityEngine.GameObject unequipSkinButton;
    private UnityEngine.GameObject buySkinButtonOffline;
    private UnityEngine.GameObject goToTraderButton;
    private CurrencyUI purchasePriceUI;
    private UnityEngine.GameObject bottomRightMessageContainer;
    private System.Collections.Generic.List<UILabel> bottomRightMessageLabels;
    private UnityEngine.GameObject goToEventRouletButton;
    private UnityEngine.GameObject goToGatchaButton;
    private UnityEngine.GameObject goToChestsEventButton;
    private UnityEngine.GameObject goToContestButton;
    private UIButton freeBattlePassButton;
    private UIButton paidBattlePassButton;
    private PGCompany.LoopCustomUiSetter loopUiSetter;
    private ArmoryInfoScreenController armoryInfoScreenController;
    public UnityEngine.GameObject itemPreviewHolder;
    public UnityEngine.GameObject hideButton;
    private ScrollViewHelper scrollViewHelper;
    private UIPlaySound buySound;
    
    // Methods
    private void OnEnable()
    {
        this.且丙丐丄专丏丂业丂();
    }
    internal void 丌丑世三丑丁丗丞万(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        ArmoryInfoScreenController val_3;
        丟上下丞世丞不不丁 val_4;
        this.丙丅丂丟丝世不三丂 = 0;
        this.ClearAllButtons();
        if(下丅丙一丂丗丅丝七 != null)
        {
                if(null != null)
        {
                val_3 = this.armoryInfoScreenController;
            且与丆丅一下丐丕业 val_1 = null;
            val_4 = val_1;
            val_1 = new 且与丆丅一下丐丕业(一专下东下丑业万丗:  下丅丙一丂丗丅丝七, 丏丙且七世与丛丌丈:  val_3);
        }
        else
        {
                val_3 = this.itemPreviewHolder;
            三世丛专丂丗丛丂一 val_2 = null;
            val_4 = val_2;
            val_2 = new 三世丛专丂丗丛丂一(一业一丕丅下业世与:  下丅丙一丂丗丅丝七, 丌丕丟丘万丅丝与一:  val_3);
        }
        
            this.丂丅丒一上丑丞丟丙 = val_4;
        }
        
        this.丈且东丑丂且万丒丅();
    }
    public void Clear()
    {
        this.丙丅丂丟丝世不三丂 = 0;
        this.ClearAllButtons();
    }
    internal void 七丞丝丆东丆一丆下(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = 丛丆世丂丒丁不世不;
        val_15 = 0;
        val_16 = 0;
        goto label_1;
        label_22:
        SelectableButton val_1 = X23.Item[0];
        if(val_1 == 0)
        {
            goto label_19;
        }
        
        val_17 = 0;
        val_18 = 0;
        if( == 0)
        {
            goto label_19;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_5 = 丕丏业丒丘丒世丟且();
        if(val_5 != null)
        {
                int val_7 = (val_5 == 0) ? (val_15) : (val_5).业东丅东丌上丗丑不();
            val_18 = public System.Void System.Nullable<System.Int32>::.ctor(System.Int32 value);
            val_19 = 0;
        }
        else
        {
                val_19 = 0;
        }
        
        if(val_14 != null)
        {
                int val_8 = val_14.业东丅东丌上丗丑不();
            val_18 = public System.Void System.Nullable<System.Int32>::.ctor(System.Int32 value);
            val_20 = 0;
        }
        else
        {
                val_20 = 0;
        }
        
        if(val_19.丙东专丂世丈丏丁丂() != val_20.丙东专丂世丈丏丁丂())
        {
            goto label_18;
        }
        
        val_14 = val_14;
        if((8 & 1) != 0)
        {
            goto label_19;
        }
        
        goto label_20;
        label_18:
        val_14 = val_14;
        label_19:
        val_16 = 1;
        label_1:
        if(val_16 < val_1.Count)
        {
            goto label_22;
        }
        
        return;
        label_20:
        if(this.scrollViewHelper == 0)
        {
                return;
        }
        
        this.scrollViewHelper.ScrollTo(不七丘丘丒万七丄丒:  val_1.transform, 丌与丟丁万丝丞丄丏:  false);
    }
    public override bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
    {
        丟上下丞世丞不不丁 val_4;
        var val_5;
        val_4 = this;
        if((this.SelectButton(丕丐不丑三上万丝东:  丕丐不丑三上万丝东)) != false)
        {
                this.丙丅丂丟丝世不三丂 = 0;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.skinNameLabels, 丕丗丘丑丛与丑业丒:  0.丕丏业丒丘丒世丟且());
            this.且丙丐丄专丏丂业丂();
            val_4 = this.丂丅丒一上丑丞丟丙;
            PGCompany.丗丟丄丈东丝丕丄世 val_3 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
            val_5 = 1;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    public void OnBuySkinPressed()
    {
        ShopItemSkinView val_9;
        var val_10;
        var val_11;
        WeaponSkinsShopUI.丂丄丕业东丆丄三三 val_1 = new WeaponSkinsShopUI.丂丄丕业东丆丄三三();
        .丝且与丝丒丟万丁专 = this;
        val_9 = this.丙丅丂丟丝世不三丂;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = this.丙丅丂丟丝世不三丂;
        if(val_9.丕丏业丒丘丒世丟且() == null)
        {
                return;
        }
        
        .丒世丘丘上丆丝东丞 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
            goto label_9;
        }
        
        if(null == null)
        {
            goto label_10;
        }
        
        var val_5 = (null != null) ? 0 : 124;
        goto label_12;
        label_9:
        val_10 = 0;
        goto label_12;
        label_10:
        val_10 = 94;
        label_12:
        if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
        {
                val_11 = null;
            val_11 = null;
            val_9 = (WeaponSkinsShopUI.丂丄丕业东丆丄三三)[1152921540724722928].丒世丘丘上丆丝东丞;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丆且上丁世专丛专丞(丒世丘丘上丆丝东丞:  val_9, 七丁上丁丒专丈七丙:  0, 丞一丁业丄一一业且:  "", 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void WeaponSkinsShopUI.丂丄丕业东丆丄三三::丌丁丂上丘不七专专()), 丘丅丌丄丐丟丑丈丘:  0, 丐丈上丂与上丂丒丏:  94, 丅丑丗丐丛丂丕丏丌:  0);
            return;
        }
        
        val_9 = (WeaponSkinsShopUI.丂丄丕业东丆丄三三)[1152921540724722928].丒世丘丘上丆丝东丞;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  val_9, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void WeaponSkinsShopUI.丂丄丕业东丆丄三三::丌丁丂上丘不七专专()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  94);
    }
    public void OnEquipSkinPressed()
    {
        if(this.丙丅丂丟丝世不三丂 == 0)
        {
                return;
        }
        
        if(this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且() == null)
        {
                return;
        }
        
        if((this.丂丅丒一上丑丞丟丙.丐丌丁一丏丁丗一丐(丛丆世丂丒丁不世不:  this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且())) == false)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_5 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
        this.与丂丐丄丅丈丏丈丑();
    }
    public void OnUnequipSkinPressed()
    {
        if(this.丙丅丂丟丝世不三丂 == 0)
        {
                return;
        }
        
        if(this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且() == null)
        {
                return;
        }
        
        if((this.丂丅丒一上丑丞丟丙.丐丌丁一丏丁丗一丐(丛丆世丂丒丁不世不:  this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且())) == false)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_5 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
        this.与丂丐丄丅丈丏丈丑();
    }
    public void SetDefault()
    {
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
                return;
        }
        
        goto typeof(丟上下丞世丞不不丁).__il2cppRuntimeField_198;
    }
    private void 业专丛丟丆丞一东一()
    {
        this.且丙丐丄专丏丂业丂();
    }
    private void 且丙丐丄专丏丂业丂()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySkinButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipSkinButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipSkinDisabledButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.unequipSkinButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySkinButtonOffline, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToTraderButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bottomRightMessageContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToChestsEventButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToContestButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToGatchaButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToEventRouletButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.freeBattlePassButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.paidBattlePassButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.loopUiSetter, 丏业丟一东丂东丘丛:  false);
        if(((this.buySkinButton != 0) && (this.丙丅丂丟丝世不三丂 != 0)) && (this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且() != null))
        {
                PGCompany.丗丟丄丈东丝丕丄世 val_4 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
            if(val_4 != null)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
            if(this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且() == null)
        {
                return;
        }
        
            if(null != null)
        {
                return;
        }
        
            this.丏专万七万专丂与七(丛丆世丂丒丁不世不:  this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且());
            return;
        }
        
        this.丙丅丂丟丝世不三丂 = 0;
        return;
        label_13:
        this.丗丌丁东丂世上丗丒(丞丝丌七丁万丗丐一:  val_4);
    }
    private void 丗丌丁东丂世上丗丒(PGCompany.丟丝世万东万丆丟上 丞丝丌七丁万丗丐一)
    {
        var val_11;
        UnityEngine.GameObject val_12;
        PGCompany.GameplayLoop.GameplayLoopType val_13;
        if((上丑三丁丄丛丁万丑.东丂下丞丑专丒丆丞(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一)) == false)
        {
            goto label_3;
        }
        
        val_11 = 1152921505284374528;
        val_12 = this.goToTraderButton;
        goto label_12;
        label_3:
        if((上丑三丁丄丛丁万丑.一丙丕丈三丒丌丈丏(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一)) == false)
        {
            goto label_7;
        }
        
        val_11 = 1152921505284374528;
        val_12 = this.equipSkinButton;
        goto label_12;
        label_7:
        if((上丑三丁丄丛丁万丑.七专与丞一丙丂万七(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一)) == false)
        {
            goto label_11;
        }
        
        val_11 = 1152921505284374528;
        val_12 = this.equipSkinDisabledButton;
        goto label_12;
        label_11:
        if((上丑三丁丄丛丁万丑.丞丝丆丄丈专丏万丘(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一)) == false)
        {
            goto label_15;
        }
        
        val_11 = 1152921505284374528;
        val_12 = this.buySkinButtonOffline;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  true);
        return;
        label_15:
        if((上丑三丁丄丛丁万丑.三丟丁丕丈丙与下业(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySkinButton, 丏业丟一东丂东丘丛:  true);
            this.purchasePriceUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  this.丙丅丂丟丝世不三丂);
            return;
        }
        
        if((上丑三丁丄丛丁万丑.与丞专丅丁上上与丘(上丒一丂丞丅丏丅丂:  1, 丐丏专丈丏一丒丝万:  丞丝丌七丁万丗丐一)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToGatchaButton, 丏业丟一东丂东丘丛:  true);
            this.世丅且丘世丒上世一();
            val_13 = 1;
        }
        else
        {
                if((上丑三丁丄丛丁万丑.与丞专丅丁上上与丘(上丒一丂丞丅丏丅丂:  5, 丐丏专丈丏一丒丝万:  丞丝丌七丁万丗丐一)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToContestButton, 丏业丟一东丂东丘丛:  true);
            this.世丅且丘世丒上世一();
            val_13 = 5;
        }
        else
        {
                if((上丑三丁丄丛丁万丑.与丞专丅丁上上与丘(上丒一丂丞丅丏丅丂:  3, 丐丏专丈丏一丒丝万:  丞丝丌七丁万丗丐一)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToEventRouletButton, 丏业丟一东丂东丘丛:  true);
            this.世丅且丘世丒上世一();
            val_13 = 3;
        }
        else
        {
                if((上丑三丁丄丛丁万丑.与丞专丅丁上上与丘(上丒一丂丞丅丏丅丂:  2, 丐丏专丈丏一丒丝万:  丞丝丌七丁万丗丐一)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goToChestsEventButton, 丏业丟一东丂东丘丛:  true);
            this.世丅且丘世丒上世一();
            val_13 = 2;
        }
        else
        {
                if((上丑三丁丄丛丁万丑.与丞专丅丁上上与丘(上丒一丂丞丅丏丅丂:  4, 丐丏专丈丏一丒丝万:  丞丝丌七丁万丗丐一)) == false)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.paidBattlePassButton, 丏业丟一东丂东丘丛:  true);
            this.世丅且丘世丒上世一();
            val_13 = 4;
        }
        
        }
        
        }
        
        }
        
        this.丙业七丒世丂七与丆(丞丝丌七丁万丗丐一:  丞丝丌七丁万丗丐一, 上丒一丂丞丅丏丅丂:  val_13);
    }
    private void 丏专万七万专丂与七(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        string val_11;
        丟上下丞世丞不不丁 val_12;
        丟上下丞世丞不不丁 val_13;
        var val_14;
        UnityEngine.GameObject val_15;
        System.Collections.Generic.List<UILabel> val_16;
        int val_17;
        val_11 = this;
        if((this.丂丅丒一上丑丞丟丙.丄丆丌丑丛一上专丘(丛丆世丂丒丁不世不:  丛丆世丂丒丁不世不)) == false)
        {
            goto label_2;
        }
        
        val_12 = this.丂丅丒一上丑丞丟丙;
        if((val_12.丐丌丁一丏丁丗一丐(丛丆世丂丒丁不世不:  丛丆世丂丒丁不世不)) == false)
        {
            goto label_4;
        }
        
        label_2:
        val_12 = this.丂丅丒一上丑丞丟丙;
        if((val_12.丐丌丁一丏丁丗一丐(丛丆世丂丒丁不世不:  丛丆世丂丒丁不世不)) == false)
        {
            goto label_6;
        }
        
        val_13 = this.丂丅丒一上丑丞丟丙;
        if((val_13 & 1) != 0)
        {
                return;
        }
        
        val_14 = 1152921505284374528;
        val_15 = this.equipSkinButton;
        goto label_13;
        label_6:
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_12;
        }
        
        val_14 = 1152921505284374528;
        val_15 = this.buySkinButtonOffline;
        goto label_13;
        label_4:
        val_14 = 1152921505284374528;
        val_15 = this.goToTraderButton;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
        return;
        label_12:
        if((this.丂丅丒一上丑丞丟丙 & 1) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bottomRightMessageContainer, 丏业丟一东丂东丘丛:  true);
            val_16 = this.bottomRightMessageLabels;
            val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7535");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_16, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_11, arg0:  this.丂丅丒一上丑丞丟丙));
            return;
        }
        
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
            goto label_24;
        }
        
        if((this.丂丅丒一上丑丞丟丙 & 1) == 0)
        {
            goto label_25;
        }
        
        label_30:
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
            goto label_26;
        }
        
        val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丛丆世丂丒丁不世不);
        goto label_29;
        label_24:
        if((this.丂丅丒一上丑丞丟丙 & 1) != 0)
        {
            goto label_30;
        }
        
        label_25:
        if((this.丂丅丒一上丑丞丟丙.丄丆丌丑丛一上专丘(丛丆世丂丒丁不世不:  丛丆世丂丒丁不世不)) == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buySkinButton, 丏业丟一东丂东丘丛:  true);
        this.purchasePriceUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  this.丙丅丂丟丝世不三丂);
        return;
        label_26:
        val_17 = System.String.alignConst;
        label_29:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bottomRightMessageContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.bottomRightMessageLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9176"), arg0:  val_17));
    }
    private ShopItemSkinView 丑丌丟一丌丕三丗丏()
    {
        if((this.丂丅丒一上丑丞丟丙 != null) && (null != null))
        {
                if(null == null)
        {
                return (ShopItemSkinView)this.weaponSkinViewExample;
        }
        
        }
        
        return (ShopItemSkinView)this.weaponSkinViewExample;
    }
    private void 丙且与上丁丛丝三丄()
    {
        UnityEngine.Object val_24;
        PGCompany.丗丟丄丈东丝丕丄世 val_26;
        var val_28;
        var val_29;
        ScrollViewHelper val_31;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.weaponSkinViewExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.armorSkinViewExample, 丏业丟一东丂东丘丛:  false);
        this.ClearAllButtons();
        var val_26 = 0;
        val_26 = val_26 + 1;
        System.Collections.Generic.IEnumerator<T> val_2 = this.丂丅丒一上丑丞丟丙.GetEnumerator();
        val_24 = 0;
        goto label_9;
        label_37:
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_26 = val_2.Current;
        if(val_26 != 0)
        {
                val_26 = 0;
        }
        
        ShopItemSkinView val_14 = UnityEngine.Object.Instantiate<ShopItemSkinView>(original:  this.丑丌丟一丌丕三丗丏(), parent:  X24.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_14.transform);
        val_14.丈且东丑丂且万丒丅(丛丆世丂丒丁不世不:  null, 万丝丗丛丁丁丆业丞:  this.itemPreviewHolder);
        this.AddNewButton(丟丂丄丕下业丗丛丂:  val_14);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_14, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Object val_16 = (this.丂丅丒一上丑丞丟丙 != 1) ? (val_14) : (val_24);
        label_9:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_37;
        }
        
        val_28 = 0;
        val_29 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_2.Dispose();
        }
        
        val_2.Reposition();
        if(val_16 == 0)
        {
                if(val_2.Count >= 1)
        {
                val_24 = val_16.Item[0];
        }
        
        }
        
        if((this.selectOnShow != false) && (val_24 != 0))
        {
                val_31 = this.scrollViewHelper;
            if(val_31 != 0)
        {
                val_31 = this.scrollViewHelper;
            val_31.ScrollTo(不七丘丘丒万七丄丒:  val_24.transform, 丌与丟丁万丝丞丄丏:  false);
        }
        
        }
        
        this.且丙丐丄专丏丂业丂();
    }
    private void 与丂丐丄丅丈丏丈丑()
    {
        var val_3;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        string val_23;
        var val_24;
        var val_25;
        string val_26;
        var val_27;
        ShopNGUIController val_28;
        var val_29;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_18 = 1152921524324429632;
        label_9:
        if((1760136432 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 != null)
        {
                val_19 = null;
        }
        
        if(val_4 != null)
        {
                val_19 = null;
        }
        
        丕丕业七丙七丅丈丄();
        goto label_9;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.且丙丐丄专丏丂业丂();
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
            goto label_38;
        }
        
        if(null == null)
        {
            goto label_15;
        }
        
        if(null != null)
        {
            goto label_38;
        }
        
        val_18 = 1152921505261211648;
        val_20 = null;
        val_20 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_38;
        }
        
        ShopItemSkinView val_18 = this.丙丅丂丟丝世不三丂;
        PGCompany.丗丟丄丈东丝丕丄世 val_7 = val_18.丕丏业丒丘丒世丟且();
        if(val_7 == null)
        {
            goto label_23;
        }
        
        val_18 = (null == null) ? (val_7) : 0;
        goto label_24;
        label_15:
        val_18 = 1152921505261211648;
        val_22 = null;
        val_22 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
        {
            goto label_38;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_9 = this.丙丅丂丟丝世不三丂.丕丏业丒丘丒世丟且();
        if(val_9 != null)
        {
                var val_10 = (null == null) ? (val_9) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
        val_24 = null;
        val_24 = null;
        if(val_23 != 0)
        {
                val_23 = val_23.上专丗丏丛丁专丑丄().WeaponPrefabName;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.七丄丒丌上万万丐业(丅丐丞丞丐丘东丘丘:  val_23);
        goto label_38;
        label_23:
        val_21 = 0;
        label_24:
        val_25 = null;
        val_25 = null;
        val_18 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丌上丏丁下丞丐丏万();
        if(val_21 == 0)
        {
            goto label_42;
        }
        
        val_26 = val_21.业上丙丞丐丄丆丅七();
        if(val_26 != null)
        {
            goto label_43;
        }
        
        label_42:
        val_26 = this.丂丅丒一上丑丞丟丙.丐丙世七丅丅丐下丙();
        label_43:
        val_18.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  val_26);
        label_38:
        val_27 = null;
        val_27 = null;
        val_28 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        if(val_28 == 0)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_28 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
        val_28.丙丑丘业丕丗丗不丘();
    }
    private void 丈且东丑丂且万丒丅()
    {
        System.Collections.Generic.List<UILabel> val_12;
        var val_13;
        System.Func<WeaponSkinSettings, System.Int32> val_15;
        if(this.丂丅丒一上丑丞丟丙 == null)
        {
            goto label_1;
        }
        
        var val_1 = (null == null) ? this.丂丅丒一上丑丞丟丙 : 0;
        if(val_1 == 0)
        {
            goto label_2;
        }
        
        丏丞丛上七丁丞丛万.丛丒丑丕丏丟世丆丝();
        丏丞丛上七丁丞丛万.世丘上丈丅丂丛业丈(丅丐丞丞丐丘东丘丘:  val_1.丂上丛丝丑三万丑丌());
        val_12 = this.weaponNameLabels;
        if(this.丂丅丒一上丑丞丟丙 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_1:
        val_12 = this.weaponNameLabels;
        goto label_7;
        label_2:
        val_12 = this.weaponNameLabels;
        label_7:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_12, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.丂丅丒一上丑丞丟丙.丐丙世七丅丅丐下丙(), 七丆丒与丗丌丄且丂:  this.丂丅丒一上丑丞丟丙.丅丂丄且丞一丏丝丕()));
        this.丙且与上丁丛丝三丄();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  58);
        val_13 = null;
        val_13 = null;
        val_15 = WeaponSkinsShopUI.<>c.<>9__44_0;
        if(val_15 == null)
        {
                System.Func<WeaponSkinSettings, System.Int32> val_9 = null;
            val_15 = val_9;
            val_9 = new System.Func<WeaponSkinSettings, System.Int32>(object:  WeaponSkinsShopUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponSkinsShopUI.<>c::下丞丒丞丙丄东且丞(WeaponSkinSettings 三丟东丕丄丄下下丑));
            WeaponSkinsShopUI.<>c.<>9__44_0 = val_15;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丑丈丂丈丝丛丂一下(丅专丐丝丒丕丐业丘:  System.Linq.Enumerable.Select<WeaponSkinSettings, System.Int32>(source:  System.Linq.Enumerable.OfType<WeaponSkinSettings>(source:  this.丂丅丒一上丑丞丟丙), selector:  val_9));
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private void 世丅且丘世丒上世一()
    {
        var val_16;
        System.Action<GameLoopSpriteOnButton> val_18;
        var val_19;
        var val_21;
        System.Action<GameLoopSpriteOnButton> val_23;
        if((this.goToGatchaButton != 0) && (this.goToGatchaButton.activeInHierarchy != false))
        {
                val_16 = null;
            val_16 = null;
            val_18 = WeaponSkinsShopUI.<>c.<>9__45_0;
            if(val_18 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_4 = null;
            val_18 = val_4;
            val_4 = new System.Action<GameLoopSpriteOnButton>(object:  WeaponSkinsShopUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponSkinsShopUI.<>c::上下丄丞丆丙业丑丈(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            WeaponSkinsShopUI.<>c.<>9__45_0 = val_18;
        }
        
            GameLoopSpriteOnButton val_5 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  this.goToGatchaButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_4);
        }
        
        if((this.goToEventRouletButton != 0) && (this.goToEventRouletButton.activeInHierarchy != false))
        {
                val_19 = null;
            val_19 = null;
            val_18 = WeaponSkinsShopUI.<>c.<>9__45_1;
            if(val_18 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_9 = null;
            val_18 = val_9;
            val_9 = new System.Action<GameLoopSpriteOnButton>(object:  WeaponSkinsShopUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponSkinsShopUI.<>c::上丈一七丟下丑丌东(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            WeaponSkinsShopUI.<>c.<>9__45_1 = val_18;
        }
        
            GameLoopSpriteOnButton val_10 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  this.goToEventRouletButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_9);
        }
        
        if(this.goToChestsEventButton == 0)
        {
                return;
        }
        
        if(this.goToChestsEventButton.activeInHierarchy == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_23 = WeaponSkinsShopUI.<>c.<>9__45_2;
        if(val_23 == null)
        {
                System.Action<GameLoopSpriteOnButton> val_14 = null;
            val_23 = val_14;
            val_14 = new System.Action<GameLoopSpriteOnButton>(object:  WeaponSkinsShopUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponSkinsShopUI.<>c::丙丒丈三一丆丗世一(GameLoopSpriteOnButton 三丟东丕丄丄下下丑));
            WeaponSkinsShopUI.<>c.<>9__45_2 = val_23;
        }
        
        GameLoopSpriteOnButton val_15 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<GameLoopSpriteOnButton>(丞下万上三丘上与专:  this.goToChestsEventButton.GetComponent<GameLoopSpriteOnButton>(), 丌专业且丛丏丞丝且:  val_14);
    }
    private void 丙业七丒世丂七与丆(PGCompany.丟丝世万东万丆丟上 丞丝丌七丁万丗丐一, PGCompany.GameplayLoop.GameplayLoopType 上丒一丂丞丅丏丅丂)
    {
        if(this.loopUiSetter == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.loopUiSetter, 丏业丟一东丂东丘丛:  true);
        this.loopUiSetter.丈且东丑丂且万丒丅(丞一丁业丄一一业且:  丞丝丌七丁万丗丐一.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  128, 上丒一丂丞丅丏丅丂:  上丒一丂丞丅丏丅丂, 一丏且丏东丌丈丄且:  true, 专丐丛丑丞丕丌与丛:  0);
    }
    public WeaponSkinsShopUI()
    {
        this.selectOnShow = true;
    }

}
