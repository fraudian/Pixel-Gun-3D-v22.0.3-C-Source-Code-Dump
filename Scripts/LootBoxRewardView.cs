using UnityEngine;
internal sealed class LootBoxRewardView : PGBehaviour
{
    // Fields
    private PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 专丌丕丆世丂万东万;
    private PGCompany.InventoryItemView itemView;
    private ItemCountView itemRangeView;
    private TagSpecificObject tagSpecificObject;
    private UnityEngine.GameObject countView_Amount;
    private UnityEngine.GameObject countView_Unique;
    private UnityEngine.GameObject countView_Range;
    private UnityEngine.GameObject obtained;
    private UIWidget texture;
    private float normalAlpha;
    private float obtainedAlpha;
    
    // Properties
    internal PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丗上丆专不上丏丏丒 { get; }
    
    // Methods
    internal PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 与丝三丁丆三丒丞且()
    {
        return (PGCompany.LootBoxSystem.丗上丆专不上丏丏丒)this.专丌丕丆世丂万东万;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丆丈丑丅东丙丘三且)
    {
        this.专丌丕丆世丂万东万 = 丆丈丑丅东丙丘三且;
        this.itemView.Setup(丈丄不七三万丄丁不:  丆丈丑丅东丙丘三且.三东丏不丗世丅丌丄);
        this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  丆丈丑丅东丙丘三且.一丟丘万世一下不下);
        this.不丆不东专东丞且不();
    }
    private void 不丆不东专东丞且不()
    {
        PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 val_7;
        var val_8;
        UnityEngine.GameObject val_9;
        var val_10;
        UIWidget val_11;
        float val_12;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countView_Amount, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countView_Unique, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countView_Range, 丏业丟一东丂东丘丛:  false);
        val_7 = this.专丌丕丆世丂万东万;
        if(val_7 == null)
        {
                return;
        }
        
        if(this.专丌丕丆世丂万东万.且丟一丛丈丅丑世七 == 3)
        {
            goto label_4;
        }
        
        if(this.专丌丕丆世丂万东万.且丟一丛丈丅丑世七 == 2)
        {
            goto label_5;
        }
        
        if(this.专丌丕丆世丂万东万.且丟一丛丈丅丑世七 != 1)
        {
            goto label_6;
        }
        
        val_8 = null;
        val_9 = this.countView_Amount;
        goto label_23;
        label_4:
        if(this.itemRangeView == 0)
        {
            goto label_21;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countView_Range, 丏业丟一东丂东丘丛:  true);
        this.itemRangeView.七七丛不东丁三丐丝(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}-{1}", arg0:  this.专丌丕丆世丂万东万.丞专丏上丈丆下东丛.From, arg1:  this.专丌丕丆世丂万东万.丞专丏上丈丆下东丛.To));
        goto label_21;
        label_5:
        val_8 = null;
        val_9 = this.countView_Unique;
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        label_21:
        val_7 = this.专丌丕丆世丂万东万;
        if(val_7 == null)
        {
            goto label_24;
        }
        
        label_6:
        if(this.专丌丕丆世丂万东万.丞东丛丅下万不业与 != false)
        {
                val_10 = this.专丌丕丆世丂万东万.一丟丘万世一下不下.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "reward.obtained");
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.obtained, 丏业丟一东丂东丘丛:  val_10 & 1);
        val_11 = this.texture;
        if(val_11 == 0)
        {
                return;
        }
        
        val_11 = this.texture;
        if((val_10 & 1) != 0)
        {
                val_12 = this.obtainedAlpha;
            if(val_11 != null)
        {
                return;
        }
        
            return;
        }
        
        val_12 = this.normalAlpha;
        if(val_11 != null)
        {
                return;
        }
        
        return;
        label_24:
    }
    public LootBoxRewardView()
    {
        this.normalAlpha = 1f;
        this.obtainedAlpha = 5.877466E-41f;
    }

}
