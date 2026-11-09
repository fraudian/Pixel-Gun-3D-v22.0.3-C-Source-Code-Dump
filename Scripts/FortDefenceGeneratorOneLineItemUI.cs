using UnityEngine;
internal sealed class FortDefenceGeneratorOneLineItemUI : PGBehaviour
{
    // Fields
    private UISprite _backSprite;
    private DamageableObject 七一丕上丄上万不不;
    
    // Methods
    internal void 世丂丕丁丙丙且业丄(DamageableObject 丂丈丙且丈丗三丆丕)
    {
        if(this.七一丕上丄上万不不 != 0)
        {
                this.七一丕上丄上万不不.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorOneLineItemUI::上专世丌丑与丕丛丕()));
        }
        
        this.七一丕上丄上万不不 = 丂丈丙且丈丗三丆丕;
        丂丈丙且丈丗三丆丕.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceGeneratorOneLineItemUI::上专世丌丑与丕丛丕()));
    }
    private void 上专世丌丑与丕丛丕()
    {
        float val_2 = this.七一丕上丄上万不不.maxHealth;
        val_2 = this.七一丕上丄上万不不.三丏丟不丆丅丞不丛() / val_2;
        this._backSprite.fillAmount = val_2;
    }
    public FortDefenceGeneratorOneLineItemUI()
    {
    
    }

}
