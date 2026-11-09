using UnityEngine;
internal sealed class DisableObjectOnKill : PGBehaviour
{
    // Fields
    private DamageableObject _damageableObject;
    private System.Collections.Generic.List<UnityEngine.GameObject> _disableOnKill;
    
    // Methods
    private void Awake()
    {
        this._damageableObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DisableObjectOnKill::下三与丙丒一丞丐丒()));
    }
    private void OnDestroy()
    {
        this._damageableObject.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DisableObjectOnKill::下三与丙丒一丞丐丒()));
    }
    private void 下三与丙丒一丞丐丒()
    {
        List.Enumerator<T> val_1 = this._disableOnKill.GetEnumerator();
        label_4:
        if(((-436986856) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public DisableObjectOnKill()
    {
        this._disableOnKill = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
