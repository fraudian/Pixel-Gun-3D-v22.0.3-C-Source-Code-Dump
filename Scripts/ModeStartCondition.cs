using UnityEngine;
public abstract class ModeStartCondition : PhotonEventBehaviour
{
    // Fields
    private System.Action 丒七下丂丒丛万一丁;
    
    // Methods
    internal void 丈专丙丆与丙丟世丈(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丒七下丂丒丛万一丁 != 1152921537665252872);
    
    }
    internal void 丏丘丗丝丂丛丟丐丝(System.Action 丙业与丙丗丝不丈东)
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
        while(this.丒七下丂丒丛万一丁 != 1152921537665389448);
    
    }
    internal abstract void 上丛丌丆丑上七世三(); // 0
    protected virtual void 丛万丙丏丝丗丛丄丐()
    {
        if(this.丒七下丂丒丛万一丁 == null)
        {
                return;
        }
        
        this.丒七下丂丒丛万一丁.Invoke();
    }
    protected ModeStartCondition()
    {
    
    }

}
