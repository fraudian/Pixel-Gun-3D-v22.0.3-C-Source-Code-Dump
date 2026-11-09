using UnityEngine;
internal sealed class CapturedPointConditionEndRound : BaseConditionEndRound
{
    // Fields
    private AltarePoint 丛业丛丝不万与丅丝;
    
    // Methods
    internal override void 丅专下万丕丑丆丅丝(object[] 丗专丆万丏万丂丂丆)
    {
        object val_3 = 丗专丆万丏万丂丂丆[0];
        if(val_3 != null)
        {
                val_3 = 0;
        }
        
        this.丛业丛丝不万与丅丝 = val_3;
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
        if(this.丛业丛丝不万与丅丝 == 0)
        {
                return;
        }
        
        this.丛业丛丝不万与丅丝.丐专三丁丘丈丘丝丅(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void CapturedPointConditionEndRound::丏上丁丆下业丁丁七(float 丅专与丒丈丗丒丘丌)));
    }
    internal override void 一丗一上丙丅下丑万()
    {
        if(this.丛业丛丝不万与丅丝 == 0)
        {
                return;
        }
        
        this.丛业丛丝不万与丅丝.丘业下上且丗丈且丙(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void CapturedPointConditionEndRound::丏上丁丆下业丁丁七(float 丅专与丒丈丗丒丘丌)));
    }
    private void OnDestroy()
    {
        if(this.丛业丛丝不万与丅丝 == 0)
        {
                return;
        }
        
        this.丛业丛丝不万与丅丝.丘业下上且丗丈且丙(丙业与丙丗丝不丈东:  new System.Action<System.Single>(object:  this, method:  System.Void CapturedPointConditionEndRound::丏上丁丆下业丁丁七(float 丅专与丒丈丗丒丘丌)));
    }
    private void 丏上丁丆下业丁丁七(float 丅专与丒丈丗丒丘丌)
    {
        if(this.丛业丛丝不万与丅丝.CurrentCapturePoint < this.丛业丛丝不万与丅丝.maxCapturePoint)
        {
                return;
        }
        
        this.丛万丙丏丝丗丛丄丐();
    }
    public CapturedPointConditionEndRound()
    {
    
    }

}
