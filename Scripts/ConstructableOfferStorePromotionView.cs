using UnityEngine;
internal sealed class ConstructableOfferStorePromotionView : StorePromotionView
{
    // Fields
    private UnityEngine.GameObject state_CanBuy;
    private UnityEngine.GameObject state_CantBuy;
    private ItemListUI itemListUI;
    private PGCompany.TimerUI timerUI;
    private PGCompany.世丞上丏丗不丛上东 丄丌上丞一丈且丌丕;
    
    // Methods
    private void OnEnable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
        if(((System.Delegate.Combine(a:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, b:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableOfferStorePromotionView::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
    }
    private void OnDisable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
        if(((System.Delegate.Remove(source:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, value:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void ConstructableOfferStorePromotionView::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.专丟专世丅丂丁且专 val_6;
        int val_2 = 0;
        val_6 = 且丘丏丁丑与丙与丁.七丈丒丒下下且万与();
        if((PGCompany.七丂专七丆丗不丌专.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  val_6, 丞世不丒下上上丝丑: out  val_2)) != false)
        {
                val_6 = val_2;
            this.丄丌上丞一丈且丌丕 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  0);
        }
        
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
    }
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_5;
        UnityEngine.GameObject val_6;
        val_5 = this.丝一丅丆三东丂丞七();
        if(this.丄丌上丞一丈且丌丕 == null)
        {
            goto label_1;
        }
        
        val_6 = this.state_CanBuy;
        if(this.丄丌上丞一丈且丌丕.与丈丟东丆丅丅丝丁() == false)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CantBuy, 丏业丟一东丂东丘丛:  false);
        val_6 = this.itemListUI;
        val_6.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丄丌上丞一丈且丌丕.三丕丂丝丙丆丅三丞());
        goto label_7;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_CantBuy, 丏业丟一东丂东丘丛:  true);
        label_7:
        this.丝丂丕东专世丅丝丁();
        return (bool)val_5;
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
                this.timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_1, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ConstructableOfferStorePromotionView::丝丂丕东专世丅丝丁()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_3 = this.timerUI;
            val_4 = 1;
            val_5 = val_3;
        }
        else
        {
                val_5 = this.timerUI;
            val_4 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
    }
    private void 丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        goto typeof(ConstructableOfferStorePromotionView).__il2cppRuntimeField_198;
    }
    public ConstructableOfferStorePromotionView()
    {
    
    }

}
