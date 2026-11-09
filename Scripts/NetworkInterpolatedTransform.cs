using UnityEngine;
internal sealed class NetworkInterpolatedTransform : MonoBehaviour
{
    // Fields
    private bool 下与丆丂丐丏七丟丆;
    private bool 丝丐丄丌丞且下下丘;
    internal Player_move_c playerMovec;
    public bool isStartAngel;
    public UnityEngine.Vector3 correctPlayerPos;
    public UnityEngine.Quaternion correctPlayerRot;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    
    // Methods
    private void Awake()
    {
        var val_2 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_6;
        }
        
        }
        
        this.enabled = false;
        label_6:
        this.correctPlayerPos = 0;
        mem[1152921530961488148] = 0;
        this.万东万丆专丌丕丐丗 = this.transform;
    }
    public void StartAngel()
    {
        this.isStartAngel = true;
    }
    public NetworkInterpolatedTransform()
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.correctPlayerRot = val_1;
        mem[1152921530961716252] = val_1.y;
        mem[1152921530961716256] = val_1.z;
        mem[1152921530961716260] = val_1.w;
    }

}
