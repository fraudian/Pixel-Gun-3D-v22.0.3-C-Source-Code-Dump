using UnityEngine;
public class GiftRecipientDynamicWrapItem : DynamicWrapGridItem
{
    // Fields
    private GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 <丂与丘三下丅丟丒丞>k__BackingField;
    private UITexture playerTexture;
    private UITexture rankTexture;
    private UILabel rankName;
    private UILabel playerName;
    private UILabel giftLimitTitle;
    private UILabel level;
    
    // Properties
    public GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 丅丂丄丄世且丗上丄 { get; set; }
    
    // Methods
    public GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 get_ViewData()
    {
        return (一丄丙丐丄业丘东丕)this.<丂与丘三下丅丟丒丞>k__BackingField;
    }
    private void 三丂丆丏丞七业七专(GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 丙业与丙丗丝不丈东)
    {
        this.<丂与丘三下丅丟丒丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        this.不丘丆丝且丘丒丁丘();
        this.<丂与丘三下丅丟丒丞>k__BackingField = 0;
    }
    private void 丘丁丏丑与丞丛三且(GiftRecipientDynamicWrapItem.与丂世丟丟七一丐丞 一丐丗丁丞丆丅丟丄)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerTexture, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerName, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.level, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rankName, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.playerName, 丕丗丘丑丛与丑业丒:  X22);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.level, 丕丗丘丑丛与丑业丒:  null);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rankName, 丕丗丘丑丛与丑业丒:  七丈丗不丞丈丝丙七.丕下与与丂七丈业上(丕万丐东与一丈万与:  一丐丗丁丞丆丅丟丄.<业丕三丞丘一丒丙丈>k__BackingField));
    }
    private void 业丅丙丁且丆专丅专(GiftRecipientDynamicWrapItem.一丄丙丐丄业丘东丕 一丐丗丁丞丆丅丟丄)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerTexture, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerName, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.level, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.playerName, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.<丑业丑上丗丐丏丝七>k__BackingField);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.level, 丕丗丘丑丛与丑业丒:  一丐丗丁丞丆丅丟丄.<丟不丆上与三不不丞>k__BackingField);
    }
    private void 不丘丆丝且丘丒丁丘()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerTexture, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rankTexture, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.playerName, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.level, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.giftLimitTitle, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rankName, 丏业丟一东丂东丘丛:  false);
    }
    public GiftRecipientDynamicWrapItem()
    {
    
    }

}
