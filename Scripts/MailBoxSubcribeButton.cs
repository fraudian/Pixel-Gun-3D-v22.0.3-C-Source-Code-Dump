using UnityEngine;
internal sealed class MailBoxSubcribeButton : PGBehaviour
{
    // Fields
    private UILabel RewardCount;
    private UnityEngine.GameObject RewardIconGems;
    private UnityEngine.GameObject RewardIconCoins;
    private UILabel RewardText;
    
    // Methods
    internal void 丑丗丛三丏丆丞七丁(丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, 丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
    {
        UILabel val_9;
        string val_10;
        string val_11;
        string val_12;
        UnityEngine.GameObject val_13;
        var val_14;
        val_9 = 丑丑丞专丒丙丒东不;
        val_10 = 万丐丏丐丒万不丟三;
        if(val_9 == null)
        {
                return;
        }
        
        if((丑丑丞专丒丙丒东不.TextButtonReward.Equals(value:  System.String.alignConst)) == false)
        {
            goto label_3;
        }
        
        val_11 = "subscribe";
        丑丑丞专丒丙丒东不.TextButtonReward = val_11;
        if("subscribe" != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_11 = 丑丑丞专丒丙丒东不.TextButtonReward;
        if(val_11 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_9 = this.RewardText;
        if((val_11.Equals(value:  "subscribe")) != false)
        {
                val_12 = "Key_8787";
        }
        else
        {
                val_12 = "Key_8786";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_9, 丕丗丘丑丛与丑业丒:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  val_12));
        if(val_10 == null)
        {
                return;
        }
        
        val_9 = this.RewardIconGems;
        if((val_10.东与三丌丅三丒丏业().Replace(oldValue:  "Currency", newValue:  System.String.alignConst).Equals(value:  "Gems")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
            val_13 = this.RewardIconCoins;
            val_14 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
            val_13 = this.RewardIconCoins;
            val_14 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        val_10 = System.String.Format(format:  "+{0}", arg0:  val_10.丟丂丞不专丆万丒世());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RewardCount, 丕丗丘丑丛与丑业丒:  val_10);
    }
    public MailBoxSubcribeButton()
    {
    
    }

}
