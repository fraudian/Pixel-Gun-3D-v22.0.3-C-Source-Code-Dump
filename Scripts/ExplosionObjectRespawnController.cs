using UnityEngine;
public class ExplosionObjectRespawnController : MonoBehaviour
{
    // Fields
    internal static System.Collections.Generic.List<UnityEngine.GameObject> 世丌业丌丕丕丙丅丈;
    private UnityEngine.GameObject 丕丆世丏丘丙丁专万;
    private bool 丑一业丟上丐丕丗下;
    public UnityEngine.GameObject explosionObjectPrefab;
    public float timeToNextRespawn;
    
    // Methods
    private void CreateExplosionObject()
    {
        UnityEngine.GameObject val_17;
        if(this.丑一业丟上丐丕丗下 == false)
        {
            goto label_1;
        }
        
        val_17 = 0;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_4;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        UnityEngine.Quaternion val_7 = this.transform.rotation;
        UnityEngine.GameObject val_8 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  System.String.Format(format:  "ExplosionObjects/{0}", arg0:  this.explosionObjectPrefab.name), 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
        goto label_10;
        label_1:
        label_10:
        val_17 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.explosionObjectPrefab);
        label_4:
        this.丕丆世丏丘丙丁专万 = val_17;
        if(val_17 == 0)
        {
                return;
        }
        
        this.丕丆世丏丘丙丁专万.transform.parent = this.transform;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        this.丕丆世丏丘丙丁专万.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.identity;
        this.丕丆世丏丘丙丁专万.transform.localRotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w};
    }
    private void Start()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        this.丑一业丟上丐丕丗下 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.CreateExplosionObject();
        val_3 = null;
        val_3 = null;
        ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Add(item:  this.gameObject);
    }
    private void OnDestroy()
    {
        null = null;
        bool val_2 = ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈.Remove(item:  this.gameObject);
    }
    public void StartProcessNewRespawn()
    {
        this.丕丆世丏丘丙丁专万 = 0;
        this.Invoke(methodName:  "CreateExplosionObject", time:  this.timeToNextRespawn);
    }
    public ExplosionObjectRespawnController()
    {
    
    }
    private static ExplosionObjectRespawnController()
    {
        ExplosionObjectRespawnController.世丌业丌丕丕丙丅丈 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
