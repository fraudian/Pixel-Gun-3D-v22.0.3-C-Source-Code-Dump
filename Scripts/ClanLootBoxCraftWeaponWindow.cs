using UnityEngine;
internal sealed class ClanLootBoxCraftWeaponWindow : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView scrollItem;
    private UIScrollView scrollView;
    private UICenterOnChild _myCenterOnChild;
    private UIWrapContent _wrapContent;
    private UnityEngine.GameObject weaponCraftHeader;
    private UnityEngine.GameObject gadgetCraftHeader;
    private UnityEngine.GameObject weaponDownLabel;
    private UnityEngine.GameObject gadgetDownLabel;
    internal bool 丑不万丁丟丏丂业与;
    private System.Action 丐且且丆丝世专不丘;
    private bool 丅世业丝丟世丒万七;
    private System.Collections.Generic.List<UnityEngine.GameObject> 万丆上丆世丏丝丁下;
    
    // Methods
    internal void 丌万丗与七丄丕不丁(System.Collections.Generic.Dictionary<string, PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, System.Action 丁且丙丞丁丌丆丛丐)
    {
        this.丑不万丁丟丏丂业与 = false;
        this.丅世业丝丟世丒万七 = false;
        this._wrapContent.minIndex = 0;
        this._wrapContent.maxIndex = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetCraftHeader, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetDownLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponCraftHeader, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponDownLabel, 丏业丟一东丂东丘丛:  true);
        this.丌专丞专一且丟丕丑();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
        this.scrollView.enabled = true;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        val_2.AddRange(collection:  System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  上业丟世三与七七三.Values));
        if(上业丟世三与七七三.Values.Count <= 2)
        {
                if(上业丟世三与七七三.Values.Count >= 2)
        {
                val_2.AddRange(collection:  System.Linq.Enumerable.ToList<PGCompany.三东丏不丗世丅丌丄>(source:  上业丟世三与七七三.Values));
        }
        
        }
        
        if(val_2.Count == 1)
        {
                this.丅世业丝丟世丒万七 = true;
        }
        
        List.Enumerator<T> val_12 = val_2.GetEnumerator();
        label_20:
        if((2093839016 & 1) == 0)
        {
            goto label_19;
        }
        
        this.万万丘丑丒丗丌丄不(丈丄不七三万丄丁不:  0.丐丏七丌丕丗业且上());
        goto label_20;
        label_19:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丐且且丆丝世专不丘 = 丁且丙丞丁丌丆丛丐;
        if(val_2.Count <= 1)
        {
                this._wrapContent.minIndex = 1;
            this._wrapContent.maxIndex = 2;
        }
        
        this.UpdateScroll();
    }
    private void 丌专丞专一且丟丕丑()
    {
        List.Enumerator<T> val_1 = this.万丆上丆世丏丝丁下.GetEnumerator();
        label_8:
        if((2094045256 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.万丆上丆世丏丝丁下.Clear();
    }
    private void 万万丘丑丒丗丌丄不(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        Rilisoft.OfferItem val_2 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
        PGCompany.InventoryItemView val_5 = UnityEngine.Object.Instantiate<PGCompany.InventoryItemView>(original:  this.scrollItem, parent:  this.scrollItem.transform.parent, worldPositionStays:  true);
        if(val_5 != null)
        {
                val_5.Setup(丏且丕丄丁丟丆丏丁:  val_2);
        }
        else
        {
                val_5.Setup(丏且丕丄丁丟丆丏丁:  val_2);
        }
        
        ClanLootBoxInfoItemUI val_6 = val_5.GetComponent<ClanLootBoxInfoItemUI>();
        val_6.丅丞丆东下丌丘丙丈 = this.丌丟丄业且三丛丕丄();
        val_5.GetComponent<ClanLootBoxInfoItemUI>().丈且东丑丂且万丒丅();
        val_5.transform.SetParent(p:  this._wrapContent.transform);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        this.万丆上丆世丏丝丁下.Add(item:  val_5.gameObject);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this.丅世业丝丟世丒万七 == false)
        {
                return;
        }
        
        val_5.GetComponent<UIDragScrollView>().enabled = false;
    }
    private void OnEnable()
    {
        System.Delegate val_4 = System.Delegate.Combine(a:  this._myCenterOnChild.onCenter, b:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClanLootBoxCraftWeaponWindow::丆三一丐丒丁与丛下(UnityEngine.GameObject 丌丙丌一上下丂丗业)));
        if(this._myCenterOnChild == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        this._myCenterOnChild.onCenter = val_4;
    }
    public void U_Later()
    {
        if(this.丐且且丆丝世专不丘 == null)
        {
                return;
        }
        
        this.丐且且丆丝世专不丘.Invoke();
    }
    private void 丆三一丐丒丁与丛下(UnityEngine.GameObject 丌丙丌一上下丂丗业)
    {
        int val_18;
        UnityEngine.GameObject val_19;
        var val_20;
        if((this._myCenterOnChild.centeredObject.GetComponent<ClanLootBoxInfoItemUI>()) == 0)
        {
                return;
        }
        
        val_18 = val_2.itemView.ItemParams.业东丅东丌上丗丑不();
        Rilisoft.OfferItem val_6 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_18);
        if(((val_6.Type != 10) && (val_6.Type != 1070)) && (val_6.Type == 1300))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetCraftHeader, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetDownLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponCraftHeader, 丏业丟一东丂东丘丛:  false);
            val_19 = this.weaponDownLabel;
            val_20 = 0;
        }
        else
        {
                val_18 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_6.Record.与不丞丑七丘丁丂丛()).业东丅东丌上丗丑不()).ItemParams;
            PGCompany.丟丝东丈丐丙三下丛 val_16 = new PGCompany.丟丝东丈丐丙三下丛(丈丄不七三万丄丁不:  val_18);
            if(val_16 == null)
        {
                return;
        }
        
            if(val_16.丐上下三丑丈丑丄丟() == null)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetCraftHeader, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gadgetDownLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponCraftHeader, 丏业丟一东丂东丘丛:  true);
            val_19 = this.weaponDownLabel;
            val_20 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  true);
    }
    public void U_GoCraft()
    {
        UnityEngine.Object val_36;
        var val_37;
        CategoryNames val_38;
        if(this.丐且且丆丝世专不丘 != null)
        {
                this.丐且且丆丝世专不丘.Invoke();
        }
        
        new ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不() = new System.Object();
        val_36 = this._myCenterOnChild.centeredObject;
        if(val_36 == 0)
        {
                return;
        }
        
        if((this._myCenterOnChild.centeredObject.GetComponent<ClanLootBoxInfoItemUI>()) == 0)
        {
                return;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_7 = val_5.itemView.ItemParams;
        val_37 = 1152921505475907584;
        val_36 = new Rilisoft.OfferItem();
        val_36 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_7.业东丅东丌上丗丑不());
        if((new Rilisoft.OfferItem().Type != 10) && (new Rilisoft.OfferItem().Type != 1070))
        {
                Rilisoft.OfferItemType val_12 = new Rilisoft.OfferItem().Type;
            if(val_12 == 1300)
        {
                val_12.丁丙丆丝丗一七丄东(丈丄不七三万丄丁不:  val_7);
            return;
        }
        
        }
        
        new Rilisoft.OfferItem() = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  new Rilisoft.OfferItem().Record.与不丞丑七丘丁丂丛()).业东丅东丌上丗丑不());
        val_36 = new PGCompany.丟丝东丈丐丙三下丛();
        val_36 = new PGCompany.丟丝东丈丐丙三下丛(丈丄不七三万丄丁不:  new Rilisoft.OfferItem().ItemParams);
        if(new ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不() != null)
        {
                val_37 = new ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不();
            .一业一丕丅下业世与 = val_36;
        }
        else
        {
                val_37 = 16;
            mem[16] = val_36;
        }
        
        if(val_37 == 0)
        {
                return;
        }
        
        if(0.丐上下三丑丈丑丄丟() == null)
        {
                return;
        }
        
        val_36 = mem[16];
        PGCompany.丗丟丄丈东丝丕丄世 val_23 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  new Rilisoft.OfferItem().ItemParams);
        if((val_23.丒不丈丝丒丟丒丆下(一业一丕丅下业世与:  new PGCompany.丟丝东丈丐丙三下丛(), 丞丘丞丏业且丛丏丘:  val_23)) == true)
        {
                return;
        }
        
        PGCompany.上丕丈丞一丟丟丛丂 val_25 = PGCompany.丌东丛不丅三下业上.丌不丂丙丂丝丌丅丈(一业一丕丅下业世与:  new PGCompany.丟丝东丈丐丙三下丛());
        if(val_25 == 0)
        {
                return;
        }
        
        new PGCompany.丌不丞丐世丞三丘丌() = new PGCompany.丌不丞丐世丞三丘丌();
        .Type = PGCompany.丕丝下丁七东丄三丑.丘丅与万三丙世丆丈(世丌七与丄丟丅丁东:  val_25);
        .ItemId = new PGCompany.丟丝东丈丐丙三下丛().业上丙丞丐丄丆丅七();
        .ItemCategory = mem[16];
        val_37 = 1152921505259880448;
        val_36 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  176, 丙丑丄与丅丐一不东:  false);
        static_value_081D9E68 = new System.Predicate<丙且上东下丏丏丟下>(object:  new ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不(), method:  System.Boolean ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不::丌丈上世且丕丛万三(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
        if((val_36.Exists(match:  static_value_081D9E68)) != false)
        {
                val_38 = 65536;
            val_38 = 1;
        }
        else
        {
                val_36 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  88, 丙丑丄与丅丐一不东:  false);
            static_value_081D9E68 = new System.Predicate<丙且上东下丏丏丟下>(object:  new ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不(), method:  System.Boolean ClanLootBoxCraftWeaponWindow.与丟业一丈上丅上不::万丞丛丙丑丏丆丒丞(丙且上东下丏丏丟下 三丟东丕丄丄下下丑));
            if((val_36.Exists(match:  static_value_081D9E68)) != false)
        {
                val_38 = 131072;
            val_38 = 2;
        }
        else
        {
                val_38 = (PGCompany.丌不丞丐世丞三丘丌)[1152921536766908416].ItemCategory;
        }
        
        }
        
        .ShopCategory = val_38;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
    
    }
    private void 丁丙丆丝丗一七丄东(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        PGCompany.三东丏不丗世丅丌丄 val_20;
        int val_21;
        string val_22;
        val_20 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丛丈丏丅丂一不丒业(上七下丘一下三世丏:  丈丄不七三万丄丁不);
        val_21 = val_20.业东丅东丌上丗丑不();
        Rilisoft.OfferItem val_4 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  val_21);
        System.Nullable<CategoryNames> val_5 = val_4.Category;
        if((2095441256 & 1) == 0)
        {
                return;
        }
        
        if(val_4 != null)
        {
                val_22 = val_4.Id;
        }
        else
        {
                val_22 = val_4.Id;
        }
        
        System.Nullable<CategoryNames> val_8 = val_4.Category;
        丙且上东下丏丏丟下 val_9 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_22, 七丆丒与丗丌丄且丂:  val_8.HasValue);
        val_21 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_9 == null)
        {
                return;
        }
        
        if(val_21.丞丗丑丈一丅丗丌丟() == null)
        {
                return;
        }
        
        val_21 = PGCompany.ClanStoreMainUI.丑七不且上丗丁一世();
        if(val_21 == 0)
        {
                return;
        }
        
        PGCompany.StoreItemSettings val_17 = null;
        val_21 = val_17;
        val_17 = new PGCompany.StoreItemSettings();
        .ItemParams = val_20;
        val_20 = PGCompany.ClanStoreMainUI.丑七不且上丗丁一世();
        val_20.丆丂东丄万三不丏丅(丐丅丒专丛丏上与业:  (((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_9.丒万丕七专不丏丞丌())) & true) != 0) ? (4 + 1) : 4, 且丘丏丁丑与丙与丁:  0, 丅丘丌且丈丘丄丗丄:  new PGCompany.丟丁且丝丁三丏丙且(与不丕丆丈不丙丟丛:  val_17), 丞丘丞丏业且丛丏丘:  0, 丑丒万丐丞丒丈专丞:  false);
    }
    internal void 专丈丟丛丛一专丈丞()
    {
        this.丑不万丁丟丏丂业与 = true;
        if(this.丐且且丆丝世专不丘 != null)
        {
                this.丐且且丆丝世专不丘.Invoke();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        System.Delegate val_4 = System.Delegate.Remove(source:  this._myCenterOnChild.onCenter, value:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void ClanLootBoxCraftWeaponWindow::丆三一丐丒丁与丛下(UnityEngine.GameObject 丌丙丌一上下丂丗业)));
        if(this._myCenterOnChild == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        this._myCenterOnChild.onCenter = val_4;
        this.丌专丞专一且丟丕丑();
        this.丑不万丁丟丏丂业与 = false;
    }
    private bool 丒不丈丝丒丟丒丆下(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与, PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
    {
        var val_20;
        System.Collections.Generic.HashSet<System.String> val_21;
        var val_22;
        string val_23;
        var val_24;
        val_20 = null;
        val_20 = null;
        val_21 = WeaponManager.丆丘丘丑丌丁世七不;
        if((val_21.Contains(item:  一业一丕丅下业世与.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_8;
        }
        
        if(一业一丕丅下业世与 != null)
        {
                val_22 = 0;
            val_23 = 一业一丕丅下业世与.业上丙丞丐丄丆丅七();
        }
        else
        {
                val_22 = 0;
            val_23 = 一业一丕丅下业世与.业上丙丞丐丄丆丅七();
        }
        
        丙且上东下丏丏丟下 val_5 = null;
        val_21 = val_5;
        val_5 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_23, 七丆丒与丗丌丄且丂:  一业一丕丅下业世与);
        if(val_21 == null)
        {
            goto label_8;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return (bool)val_24;
        }
        
        if((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  val_5.丒万丕七专不丏丞丌())) == false)
        {
            goto label_13;
        }
        
        val_21 = 3;
        goto label_14;
        label_8:
        val_24 = 0;
        return (bool)val_24;
        label_13:
        label_14:
        if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() != 0)
        {
                .ItemParams = 一业一丕丅下业世与.丑丐丙丄丅世世丑丒();
            PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().丆丂东丄万三不丏丅(丐丅丒专丛丏上与业:  (((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_5.丒万丕七专不丏丞丌())) & true) != 0) ? (4 + 1) : 4, 且丘丏丁丑与丙与丁:  0, 丅丘丌且丈丘丄丗丄:  new PGCompany.丟丁且丝丁三丏丙且(与不丕丆丈不丙丟丛:  new PGCompany.StoreItemSettings()), 丞丘丞丏业且丛丏丘:  丞丘丞丏业且丛丏丘, 丑丒万丐丞丒丈专丞:  (丞丘丞丏业且丛丏丘 != 0) ? 1 : 0);
        }
        
        val_24 = 1;
        return (bool)val_24;
    }
    public void UpdateScroll()
    {
        var val_3 = public System.Int32 System.Collections.Generic.List<UnityEngine.GameObject>::get_Count();
        int val_1 = this.万丆上丆世丏丝丁下.Count;
        this.scrollView.ResetPosition();
        this._myCenterOnChild.enabled = true;
        if(this.万丆上丆世丏丝丁下.Count < 1)
        {
                return;
        }
        
        this._myCenterOnChild.Recenter();
    }
    public ClanLootBoxCraftWeaponWindow()
    {
        this.万丆上丆世丏丝丁下 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
