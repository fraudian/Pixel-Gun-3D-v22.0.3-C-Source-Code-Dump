using UnityEngine;
internal class InstantiatePlayer : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _examplePlayerPrefab;
    private UnityEngine.GameObject 丐一三丙不丏丝业丁;
    
    // Methods
    public void SpawnPlayer(UnityEngine.Transform 丅专与丒丈丗丒丘丌)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._examplePlayerPrefab, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
        this.丐一三丙不丏丝业丁 = val_3;
        UnityEngine.Vector3 val_5 = 丅专与丒丈丗丒丘丌.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_7 = 丅专与丒丈丗丒丘丌.rotation;
        this.丐一三丙不丏丝业丁.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    public void DestroyPlayer()
    {
        UnityEngine.Object.Destroy(obj:  this.丐一三丙不丏丝业丁);
    }
    public InstantiatePlayer()
    {
    
    }

}
