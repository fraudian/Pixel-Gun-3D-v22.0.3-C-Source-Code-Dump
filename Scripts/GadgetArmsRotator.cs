using UnityEngine;
public class GadgetArmsRotator : MonoBehaviour
{
    // Fields
    internal FirstPersonControlSharp 丒专丈丛下丒一丒丛;
    public UnityEngine.Transform fpsCamTransform;
    public bool needShiftPositionForFps;
    public UnityEngine.Vector3 positionShiftForFps;
    public bool needShiftPositionForTps;
    public UnityEngine.Vector3 positionShiftForTps;
    
    // Methods
    private void Update()
    {
        var val_14;
        UnityEngine.Transform val_15;
        var val_16;
        var val_17;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        if(this.丒专丈丛下丒一丒丛.丌且下丕下下丌万丞 == false)
        {
            goto label_11;
        }
        
        if(this.丒专丈丛下丒一丒丛.丝丝丐业不业与丐下 == false)
        {
            goto label_4;
        }
        
        label_13:
        val_14 = this.transform;
        val_15 = this.丒专丈丛下丒一丒丛.playerCamera.transform;
        if(val_15 != null)
        {
            goto label_14;
        }
        
        goto label_8;
        label_4:
        val_16 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.丒专丈丛下丒一丒丛.丌丙丁丝七丕丐上丛() == false)
        {
            goto label_13;
        }
        
        }
        
        label_11:
        val_15 = this.fpsCamTransform;
        val_14 = this.transform;
        if(val_15 != null)
        {
            goto label_14;
        }
        
        label_8:
        label_14:
        UnityEngine.Quaternion val_6 = val_15.rotation;
        val_14.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
        if(this.丒专丈丛下丒一丒丛.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        if(this.丒专丈丛下丒一丒丛.丝丝丐业不业与丐下 == false)
        {
            goto label_19;
        }
        
        label_30:
        if(this.needShiftPositionForTps == false)
        {
                return;
        }
        
        val_17 = this.丒专丈丛下丒一丒丛.playerCamera.transform;
        UnityEngine.Vector3 val_9 = val_17.TransformPoint(position:  new UnityEngine.Vector3() {x = this.positionShiftForTps, y = val_6.y, z = val_6.z});
        val_21 = val_9.x;
        val_22 = val_9.y;
        val_23 = val_9.z;
        if(this.transform != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_19:
        val_24 = null;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                if(this.丒专丈丛下丒一丒丛.丌丙丁丝七丕丐上丛() == false)
        {
            goto label_30;
        }
        
        }
        
        if(this.needShiftPositionForFps == false)
        {
                return;
        }
        
        val_17 = this.transform;
        UnityEngine.Vector3 val_13 = this.fpsCamTransform.TransformPoint(position:  new UnityEngine.Vector3() {x = this.positionShiftForFps, y = val_6.y, z = val_6.z});
        val_21 = val_13.x;
        val_22 = val_13.y;
        val_23 = val_13.z;
        label_25:
        val_17.position = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
    }
    public GadgetArmsRotator()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.positionShiftForFps = val_1;
        mem[1152921540148896656] = val_1.y;
        mem[1152921540148896660] = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.positionShiftForTps = val_2;
        mem[1152921540148896672] = val_2.y;
        mem[1152921540148896676] = val_2.z;
    }

}
