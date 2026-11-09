using UnityEngine;
internal sealed class SimpleTweenEnable : SimpleTween
{
    // Fields
    public UnityEngine.Transform _target;
    public bool FinishState;
    
    // Properties
    public UnityEngine.Transform 丘与丈丘丒丂丁丛丟 { get; }
    
    // Methods
    public UnityEngine.Transform get_Target()
    {
        UnityEngine.Transform val_3;
        if(this._target == 0)
        {
                this._target = this.transform;
            return val_3;
        }
        
        val_3 = this._target;
        return val_3;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 > 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.Target, 丏业丟一东丂东丘丛:  (this.FinishState == true) ? 1 : 0);
    }
    public SimpleTweenEnable()
    {
    
    }

}
