using UnityEngine;
internal class ActivateGOByRadius : MonoBehaviour
{
    // Fields
    private float _radiusActivate;
    private System.Collections.Generic.List<UnityEngine.GameObject> _listGO;
    private bool 业丅东一丅三不丞丟;
    
    // Methods
    private void Start()
    {
        bool val_2 = this.丑不丅丁丘丛丑一七();
        this.业丅东一丅三不丞丟 = val_2;
        this.丗一三丌三与丆上与(世丁万下丗专世万丅:  val_2);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丞丙丂丌丁专丛丙());
    }
    private System.Collections.IEnumerator 下丞丙丂丌丁专丛丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ActivateGOByRadius.一与业不丟万丞丞专();
    }
    private void 丗一三丌三与丆上与(bool 世丁万下丗专世万丅)
    {
        bool val_4;
        List.Enumerator<T> val_1 = this._listGO.GetEnumerator();
        val_4 = 世丁万下丗专世万丅;
        label_4:
        if(((-1794587208) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().SetActive(value:  val_4);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private bool 丑不丅丁丘丛丑一七()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_5;
        }
        
        val_10 = null;
        val_10 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_11;
        }
        
        label_5:
        val_11 = 0;
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) < 0) ? 1 : 0;
        label_11:
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_12 = null;
        val_12 = null;
        UnityEngine.Vector3 val_6 = transform.position;
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) < 0) ? 1 : 0;
    }
    public ActivateGOByRadius()
    {
        this._radiusActivate = 60f;
        this._listGO = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
