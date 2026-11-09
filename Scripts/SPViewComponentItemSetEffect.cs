using UnityEngine;
internal sealed class SPViewComponentItemSetEffect : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject _body;
    private UILabel _craftSetNameLabel;
    private UILabel _craftSetDescription;
    private UISprite _craftSetMiniIcon;
    private UISprite _craftSetMainIcon;
    private UILabel _hasSetEffectLabel;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_4;
        UILabel val_15;
        var val_16;
        丛且专丞丗丆丙丒万 val_17;
        var val_18;
        val_15 = this;
        SPViewComponentItemSetEffect.丘丞上世丗丘丏丐东 val_1 = new SPViewComponentItemSetEffect.丘丞上世丗丘丏丐东();
        if(val_1 != null)
        {
                val_16 = val_1;
            .且丘丏丁丑与丙与丁 = 且丘丏丁丑与丙与丁;
            mem[1152921539228325272] = 且丘丏丁丑与丙与丁;
        }
        else
        {
                val_16 = 16;
            mem[16] = 且丘丏丁丑与丙与丁;
            mem[1152921539228325272] = mem[16];
        }
        
        val_17 = val_16;
        List.Enumerator<T> val_2 = val_17.GetEnumerator();
        val_18 = 1152921525631264896;
        label_8:
        if((261727760 & 1) == 0)
        {
            goto label_5;
        }
        
        val_17 = 丙丞丟丑丗丅专丈一.上丕丌丙丂丗丄三一(丈丄不七三万丄丁不:  val_4.丐丏七丌丕丗业且上());
        if(val_17 == null)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        bool val_9 = System.Linq.Enumerable.All<PGCompany.三东丏不丗世丅丌丄>(source:  丙丞丟丑丗丅专丈一.丐丟丛与丗且专丘业(丂万丏专丒下丈丂丟:  val_17), predicate:  new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  val_1, method:  System.Boolean SPViewComponentItemSetEffect.丘丞上世丗丘丏丐东::丆一且世上丗上一丗(PGCompany.三东丏不丗世丅丌丄 丗丛丂且丕丆上世丛)));
        val_18 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  val_9);
        if(val_9 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._craftSetNameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4587"));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._craftSetDescription, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6.丟三丞丝专且丅丟万));
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._craftSetMiniIcon, 万丑丞一丝丌丐丒丘:  val_6.下不丑丟世丈世丈丞);
        val_17 = val_6.下丄丈不与世丐业专;
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this._craftSetMainIcon, 万丑丞一丝丌丐丒丘:  丙丞丟丑丗丅专丈一.丝世丝丌丝丝万丌七(丐世下不一丁丟丅专:  val_17));
        val_15 = this._hasSetEffectLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11140"));
        return;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = this._body;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  false);
    }
    public SPViewComponentItemSetEffect()
    {
        val_1 = new PGBehaviour();
    }

}
