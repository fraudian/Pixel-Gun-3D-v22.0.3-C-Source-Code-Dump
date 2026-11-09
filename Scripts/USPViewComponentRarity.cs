using UnityEngine;
internal sealed class USPViewComponentRarity : SPViewComponentBase
{
    // Fields
    private UnityEngine.GameObject body;
    private UILabel firstItemRarityLabel;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_6;
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "view.disable.rarity")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.body, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.body, 丏业丟一东丂东丘丛:  true);
        val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(且丘丏丁丑与丙与丁 == null)
        {
            goto label_8;
        }
        
        if(val_6 != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        PGCompany.丗丟丄丈东丝丕丄世 val_5 = val_6.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  且丘丏丁丑与丙与丁));
        if(val_5 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.firstItemRarityLabel, 丕丗丘丑丛与丑业丒:  val_5);
        return;
        label_8:
        if(val_6 != null)
        {
            goto label_13;
        }
        
        goto label_14;
    }
    public USPViewComponentRarity()
    {
    
    }

}
