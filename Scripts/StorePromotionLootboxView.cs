using UnityEngine;
internal sealed class StorePromotionLootboxView : StorePromotionView
{
    // Fields
    private UIBasicSprite _icon;
    private UILabel _countLbl;
    private UISprite _countBar;
    private UnityEngine.GameObject _priceContainer;
    private UnityEngine.GameObject _buyContainer;
    private PGCompany.TimerUI _timer;
    private UILabel _buffPointsLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> _enableIfSuperchest;
    protected UnityEngine.GameObject singleOpenUI;
    protected UnityEngine.GameObject multiOpenUI;
    protected PGCompany.InventoryItemView _priceMultiUI;
    private PGCompany.七东万三万丒丏一丁 丂丂东且丐丗丗不一;
    
    // Methods
    private void OnEnable()
    {
        this.丈丌一一丞且万丌三();
        PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void StorePromotionLootboxView::丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        PGCompany.世东三上七丂丌下丑.专且丞七丟丌一丝丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void StorePromotionLootboxView::丐丁万丙丄业丐且丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
    }
    private void OnDisable()
    {
        PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void StorePromotionLootboxView::丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
        PGCompany.世东三上七丂丌下丑.丑丗丟丑丑丒丈一不(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void StorePromotionLootboxView::丐丁万丙丄业丐且丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
    }
    public override void U_Purchase()
    {
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return;
        }
        
        if((this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七().Equals(value:  "ClanLootBoxPoints")) != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
                return;
        }
        
        }
        
        this.U_Purchase();
    }
    private void 丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
    {
        if((丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业上丙丞丐丄丆丅七().Equals(value:  "ClanLootBoxPoints")) == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(StorePromotionLootboxView).__il2cppRuntimeField_198;
    }
    private void 丐丁万丙丄业丐且丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        if((丈丄不七三万丄丁不.业上丙丞丐丄丆丅七().Equals(value:  "ClanLootBoxPoints")) == false)
        {
                return;
        }
        
        this = ???;
        goto typeof(StorePromotionLootboxView).__il2cppRuntimeField_198;
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_3;
        PGCompany.七东万三万丒丏一丁 val_39;
        UnityEngine.Texture val_40;
        PGCompany.丗丟丄丈东丝丕丄世 val_41;
        var val_42;
        var val_43;
        PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.与丞丆丑东东丟丆丌();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_39 = val_1.三丘丆丅丝丙一丑与();
        if(this == null)
        {
            goto label_2;
        }
        
        label_5:
        if(val_39 != null)
        {
            goto label_3;
        }
        
        goto label_7;
        label_1:
        val_39 = 0;
        if(this != null)
        {
            goto label_5;
        }
        
        label_2:
        if(val_39 == 0)
        {
            goto label_7;
        }
        
        label_3:
        if(1179403647 != null)
        {
                val_39 = 0;
        }
        
        label_7:
        this.丂丂东且丐丗丗不一 = val_39;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  X21.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._enableIfSuperchest, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buffPointsLabel, 丏业丟一东丂东丘丛:  false);
        val_40 = this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不();
        if(this.丂丂东且丐丗丗不一.世一下丕丟不不丌丈() != true)
        {
                if(val_40 != 11015)
        {
            goto label_15;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.multiOpenUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.singleOpenUI, 丏业丟一东丂东丘丛:  true);
        label_55:
        if(this.丝一丅丆三东丂丞七() == false)
        {
            goto label_18;
        }
        
        string val_10 = this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七();
        if((val_10.Equals(value:  "ClanLootBoxPoints")) == false)
        {
            goto label_22;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._enableIfSuperchest, 丏业丟一东丂东丘丛:  true);
        val_3 = 0;
        val_41 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        val_40 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不());
        if(val_41 != null)
        {
                val_41 = val_41;
        }
        
        val_42 = this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌();
        float val_38 = (float)val_41;
        val_38 = val_38 / (float)val_42;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._countBar, 丙业与丙丗丝不丈东:  val_38);
        if(val_41 >= this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌())
        {
            goto label_38;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._priceContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._icon, 与万丆丛丒万丝丙丑:  val_40);
        val_40 = this._countLbl;
        val_42 = 1152921504622075904;
        val_3 = val_41;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_40, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} / {1}", arg0:  val_3, arg1:  this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌()));
        goto label_61;
        label_18:
        val_43 = 0;
        return (bool)val_43;
        label_15:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.multiOpenUI, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.singleOpenUI, 丏业丟一东丂东丘丛:  false);
        if((this._priceMultiUI == 0) || (this.与丞丆丑东东丟丆丌() == null))
        {
            goto label_55;
        }
        
        this._priceMultiUI.Setup(丈丄不七三万丄丁不:  this.与丞丆丑东东丟丆丌());
        goto label_55;
        label_22:
        int val_30 = PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  this.丂丂东且丐丗丗不一);
        val_40 = this._buffPointsLabel;
        val_3 = this.丂丂东且丐丗丗不一.丂万丞与丈丙丅丝七() + val_30;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_40, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "+{0}", arg0:  val_3));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buffPointsLabel, 丏业丟一东丂东丘丛:  (val_30 > 0) ? 1 : 0);
        goto label_61;
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyContainer, 丏业丟一东丂东丘丛:  true);
        label_61:
        if(this.丂丂东且丐丗丗不一 != null)
        {
                int val_35 = 丌丅且丗七丘丅丛丑.七丛一且丝丆上丅丑(专业丗丛不丕七丐东:  this.丂丂东且丐丗丗不一);
            if(val_35 >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丂丂东且丐丗丗不一, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丂丂东且丐丗丗不一, 丕丗丘丑丛与丑业丒:  val_35.ToString());
        }
        
        }
        
        if(this.isActiveAndEnabled != false)
        {
                this.丈丌一一丞且万丌三();
        }
        
        val_43 = 1;
        return (bool)val_43;
    }
    private void 丈丌一一丞且万丌三()
    {
        int val_14;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  false);
        if(this.丂丂东且丐丗丗不一 == null)
        {
                return;
        }
        
        if(this.与丞丆丑东东丟丆丌().不业丙丒丂丞下丆丙() != 1)
        {
                return;
        }
        
        val_14 = this.丂丂东且丐丗丗不一.业东丅东丌上丗丑不();
        if((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝丞东业丌丐与不丕(丏专丒丅丙七三专丐:  val_14)) == false)
        {
                return;
        }
        
        val_14 = this.丂丂东且丐丗丗不一.业东丅东丌上丗丑不();
        if((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  val_14)) == true)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  true);
        System.TimeSpan val_11 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝三丅下丂丘下丐专(丏专丒丅丙七三专丐:  this.丂丂东且丐丗丗不一.业东丅东丌上丗丑不());
        System.Action val_13 = null;
        val_14 = val_13;
        val_13 = new System.Action(object:  this, method:  System.Void StorePromotionLootboxView::丅丅东万丟丄丗丘丏());
        this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  (int)val_11._ticks.TotalSeconds, 三丘丄丕丂丏东不丛:  val_13, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
    }
    public StorePromotionLootboxView()
    {
    
    }
    private void 丅丅东万丟丄丗丘丏()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timer, 丏业丟一东丂东丘丛:  false);
    }

}
