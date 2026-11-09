using UnityEngine;
internal class CurrencyUI : MonoBehaviour
{
    // Fields
    private UISprite iconSprite;
    private UILabel priceLabel;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三)
    {
        string val_3;
        var val_4;
        if(万丐丏丐丒万不丟三 != null)
        {
                val_3 = 万丐丏丐丒万不丟三.东与三丌丅三丒丏业();
            val_4 = 万丐丏丐丒万不丟三.丟丂丞不专丆万丒世();
        }
        else
        {
                val_4 = 0;
            val_3 = "";
        }
        
        this.丈且东丑丂且万丒丅(丒世丘丘上丆丝东丞:  0, 七丈丟下世三万丙丄:  val_3);
    }
    internal void 丈且东丑丂且万丒丅(int 丒世丘丘上丆丝东丞, string 七丈丟下世三万丙丄)
    {
        UISprite val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = this;
        this.priceLabel.text = 丒世丘丘上丆丝东丞.ToString();
        val_11 = null;
        val_11 = null;
        if((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
        {
                val_12 = "item_levelup_gems";
        }
        else
        {
                val_13 = null;
            val_13 = null;
            if((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
        {
                val_12 = "item_levelup_coin";
        }
        else
        {
                if((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  "CraftCurrency")) != false)
        {
                val_12 = "CraftCurrency";
        }
        else
        {
                if((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  "BattlePassCurrency")) != false)
        {
                val_12 = "item_BattlePassCurrency";
        }
        else
        {
                if((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  "EventCurrency")) != false)
        {
                val_12 = "item_EventCurrency";
        }
        else
        {
                string val_8 = ((System.String.op_Equality(a:  七丈丟下世三万丙丄, b:  "Coupons")) != true) ? "coupon_icon" : "";
        }
        
        }
        
        }
        
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  val_8)) == true)
        {
                return;
        }
        
        val_10 = this.iconSprite;
        val_10.spriteName = val_8;
    }
    public CurrencyUI()
    {
    
    }

}
