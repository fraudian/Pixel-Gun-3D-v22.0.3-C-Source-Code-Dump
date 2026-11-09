using UnityEngine;
public abstract class BaseConditionEndRound : MonoBehaviour
{
    // Fields
    private 丌丈不下下丘丏丌一 _resultMatch;
    private System.Action<BaseConditionEndRound> 丒七下丂丒丛万一丁;
    
    // Properties
    internal virtual 丌丈不下下丘丏丌一 丈万丝与丛丅丛丂七 { get; }
    
    // Methods
    internal virtual 丌丈不下下丘丏丌一 丏丗丕不万世丌丟丈()
    {
        return (丌丈不下下丘丏丌一)this._resultMatch;
    }
    internal void 丈专丙丆与丙丟世丈(System.Action<BaseConditionEndRound> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒七下丂丒丛万一丁, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒七下丂丒丛万一丁 != 1152921537450871328);
    
    }
    internal void 丏丘丗丝丂丛丟丐丝(System.Action<BaseConditionEndRound> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒七下丂丒丛万一丁, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒七下丂丒丛万一丁 != 1152921537451007904);
    
    }
    protected virtual void 丛万丙丏丝丗丛丄丐()
    {
        if(this.丒七下丂丒丛万一丁 == null)
        {
                return;
        }
        
        this.丒七下丂丒丛万一丁.Invoke(obj:  this);
    }
    internal virtual void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
    
    }
    internal abstract void 下丌且丈丝丗丛上丌(); // 0
    internal abstract void 一丗一上丙丅下丑万(); // 0
    protected BaseConditionEndRound()
    {
    
    }

}
