using UnityEngine;
internal class UniversalPromotionView : StorePromotionViewBase
{
    // Fields
    private GuiApplyersGroup mainGuiApplyersGroup;
    private System.Collections.Generic.List<UIBasicSprite> backgroundTextures;
    
    // Methods
    internal override bool 丝一丅丆三东丂丞七()
    {
        var val_12;
        var val_14;
        val_12 = this;
        if(this.丝一丅丆三东丂丞七() == false)
        {
            goto label_1;
        }
        
        if(this.mainGuiApplyersGroup == 0)
        {
            goto label_4;
        }
        
        if((下下丈一业上万丏丕.丑丑丒与丙丂世丘丛(七丆丒与丗丌丄且丂:  "GameOfferStyle", 丒丑丞丁世丌专不丈:  this.与丞丆丑东东丟丆丌().丑丕丘不丑万业丁丌())) == false)
        {
            goto label_6;
        }
        
        string val_7 = this.与丞丆丑东东丟丆丌().丑丕丘不丑万业丁丌();
        if(this.mainGuiApplyersGroup != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_1:
        val_14 = 0;
        return (bool)val_14;
        label_6:
        label_9:
        label_4:
        List.Enumerator<T> val_8 = this.backgroundTextures.GetEnumerator();
        label_18:
        if((499121544 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_9 = 0.丐丏七丌丕丗业且上();
        if(val_9 == null)
        {
            goto label_18;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_9, 与万丆丛丒万丝丙丑:  this.与丞丆丑东东丟丆丌().与丙丘丟七丘丄专丟());
        goto label_18;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_14 = 1;
        return (bool)val_14;
    }
    internal override void 丐丌丘不上且东业丘()
    {
    
    }
    internal override void 丌丆丌且丘丝丝丑丄()
    {
    
    }
    internal override void 世世丑丞丒丟业丁与()
    {
    
    }
    public UniversalPromotionView()
    {
    
    }

}
