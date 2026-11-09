using UnityEngine;
internal class ConstructableBankViewItem : AbstractBankViewItem
{
    // Fields
    private UILabel _titleLabel;
    private UILabel _descriptionLabel;
    private PGCompany.InventoryItemView _priceUi;
    private UnityEngine.GameObject _state_CanBuy;
    private UnityEngine.GameObject _state_CantBuy;
    private ItemListUI _itemListUI;
    private PGCompany.TimerUI _timerUI;
    private UnityEngine.GameObject _profitContainer;
    private UILabel _profitLabel;
    private UIBasicSprite _texture;
    private PGCompany.世丞上丏丗不丛上东 丄丌上丞一丈且丌丕;
    private PGCompany.东丑丆丗丏丐丟下丄 丂丅七与丘丞丟万丕;
    private PGCompany.StorePromotionInfoUIAbstract 丕丐丏丈丐丕丕且丞;
    
    // Methods
    protected override void OnEnable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_5;
        if(((System.Delegate.Combine(a:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, b:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableBankViewItem::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_5;
        PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void ConstructableBankViewItem::且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)));
    }
    protected override void OnDisable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_5;
        if(((System.Delegate.Remove(source:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, value:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableBankViewItem::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_5;
        PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void ConstructableBankViewItem::且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)));
    }
    protected override void 丞业与下丛万丁下丙()
    {
    
    }
    public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
    {
        this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丛与世且丑丅丟下丛);
        PGCompany.世丞上丏丗不丛上东 val_3 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  丙业丞丑七丗下丟丌.丏不丁丛丕丒丏丆丂());
        this.丄丌上丞一丈且丌丕 = val_3;
        if(val_3.丞丝丂东丏七丝丈且() != false)
        {
                if((this.丄丌上丞一丈且丌丕.专丞丅东且三丆世与(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int32>() {HasValue = false})) >= 1)
        {
                this.丂丅七与丘丞丟万丕 = PGCompany.七丂专七丆丗不丌专.丞专丛丏丘丁丕丕丘(丙业丞丑七丗下丟丌:  this.丄丌上丞一丈且丌丕);
        }
        
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_4;
        if(this.丂丅七与丘丞丟万丕 == null)
        {
                return;
        }
        
        if(this.丄丌上丞一丈且丌丕 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  this.丂丅七与丘丞丟万丕);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  this.丂丅七与丘丞丟万丕);
        val_4 = this.丂丅七与丘丞丟万丕;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._descriptionLabel, 丕丗丘丑丛与丑业丒:  val_4);
        if(this._priceUi != 0)
        {
                val_4 = this.丂丅七与丘丞丟万丕;
            this._priceUi.Setup(丈丄不七三万丄丁不:  val_4);
        }
        
        if(this.丄丌上丞一丈且丌丕.与丈丟东丆丅丅丝丁() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._state_CanBuy, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._state_CantBuy, 丏业丟一东丂东丘丛:  false);
            this.且东丝丟丙专丄丒丂();
            val_4 = this.丄丌上丞一丈且丌丕.三丕丂丝丙丆丅三丞();
            this._itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_4);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._state_CanBuy, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._state_CantBuy, 丏业丟一东丂东丘丛:  true);
        }
        
        this.丝丂丕东专世丅丝丁();
    }
    private void 且东丝丟丙专丄丒丂()
    {
        var val_7;
        decimal val_1 = this.丂丅七与丘丞丟万丕.万丏丛上丌丏业三不();
        val_7 = null;
        val_7 = null;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitContainer, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._profitContainer, 丏业丟一东丂东丘丛:  true);
        decimal val_4 = this.丂丅七与丘丞丟万丕.万丏丛上丌丏业三不();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._profitLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5570"), arg0:  val_4)(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5570"), arg0:  val_4)) + "%"("%"));
    }
    private void 丝丂丕东专世丅丝丁()
    {
        object val_3;
        var val_4;
        UnityEngine.MonoBehaviour val_5;
        val_3 = this;
        int val_1 = this.丄丌上丞一丈且丌丕.专丞丅东且三丆世与(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int32>() {HasValue = false});
        if(val_1 >= 1)
        {
                this._timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_1, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ConstructableBankViewItem::丝丂丕东专世丅丝丁()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_3 = this._timerUI;
            val_4 = 1;
            val_5 = val_3;
        }
        else
        {
                val_5 = this._timerUI;
            val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
    }
    private void 且丌东七丒不专丗七(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七, object 一丐丗丁丞丆丅丟丄)
    {
        PGCompany.专丟专世丅丂丁且专 val_2 = this.丂丅七与丘丞丟万丕.七丈丒丒下下且万与();
        var val_5 = 0;
        val_5 = val_5 + 1;
        if((丐丆丝业丙丈下世丁.七丈丒丒下下且万与().Equals(other:  ???)) == false)
        {
                return;
        }
        
        this.丂丅七与丘丞丟万丕 = 丐丆丝业丙丈下世丁;
        this.丝一丅丆三东丂丞七();
    }
    private void 丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.丝一丅丆三东丂丞七();
    }
    public void U_Purchase()
    {
        this.丛丁丏丏丄下丈下下();
    }
    private void 丛丁丏丏丄下丈下下()
    {
        PGCompany.东丑丆丗丏丐丟下丄 val_15;
        PGCompany.三东丏不丗世丅丌丄 val_16;
        var val_17;
        var val_18;
        val_15 = this;
        if(this.丂丅七与丘丞丟万丕 == null)
        {
                return;
        }
        
        val_16 = this.丂丅七与丘丞丟万丕.且丏三丞丝丟丘丅丕();
        if(this.丂丅七与丘丞丟万丕 == null)
        {
            goto label_2;
        }
        
        if(val_16 == false)
        {
            goto label_3;
        }
        
        label_4:
        this.丂丅七与丘丞丟万丕.丈丙且一万丟丕万下();
        return;
        label_2:
        if(val_16 == true)
        {
            goto label_4;
        }
        
        label_3:
        if(((this.丂丅七与丘丞丟万丕 == null) || (this.丂丅七与丘丞丟万丕.业东丅东丌上丗丑不() == 10015)) || (this.丂丅七与丘丞丟万丕.业东丅东丌上丗丑不() == 11015))
        {
            goto label_11;
        }
        
        val_16 = this.丂丅七与丘丞丟万丕;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_16, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_14;
        }
        
        label_11:
        val_15 = this.丂丅七与丘丞丟万丕;
        val_15.丏丝丘七丕与世丅丆();
        return;
        label_14:
        if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() != false)
        {
                BankController.丑七不且上丗丁一世().丈丄丁与丝丌丛与世(丈丄不七三万丄丁不:  this.丂丅七与丘丞丟万丕);
        }
        else
        {
                val_17 = null;
            val_17 = null;
            BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
            val_18 = null;
            val_18 = null;
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  ConstructableBankViewItem.<>c.<>9, method:  System.Void ConstructableBankViewItem.<>c::东丘丕丞七丑丟下业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  this.丂丅七与丘丞丟万丕.业上丙丞丐丄丆丅七(), 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  "");
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
    }
    public ConstructableBankViewItem()
    {
    
    }

}
