using UnityEngine;
internal sealed class PixelPassBuyLevelView : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView price;
    private UILabel levelCountLabel;
    private UnityEngine.AudioClip buySound;
    private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
    private int 专七丕丒丈与丏一业;
    
    // Properties
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑万丆丏丘七世上丐 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丙丙丕万东丘下丅丌 丘丗不丂世丘三三丙()
    {
        return (PGCompany.PixelPass.丙丙丕万东丘下丅丌)this.丑与万三丐丒丏一专;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丐丑世东丈丑三业丘)
    {
        this.丑与万三丐丒丏一专 = 丈丂七世丟丞丂丗丒;
        this.专七丕丒丈与丏一业 = 丐丑世东丈丑三业丘;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12450"), arg0:  丐丑世东丈丑三业丘));
        if(this.price == null)
        {
                return;
        }
        
        this.price.Setup(丈丄不七三万丄丁不:  PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.与七丞万东丘丗下丒(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丌与丅丌丒丅丄丆丁:  this.专七丕丒丈与丏一业));
    }
    public void U_BuyLevelPressed()
    {
        if((PGCompany.PixelPass.丘丏丅丆丑下业丙七.不丒万丅丝业万业丏(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 丐丑世东丈丑三业丘:  this.专七丕丒丈与丏一业)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.buySound)) == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.buySound);
    }
    public void U_CancelBuyLevelPressed()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public PixelPassBuyLevelView()
    {
    
    }

}
