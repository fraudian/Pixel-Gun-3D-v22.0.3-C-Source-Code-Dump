using UnityEngine;
internal sealed class StorePromotionLootboxGiftView : StorePromotionView
{
    // Fields
    private UILabel _giftButtonLabel;
    private UILabel _boxesCountLabel;
    
    // Methods
    internal override bool 丝一丅丆三东丂丞七()
    {
        UILabel val_14;
        var val_15;
        val_14 = this;
        this.丕丄丆业丐丐丟丏丗();
        if(this.与丞丆丑东东丟丆丌() == null)
        {
                return (bool)val_15;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_3 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  X21, 丕丗丘丑丛与丑业丒:  this.与丞丆丑东东丟丆丌());
        X21.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._giftButtonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8346"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._boxesCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8459"), arg0:  this.与丞丆丑东东丟丆丌().丂丁丏一丙丛业且丌()));
        if((val_3 != null) && (null == null))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  丌丅且丗七丘丅丛丑.丞丛丈丐丂丞丅上东().ToString());
        }
        
        val_15 = 1;
        return (bool)val_15;
    }
    private void 丕丄丆业丐丐丟丏丗()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  137121792, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  137121792, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  137121792, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  137121792, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  137121792, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  137121792, 丏业丟一东丂东丘丛:  false);
    }
    public StorePromotionLootboxGiftView()
    {
    
    }

}
