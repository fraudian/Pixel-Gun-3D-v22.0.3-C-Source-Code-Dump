using UnityEngine;
internal sealed class SPViewComponentConstructable : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject state_Constructed;
    private UnityEngine.GameObject state_NotConstructed;
    private ItemListUI itemListUI;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> oldPrice;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfStarted;
    private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丂丅七与丘丞丟万丕;
    private PGCompany.世丞上丏丗不丛上东 丄丌上丞一丈且丌丕;
    
    // Methods
    private void OnEnable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
        if(((System.Delegate.Combine(a:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, b:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void SPViewComponentConstructable::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
    }
    private void OnDisable()
    {
        System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄> val_4;
        if(((System.Delegate.Remove(source:  PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒, value:  new System.Action<PGCompany.丕丘一丐丕上不万丁, PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void SPViewComponentConstructable::丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.丕丘一丐丕上不万丁.丗不东丝丑三不业丒 = val_4;
    }
    private void 丂业丏丏丁与丌丈不(PGCompany.丕丘一丐丕上不万丁 丌丝万上丅丒一丈丘, PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        this.丝一丅丆三东丂丞七();
    }
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_7;
        if(且丘丏丁丑与丙与丁 == null)
        {
            goto label_1;
        }
        
        val_7 = 0;
        goto label_3;
        label_1:
        this.丂丅七与丘丞丟万丕 = 0;
        goto label_4;
        label_3:
        this.丂丅七与丘丞丟万丕 = ;
        label_4:
        if((PGCompany.七丂专七丆丗不丌专.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与(), 丞世不丒下上上丝丑: out  0)) != false)
        {
                this.丄丌上丞一丈且丌丕 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丞世不丒下上上丝丑:  0);
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        object val_13;
        var val_14;
        var val_15;
        val_13 = this;
        if(this.丄丌上丞一丈且丌丕 == null)
        {
                return;
        }
        
        if(this.丂丅七与丘丞丟万丕 == null)
        {
            goto label_3;
        }
        
        TagSystem.三与下丘七丘丌丏丄 val_1 = this.丂丅七与丘丞丟万丕.与不丞丑七丘丁丂丛();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        string val_13 = "constructable_can_purchased";
        val_13 = val_1.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_13);
        val_14 = 0;
        goto label_4;
        label_3:
        val_14 = 0;
        label_4:
        if((255539228 & 1) != 0)
        {
                if(val_14.GetValueOrDefault() == true)
        {
            goto label_6;
        }
        
        }
        
        if(this.丂丅七与丘丞丟万丕 == null)
        {
            goto label_8;
        }
        
        TagSystem.三与下丘七丘丌丏丄 val_4 = this.丂丅七与丘丞丟万丕.与不丞丑七丘丁丂丛();
        if(val_4 == null)
        {
            goto label_8;
        }
        
        string val_14 = "state.purchased";
        val_14 = val_4.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_14);
        val_15 = 0;
        goto label_9;
        label_8:
        val_15 = 0;
        label_9:
        if(((255539228 & 1) != 0) && (val_15.GetValueOrDefault() != false))
        {
                label_6:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Constructed, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotConstructed, 丏业丟一东丂东丘丛:  false);
            this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丂丅七与丘丞丟万丕);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<PGCompany.InventoryItemView>(不丗上三丛丒上东丑:  this.oldPrice, 丏业丟一东丂东丘丛:  (this.丄丌上丞一丈且丌丕.丑专不且丒丄丏丝丞() != 0) ? 1 : 0);
            this.oldPrice.ForEach(action:  new System.Action<PGCompany.InventoryItemView>(object:  this, method:  System.Void SPViewComponentConstructable::万丄专且一丈丌上丌(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)));
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Constructed, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NotConstructed, 丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfStarted, 丏业丟一东丂东丘丛:  true);
        int val_15 = this.丄丌上丞一丈且丌丕.上丟丄与丁三丌丘专();
        val_15 = val_15 - PixelTime.丝丗专上三不丄丑丑();
        if(val_15 < 1)
        {
                return;
        }
        
        if(this.丄丌上丞一丈且丌丕.上丟丄与丁三丌丘专() < 1)
        {
                return;
        }
        
        val_13 = this.enableIfStarted;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
    }
    public SPViewComponentConstructable()
    {
        val_1 = new PGBehaviour();
    }
    private void 万丄专且一丈丌上丌(PGCompany.InventoryItemView 三丟东丕丄丄下下丑)
    {
        if(三丟东丕丄丄下下丑 == null)
        {
                return;
        }
        
        三丟东丕丄丄下下丑.Setup(丈丄不七三万丄丁不:  this.丄丌上丞一丈且丌丕.丑专不且丒丄丏丝丞());
    }

}
