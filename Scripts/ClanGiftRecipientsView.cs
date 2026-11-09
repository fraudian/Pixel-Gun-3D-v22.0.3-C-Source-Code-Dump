using UnityEngine;
internal sealed class ClanGiftRecipientsView : PGBehaviour
{
    // Fields
    internal static ClanGiftRecipientsView 丆丕丝丒不丙且丐丗;
    private SelectableButtonController selectableButtonController;
    private DynamicWrapGrid dynamicWrap;
    private UnityEngine.GameObject successMessage;
    private UnityEngine.GameObject noPriceSendButton;
    private UnityEngine.GameObject yesPriceSendButton;
    private UILabel priceLabel;
    private PGCompany.InventoryItemView priceView;
    private PGCompany.东丑丆丗丏丐丟下丄 <丒丄丙世且丑丑丄不>k__BackingField;
    private PGCompany.GiftSystem.丑世丂丙丛且丟一丁 <上万丟丟丘丆丛丄丐>k__BackingField;
    private const bool 丘不上丅丅不下三业 = True;
    private System.IDisposable 东三世丝丒三一丈丛;
    private const string 万不三丗丕上丌与专 = "Banners/ClanStoreGift";
    
    // Properties
    private PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝 { get; set; }
    private PGCompany.GiftSystem.丑世丂丙丛且丟一丁 丈丘丛且丒丙东丕三 { get; set; }
    
    // Methods
    private PGCompany.东丑丆丗丏丐丟下丄 与丞丆丑东东丟丆丌()
    {
        return (PGCompany.东丑丆丗丏丐丟下丄)this.<丒丄丙世且丑丑丄不>k__BackingField;
    }
    private void 丛丐丟万丐世万丏丌(PGCompany.东丑丆丗丏丐丟下丄 丙业与丙丗丝不丈东)
    {
        this.<丒丄丙世且丑丑丄不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private PGCompany.GiftSystem.丑世丂丙丛且丟一丁 且丛丈一丝东丒丙丘()
    {
        return (PGCompany.GiftSystem.丑世丂丙丛且丟一丁)this.<上万丟丟丘丆丛丄丐>k__BackingField;
    }
    private void 与丐下丏三丂上丕丛(PGCompany.GiftSystem.丑世丂丙丛且丟一丁 丙业与丙丗丝不丈东)
    {
        this.<上万丟丟丘丆丛丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static ClanGiftRecipientsView 下与丞三丅丛丄七丕(UnityEngine.GameObject 丈东丘丏与丌东东下, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, PGCompany.GiftSystem.丑世丂丙丛且丟一丁 东东丂丑丙丞专东与)
    {
        var val_13;
        if(ClanGiftRecipientsView.万不三丗丕上丌与专 == 0)
        {
                ClanGiftRecipientsView.万不三丗丕上丌与专 = 丞东丑专丛丆丄丝世.丙丌专东丌丏东丗丕<ClanGiftRecipientsView>(丑与丞三且丛与丟业:  "Banners/ClanStoreGift", 七万上丐一丈丏丏专:  丈东丘丏与丌东东下, 万世丛丄丄业丆且丅:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        ClanGiftRecipientsView.万不三丗丕上丌与专.丌丟丄业且三丛丕丄().SetParent(parent:  丈东丘丏与丌东东下.transform, worldPositionStays:  true);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        ClanGiftRecipientsView.万不三丗丕上丌与专.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        ClanGiftRecipientsView.万不三丗丕上丌与专.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        ClanGiftRecipientsView.万不三丗丕上丌与专.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  ClanGiftRecipientsView.万不三丗丕上丌与专.gameObject, 不东丛三丂丌丑专丆:  丈东丘丏与丌东东下.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_13 = null;
        if(ClanGiftRecipientsView.万不三丗丕上丌与专 == null)
        {
                val_13 = null;
        }
        
        mem2[0] = 且丘丏丁丑与丙与丁;
        if(ClanGiftRecipientsView.万不三丗丕上丌与专 == null)
        {
                val_13 = null;
        }
        
        mem2[0] = 东东丂丑丙丞专东与;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ClanGiftRecipientsView.万不三丗丕上丌与专, 丏业丟一东丂东丘丛:  true);
        ClanGiftRecipientsView.万不三丗丕上丌与专.七丕丗且且丕丛丞丕();
        return (ClanGiftRecipientsView)ClanGiftRecipientsView.万不三丗丕上丌与专;
    }
    private void Awake()
    {
        this.dynamicWrap.unlimitedContent = true;
        this.dynamicWrap.allowNegativeIndices = true;
        this.dynamicWrap.scaleWidth = false;
    }
    internal void 丝一丅丆三东丂丞七(System.Collections.Generic.IEnumerable<string> 丛丅丈一一丟丂业万)
    {
        var val_8 = this;
        this.dynamicWrap.UpdateContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.<上万丟丟丘丆丛丄丐>k__BackingField)));
        this.dynamicWrap.ScrollToCenterOnItem(世万专丛与丐丌专不:  0);
        if(this.selectableButtonController.allButtons.Count != 0)
        {
                return;
        }
        
        List.Enumerator<T> val_5 = this.dynamicWrap.GridItems.GetEnumerator();
        label_12:
        if((1919315128 & 1) == 0)
        {
            goto label_9;
        }
        
        SelectableButton val_7 = 0.丐丏七丌丕丗业且上().GetComponent<SelectableButton>();
        if(this.selectableButtonController != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞丏丛业丄万专丈丛()
    {
        var val_26;
        PGCompany.GiftSystem.丑世丂丙丛且丟一丁 val_27;
        string val_28;
        var val_29;
        var val_30;
        val_26 = this;
        if(this.selectableButtonController.selectedButton == 0)
        {
                return;
        }
        
        一丄丙丐丄业丘东丕 val_3 = this.selectableButtonController.selectedButton.GetComponent<GiftRecipientDynamicWrapItem>().ViewData;
        val_27 = this.<上万丟丟丘丆丛丄丐>k__BackingField;
        if((this.<丒丄丙世且丑丑丄不>k__BackingField) == null)
        {
                return;
        }
        
        val_28 = 0;
        if((this.<丒丄丙世且丑丑丄不>k__BackingField.不业丙丒丂丞下丆丙()) == 24)
        {
                val_28 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((System.String.op_Inequality(a:  val_27.业丄丁丘丝东丗业与(), b:  val_28)) != false)
        {
                System.Version val_11 = new System.Version(major:  21, minor:  7, build:  0);
            val_28 = val_11;
            if((System.Version.op_LessThan(v1:  丂与专万与丐丌丏不.丑七不且上丗丁一世().丅业下一丁不丁与三(丄丒且丙三丆丟与丏:  val_27.业丄丁丘丝东丗业与()), v2:  val_11)) != false)
        {
                InfoWindowController.丟丂不丘丂下上与世(丏不丄丑丝丁丘万不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12367"));
            return;
        }
        
        }
        
        }
        
        if((((this.<丒丄丙世且丑丑丄不>k__BackingField) == null) || ((this.<丒丄丙世且丑丑丄不>k__BackingField.业东丅东丌上丗丑不()) == 10015)) || ((this.<丒丄丙世且丑丑丄不>k__BackingField.业东丅东丌上丗丑不()) == 11015))
        {
            goto label_29;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  this.<丒丄丙世且丑丑丄不>k__BackingField, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_32;
        }
        
        label_29:
        val_27 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_27.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  26);
        this.<丒丄丙世且丑丑丄不>k__BackingField.丛下丈丞丗丁丕丒丂<PGCompany.GiftSystem.一丟丙一东丕丏万万>(丞万丕丏东与丑下丕:  val_27);
        val_26 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_26.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_32:
        val_29 = null;
        val_29 = null;
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
        val_30 = null;
        val_30 = null;
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  ClanGiftRecipientsView.<>c.<>9, method:  System.Void ClanGiftRecipientsView.<>c::丂专上丂且丗一与不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  this.<丒丄丙世且丑丑丄不>k__BackingField.业上丙丞丐丄丆丅七(), 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  "");
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    private void 丆世与丑丆丅丐万且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.successMessage, 丏业丟一东丂东丘丛:  false);
        this.selectableButtonController.丞与万丕丈丒丌丆世();
    }
    private void 且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丁且与丏世一丈丕, object 一丐丗丁丞丆丅丟丄)
    {
        if((ClanGiftRecipientsView.万不三丗丕上丌与专 + 128) != 且丘丏丁丑与丙与丁)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  丕丁且与丏世一丈丕)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.successMessage, 丏业丟一东丂东丘丛:  true);
        this.selectableButtonController.丞与万丕丈丒丌丆世();
    }
    private void OnEnable()
    {
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void ClanGiftRecipientsView::且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丁且与丏世一丈丕, object 一丐丗丁丞丆丅丟丄)));
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void ClanGiftRecipientsView::且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丁且与丏世一丈丕, object 一丐丗丁丞丆丅丟丄)));
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ClanGiftRecipientsView::U_Hide()), 与且专丈不万东一万:  System.String.Format(format:  "ClanGiftRecipientsView_{0}", arg0:  this.gameObject.name));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.七丕丗且且丕丛丞丕();
    }
    private void 七丕丗且且丕丛丞丕()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noPriceSendButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.yesPriceSendButton, 丏业丟一东丂东丘丛:  false);
        if(((this.<丒丄丙世且丑丑丄不>k__BackingField) != null) && ((this.<丒丄丙世且丑丑丄不>k__BackingField) != null))
        {
                if((this.<丒丄丙世且丑丑丄不>k__BackingField.业东丅东丌上丗丑不()) != 11015)
        {
            goto label_5;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.noPriceSendButton, 丏业丟一东丂东丘丛:  true);
        return;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.yesPriceSendButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.priceLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.priceView, 丏业丟一东丂东丘丛:  false);
        if((PGCompany.万丞丘与丕丞下万丌.丈三世丆丙丄丌东丗(丈丄不七三万丄丁不:  this.<丒丄丙世且丑丑丄不>k__BackingField)) != false)
        {
                decimal val_4 = System.Decimal.op_Implicit(value:  this.<丒丄丙世且丑丑丄不>k__BackingField.丂丁丏一丙丛业且丌());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.priceLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8692"), arg0:  Rilisoft.Offers.丁且丕专万丈丒丏丗.且业业丈丅丝丟丄专(七丛下丘丁丌丅丗丟:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid}, 丞丂业丅丟丙丏七丗:  this.<丒丄丙世且丑丑丄不>k__BackingField.业东丅东丌上丗丑不(), 丆丗丘丕且丈丘丁不:  "F2")));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.priceLabel, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        this.priceView.Setup(丈丄不七三万丄丁不:  this.<丒丄丙世且丑丑丄不>k__BackingField);
    }
    private void OnDisable()
    {
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void ClanGiftRecipientsView::且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丕丁且与丏世一丈丕, object 一丐丗丁丞丆丅丟丄)));
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    public void U_HideSuccessMessage()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.successMessage, 丏业丟一东丂东丘丛:  false);
    }
    public void U_Buy()
    {
        this.丞丏丛业丄万专丈丛();
    }
    public void U_Hide()
    {
        this.丆世与丑丆丅丐万且();
    }
    public ClanGiftRecipientsView()
    {
    
    }

}
