using UnityEngine;
internal sealed class ActivateOrActivateOnKillDamageableObject : PGBehaviour
{
    // Fields
    private DamageableObject _damageableObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> _objects;
    private bool _activate;
    
    // Methods
    private void Awake()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ActivateOrActivateOnKillDamageableObject::丟丏丂丈东业三丗丆()));
    }
    private void OnDestroy()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ActivateOrActivateOnKillDamageableObject::丟丏丂丈东业三丗丆()));
    }
    private void 丟丏丂丈东业三丗丆()
    {
        var val_4 = this;
        List.Enumerator<T> val_1 = this._objects.GetEnumerator();
        label_4:
        if((1522795944 & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().SetActive(value:  (this._activate == true) ? 1 : 0);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ActivateOrActivateOnKillDamageableObject()
    {
        this._objects = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
