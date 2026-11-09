using UnityEngine;
public class SmoothSyncMovement : MonoBehaviour, 丈丆丁上丁业丒七丘
{
    // Fields
    public float SmoothingDelay;
    private UnityEngine.Vector3 丞上业丐丞丝不丐专;
    private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    
    // Properties
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    public void Awake()
    {
        PhotonView val_1 = this.photonView;
        List.Enumerator<T> val_2 = val_1.ObservedComponents.GetEnumerator();
        label_6:
        if((962148648 & 1) == 0)
        {
            goto label_3;
        }
        
        if(0.丐丏七丌丕丗业且上() != this)
        {
            goto label_6;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this = this + " is not observed by this object\'s photonView! OnPhotonSerializeView() in this class won\'t be used."(" is not observed by this object\'s photonView! OnPhotonSerializeView() in this class won\'t be used.");
        UnityEngine.Debug.LogWarning(message:  this);
    }
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            UnityEngine.Quaternion val_5 = this.丌丟丄业且三丛丕丄().rotation;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
            return;
        }
        
        object val_6 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丞上业丐丞丝不丐专 = new UnityEngine.Vector3();
        mem[1152921535633950172] = ???;
        object val_7 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丘丐丐不丐丁丛且丝 = new UnityEngine.Quaternion();
        mem[1152921535633950180] = ???;
        mem[1152921535633950188] = ???;
    }
    public void Update()
    {
        if(this.photonView.isMine != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
        float val_6 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.丞上业丐丞丝不丐专, y = V11.16B, z = V12.16B}, t:  val_6 * this.SmoothingDelay);
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_11 = this.丌丟丄业且三丛丕丄().rotation;
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = val_12 * this.SmoothingDelay;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, b:  new UnityEngine.Quaternion() {x = this.丘丐丐不丐丁丛且丝, y = V12.16B, z = val_5.z, w = val_6}, t:  val_12);
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public SmoothSyncMovement()
    {
        this.SmoothingDelay = 5f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丞上业丐丞丝不丐专 = val_1;
        mem[1152921535634394664] = val_1.y;
        mem[1152921535634394668] = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丘丐丐不丐丁丛且丝 = val_2;
        mem[1152921535634394676] = val_2.y;
        mem[1152921535634394680] = val_2.z;
        mem[1152921535634394684] = val_2.w;
    }

}
