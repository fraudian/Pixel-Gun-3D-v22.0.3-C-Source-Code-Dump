using UnityEngine;
internal sealed class 七三丌丙下丅不丕丞.丄下三丞万丐一丆丏
{
    // Fields
    internal 丏丒丏上丄七丘丌丅 Group;
    internal ItemRarity Rarity;
    internal Rilisoft.丝丑丂丛万丐丈丘且 LackAmount;
    internal Rilisoft.丝丑丂丛万丐丈丘且 PriceItemIndex;
    internal Rilisoft.丂上丐丄丛一一丒七 PriceValue;
    internal Rilisoft.丂上丐丄丛一一丒七 PriceModifyMin;
    internal Rilisoft.丂上丐丄丛一一丒七 PriceModifyMax;
    
    // Methods
    public override string ToString()
    {
        string[] val_1 = new string[7];
        string val_2 = System.String.Format(format:  "group={0} ", arg0:  this.Group);
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = System.String.Format(format:  "rarity={0} ", arg0:  this.Rarity);
        val_1[2] = System.String.Format(format:  "lackAmount={0} ", arg0:  this.LackAmount);
        val_1[3] = System.String.Format(format:  "priceItemIndex={0} ", arg0:  this.PriceItemIndex);
        val_1[4] = System.String.Format(format:  "priceValue={0} ", arg0:  this.PriceValue);
        val_1[5] = System.String.Format(format:  "priceModifyMin={0} ", arg0:  this.PriceModifyMin);
        val_1[6] = System.String.Format(format:  "priceModifyMax={0}", arg0:  this.PriceModifyMax);
        return (string)+val_1;
    }
    public 七三丌丙下丅不丕丞.丄下三丞万丐一丆丏()
    {
    
    }

}
