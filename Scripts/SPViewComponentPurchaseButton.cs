using UnityEngine;
internal sealed class SPViewComponentPurchaseButton : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject enableIfPurchased;
    private UnityEngine.GameObject enableIfFree;
    private UnityEngine.GameObject enableIfWatch;
    private UnityEngine.GameObject enableIfInvalidServerTime;
    private UnityEngine.GameObject enableIfRealPrice;
    private UnityEngine.GameObject enableIfItemPrice;
    private UnityEngine.GameObject timerContainer;
    private PGCompany.TimerUI timer;
    private UnityEngine.GameObject noServerTime;
    private UnityEngine.GameObject giftButton;
    private UnityEngine.GameObject lockedByAttribute;
    private UnityEngine.GameObject notifHolder;
    private PGCompany.TimerUI notifTimer;
    private UnityEngine.GameObject notifSubButton;
    private UnityEngine.GameObject notifUnsubButton;
    public System.Collections.Generic.List<UILabel> purchaseButtonLabels;
    public System.Collections.Generic.List<PGCompany.InventoryItemView> priceView;
    public System.Collections.Generic.List<ItemListUI> priceListViews;
    private WidgetLayoutConstrainedFixed layoutConstrainedFixed;
    
    // Methods
    private void OnEnable()
    {
        PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::丝一丅丆三东丂丞七()));
        PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::丝一丅丆三东丂丞七()));
        PGCompany.丁丞丒业不与万且下.丐不丙三丙不专万丁(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void SPViewComponentPurchaseButton::丑丗丑丝丏丏丏丟一(PGCompany.专丟专世丅丂丁且专 丞丅上丏丂且下丅与)));
        PGCompany.丁丞丒业不与万且下.业上丞不七丝东专丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void SPViewComponentPurchaseButton::丑丗丑丝丏丏丏丟一(PGCompany.专丟专世丅丂丁且专 丞丅上丏丂且下丅与)));
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::丝一丅丆三东丂丞七()));
        PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::丝一丅丆三东丂丞七()));
        PGCompany.丁丞丒业不与万且下.三万与丑丟丕丅世丒(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void SPViewComponentPurchaseButton::丑丗丑丝丏丏丏丟一(PGCompany.专丟专世丅丂丁且专 丞丅上丏丂且下丅与)));
        PGCompany.丁丞丒业不与万且下.不丞丕丕丐专丈丛世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.专丟专世丅丂丁且专>(object:  this, method:  System.Void SPViewComponentPurchaseButton::丑丗丑丝丏丏丏丟一(PGCompany.专丟专世丅丂丁且专 丞丅上丏丂且下丅与)));
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539233428232] = 且丘丏丁丑与丙与丁;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        object val_35;
        string val_36;
        UnityEngine.GameObject val_37;
        UnityEngine.GameObject val_38;
        var val_39;
        UnityEngine.GameObject val_40;
        var val_41;
        val_35 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfPurchased, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfFree, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfWatch, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfRealPrice, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfItemPrice, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timerContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noServerTime, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notifHolder, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.lockedByAttribute, 丏业丟一东丂东丘丛:  false);
        if(this.lockedByAttribute == null)
        {
                return;
        }
        
        val_36 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.lockedByAttribute.丟丘丏丞丏三与且丗());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.purchaseButtonLabels, 丕丗丘丑丛与丑业丒:  val_36);
        TagSystem.三与下丘七丘丌丏丄 val_3 = this.purchaseButtonLabels.与不丞丑七丘丁丂丛();
        if((val_3.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.purchased")) == false)
        {
            goto label_10;
        }
        
        val_37 = this.enableIfPurchased;
        goto label_13;
        label_10:
        if(val_3 == null)
        {
                return;
        }
        
        if(PixelTime.丝丗专上三不丄丑丑() <= 0)
        {
                if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == false)
        {
            goto label_21;
        }
        
        }
        
        if((val_3.不丑三丌丈丞丈一丆() == null) || ((System.Linq.Enumerable.Any<PGCompany.Attributes.丝万专丆丂丘丌世丟>(source:  val_3.不丑三丌丈丞丈一丆())) == false))
        {
            goto label_25;
        }
        
        val_37 = this.lockedByAttribute;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_37, 丏业丟一东丂东丘丛:  true);
        return;
        label_25:
        int val_35 = val_3.上丟丄与丁三丌丘专();
        val_35 = val_35 - PixelTime.丝丗专上三不丄丑丑();
        var val_15 = ((val_35 < 1) ? 1 : 0) | ((val_36.上丟丄与丁三丌丘专() < 1) ? 1 : 0);
        if(val_36 == null)
        {
            goto label_31;
        }
        
        if((val_15 & 1) == 0)
        {
            goto label_32;
        }
        
        label_40:
        if(val_36.业东丅东丌上丗丑不() != 17015)
        {
            goto label_34;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfWatch, 丏业丟一东丂东丘丛:  (PixelTime.丝丗专上三不丄丑丑() > 0) ? 1 : 0);
        val_38 = this.enableIfInvalidServerTime;
        var val_20 = (PixelTime.丝丗专上三不丄丑丑() < 1) ? 1 : 0;
        goto label_39;
        label_31:
        if((val_15 & 1) != 0)
        {
            goto label_40;
        }
        
        label_32:
        if((val_36.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "notifications.enabled")) == false)
        {
            goto label_42;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notifHolder, 丏业丟一东丂东丘丛:  true);
        if(this.notifTimer != 0)
        {
                this.notifTimer.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_10624");
            this.notifTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_35, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::丌丘且丘丏丗丑且丐()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        if(val_35.丘世丕丝七丛丙丂丐() == false)
        {
            goto label_51;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notifSubButton, 丏业丟一东丂东丘丛:  false);
        val_40 = this.notifUnsubButton;
        val_39 = 1;
        goto label_71;
        label_21:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noServerTime, 丏业丟一东丂东丘丛:  true);
        val_35 = this.timer;
        if(val_35 == null)
        {
                return;
        }
        
        val_35.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453"));
        return;
        label_34:
        if(val_36.业东丅东丌上丗丑不() != 11015)
        {
            goto label_62;
        }
        
        val_41 = null;
        val_38 = this.enableIfFree;
        goto label_91;
        label_42:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timerContainer, 丏业丟一东丂东丘丛:  true);
        if(this.timer == null)
        {
            goto label_68;
        }
        
        this.timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_35, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void SPViewComponentPurchaseButton::专且上业丗与丐下一()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        goto label_68;
        label_51:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notifSubButton, 丏业丟一东丂东丘丛:  true);
        val_40 = this.notifUnsubButton;
        val_39 = 0;
        goto label_71;
        label_62:
        if(val_36.业东丅东丌上丗丑不() != 10015)
        {
                if(val_36.业东丅东丌上丗丑不() != 19015)
        {
                if(val_36.业东丅东丌上丗丑不() != 20015)
        {
            goto label_91;
        }
        
        }
        
        }
        
        val_41 = null;
        val_38 = this.enableIfRealPrice;
        label_91:
        val_39 = 1;
        label_39:
        val_40 = val_38;
        label_71:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_40, 丏业丟一东丂东丘丛:  true);
        label_68:
        if(val_38.三丛丈且与丒丙丟丟() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.giftButton, 丏业丟一东丂东丘丛:  true);
        }
        
        this.priceView.ForEach(action:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void SPViewComponentPurchaseButton::丑业丛丐丈丙丕一丒(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)));
        System.Action<ItemListUI> val_34 = null;
        val_36 = val_34;
        val_34 = new System.Action<ItemListUI>(object:  this, method:  System.Void SPViewComponentPurchaseButton::三业下丘三丗丏一与(ItemListUI 三丟东丕丄丄下下丑));
        this.priceListViews.ForEach(action:  val_34);
        if(this.layoutConstrainedFixed == null)
        {
                return;
        }
        
        this.layoutConstrainedFixed.丁下丏丙一丗下丈七();
    }
    private void 丑丗丑丝丏丏丏丟一(PGCompany.专丟专世丅丂丁且专 丞丅上丏丂且下丅与)
    {
        if(X21.七丈丒丒下下且万与() != 丞丅上丏丂且下丅与)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void U_SeteupNotification()
    {
        if(this != null)
        {
                this.丟东业丄丅丏丗丏丅();
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void U_DeleteNotification()
    {
    
    }
    public SPViewComponentPurchaseButton()
    {
        val_1 = new PGBehaviour();
    }
    private void 丌丘且丘丏丗丑且丐()
    {
        var val_2 = this;
        if(true == 0)
        {
                return;
        }
        
        var val_1 = (((mem[1103844756749] + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? true : 0;
    }
    private void 专且上业丗与丐下一()
    {
        var val_2 = this;
        if(true == 0)
        {
                return;
        }
        
        var val_1 = (((mem[1103844756749] + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? true : 0;
    }
    private void 丑业丛丐丈丙丕一丒(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return;
        }
        
        三丟东丕丄丄下下丑.Setup(丈丄不七三万丄丁不:  X20);
    }
    private void 三业下丘三丗丏一与(ItemListUI 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return;
        }
        
        三丟东丕丄丄下下丑.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  X20);
    }

}
