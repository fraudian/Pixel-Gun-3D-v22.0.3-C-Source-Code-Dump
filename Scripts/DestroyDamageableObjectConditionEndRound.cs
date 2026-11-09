using UnityEngine;
internal sealed class DestroyDamageableObjectConditionEndRound : BaseConditionEndRound
{
    // Fields
    private DamageableObject 七一丕上丄上万不不;
    
    // Methods
    internal override void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
        object val_3 = 丗专丆万丏万丂丂丆[0];
        if(val_3 != null)
        {
                val_3 = 0;
        }
        
        this.七一丕上丄上万不不 = val_3;
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
        if(this.七一丕上丄上万不不 == 0)
        {
                return;
        }
        
        this.七一丕上丄上万不不.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DestroyDamageableObjectConditionEndRound::丅七下七丗丒专世三()));
    }
    internal override void 一丗一上丙丅下丑万()
    {
        if(this.七一丕上丄上万不不 == 0)
        {
                return;
        }
        
        this.七一丕上丄上万不不.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DestroyDamageableObjectConditionEndRound::丅七下七丗丒专世三()));
    }
    private void 丅七下七丗丒专世三()
    {
        this.丛万丙丏丝丗丛丄丐();
    }
    public DestroyDamageableObjectConditionEndRound()
    {
    
    }

}
