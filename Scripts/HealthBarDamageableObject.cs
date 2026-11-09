using UnityEngine;
internal sealed class HealthBarDamageableObject : PGBehaviour
{
    // Fields
    private DamageableObjectHealthUI 丏丆上丑专不丑丌丙;
    private string _loadHealthPath;
    private DamageableObject _damagebleObject;
    private UnityEngine.Transform pointForHealth;
    
    // Methods
    private void Start()
    {
        if(this._damagebleObject == 0)
        {
                return;
        }
        
        this.丕不一丁丄丏丙丝丅();
    }
    internal void 不丒世下丝万丙丟丆(DamageableObject 丅丞万丒不专丈专丕)
    {
        this._damagebleObject = 丅丞万丒不专丈专丕;
        this.丕不一丁丄丏丙丝丅();
    }
    private void 丕不一丁丄丏丙丝丅()
    {
        DamageableObjectHealthUI val_2 = UnityEngine.Object.Instantiate<DamageableObjectHealthUI>(original:  UnityEngine.Resources.Load<DamageableObjectHealthUI>(path:  this._loadHealthPath), parent:  this.pointForHealth, worldPositionStays:  true);
        this.丏丆上丑专不丑丌丙 = val_2;
        val_2.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.丏丆上丑专不丑丌丙.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        this.丏丆上丑专不丑丌丙.不丒世下丝万丙丟丆(丘万丗丑丘丅丆丛万:  this._damagebleObject);
    }
    public HealthBarDamageableObject()
    {
        this._loadHealthPath = "HealthBarForDamageableObject";
    }

}
